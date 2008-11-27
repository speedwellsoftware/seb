<?php  // $Id: review.php,v 1.59.2.6 2008/02/13 17:01:44 skodak Exp $
/**
 * This page prints a review of a particular quiz attempt
 *
 * @author Martin Dougiamas and many others. This has recently been completely
 *         rewritten by Alex Smith, Julian Sedding and Gustav Delius as part of
 *         the Serving Mathematics project
 *         {@link http://maths.york.ac.uk/serving_maths}
 * @license http://www.gnu.org/copyleft/gpl.html GNU Public License
 * @package quiz
 */

    require_once("../../config.php");
    require_once("locallib.php");

    $attempt = required_param('attempt', PARAM_INT);    // A particular attempt ID for review
    $page = optional_param('page', 0, PARAM_INT); // The required page
    $showall = optional_param('showall', 0, PARAM_BOOL);

    if (! $attempt = get_record("quiz_attempts", "id", $attempt)) {
        error("No such attempt ID exists");
    }
    if (! $quiz = get_record("quiz", "id", $attempt->quiz)) {
        error("The quiz with id $attempt->quiz belonging to attempt $attempt is missing");
    }
    if (! $course = get_record("course", "id", $quiz->course)) {
        error("The course with id $quiz->course that the quiz with id $quiz->id belongs to is missing");
    }
    if (! $cm = get_coursemodule_from_instance("quiz", $quiz->id, $course->id)) {
        error("The course module for the quiz with id $quiz->id is missing");
    }

    $grade = quiz_rescale_grade($attempt->sumgrades, $quiz);
    $feedback = quiz_feedback_for_grade($grade, $attempt->quiz);

    if (!count_records('question_sessions', 'attemptid', $attempt->uniqueid)) {
        // this question has not yet been upgraded to the new model
        quiz_upgrade_states($attempt);
    }

    require_login($course->id, false, $cm);
    $context = get_context_instance(CONTEXT_MODULE, $cm->id);
    $coursecontext = get_context_instance(CONTEXT_COURSE, $cm->course);
    $isteacher = has_capability('mod/quiz:preview', get_context_instance(CONTEXT_MODULE, $cm->id));
    $options = quiz_get_reviewoptions($quiz, $attempt, $context);
    $popup = $isteacher ? 0 : $quiz->popup; // Controls whether this is shown in a javascript-protected window.

    $timenow = time();
    if (!has_capability('mod/quiz:viewreports', $context)) {
        // Can't review during the attempt.
        if (!$attempt->timefinish) {
            redirect('attempt.php?q=' . $quiz->id);
        }
        // Can't review other student's attempts.
        if ($attempt->userid != $USER->id) {
            error("This is not your attempt!", 'view.php?q=' . $quiz->id);
        }
        // Can't review if Student's may review ... Responses is turned on.
        if (!$options->responses) {
            if ($options->quizstate == QUIZ_STATE_IMMEDIATELY) {
                $message = '';
            } else if ($options->quizstate == QUIZ_STATE_OPEN && $quiz->timeclose &&
                        ($quiz->review & QUIZ_REVIEW_CLOSED & QUIZ_REVIEW_RESPONSES)) {
                $message = get_string('noreviewuntil', 'quiz', userdate($quiz->timeclose));
            } else {
                $message = get_string('noreview', 'quiz');
            }
            if (empty($popup)) {
                redirect('view.php?q=' . $quiz->id, $message);
            } else {
                ?><script type="text/javascript">
                opener.document.location.reload();
                self.close();
                </script><?php
                die();
            }
        }
    }

    add_to_log($course->id, "quiz", "review", "review.php?id=$cm->id&amp;attempt=$attempt->id", "$quiz->id", "$cm->id");

