using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ventas_watch.modelo;

namespace ventas_watch.dataAccess
{
    public class dataAccessClient
    {
        private string _connection_string;

        public dataAccessClient()
        {
            _connection_string = ConfigurationManager.ConnectionStrings["conexionTiendaWatch"].ConnectionString;
        }

        public IEnumerable<client> GetClients()
        {
            var clients = new List<client>();

            using (var conexion = new SqlConnection(_connection_string)) 
            {
                var command = new SqlCommand("SELECT * FROM CLIENTS", conexion);
                conexion.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clients.Add(new client
                        {
                            cedula_ciudadania = reader.GetInt32(1),
                            name = reader.GetString(2),
                            last_name = reader.GetString(3),
                            email = reader.GetString(4),
                            phone = reader.GetInt32(5)
                        });  
                    }
                }
            }
            return clients;
        }

    }
}
