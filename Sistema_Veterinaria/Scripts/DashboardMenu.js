$(document).ready(function () {
    //$("#container").load("../Productos/index")

    $("#productos").click(function () {
        $.ajax({
            url: '../Productos/Index',
            contentType: 'application/html; charset=utf-8',
            type: 'GET',
            dataType: 'html',
            success: function (html) {
                $('#container').html(html);
            }
        });
    });

    $("#servicios").click(function () {
        $.ajax({
            url: '../Servicios/Index',
            contentType: 'application/html; charset=utf-8',
            type: 'GET',
            dataType: 'html',
            success: function (html) {
                $('#container').html(html);
            }
        });
        //$("#container").load("../Servicios/Index")
    });
});

$(document).on("click", "#btnEditar", function () {
    fila = $(this).closest("tr");
    id = parseInt(fila.find('td:eq(0)').text());
    nombre = fila.find('td:eq(1)').text();
    precio = parseFloat(fila.find('td:eq(2)').text());
    descripcion = fila.find('td:eq(4)').text();
    serie = parseInt(fila.find('td:eq(5)').text());
    marca = fila.find('td:eq(3)').text();
    descripcionHTML = fila.find('td:eq(6)').text();

    $("#codigo").val(id);
    $("#nombre_m").val(nombre);
    $("#precio_m").val(precio);
    $("#descripcion_m").val(descripcion);
    $("#serie_m").val(serie);
    $("#marca_m").val(marca);
    $("#descripcionHTML_m").val(descripcionHTML);
    //setTimeout(function () { $("#cargo_m").val(id_cargo); }, 200, $("#area_m").trigger("change"));
});

$(document).on("click", "#btnEditarServicio", function () {
    fila = $(this).closest("tr");
    id = parseInt(fila.find('td:eq(0)').text());
    nombre = fila.find('td:eq(1)').text();
    precio = parseFloat(fila.find('td:eq(2)').text());
    descripcion = fila.find('td:eq(3)').text();
    horario = fila.find('td:eq(4)').text();
    fechas = fila.find('td:eq(5)').text();

    $("#codigo_m_s").val(id);
    $("#nombre_m_s").val(nombre);
    $("#precio_m_s").val(precio);
    $("#descripcion_m_s").val(descripcion);
    $("#horario_m_s").val(horario);
    $("#fechas_m_s").val(fechas);
    //setTimeout(function () { $("#cargo_m").val(id_cargo); }, 200, $("#area_m").trigger("change"));
});

function btnEliminar() {
    var m = confirm("¿Estás seguro que deseas eliminar el registro?");
    if (m == true) {
        return true;
    } else {
        return false;
    }
}

$(document).ready(function () {
    //$("#container").load("../Registro/Cliente")

    $("#cliente").click(function () {
        $.ajax({
            url: '../Registro/Cliente',
            contentType: 'application/html; charset=utf-8',
            type: 'GET',
            dataType: 'html',
            success: function (html) {
                $('#container').html(html);
            }
        });
    });

    $("#mascota").click(function () {
        $.ajax({
            url: '../Registro/Mascota',
            contentType: 'application/html; charset=utf-8',
            type: 'GET',
            dataType: 'html',
            success: function (html) {
                $('#container').html(html);
            }
        });
        //$("#container").load("../Servicios/Index")
    });
});

$(document).on("click", "#btnEditarCliente", function () {
    fila = $(this).closest("tr");
    id = parseInt(fila.find('td:eq(0)').text());
    nombre = fila.find('td:eq(1)').text();
    apellido = fila.find('td:eq(2)').text();
    email = fila.find('td:eq(3)').text();
    telefono = fila.find('td:eq(4)').text();
    contraseña = fila.find('td:eq(5)').text();

    $("#codigo_m_c").val(id);
    $("#nombre_m_c").val(nombre);
    $("#apellido_m_c").val(apellido);
    $("#email_m_c").val(email);
    $("#telefono_m_c").val(telefono);
    $("#contraseña_m_c").val(contraseña);
    //setTimeout(function () { $("#cargo_m").val(id_cargo); }, 200, $("#area_m").trigger("change"));
});

$(document).on("click", "#btnEditarMascota", function () {
    fila = $(this).closest("tr");
    id = parseInt(fila.find('td:eq(0)').text());
    nombre = fila.find('td:eq(1)').text();
    especie = fila.find('td:eq(2)').text();
    raza = fila.find('td:eq(3)').text();
    edad = parseInt(fila.find('td:eq(4)').text());
    sexo = fila.find('td:eq(5)').text();
    fechanacimiento = fila.find('td:eq(6)').text();

    $("#codigo_m_m").val(id);
    $("#nombre_m_m").val(nombre);
    $("#especie_m_m").val(especie);
    $("#raza_m_m").val(raza);
    $("#edad_m_m").val(edad);
    $("#sexo_m_m").val(sexo);
    $("#fechanacimiento_m_m").val(fechanacimiento);
    //setTimeout(function () { $("#cargo_m").val(id_cargo); }, 200, $("#area_m").trigger("change"));
});