﻿$(document).ready(function () {
    Insertar();
});



function Insertar() {
    var accion;
    var error;
    var msj;

    var nombre = $("#nombreAdmin").val();
    var direccion = $("#direccion").val();
    var telefono = $("#telefono").val();
    var nivel = $("#nivelEdInstitucion").val();
    var director = $("#directorInstitucion").val();

    if (nombre == "") {

        swal("Ingresa todos los campos");
        $('#nombreAdmin').focus();

    } else if (direccion == "") {

        swal("Ingresa todos los campos");
        $('#nombreAdmin').focus();

    } else if (telefono == "") {
        swal("Ingresa todos los campos");
        $('#telefono').focus();

    } else if (nivel == "Seleccionar") {
        swal("Selecciona un nivel educativo.");

    } else if (director == "") {
        swal("Ingresa todos los campos");
        $('#directorInstitucion').focus();

    } else {
        var oModel = {
            "Name": nombre,
            "Direction": direccion,
            "Phone": telefono,
            "EducationLevelID": nivel,
            "Logo": "",
            "Director": director
        }


        $.ajax({

            "async": true,
            "crossDomain": true,
            "cache": false,
            "method": "POST",
            "url": "http://192.168.0.103:59538/Api/Institution/Create",
            "data": JSON.stringify(oModel),
            "contentType": "application/json"

        }).done(function (response) {

            error = "Ninguno";
            msj = "Funcionamiento correcto";
            accion = "Creacion de una institucion";
            Information(accion, error, msj);

            console.log(response);


            swal("Institución guardado", "La institución fue guardada exitosamente", "success");
            // $("#nombreGrupo").val("");
            //$("#nombreGrupo").focus();
            window.location.href = "/Profile/CreateProfile?qwr=" + nivel;
            return false;


        }).fail(function (jqXHR, textStatus, err) {
            error = err + " " + textStatus + " " + jqXHR;
            msj = "Administrador revisa el funcionamiento del portal";
            accion = "Fallo creacion de una institucion";
            Information(accion, error, msj);
            console.log(textStatus);
            swal("Existio un problema al guardar la institución", "Reintentelo más tarde");
        });

    }



}