/// Load all the questions and states needed by this script

    // load the questions needed by page
    $pagelist = $showall ? quiz_questions_in_quiz($attempt->layout) : quiz_questions_on_page($attempt->layout, $page);
    $sql = "SELECT q.*, i.grade AS maxgrade, i.id AS instance".
           "  FROM {$CFG->prefix}question q,".
           "       {$CFG->prefix}quiz_question_instances i".
           " WHERE i.quiz = '$quiz->id' AND q.id = i.question".
           "   AND q.id IN ($pagelist)";
    if (!$questions = get_records_sql($sql)) {
        error('No questions found');
    }

    // Load the question type specific information
    if (!get_question_options($questions)) {
        error('Could not load question options');
    }

    // Restore the question sessions to their most recent states
    // creating new sessions where required
    if (!$states = get_question_states($questions, $quiz, $attempt)) {
        error('Could not restore question sessions');
    }

/// Print the page header

    $strscore  = get_string("score", "quiz");
    $strgrade  = get_string("grade");
    $strbestgrade  = get_string("bestgrade", "quiz");
    $strtimetaken     = get_string("timetaken", "quiz");
    $strtimecompleted = get_string("completedon", "quiz");
    $stroverdue = get_string("overdue", "quiz");

/// Work out appropriate title.
    if ($isteacher and $attempt->userid == $USER->id) {
        $strreviewtitle = get_string('reviewofpreview', 'quiz');
    } else {
        $strreviewtitle = get_string('reviewofattempt', 'quiz', $attempt->attempt);
    }

    $pagequestions = explode(',', $pagelist);
    $headtags = get_html_head_contributions($pagequestions, $questions, $states);
    if (!empty($popup)) {
        define('MESSAGE_WINDOW', true);  // This prevents the message window coming up
        print_header($course->shortname.': '.format_string($quiz->name), '', '', '', $headtags, false, '', '', false, '');
        /// Include Javascript protection for this page
        include('protect_js.php');
    } else {
        $strupdatemodule = has_capability('moodle/course:manageactivities', $coursecontext)
                    ? update_module_button($cm->id, $course->id, get_string('modulename', 'quiz'))
                    : "";
        get_string('reviewofattempt', 'quiz', $attempt->attempt);
        $navigation = build_navigation($strreviewtitle, $cm);
        print_header_simple(format_string($quiz->name), "", $navigation, "", $headtags, true, $strupdatemodule);
    }
    echo '<div id="overDiv" style="position:absolute; visibility:hidden; z-index:1000;"></div>'; // for overlib

/// Print heading and tabs if this is part of a preview
    if (has_capability('mod/quiz:preview', $context)) {
        if ($attempt->userid == $USER->id) { // this is the report on a preview
            $currenttab = 'preview';
        } else {
            $currenttab = 'reports';
            $mode = '';
        }
        include('tabs.php');
    }
    print_heading(format_string($quiz->name));
    if ($isteacher and $attempt->userid == $USER->id) {
        // the teacher is at the end of a preview. Print button to start new preview
        unset($buttonoptions);
        $buttonoptions['q'] = $quiz->id;
        $buttonoptions['forcenew'] = true;
        echo '<div class="controls">';
        print_single_button($CFG->wwwroot.'/mod/quiz/attempt.php', $buttonoptions, get_string('startagain', 'quiz'));
        echo '</div>';
    }
    print_heading($strreviewtitle);

    // print javascript button to close the window, if necessary
    if (!$isteacher) {
        include('attempt_close_js.php');
    }

