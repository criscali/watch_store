using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ventas_watch.modelo;
using System.Runtime.Remoting.Messaging;
using ventas_watch.interfase;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;

namespace ventas_watch.dataAccess
{
    public class dataAccessEntity<T> where T : class, new()
    {
        private string _connection_string;
        public List<T> listadoEntidad;

        public dataAccessEntity()
        {
            _connection_string = ConfigurationManager.ConnectionStrings["conexionTiendaWatch"].ConnectionString;
            listadoEntidad = new List<T>();
        }
        public List<T> DisplayEntity()
        {
            using (var conexion = new SqlConnection(_connection_string))
            {
                var command = new SqlCommand($"SELECT * FROM {typeof(T).Name}", conexion);
                conexion.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T entidad = new T();
                        foreach (PropertyInfo propiedad in typeof(T).GetProperties())
                        {
                            if (reader.HasRows && reader[propiedad.Name] != DBNull.Value)
                            {
                                var valor = Convert.ChangeType(reader[propiedad.Name], propiedad.PropertyType);
                                propiedad.SetValue(entidad, valor);
                            }
                        }
                        listadoEntidad.Add(entidad);
                    }
                }
            }

            return listadoEntidad;
        } 
        public string CreateDataEntity(List<T> entidad)
        {
            var grabado = 0;
            var mensaje = "";
            var sql = new StringBuilder();
            var listado = new List<object>();
            var GetEntity = new object();

            T entidad1 = new T();
            GetEntity = entidad1.GetType().Name;
            foreach (T elemento in entidad)
            {
                // Usamos la reflexión para obtener y mostrar las propiedades del objeto.
                foreach (var prop in typeof(T).GetProperties())
                {
                    
                    //Console.Write($"{prop.Name}: {prop.GetValue(elemento)} ");
                    if (prop.Name != "id")
                    {
                        var algo = prop.GetValue(elemento);
                        listado.Add(algo.ToString());
                    }
                    
                }
                
            }
            sql.Append($"INSERT INTO {GetEntity}");
            if (GetEntity.ToString() == "client")
            {
                sql.Append("(cedula_ciudadania, name, last_name, email, phone)");
            }
            if (GetEntity.ToString() == "product")
            {
                sql.Append("(name, description, price_buy, price_sell)");
            }
            sql.Append("VALUES");
            sql.Append("(");

            foreach (var item in listado)
            {
                sql.Append($"'{item}',");
                    
            }
            sql.Append(")");

            if(sql.Length > 0 && sql[sql.Length - 2] == ',')
            {
                sql.Remove(sql.Length - 2, 1);
            }
            Console.WriteLine(sql.ToString());
            
            //foreach (var listado in entidad)
            //{

           
            //}
            using (var conexion = new SqlConnection(_connection_string))
            {
                using (var command = new SqlCommand(sql.ToString(), conexion))
                {
                    conexion.Open();
                    command.ExecuteNonQuery();
                    grabado = 1;
                }
            }
            if (grabado == 1)
            {
                mensaje = "REGISTRO GRABADO.";
            }
            else
            {
                mensaje = "ERROR AL GRABAR REGISTRO.";
            }
            return mensaje;
        }
    }
}

