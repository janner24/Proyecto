﻿using System;


namespace Proyecto.Web.vistas.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (!IsPostBack)
              //  ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Buen trabajo!', 'Se realizo proceso con exito!', 'success') </Script>");


        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtemail.Text)) stMensaje += "ingrese Email,";
                if (string.IsNullOrEmpty(txtPassword.Text)) stMensaje += "ingrese Password,";
                

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                //defino objeto con propiedades
                logica.Models.clsUsuarios obclsUsuarios = new logica.Models.clsUsuarios
                {
                    stLogin = txtemail.Text,
                    stPassword=txtPassword.Text

                };
                //instancio controlador
                Controllers.LoginController obloginController = new Controllers.LoginController();

                bool blBandera = obloginController.getvalidarUsuarioController(obclsUsuarios);
                if (blBandera)
                    Response.Redirect("../Index/Index.aspx"); //redirecciono
                else throw new Exception("Usuario o clave incorrecta");

            }
            catch (Exception ex)
            {

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('error!','" + ex.Message + "!', 'error') </Script>");

            }

        }
    }
}