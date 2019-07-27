﻿$(document).ready(function () {
    Insertar();
});

var clave = "";
var nombre = "";
var institucion = "";

var dateuser = localStorage.getItem("keyuser");

function Insertar() {
    var accion;
    var error;
    var msj;


    $('#SaveCareer').click(function () {
        clave = document.getElementById("claveCarrera").value;
        nombre = document.getElementById("nombreCarrera").value;
        institucion = document.getElementById("institucionId").value;
        if (clave == "") {
            swal("Ingresa todos los campos");
            $('#claveCarrera').focus();

        } else if (nombre=="") {
            swal("Ingresa todos los campos");
            $('#nombreCarrera').focus();

        } else if (institucion == "Seleccionar") {
            swal("Ingresa todos los campos");
            $('#institucionId').focus();

        }
        else {
            var oModel = {
                "Clave": $("#claveCarrera").val(),
                "Nombre": $("#nombreCarrera").val(),
                "InstitucionId": $("#institucionId").attr("selected", true).val(),
                "Users": dateuser
            }
            $.ajax({
                "async": true,
                "crossDomain": true,
                "cache": false,
                "method": "POST",
                "url": "http://192.168.0.103:59538/Api/Career/Create",
                "data": JSON.stringify(oModel),
                "contentType": "application/json"
            }).done(function (response) {
                console.log(response);
                swal("Carrera guardada", "La carrera fue guardada exitosamente", "success");
                $("#claveCarrera").val("");
                $("#nombreCarrera").val("");
                $("#institucionId").val("Seleccionar");

                error = "Ninguno";
                msj = "Funcionamiento correcto";
                accion = "Creacion de una carrera";
                Information(accion, error, msj);
            }).fail(function (jqXHR, textStatus, err) {
                //console.log(textStatus);
                swal("Existio un problema al duardar la carrera", "Reintentelo más tarde");
                $("#claveCarrera").val("");
                $("#nombreCarrera").val("");
                $("#institucionId").val("Seleccionar");

                error = err + " " + textStatus + " " + jqXHR;
                msj = "Administrador revisa el funcionamiento del portal";
                accion = "Fallo creacion de una carrera";
                Information(accion, error, msj);
            });
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
        //console.log(response);
    }).fail(function (jqXHR, textStatus, err) {
        //console.log(textStatus);
    });
}





