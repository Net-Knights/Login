using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using Persistencia;
using RegistroUsuarios.Entities;
using System.Text.RegularExpressions;
using Persistencia;

namespace Logica
{
    public class UserModel
    {

        private string connectionString = "Server=localhost;Database=sisviansa;Uid=root;Pwd=auditoredash3;";

        public void RegistrarCliente(string mail, string telefono, string direccion, string ci, string nombre, string apellido, string usuario, string contraseña)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Registrar cliente
                        string query = "INSERT INTO cliente (Mail, Telefono, Direccion) VALUES (@Mail, @Telefono, @Direccion)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Mail", mail);
                            command.Parameters.AddWithValue("@Telefono", telefono);
                            command.Parameters.AddWithValue("@Direccion", direccion);
                            command.ExecuteNonQuery();
                        }

                        // Obtener el NroCliente generado automáticamente
                        int nroCliente;
                        query = "SELECT LAST_INSERT_ID()";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            nroCliente = Convert.ToInt32(command.ExecuteScalar());
                        }

                        // Código para determinar el rol del cliente (ejemplo: común)
                        string rol = "Comun";
                        // Aquí puedes agregar la lógica para determinar el rol según algún criterio, como verificar si es empresa o administrador

                        // Registrar información común con el mismo NroCliente en la tabla "comun"
                        query = "INSERT INTO comun (NroCliente, Ci, Nombre, Apellido) VALUES (@NroCliente, @Ci, @Nombre, @Apellido)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NroCliente", nroCliente);
                            command.Parameters.AddWithValue("@Ci", ci);
                            command.Parameters.AddWithValue("@Nombre", nombre);
                            command.Parameters.AddWithValue("@Apellido", apellido);
                            command.ExecuteNonQuery();
                        }

                        // Registrar usuario y contraseña con el rol asignado en la tabla "login"
                        query = "INSERT INTO login (Usuario, Contraseña, Rol) VALUES (@Usuario, @Contraseña, @Rol)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Usuario", usuario);
                            command.Parameters.AddWithValue("@Contraseña", contraseña);
                            command.Parameters.AddWithValue("@Rol", rol);
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error al registrar: " + ex.Message);
                    }
                }
            }
        }
    }
}













