$(document).ready(function () {

    const $grafica = document.querySelector("#graficapai");
    const etiquetas = ["Mujer", "Hombre"]
    const Cantidad = [];


    $.ajax({
        url: '/Boleto/GraficaSexo',
        data: "",
        dataType: 'json',
        success: function (Grafica) {

            //Declaracion de los arrys
            var i = 0;
            // Agrega las opciones de municipios
            $.each(Grafica, function (index, GraficaS) {
                i++;
                Cantidad.push(GraficaS.femenino);
                Cantidad.push(GraficaS.masculino);

                console.log(GraficaS.femenino);
            });

            //Grafica

            const datosIngresos = {
                data: Cantidad , // La data es un arreglo que debe tener la misma cantidad de valores que la cantidad de etiquetas
                // Ahora debería haber tantos background colors como datos, es decir, para este ejemplo, 4
                backgroundColor: [
                    'rgba(163,221,203,0.2)',
                    'rgba(232,233,161,0.2)',
                    'rgba(230,181,102,0.2)',
                    'rgba(229,112,126,0.2)',
                ],// Color de fondo
                borderColor: [
                    'rgba(163,221,203,1)',
                    'rgba(232,233,161,1)',
                    'rgba(230,181,102,1)',
                    'rgba(229,112,126,1)',
                ],// Color del borde
                borderWidth: 1,// Ancho del borde
            };
            new Chart($grafica, {
                type: 'pie',// Tipo de gráfica. Puede ser dougnhut o pie
                data: {
                    labels: etiquetas,
                    datasets: [
                        datosIngresos,
                        // Aquí más datos...
                    ]
                },
            });


        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.error('Error al cargar : ' + textStatus + ', ' + errorThrown);
        }
    });

});