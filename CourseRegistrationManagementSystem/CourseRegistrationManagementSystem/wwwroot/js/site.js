/**
 * Copyright 2018
 * James Adams IV
 * East Carolina University
 */

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

    $("#dialog-cannot-add-course-message").dialog({
      autoOpen: false,
      modal: true
    });

    $("#dialog-cannot-view-directions-message").dialog({
      autoOpen: false,
      modal: true
    });

    $("#returnToScheduleButton").click(function(){
        window.location.href = "/Home/Schedule";
    });

    $("#viewDirectionsButton").click(function(){
        if ($('input[type=checkbox]:checked').length < 2) {
            $("#dialog-cannot-view-directions-message").dialog({
              autoOpen: true,  
              modal: true,
              buttons: {
                Ok: function() {
                  $(this).dialog("close");
                }
              }
            });
        } 
        else if ($('input[type=checkbox]:checked').length == 2) {
            $('input[type=checkbox]:checked').each(function(index) { 
                if (index == 0) {
                    $("#courseToMap1").val($(this).val());
                } else if (index == 1) {
                    $("#courseToMap2").val($(this).val());
                }
            });

            $("#scheduleForm").submit();
        }
    });

    $('.directionsCheckbox').on('change', function (e) {
        if ($('input[type=checkbox]:checked').length > 2) {
            $(this).prop('checked', false);

            $("#dialog-cannot-add-course-message").dialog({
              autoOpen: true,  
              modal: true,
              buttons: {
                Ok: function() {
                  $(this).dialog("close");
                }
              }
            });
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

function fillInstructorSelection(instructorArray){
    function split( val ) {
      return val.split( /,\s*/ );
    }

    function extractLast( term ) {
      return split( term ).pop();
    }
 
    $( "#selectedInstructors" )
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
            instructorArray, extractLast( request.term ) ) );
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
}
        
function initMap() {

    var directionsService = new google.maps.DirectionsService;
    var directionsDisplay = new google.maps.DirectionsRenderer({
        suppressMarkers: true
    });

    var map = new google.maps.Map(document.getElementById('map'), {
      zoom: 15,
      center: {lat: 35.6055755, lng: -77.3995847} // Put ECU campus at the center of the map
    });
    directionsDisplay.setMap(map);

    var infowindow = new google.maps.InfoWindow();

    var startLocation = new google.maps.LatLng({lat: classroomLatitude1, lng: classroomLongitude1}); 
    var endLocation = new google.maps.LatLng({lat: classroomLatitude2, lng: classroomLongitude2}); 

    createMarker(map, infowindow, startLocation, classroomName1);
    createMarker(map, infowindow, endLocation, classroomName2);

    calculateAndDisplayRoute(directionsService, directionsDisplay, startLocation, endLocation);
}

function calculateAndDisplayRoute(directionsService, directionsDisplay, startLocation, endLocation) {
    directionsService.route({
      origin: startLocation,
      destination: endLocation,
      travelMode: 'WALKING'
    }, function(response, status) {
      if (status === 'OK') {
        directionsDisplay.setDirections(response);
        document.getElementById("directionsDistance").innerHTML = response.routes[0].legs[0].distance.text;
        document.getElementById("directionsTime").innerHTML = response.routes[0].legs[0].duration.text;
      } else {
        window.alert('Directions request failed due to ' + status);
      }
    });
}

function createMarker(map, infowindow, latlng, title) {
    var marker = new google.maps.Marker({
      position: latlng,
      title: title,
      map: map
    });

    google.maps.event.addListener(marker, 'click', function () {
        infowindow.setContent(title);
        infowindow.open(map, marker);
    });
}  