$(document).ready(function($){

    $("#advancedCourseSearchGroup").hide();

    $('#startTimeTimepicker').wickedpicker();

    $('#endTimeTimepicker').wickedpicker();

    $("#advancedCourseSearchButton").click(function(){
        $("#advancedCourseSearchGroup").toggle();
    });

});
