$(document).ready(function () {
    LoadEmployer();
    LoadClassroom();
    LoadSubject();

});



function LoadSubject() {

    var accion;
    var error;
    var msj;

    var dateuser = localStorage.getItem("keyuser");


    var oModel = {

        "Users": dateuser
    }

    $.ajax({

        "async": true,
        "crossDomain": true,
        "cache": false,
        "method": "POST",
        "url": "http://192.168.0.103:59538/Api/Lesson/ShowSubject",
        "data": JSON.stringify(oModel),
        "contentType": "application/json"

    }).done(function (data) {
        for (var i = 0; i < data.length; i++) {
            $("#materiaId").append("<option value=" + data[i].id + ">" + data[i].nombre + "</option>");
        }

        error = "Ninguno";
        msj = "Funcionamiento correcto";
        accion = "Obtencion de una materia";
        Information(accion, error, msj);


    }).fail(function (jqXHR, textStatus, err) {

        alert('Disculpe, existió un problema');
        error = err + " " + textStatus + " " + jqXHR;
        msj = "Administrador revisa el funcionamiento del portal";
        accion = "Fallo obtencion de una materia";
        Information(accion, error, msj);


    });
        

}

function LoadEmployer() {
    var accion;
    var error;
    var msj;

    var dateuser = localStorage.getItem("keyuser");


    var oModel = {

        "Users": dateuser
    }

    $.ajax({

        "async": true,
        "crossDomain": true,
        "cache": false,
        "method": "POST",
        "url": "http://192.168.0.103:59538/Api/Lesson/ShowEmployer",
        "data": JSON.stringify(oModel),
        "contentType": "application/json"

    }).done(function (data) {

        for (var i = 0; i < data.length; i++) {
            $("#profesorId").append("<option value=" + data[i].id + ">" + data[i].nombre + " " + data[i].apellidop + " " + data[i].apellidom + "</option>");

            error = "Ninguno";
            msj = "Funcionamiento correcto";
            accion = "Obtencion de un empleado";
            Information(accion, error, msj);
        }


    }).fail(function (jqXHR, textStatus, err) {

        alert('Disculpe, existió un problema');

        error = err + " " + textStatus + " " + jqXHR;
        msj = "Administrador revisa el funcionamiento del portal";
        accion = "Fallo obtencion de empleados";
        Information(accion, error, msj);

    });

   
}

function LoadClassroom() {
    var accion;
    var error;
    var msj;

    var dateuser = localStorage.getItem("keyuser");


    var oModel = {

        "Users": dateuser
    }

    $.ajax({

        "async": true,
        "crossDomain": true,
        "cache": false,
        "method": "POST",
        "url": "http://192.168.0.103:59538/Api/Lesson/ShowClassroom",
        "data": JSON.stringify(oModel),
        "contentType": "application/json"

    }).done(function (data) {

        for (var i = 0; i < data.length; i++) {
            $("#aulaId").append("<option value=" + data[i].id + ">" + data[i].clave + "  " + data[i].nombre + "</option>");
        }

        error = "Ninguno";
        msj = "Funcionamiento correcto";
        accion = "Obtencion de aulas";
        Information(accion, error, msj);


    }).fail(function (jqXHR, textStatus, err) {

        alert('Disculpe, existió un problema');

        error = err + " " + textStatus + " " + jqXHR;
        msj = "Administrador revisa el funcionamiento del portal";
        accion = "Fallo obtencion de aulas";
        Information(accion, error, msj);


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
