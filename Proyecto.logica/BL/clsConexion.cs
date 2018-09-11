
using System.Configuration;
namespace Proyecto.logica.BL
{
    public class clsConexion
{
        ///obtiene conexion a base de datos
        ///<return> cadena de conexion </return>
    public string getConexion()
    {

        return ConfigurationManager.ConnectionStrings["Cnx"].ToString();
    }
}
}