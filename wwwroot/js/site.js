function BorrarRegistro(){
    var numeroBorrar = parseInt(window.prompt("Introduce el numero del producto a borrar"));
    if (!isNaN(numeroBorrar)) {
        window.location.href = "/Home/Borrar?numero=" + numeroBorrar;  
    } else {
        alert("Eso no es una numero");
    }    
}