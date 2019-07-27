﻿var accion;
var error;
var msj;


var dateuser = localStorage.getItem("keyuser");

function Actualizar() {

    var nombre = $("#nombreAlumno").val();
    var apep = $("#apellidopAlumno").val();
    var apem = $("#apellidomAlumno").val();
    var user = $("#usuarioAdmin").val();
    var contra = $("#contrasenaAdmin").val();
    var inst = $("#institucionAdmin").val();


    var oModel = {


        "Name": nombre,
        "LastNameP": apep,
        "LastNameM": apem,
        "Users": user,
        "Pass": contra,
        "InstitutionID": inst,
        "Users": dateuser

    }


    $.ajax({

        "async": true,
        "crossDomain": true,
        "cache": false,
        "method": "POST",
        "url": "http://192.168.0.103:59538/Api/Admin/UpdateRegister",
        "data": JSON.stringify(oModel),
        "contentType": "application/json"



    }).done(function (response) {



        console.log(response);

        window.location.href = "/Profile/ShowProfile";
        return false;

        swal("Registro actualizado!", "La petición fue creada correctamente!", "success");
        // $("#nombreGrupo").val("");
        //$("#nombreGrupo").focus();




        error = "Ninguno";
        msj = "Funcionamiento correcto";
        accion = "Actualizacion del perfil de un usuario";
        Information(accion, error, msj);


    }).fail(function (jqXHR, textStatus, err) {

        error = err + " " + textStatus + " " + jqXHR;
        msj = "Administrador revisa el funcionamiento del portal";
        accion = "Fallo actualización del perfil";
        Information(accion, error, msj);

        console.log(textStatus)


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
