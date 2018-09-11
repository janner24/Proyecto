using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace Proyecto.logica.BL
{
    public class clsPosiblesClientes
    {


        SqlConnection _SqlConnection = null;//me permite conectar con base de datos
        SqlCommand _sqlCommand = null;// me permite ejecutar comandos sql
        SqlDataAdapter _SqlDataAdapter = null;// permite adabtar conjuntos de datos en sql
        SqlParameter _sqlParameter = null;

        string stConexion = string.Empty;

        public clsPosiblesClientes()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        /// <summary>
        /// Consulta posibles clientes
        /// </summary>
        /// <returns>Registros posibles clientes</returns>
        public DataSet getConsultarPosiblesClientes()
        {

            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _sqlCommand = new SqlCommand("spConsultaPosiblesCliente", _SqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                

                _sqlCommand.ExecuteNonQuery();
                _SqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }
        /// <summary>
        /// Administrar posibles clientes
        /// </summary>
        /// <param name="obclsPosiblesClientes"Ongeto></param>
        /// <param name="inOpcion">opcion de ejecucion</param>
        /// <returns>Mensaje de operacion</returns>

        public string setAdministrarPosiblesClientes(Models.clsPosiblesClientes obclsPosiblesClientes, int inOpcion)
        {

            try
            {
               

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _sqlCommand = new SqlCommand("spAdministrarPosiblesClientes", _SqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.Parameters.Add(new SqlParameter("@nIdentificacion", obclsPosiblesClientes.inIdentificacion));
                _sqlCommand.Parameters.Add(new SqlParameter("@cEmpresa", obclsPosiblesClientes.stEmpresa));
                _sqlCommand.Parameters.Add(new SqlParameter("@cPrimerNombre", obclsPosiblesClientes.stprimerNombre));
                _sqlCommand.Parameters.Add(new SqlParameter("@cSegundoNombre", obclsPosiblesClientes.stSegundoNombre));
                _sqlCommand.Parameters.Add(new SqlParameter("@cPrimerApellido", obclsPosiblesClientes.stprimerApellido));
                _sqlCommand.Parameters.Add(new SqlParameter("@cSegundoApellido", obclsPosiblesClientes.stSegundoApellido));
                _sqlCommand.Parameters.Add(new SqlParameter("@cDireccion", obclsPosiblesClientes.stDireccion));
                _sqlCommand.Parameters.Add(new SqlParameter("@cTelefono", obclsPosiblesClientes.stTelefono));
                _sqlCommand.Parameters.Add(new SqlParameter("@cCorreo", obclsPosiblesClientes.stCorreo));
                _sqlCommand.Parameters.Add(new SqlParameter("@cOpcion", inOpcion));

                
                _sqlParameter = new SqlParameter();
                _sqlParameter.ParameterName = "@cMensaje";
                _sqlParameter.Direction = ParameterDirection.Output;
                _sqlParameter.SqlDbType = SqlDbType.VarChar;
                _sqlParameter.Size = 50;


                _sqlCommand.Parameters.Add(_sqlParameter);
                _sqlCommand.ExecuteNonQuery();

                return _sqlParameter.Value.ToString();
              
            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }
    }
}

