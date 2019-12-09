﻿var id = 0;
//Funciones GET
function tablaEditar(btn) {
    var tr = $(btn).closest("tr");
    var row = tabla.row(tr);
    id = row.data().id;
    _ajax(null,
        '/Requisiciones/Edit/' + id,
        'GET',
        function (obj) {
            if (obj != "-1" && obj != "-2" && obj != "-3") {
                $("#FormEditar").find("#req_Experiencia").val(obj.req_Experiencia);
                $("#FormEditar").find("#req_Sexo").val(obj.req_Sexo);
                $("#FormEditar").find("#req_Descripcion").val(obj.req_Descripcion);
                $("#FormEditar").find("#req_EdadMinima").val(obj.req_EdadMinima);
                $("#FormEditar").find("#req_EdadMaxima").val(obj.req_EdadMaxima);
                $("#FormEditar").find("#req_EstadoCivil").val(obj.req_EstadoCivil);
                $("#FormEditar").find("#req_EducacionSuperior").val(obj.req_EducacionSuperior);
                $("#FormEditar").find("#req_Permanente").val(obj.req_Permanente);
                $("#FormEditar").find("#req_Duracion").val(obj.req_Duracion);
                $("#FormEditar").find("#req_Vacantes").val(obj.req_Vacantes);
                $("#FormEditar").find("#req_FechaRequisicion").val(obj.req_FechaRequisicion);
                $("#FormEditar").find("#req_FechaContratacion").val(obj.req_FechaContratacion);
                $('#ModalEditar').modal('show');
            }
        });
}
function tablaDetalles(btn) {
    var tr = $(btn).closest("tr");
    var row = tabla.row(tr);
    id = row.data().id;
    _ajax(null,
        '/Requisiciones/Edit/' + id,
        'GET',
        function (obj) {
            if (obj != "-1" && obj != "-2" && obj != "-3") {
                $("#ModalDetalles").find("#req_Experiencia")["0"].innerText = obj.req_Experiencia;
                $("#ModalDetalles").find("#req_Sexo")["0"].innerText = obj.req_Sexo;
                $("#ModalDetalles").find("#req_Descripcion")["0"].innerText = obj.req_Descripcion;
                $("#ModalDetalles").find("#req_EdadMinima")["0"].innerText = obj.req_EdadMinima;
                $("#ModalDetalles").find("#req_EdadMaxima")["0"].innerText = obj.req_EdadMaxima;
                $("#ModalDetalles").find("#req_EstadoCivil")["0"].innerText = obj.req_EstadoCivil;
                $("#ModalDetalles").find("#req_EducacionSuperior")["0"].innerText = obj.req_EducacionSuperior;
                $("#ModalDetalles").find("#req_Permanente")["0"].innerText = obj.req_Permanente;
                $("#ModalDetalles").find("#req_Duracion")["0"].innerText = obj.req_Duracion;
                $("#ModalDetalles").find("#req_Vacantes")["0"].innerText = obj.req_Vacantes;
                $("#ModalDetalles").find("#req_FechaRequisicion")["0"].innerText = obj.req_FechaRequisicion;
                $("#ModalDetalles").find("#req_FechaContratacion")["0"].innerText = obj.req_FechaContratacion;
                $("#ModalDetalles").find("#req_Estado")["0"].innerText = obj.req_Estado;
                $("#ModalDetalles").find("#req_RazonInactivo")["0"].innerText = obj.req_RazonInactivo;
                $("#ModalDetalles").find("#req_FechaCrea")["0"].innerText = FechaFormato(obj.req_FechaCrea);
                $("#ModalDetalles").find("#req_FechaModifica")["0"].innerText = FechaFormato(obj.req_FechaModifica);
                $("#ModalDetalles").find("#tbUsuario_usu_NombreUsuario")["0"].innerText = obj.tbUsuario.usu_NombreUsuario;
                $("#ModalDetalles").find("#tbUsuario1_usu_NombreUsuario")["0"].innerText = obj.tbUsuario1.usu_NombreUsuario;
                $("#ModalDetalles").find("#btnEditar")["0"].dataset.id = id;
                $('#ModalDetalles').modal('show');
            }
        });
}
function llenarTabla() {
    _ajax(null,
        '/Requisiciones/llenarTabla',
        'POST',
        function (Lista) {
            tabla.clear();
            tabla.draw();
            $.each(Lista, function (index, value) {
                tabla.row.add({
                    id: value.req_Id,
                    Experiencia: value.req_Experiencia,
                    Sexo: value.req_Sexo,
                    Descripcion: value.req_Descripcion,
                    EdadMinima: value.req_EdadMinima,
                    EdadMaxima: value.req_EdadMaxima,
                    EstadoCivil: value.req_EstadoCivil,
                    EducacionSuperior: value.req_EducacionSuperior,
                    Permanente: value.req_Permanente,
                    Duracion: value.req_Duracion,
                    Vacantes: value.req_Vacantes,
                    FechaRequisicion: value.req_FechaRequisicion,
                    FechaContratacion: value.req_FechaContratacion
                });
            });
            tabla.draw();
        });
}
$(document).ready(function () {
    llenarTabla();
});
//Botones GET
$("#btnAgregar").click(function () {
    var modalnuevo = $('#ModalNuevo');
    modalnuevo.modal('show');
    $(modalnuevo).find("#req_Experiencia").val("");
    $(modalnuevo).find("#req_Experiencia").focus();
    $(modalnuevo).find("#req_Sexo").val("");
    $(modalnuevo).find("#req_Descripcion").val("");
    $(modalnuevo).find("#req_EdadMinima").val("");
    $(modalnuevo).find("#req_EdadMaxima").val("");
    $(modalnuevo).find("#req_EstadoCivil").val("");
    $(modalnuevo).find("#req_EducacionSuperior").val("");
    $(modalnuevo).find("#req_Permanente").val("");
    $(modalnuevo).find("#req_Duracion").val("");
    $(modalnuevo).find("#req_Vacantes").val("");
    $(modalnuevo).find("#req_FechaRequisicion").val("");
    $(modalnuevo).find("#req_FechaContratacion").val("");
});
$("#btnEditar").click(function () {
    _ajax(null,
        '/Requisiciones/Edit/' + id,
        'GET',
        function (obj) {
            if (obj != "-1" && obj != "-2" && obj != "-3") {
                CierraPopups();
                $('#ModalEditar').modal('show');
                $("#ModalEditar").find("#req_Experiencia").val(obj.req_Experiencia);
                $("#ModalEditar").find("#req_Experiencia").focus();
                $("#ModalEditar").find("#req_Sexo").val(obj.req_Sexo);
                $("#ModalEditar").find("#req_Descripcion").val(obj.req_Descripcion);
                $("#ModalEditar").find("#req_EdadMinima").val(obj.req_EdadMinima);
                $("#ModalEditar").find("#req_EdadMaxima").val(obj.req_EdadMaxima);
                $("#ModalEditar").find("#req_EstadoCivil").val(obj.req_EstadoCivil);
                $("#ModalEditar").find("#req_EducacionSuperior").val(obj.req_EducacionSuperior);
                $("#ModalEditar").find("#req_Permanente").val(obj.req_Permanente);
                $("#ModalEditar").find("#req_Duracion").val(obj.req_Duracion);
                $("#ModalEditar").find("#req_Vacantes").val(obj.req_Vacantes);
                $("#ModalEditar").find("#req_FechaRequisicion").val(obj.req_FechaRequisicion);
                $("#ModalEditar").find("#req_FechaContratacion").val(obj.req_FechaContratacion);
            }
        });
});
$("#btnInhabilitar").click(function () {
    CierraPopups();
    $('#ModalInhabilitar').modal('show');
    $("#ModalInhabilitar").find("#req__RazonInactivo").val("");
    $("#ModalInhabilitar").find("#req__RazonInactivo").focus();
});
//botones POST
$("#btnGuardar").click(function () {
    var data = $("#FormNuevo").serializeArray();
    data = serializar(data);
    if (data != null) {
        data = JSON.stringify({ tbRequisiciones: data });
        _ajax(data,
            '/Requisiciones/Create',
            'POST',
            function (obj) {
                if (obj != "-1" && obj != "-2" && obj != "-3") {
                    CierraPopups();
                    llenarTabla();
                    LimpiarControles(["req_Experiencia", "req_Sexo", "req_Descripcion", "req_EdadMinima", "req_EdadMaxima", "req_EstadoCivil", "req_EducacionSuperior", "req_Permanente", "req_Duracion", "req_Vacantes", "req_FechaRequisicion", "req_FechaContratacion", "req__RazonInactivo"]);
                    MsgSuccess("¡Exito!", "Se ah agregado el registro");
                } else {
                    MsgError("Error", "Codigo:" + obj + ". contacte al administrador.(Verifique si el registro ya existe)");
                }
            });
    } else {
        MsgError("Error", "por favor llene todas las cajas de texto");
    }
});
$("#InActivar").click(function () {
    var data = $("#FormInactivar").serializeArray();
    data = serializar(data);
    if (data != null) {
        data.req__Id = id;
        data = JSON.stringify({ tbRequisiciones: data });
        _ajax(data,
            '/Requisiciones/Delete',
            'POST',
            function (obj) {
                if (obj != "-1" && obj != "-2" && obj != "-3") {
                    CierraPopups();
                    llenarTabla();
                    LimpiarControles(["req_Experiencia", "req_Sexo", "req_Descripcion", "req_EdadMinima", "req_EdadMaxima", "req_EstadoCivil", "req_EducacionSuperior", "req_Permanente", "req_Duracion", "req_Vacantes", "req_FechaRequisicion", "req_FechaContratacion", "req__RazonInactivo"]);
                    MsgWarning("¡Exito!", "Se ah Inactivado el registro");
                } else {
                    MsgError("Error", "Codigo:" + obj + ". contacte al administrador.");
                }
            });
    } else {
        MsgError("Error", "por favor llene todas las cajas de texto");
    }
});
$("#btnActualizar").click(function () {
    var data = $("#FormEditar").serializeArray();
    data = serializar(data);
    if (data != null) {
        data.req__Id = id;
        data = JSON.stringify({ tbRequisiciones: data });
        _ajax(data,
            '/Requisiciones/Edit',
            'POST',
            function (obj) {
                if (obj != "-1" && obj != "-2" && obj != "-3") {
                    CierraPopups();
                    llenarTabla();
                    MsgSuccess("¡Exito!", "Se ah actualizado el registro");
                } else {
                    MsgError("Error", "Codigo:" + obj + ". contacte al administrador.(Verifique si el registro ya existe)");
                }
            });
    } else {
        MsgError("Error", "por favor llene todas las cajas de texto");
    }
});
