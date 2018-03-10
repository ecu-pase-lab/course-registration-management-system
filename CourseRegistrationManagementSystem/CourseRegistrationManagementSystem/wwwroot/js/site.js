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
