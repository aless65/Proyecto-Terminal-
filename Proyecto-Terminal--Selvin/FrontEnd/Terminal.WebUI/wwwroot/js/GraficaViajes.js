$(document).ready(function () {

    const $grafica = document.querySelector("#grafica");
    var Departamento = [];
    var Cantidad = [];


    $.ajax({
        url: '/Boleto/GraficaViajes',
        data: "",
        dataType: 'json',
        success: function (Grafica) {

            //Declaracion de los arrys
            var i = 0;
            // Agrega las opciones de municipios
            $.each(Grafica, function (index, GraficaV) {
                i++;
                Departamento.push(GraficaV.bole_hora_Destino_Nombre);
                Cantidad.push(GraficaV.cantidad);

            });

            //Grafica
            
            var datosVentas2020 = {
                label: "Los departamento que mas se Viajan  ",
                data: Cantidad, // La data es un arreglo que debe tener la misma cantidad de valores que la cantidad de etiquetas
                backgroundColor: 'rgba(54, 162, 235, 0.2)', // Color de fondo
                borderColor: 'rgba(54, 162, 235, 1)', // Color del borde
                borderWidth: 1,// Ancho del borde
            };
            new Chart($grafica, {
                type: 'bar',// Tipo de gráfica
                data: {
                    labels: Departamento,
                    datasets: [
                        datosVentas2020,
                        // Aquí más datos...
                    ]
                },
                options: {
                    scales: {
                        yAxes: [{
                            ticks: {
                                beginAtZero: true
                            }
                        }],
                    },
                }
            });


        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.error('Error al cargar : ' + textStatus + ', ' + errorThrown);
        }
    });

   

    

    //// Obtener una referencia al elemento canvas del DOM
    //const $grafica = document.querySelector("#grafica");
    //// Las etiquetas son las que van en el eje X. 
    //const etiquetas = ["Atlántida",
    //    "Choluteca",
    //    "Colón",
    //    "Comayagua",
    //    "Copán",
    //    "Cortés",
    //    "El Paraíso",
    //    "Francisco Morazán",
    //    "Gracias a Dios",
    //    "Intibucá",
    //    "Islas de la Bahía",
    //    "La Paz",
    //    "Lempira",
    //    "Ocotepeque",
    //    "Olancho",
    //    "Santa Bárbara",
    //    "Valle",
    //    "Yoro"]
    //// Podemos tener varios conjuntos de datos. Comencemos con uno
    //const datosVentas2020 = {
    //    label: "Los departamento que mas se Viajan  ",
    //    data: [50, 25, 80, 51, 25, 80, 51, 25, 100, 51, 25, 80, 52, 20, 80, 50, 20, 80], // La data es un arreglo que debe tener la misma cantidad de valores que la cantidad de etiquetas
    //    backgroundColor: 'rgba(54, 162, 235, 0.2)', // Color de fondo
    //    borderColor: 'rgba(54, 162, 235, 1)', // Color del borde
    //    borderWidth: 1,// Ancho del borde
    //};
    //new Chart($grafica, {
    //    type: 'bar',// Tipo de gráfica
    //    data: {
    //        labels: etiquetas,
    //        datasets: [
    //            datosVentas2020,
    //            // Aquí más datos...
    //        ]
    //    },
    //    options: {
    //        scales: {
    //            yAxes: [{
    //                ticks: {
    //                    beginAtZero: true
    //                }
    //            }],
    //        },
    //    }
    //});
})