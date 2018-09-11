using System;




namespace Proyecto.Web.Controllers
{
    public class LoginController
    {
        public bool getvalidarUsuarioController(logica.Models.clsUsuarios obclsUsuarios)
        {

            try
            {
                logica.BL.clsUsuarios obclsUsuario = new logica.BL.clsUsuarios();
                return obclsUsuario.getvalidarUsuario(obclsUsuarios);

            }
            catch (Exception ex) { throw ex; }
        }

    }
}