$(document).ready(function () {
    LoadTypeClassroom();
    LoadInstitution();

});

var dateuser = localStorage.getItem("keyuser");

function LoadTypeClassroom() {
    var accion;
    var error;
    var msj;

    $.ajax({
        url: "http://192.168.0.103:59538/Api/Classroom/ShowClassroomType",
        method: "POST",
        dataType: "json",
        data: "{}",
        success: function (data) {
             for (var i = 0; i < data.length; i++) {
                 $("#aulaId").append("<option value=" + data[i].id + ">" + data[i].nombre + "</option>");
            }

            error = "Ninguno";
            msj = "Funcionamiento correcto";
            accion = "Obtencion de un aula";
            Information(accion, error, msj);
        },
        error: function (jqXHR, status, error) {
            alert('Disculpe, existió un problema');

            error = err + " " + textStatus + " " + jqXHR;
            msj = "Administrador revisa el funcionamiento del portal";
            accion = "Fallo obtencion de un aula";
            Information(accion, error, msj);
        }
    });
}



function Information(accion, error, msj) {
    var oModel = {
        "Accion": accion,
        "Error": error,
        "Msj": msj,
        "Users": dateuser
    }
    $.ajax({
        "async": true,
        "crossDomain": true,
        "cache": false,
        "method": "POST",
        "url": "http://192.168.0.103:59538/Api/Binnacle/Info",
        "data": JSON.stringify(oModel),
        "contentType": "application/json"
    }).done(function (response) {
        console.log(response);
    }).fail(function (jqXHR, textStatus, err) {
        console.log(textStatus);
    });
}

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
