using System.Threading.Tasks;

namespace TEC_AL_0002.Models
{
    public class DefaultConnection
    {
        public static string connectionString = "" +
            "Password=Tiendas21;" +
            "Persist Security Info=True;" +
            "User ID=SISTEMA;" +
            "Initial Catalog=TIENDASDAKA_DWH;" +
            "Data Source=VSRV-DAKA-BI01";

        // Consulta principal a la base de Datos(POS)
        public static string conusltaSqlSever(string departmento)
        {
            string queryDataPrincipal = @"
                SELECT * FROM 
                    [dbo].[EXTENSIONES_DAKA] WHERE 
                    Departamento LIKE 
                    '"+ departmento + "%'";
            return queryDataPrincipal;
        }
    }
}