/// Print infobox

    $timelimit = (int)$quiz->timelimit * 60;
    $overtime = 0;

    if ($attempt->timefinish) {
        if ($timetaken = ($attempt->timefinish - $attempt->timestart)) {
            if($timelimit && $timetaken > ($timelimit + 60)) {
                $overtime = $timetaken - $timelimit;
                $overtime = format_time($overtime);
            }
            $timetaken = format_time($timetaken);
        } else {
            $timetaken = "-";
        }
    } else {
        $timetaken = get_string('unfinished', 'quiz');
    }
    echo '<table class="generaltable generalbox quizreviewsummary"><tbody>';
    if ($attempt->userid <> $USER->id) {
        $student = get_record('user', 'id', $attempt->userid);
        $picture = print_user_picture($student, $course->id, $student->picture, false, true);
        echo '<tr><th scope="row" class="cell">', $picture, '</th><td class="cell"><a href="', $CFG->wwwroot,
            '/user/view.php?id=', $student->id, '&amp;course='.$course->id.'">',
            fullname($student, true), '</a></td></tr>';
    }
    if (has_capability('mod/quiz:grade', $context) and
            count($attempts = get_records_select('quiz_attempts', "quiz = '$quiz->id' AND userid = '$attempt->userid'", 'attempt ASC')) > 1) {
        // print list of attempts
        $attemptlist = '';
        foreach ($attempts as $at) {
            $attemptlist .= ($at->id == $attempt->id)
                ? '<strong>'.$at->attempt.'</strong>, '
                : '<a href="review.php?attempt='.$at->id.($showall?'&amp;showall=true':'').'">'.$at->attempt.'</a>, ';
        }
        echo '<tr><th scope="row" class="cell">', get_string('attempts', 'quiz'), '</th><td class="cell">',
                trim($attemptlist, ' ,'), '</td></tr>';
    }

    echo '<tr><th scope="row" class="cell">', get_string('startedon', 'quiz'), '</th><td class="cell">',
            userdate($attempt->timestart), '</td></tr>';
    if ($attempt->timefinish) {
        echo '<tr><th scope="row" class="cell">', $strtimecompleted, '</th><td class="cell">',
                userdate($attempt->timefinish), '</td></tr>';
        echo '<tr><th scope="row" class="cell">', $strtimetaken, '</th><td class="cell">',
                $timetaken, '</td></tr>';
    }
    if (!empty($overtime)) {
        echo '<tr><th scope="row" class="cell">', $stroverdue, '</th><td class="cell">',$overtime, '</td></tr>';
    }
    //if the student is allowed to see their score
    if ($options->scores) {
        if ($quiz->grade and $quiz->sumgrades) {
            if($overtime) {
                $result->sumgrades = "0";
                $result->grade = "0.0";
            }

            $a = new stdClass;
            $percentage = round(($attempt->sumgrades/$quiz->sumgrades)*100, 0);
            $a->grade = $grade;
            $a->maxgrade = $quiz->grade;
            $rawscore = round($attempt->sumgrades, $CFG->quiz_decimalpoints);
            echo '<tr><th scope="row" class="cell">', $strscore, '</th><td class="cell">',
                "$rawscore/$quiz->sumgrades ($percentage%)", '</td></tr>';
            echo '<tr><th scope="row" class="cell">', $strgrade, '</th><td class="cell">',
                get_string('outof', 'quiz', $a), '</td></tr>';
        }
    }
    if ($options->overallfeedback && $feedback) {
        echo '<tr><th scope="row" class="cell">', get_string('feedback', 'quiz'), '</th><td class="cell">',
                $feedback, '</td></tr>';
    }
    echo '</tbody></table>';

/// Print the navigation panel if required
    $numpages = quiz_number_of_pages($attempt->layout);
    if ($numpages > 1 and !$showall) {
        print_paging_bar($numpages, $page, 1, 'review.php?attempt='.$attempt->id.'&amp;');
        echo '<div class="controls"><a href="review.php?attempt='.$attempt->id.'&amp;showall=true">';
        print_string('showall', 'quiz');
        echo '</a></div>';
    }

/// Print all the questions

    $number = quiz_first_questionnumber($attempt->layout, $pagelist);
    foreach ($pagequestions as $i) {
        if (!isset($questions[$i])) {
            print_simple_box_start('center', '90%');
            echo '<strong><font size="+1">' . $number . '</font></strong><br />';
            notify(get_string('errormissingquestion', 'quiz', $i));
            print_simple_box_end();
            $number++; // Just guessing that the missing question would have lenght 1
            continue;
        }
        $options->validation = QUESTION_EVENTVALIDATE === $states[$i]->event;
        $options->history = ($isteacher and !$attempt->preview) ? 'all' : 'graded';
        // Print the question
        print_question($questions[$i], $states[$i], $number, $quiz, $options);
        $number += $questions[$i]->length;
    }

    // Print the navigation panel if required
    if ($numpages > 1 and !$showall) {
        print_paging_bar($numpages, $page, 1, 'review.php?attempt='.$attempt->id.'&amp;');
    }

    // print javascript button to close the window, if necessary
    if (!$isteacher) {
        include('attempt_close_js.php');
    }

    if (empty($popup)) {
        print_footer($course);
    }
?>
