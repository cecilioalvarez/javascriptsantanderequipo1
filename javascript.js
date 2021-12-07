/*window.onload = function () {
    var botones = document.getElementsByTagName("input");
    for (boton of botones) {
        boton.onclick = pulsar;
    }
}
function pulsar() {
    let body = document.getElementsByTagName("body")[0];
    let parrafo = document.createElement("p");
    let texto = document.createTextNode("has pulsado");
    parrafo.appendChild(texto);
    body.append(parrafo);
}*/
// $ es una funcion y recibe el documento
// generando un objeto complejo
/*$(document).ready(function () {
    console.log($(document));
    // hemos usado la funcion de click para ligar la funcion pulsar
    $("input").click(pulsar);
});


function pulsar() {
    // uno de los metodos adicionales para añadir contenido a la pagina
    $("body").append("<p>has pulsado</p>");
}*/
/*$(document).ready(function () {
    // selector de identificador
    $("#mas").click(function () {
        $("body").addClass("mas");
    });
    $("#azul").click(function () {
        $("body").addClass("azul");
    });
    $("#verdana").click(function () {
        $("body").addClass("verdana");
    });

});*/
$(document).ready(function () {
    $("input").click(function (e) {
        $("p").addClass(e.target.id);
    });
});