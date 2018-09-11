using System;
using System.Data;
namespace Proyecto.Web.Controllers
{

    public class clsPosiblesClientesController
    {

       
        public DataSet getConsultarPosiblesClientesController()
        {


            try{

                logica.BL.clsPosiblesClientes obclsPosiblesClientes = new logica.BL.clsPosiblesClientes();
                return obclsPosiblesClientes.getConsultarPosiblesClientes();

            }catch (Exception ex) { throw ex; }

        }

        /// <summary>
        /// Administra posibles clientes
        /// </summary>
        /// <param name="obclsPosiblesClientesModels">Objeto</param>
        /// <param name="inOpcion">Opcion de ejecucion</param>
        /// <returns>mensaje de proceso</returns>

        public string setAdministrarPosiblesClientesController(logica.Models.clsPosiblesClientes obclsPosiblesClientesModels, int inOpcion)
        {

            try
            {

                logica.BL.clsPosiblesClientes obclsPosiblesClientes = new logica.BL.clsPosiblesClientes();
                return obclsPosiblesClientes.setAdministrarPosiblesClientes(obclsPosiblesClientesModels,inOpcion);
            }
            catch (Exception ex){ throw ex; }
           


        }

    }
}