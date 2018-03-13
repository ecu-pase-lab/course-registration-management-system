$(document).ready(function($){

    $("#advancedCourseSearchGroup").hide();

    var options = {title: 'Choose Time'};

    $('#startTimeTimepicker').wickedpicker(options);

    $('#endTimeTimepicker').wickedpicker(options);

    $('#startTimeTimepicker').val('');

    $('#endTimeTimepicker').val('');

    $("#advancedCourseSearchButton").click(function(){
        $("#advancedCourseSearchGroup").toggle();
    });

    $("#dialog-confirm").dialog({
      autoOpen: false,
      modal: true
    });

    var availableTags = [
      "ActionScript",
      "AppleScript",
      "Asp",
      "BASIC",
      "C",
      "C++",
      "Clojure",
      "COBOL",
      "ColdFusion",
      "Erlang",
      "Fortran",
      "Groovy",
      "Haskell",
      "Java",
      "JavaScript",
      "Lisp",
      "Perl",
      "PHP",
      "Python",
      "Ruby",
      "Scala",
      "Scheme"
    ];

    function split( val ) {
      return val.split( /,\s*/ );
    }

    function extractLast( term ) {
      return split( term ).pop();
    }
 
    $( "#tags" )
      // don't navigate away from the field on tab when selecting an item
      .on( "keydown", function( event ) {
        if ( event.keyCode === $.ui.keyCode.TAB &&
            $( this ).autocomplete( "instance" ).menu.active ) {
          event.preventDefault();
        }
      })
      .autocomplete({
        minLength: 0,
        source: function( request, response ) {
          // delegate back to autocomplete, but extract the last term
          response( $.ui.autocomplete.filter(
            availableTags, extractLast( request.term ) ) );
        },
        focus: function() {
          // prevent value inserted on focus
          return false;
        },
        select: function( event, ui ) {
          var terms = split( this.value );
          // remove the current input
          terms.pop();
          // add the selected item
          terms.push( ui.item.value );
          // add placeholder to get the comma-and-space at the end
          terms.push( "" );
          this.value = terms.join( ", " );
          return false;
        }
      });
});

function addOrRemoveCourseFromScheduleOnResultsScreen(id){
    if($("#classScheduleCheckbox_" + id).is(':checked')){
        $.ajax({
            url: '/Home/AddCourseToSchedule',
            data: { 'courseId' : id },
            type: "POST",
            cache: false,
            success: function (success) {
                $("#scheduleText_" + id).html("Added to Schedule");
                $("#scheduleText_" + id).css("color", "green");
            },
            error: function (error) {
                $("#scheduleText_" + id).html("Error adding course to schedule");
                $("#scheduleText_" + id).css("color", "red");
            }
        });
    } else {
        $.ajax({
            url: '/Home/RemoveCourseFromSchedule',
            data: { 'courseId' : id },
            type: "POST",
            cache: false,
            success: function (success) {
                $("#scheduleText_" + id).html("Removed from Schedule");
                $("#scheduleText_" + id).css("color", "red");
            },
            error: function (error) {
                $("#scheduleText_" + id).html("Error removing course from schedule");
                $("#scheduleText_" + id).css("color", "red");
            }
        });
    }
}

function deleteCourseFromScheduleOnScheduleScreen(id){
    $("#dialog-confirm").dialog({
      resizable: false,
      height: "auto",
      width: 300,
      autoOpen: true,
      modal: true,
      buttons: {
        "Remove Course": function() {
            $.ajax({
                url: '/Home/RemoveCourseFromSchedule',
                data: { 'courseId' : id },
                type: "POST",
                cache: false,
                success: function (success) {
                    location.reload();
                },
                error: function (error) {
                    alert("Error deleting course from schedule");
                }
            });    
            $(this).dialog("close");
        },
        Cancel: function() {
          $(this).dialog("close");
        }
      }
    });
}
