// Write your JavaScript code.

$(document).ready(function($){

    $("#advancedCourseSearchGroup").hide();

    $('#startTimeTimepicker').timepicki(); 

    $('#endTimeTimepicker').timepicki(); 

    $("#advancedCourseSearchButton").click(function(){
        $("#advancedCourseSearchGroup").toggle();
    });

});
