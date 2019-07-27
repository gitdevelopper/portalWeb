$(document).ready(function () {
    LoadInstitution();

});




function LoadInstitution() {
    
    var dateuser = localStorage.getItem("keyuser");


    var oModel = {

        "Users": dateuser
    }

    $.ajax({

        "async": true,
        "crossDomain": true,
        "cache": false,
        "method": "POST",
        "url": "http://192.168.0.103:59538/Api/Classroom/ShowInstitution",
        "data": JSON.stringify(oModel),
        "contentType": "application/json"

    }).done(function (data) {

        //console.log(data);
        for (var i = 0; i < data.length; i++) {
            $("#institucionId").append("<option value=" + data[i].id + ">" + data[i].nombre + "</option>");
        }


    }).fail(function (jqXHR, textStatus, err) {

        console.log(textStatus);
        console.log(jqXHR);
        console.log(err);


    });
}

