using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JAB_Verificador_Codigos_Gemelos_Twins
{
    internal class Datos_Codigos
    {
        public List<CodBar> getCodBarList(string fecha)
        {
            //devuelve lista con los codigos de barra de la fecha solicitada.
            List<String> columnData = new List<String>();

            List<CodBar> codBars = new List<CodBar>();

            CodBar codBar;

            //String sqlConnString = @"Data Source = localhost; Initial Catalog = Twinsdb; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            String sqlConnString = @"Data Source = PGESA-SERVER6\WINCAMPO; Initial Catalog = Twinsdb;User ID=SA;Password=TJTQ; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            using (SqlConnection connection = new SqlConnection(sqlConnString))
            {
                connection.Open();
                string query =  "SELECT prod.codbar_s AS CodBar, merc.codigo AS CodProd, merc.descripcion AS Descripcion, " +
                                "prod.CantidadMovidap AS Peso, prod.Lote, prod.FechaProduccion, prod.fechasys AS FechaSys, " +
                                "prod.HORASYS AS HoraSys, prod.estado, prod.realizo AS Usuario " +
                                "FROM produccion_general prod " +
                                "inner join MERCADERIA merc ON prod.mercnro = merc.NC_MERCADERIA " +
                                $"WHERE prod.fechasys = '{fecha}' AND codbar_s != '' ORDER BY CodBar";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            codBar = new CodBar();
                            codBar.codBarras = (reader.GetString(0));
                            codBar.codProducto = (reader.GetString(1));
                            codBar.descripcion = (reader.GetString(2));
                            codBar.peso = (reader.GetDecimal(3));
                            codBar.lote = (reader.GetString(4));
                            codBar.fechaProduccion = (reader.GetInt32(5));
                            codBar.fecha = (reader.GetInt32(6));
                            codBar.hora = (reader.GetString(7));
                            codBar.estado = (reader.GetString(8));
                            codBar.usuario = (reader.GetString(9));
                            codBars.Add(codBar);
                        }
                    }
                }
            }

            return codBars;
        }

        public List<CodBar> getCodBarSandwich(long suspect_codbar)
        {
            //devuelve lista de los codigos de barra anterior y posterior al codigo proporcionado.
            List<CodBar> codBars = new List<CodBar>();

            CodBar codBar;

            String sqlConnString = @"Data Source = PGESA-SERVER6\WINCAMPO; Initial Catalog = Twinsdb;User ID=SA;Password=TJTQ; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            using (SqlConnection connection = new SqlConnection(sqlConnString))
            {
                connection.Open();

                string query =  "SELECT prod.codbar_s AS CodBar, merc.codigo AS CodProd, merc.descripcion AS Descripcion, " +
                                "prod.CantidadMovidap as Peso, prod.Lote, prod.FechaProduccion, prod.fechasys AS FechaSys, " +
                                "prod.HORASYS AS HoraSys, prod.estado, prod.realizo AS Usuario " +
                                "FROM produccion_general prod " +
                                "INNER JOIN MERCADERIA merc ON prod.mercnro = merc.NC_MERCADERIA " +
                                $"WHERE prod.CODBAR_S IN ('{suspect_codbar - 1}', '{suspect_codbar}', '{suspect_codbar + 1}') " +
                                "ORDER BY CodBar; ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            codBar = new CodBar();
                            codBar.codBarras = (reader.GetString(0));
                            codBar.codProducto = (reader.GetString(1));
                            codBar.descripcion = (reader.GetString(2));
                            codBar.peso = (reader.GetDecimal(3));
                            codBar.lote = (reader.GetString(4));
                            codBar.fechaProduccion = (reader.GetInt32(5));
                            codBar.fecha = (reader.GetInt32(6));
                            codBar.hora = (reader.GetString(7));
                            codBar.estado = (reader.GetString(8));
                            codBar.usuario = (reader.GetString(9));
                            codBars.Add(codBar);
                        }
                    }
                }
            }

            return codBars;
        }
    }
}
