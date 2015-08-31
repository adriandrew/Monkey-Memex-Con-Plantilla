function MuestraOculta ( id )
{

    // Se obtiene el id.

     if ( document.getElementById ) {

         // Se define la variable "comentarioUsuarios" igual a nuestro div.

        var comentarioUsuario = document.getElementById ( id ); 

        // Si la variable comentarioUsuario no viene nula o indefinida se aplica la propiedad.

        if ( typeof comentarioUsuario !== 'undefined' && comentarioUsuario !== null ) {

            // Damos un atributo display:none que oculta el div.

            comentarioUsuario.style.display = ( comentarioUsuario.style.display == 'none' ) ? 'block' : 'none'; 

        }

    }

}

// Metodo obsoleto.

function InvocarFancybox() {

    // Aplicando efectos a todos los enlaces con el id iframe.

    $ ( "a.iframe" ) .fancybox ( {

        'width': '75%',

        'height': '100%',

        'autoScale': false,

        'transitionIn': 'elastic',

        'transitionOut': 'elastic',

        'overlayOpacity': '.8',

        'overlayColor': 'black',

        'type': 'iframe'

    } );

}

function InvocarFancybox(ancho, alto, autoescala, opacidad) {

    // Aplicando efectos a todos los enlaces con el id iframe.

    $("a.iframe").fancybox({

        'width': ancho,

        'height': alto,

        'autoScale': autoescala,

        'transitionIn': 'elastic',

        'transitionOut': 'elastic',

        'overlayOpacity': opacidad,

        'overlayColor': 'black',

        'type': 'iframe'

    });

}

window.onload = function ()
{

    // Hace que se cargue la función lo que predetermina que div estará oculto hasta llamar a la función nuevamente. 

    MuestraOculta('navEquipos');

    // El parametro es el nombre que le dimos al DIV. 

    InsigniaGoogle();

    DetectarCarga();

}

// Carga manual.

function DetectarCarga() {

    $('#carga').remove();

}

function CerrarFancyboxYRedireccionar(url) {

    $.fancybox.close();

    window.location = url;

    // Esta instruccion hace lo mismo, pero va en algun evento (onclick, onmouseover, etc.) del control (boton, link, etc.).
    // self.parent.location.href = 'Registrarse'

}

function InsigniaGoogle(){

    //<!-- Inserta esta etiqueta después de la última etiqueta de widget. -->
    //<script type="text/javascript">
    window.___gcfg = { lang: 'es-419' };

    (function () {
        var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;
        po.src = 'https://apis.google.com/js/platform.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);
    })();
    //</script>

}

// TODO. Intento de flappy bird al iniciar la pagina de error.
//$(document).ready(function () {

//    $("a").fancybox();

//    $("#iframe").click();

//});