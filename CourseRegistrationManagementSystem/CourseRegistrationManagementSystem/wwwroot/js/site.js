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
   
});

function deleteCourseFromScheduleOnScheduleScreen(id){
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
}
