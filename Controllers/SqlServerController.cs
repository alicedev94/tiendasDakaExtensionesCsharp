using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using TEC_AL_0002.Models;

namespace TEC_AL_0002.Controllers
{
    public class SqlServerController : Controller
    {
        // ____________________________________:
        // Variables                        ___:
        bool httpsIndex = false;         // ___:

        public IActionResult Index()
        {
            return View();
        }
        //                                  ___:
        // ____________________________________:

        // Funcion que realiza una consulta a los datos (POS); Recibe dos parametros los cuales son (Caja, Fecha)
        [HttpPost]
        public async Task<IActionResult> Index(Parameters _parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DefaultConnection.connectionString)) // cambiar conexion
                {
                    string query = DefaultConnection.conusltaSqlSever(_parameters.Departamento); // cambiar a los valores requeridos _parameters.Caja, _parameters.Fecha
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var reader = cmd.ExecuteReader();

                    //C M
                    while (reader.Read())
                    {
                        // Columnas PD: reducir el numero de columnas
                        ModelSqlSever.Departamento.Add(reader.GetString(0).ToString());
                        ModelSqlSever.Ext.Add(reader.GetString(1).ToString());
                        ModelSqlSever.Nombre.Add(reader.GetString(2).ToString());
                        ModelSqlSever.Localidad.Add(reader.GetString(3).ToString());
                    }
                    // Agregar las columnas obtenidas a un fichero html,css,js
                }
                httpsIndex = true;
            }
            catch (SqlException) // ex 
            {
                //Crear Log para errores, con un directorio raiz donde almacenra los errores
                return RedirectToAction("Index", "SqlServer");
            }

            return RedirectToAction("Index", "SqlServer");
        }

    }
}
