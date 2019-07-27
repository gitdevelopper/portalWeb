﻿$(document).ready(function () {
    LoadDatatable();
});

var dateuser = localStorage.getItem("keyuser");

function LoadDatatable() {
    var table = $('#Degree').DataTable({
        "language": {
            "lengthMenu": "Mostrar _MENU_ registros por página.",
            "zeroRecords": "Lo sentimos. No se encontraron registros.",
            "info": "Mostrando página _PAGE_ de _PAGES_",
            "infoEmpty": "No hay registros aún.",
            "infoFiltered": "(filtrados de un total de _MAX_ registros)",
            "search": "Búsqueda",
            "LoadingRecords": "Cargando ...",
            "Processing": "Procesando...",
            "SearchPlaceholder": "Comience a teclear...",
            "paginate": {
                "previous": "Anterior",
                "next": "Siguiente",
            }
        },
        "scrollY": 350,
        "scrollX": true,
        "ajax": {
            "method": "POST",
            "url": "http://192.168.0.103:59538/Api/Degree/Show",
            data: {
                "Users": dateuser
            },
            dataSrc: ''
        },
        "columns": [
            {
                'aTargets': [0],
                'bSortable': true,
                'mData': "nombre",
                "width": "20%"
            },
            {
                "mRender": function (param, type, full) {
                    return "<center><a class='btn btn-warning' role='button' aria-pressed='true' id='Editar' alt='Editar'><i class='fa fa-pencil-square-o'></i></a>" +
                           "&nbsp;&nbsp;<a class='btn btn-danger' role='button' aria-pressed='true' id='Eliminar'><i class='fa fa-trash-o'></i></a></center>";
                 }
            } 
        ]
    });

    table.on('click', '#Editar', function () {
        var objecDtos = table.row($(this).parents('tr')).data();
        var id = objecDtos.id;
        localStorage.setItem("id", id);
        var a = localStorage.getItem("id");
        window.location.href = "UpdateDegree?id="+a;
    });

    
    table.on('click', '#Eliminar', function () {
        var objecDtos = table.row($(this).parents('tr')).data();
        id = objecDtos.id;
        //console.log(id);
        if (confirm('Desea eliminar el registro')) {
            Delete(id);
        }
    });
}



function Delete(id) {
    var accion;
    var error;
    var msj;
    $.ajax({
        type: "POST",
        url: "http://192.168.0.103:59538/Api/Degree/Delete",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify({
            DegreeId: id
        }),
        async: false,
        dataType: "json",
    }).done(function (response) {
        swal("Registro eliminado correctamente")
        //LoadDatatable.table.destroy();
        error = "Ninguno";
        msj = "Funcionamiento correcto";
        accion = "Eliminacion de un grado";
        Information(accion, error, msj);
        window.location.href = "ShowDegree";
        //LoadDatatable();
    }).fail(function (jqXHR, textStatus, err) {
        console.log(err.response + textStatus + jqXHR);
        swal("Fallo eliminación")
        error = err + " " + textStatus + " " + jqXHR;
        msj = "Administrador revisa el funcionamiento del portal";
        accion = "Fallo eliminacion de un grado";
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
