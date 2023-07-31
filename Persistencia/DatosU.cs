using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using RegistroUsuarios.Entities;

namespace Persistencia
{
    public class DatosU : ConeccionSql
    {
        public bool login(string user, string pass)
        {
            using (var connection = GetSqlConnection())
            {

                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from users where NombreUsuario=@user and Contraseña=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;

                    }
                    else
                    {

                        return false;
                    }

                }

            }

        }






    }




    public class DataAccessLayer
    {
        private string connectionString = "Server=localhost;Database=sisviansa;Uid=root;Pwd=auditoredash3;";

        public bool RegistrarCliente(int numeroCliente, string nombreUsuario, string contraseña, string ci, string direccion, string correoElectronico, string nombre, string apellido)
        {
            string query = "INSERT INTO comun (NroCliente, Usuario, Contraseña, Ci, Direccion, CorreoElectronico, Nombre, Apellido) " +
                           "VALUES (@NroCliente, @Usuario, @Contraseña, @Ci, @Direccion, @CorreoElectronico, @Nombre, @Apellido)";
            string querycliente = "INSERT INTO otra_tabla (NroCliente) VALUES (@NroCliente)";


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NroCliente", numeroCliente);
                    command.Parameters.AddWithValue("@Usuario", nombreUsuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);
                    command.Parameters.AddWithValue("@Ci", ci);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

               

            }


        }
    }











    }














        
     







    

 


           








