﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace AplicacionWeb
{
    public class Global : System.Web.HttpApplication
    {

        public void RegistrarRutas ( RouteCollection rutas )
        {

            // Aquí van las rutas sobreescritas.

            rutas.MapPageRoute ( "Inicio", "Inicio", "~/Default.aspx" );

            rutas.MapPageRoute ( "RegistrarMiembro", "Registrarse", "~/RegistrarMiembro.aspx" );

            rutas.MapPageRoute ( "PublicacionIndividual", "PublicacionIndividual/{idImagen}", "~/PublicacionIndividual.aspx" );

            rutas.MapPageRoute ( "Individual", "Individual/{idImagen}", "~/Individual.aspx" );

            rutas.MapPageRoute ( "Moderar", "Moderar", "~/Administradores/PanelControl.aspx" );

            rutas.MapPageRoute ( "EnviarAporte", "EnviarAporte", "~/Miembros/EnviarAporte.aspx" );

            rutas.MapPageRoute ( "AporteEnviado", "AporteEnviado", "~/Miembros/AporteEnviado.aspx" );

            rutas.MapPageRoute ( "ControlarErrores", "Error", "~/Error.aspx" );

        }

        protected void Application_Start(object sender, EventArgs e)
        {

            // Aquí se invoca el metodo que registra las rutas que se van a sobreescribir.

            RegistrarRutas ( RouteTable.Routes );
           
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

            // Primera defensa para controlar errores generales en una sola pagina. Los errores personalizados están en el webconfig.

            //Exception ex = Server.GetLastError();

            //Server.ClearError();

            //Response.Redirect("Error");

            // Se está redireccionando pero se borra la descripcion del error. PTM :(

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

    }
}