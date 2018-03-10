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
