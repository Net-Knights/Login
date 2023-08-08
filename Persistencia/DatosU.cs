using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using RegistroUsuarios.Entities;
using System.Text.RegularExpressions;

namespace Persistencia
{
    public class DatosU 
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



        public LoginGeneral IniciarSesion(string usuario, string contraseña)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Usuario, Rol FROM login WHERE Usuario = @Usuario AND Contraseña = @Contraseña;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nombreUsuario = reader.GetString("Usuario");
                        string rol = reader.GetString("Rol");
                        return new LoginGeneral { NombreUsuario = nombreUsuario, Rol = rol };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }


        // Método para obtener los datos de clientes comunes
        public DataTable ObtenerDatosClientesComunes()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT 
                    c.NroCliente,
                    c.Autorizacion,
                    c.Mail AS 'Mail',
                    c.Telefono AS 'Telefono',
                    c.Direccion AS 'Direccion',
                    co.Ci AS 'Ci',
                    co.Nombre AS 'Nombre',
                    co.Apellido AS 'Apellido',
                    (SELECT l.Rol FROM login l WHERE l.Usuario = c.NroCliente) AS 'Rol'
                FROM Cliente c
                LEFT JOIN Comun co ON c.NroCliente = co.NroCliente
                ;";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        // Método para obtener los datos de clientes empresa
        public DataTable ObtenerDatosClientesEmpresa()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT 
                    
                    e.RUT AS 'RUT',
                    e.NombreEmpresa AS 'NombreEmpresa',
                    
                    (SELECT l.Rol FROM login l WHERE l.Usuario = c.NroCliente) AS 'Rol'
                FROM Cliente c
                LEFT JOIN Empresa e ON c.NroCliente = e.NroCliente
                ;";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        // Método para buscar un cliente por NroCliente
        public DataTable BuscarClientePorNroCliente(int nroCliente)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT 
                        c.NroCliente,
                        c.Autorizacion,
                        c.Mail AS 'MailCliente',
                        c.Telefono AS 'TelefonoCliente',
                        c.Direccion AS 'DireccionCliente',
                        co.Ci AS 'CiComun',
                        co.Nombre AS 'NombreComun',
                        co.Apellido AS 'ApellidoComun',
                        e.RUT AS 'RutEmpresa',
                        e.NombreEmpresa AS 'NombreEmpresa',
                        (SELECT l.Rol FROM login l WHERE l.Usuario = c.NroCliente) AS 'Rol'
                    FROM Cliente c
                    LEFT JOIN Comun co ON c.NroCliente = co.NroCliente
                    LEFT JOIN Empresa e ON c.NroCliente = e.NroCliente
                    WHERE c.NroCliente = @NroCliente;";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NroCliente", nroCliente);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }


        // Método para guardar un cliente en la tabla Cliente y sus respectivas tablas
        public void GuardarCliente(string tipoCliente, string nombre, string apellido, string correoElectronico, string telefono, string ci, string direccion, string rut, string nombreEmpresa, string direccionEmpresa)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();



                string queryCliente = "INSERT INTO Cliente (Mail, Telefono, Direccion) VALUES (@Mail, @Telefono, @Direccion) " +
                               "ON DUPLICATE KEY UPDATE Mail = @Mail, Telefono = @Telefono, Direccion = @Direccion;";
                MySqlCommand commandCliente = new MySqlCommand(queryCliente, connection);
                commandCliente.Parameters.AddWithValue("@Mail", correoElectronico);
                commandCliente.Parameters.AddWithValue("@Telefono", telefono);
                commandCliente.Parameters.AddWithValue("@Direccion", direccion);
                commandCliente.ExecuteNonQuery();

                // Insertar o actualizar en las tablas correspondientes según el tipo de cliente
                if (tipoCliente == "Común")
                {
                    string queryComun = "INSERT INTO Comun (NroCliente, CI, Nombre, Apellido) VALUES ((SELECT NroCliente FROM Cliente WHERE Mail = @Mail), @CI, @Nombre, @Apellido) " +
                                        "ON DUPLICATE KEY UPDATE CI = @CI, Nombre = @Nombre, Apellido = @Apellido;";
                    MySqlCommand commandComun = new MySqlCommand(queryComun, connection);
                    commandComun.Parameters.AddWithValue("@Mail", correoElectronico);
                    commandComun.Parameters.AddWithValue("@CI", ci);
                    commandComun.Parameters.AddWithValue("@Nombre", nombre);
                    commandComun.Parameters.AddWithValue("@Apellido", apellido);
                    commandComun.ExecuteNonQuery();
                }
                else if (tipoCliente == "Empresa")
                {
                    string queryEmpresa = "INSERT INTO Empresa (NroCliente, RUT, NombreEmpresa) VALUES ((SELECT NroCliente FROM Cliente WHERE Mail = @Mail), @RUT, @NombreEmpresa) " +
                                          "ON DUPLICATE KEY UPDATE RUT = @RUT, NombreEmpresa = @NombreEmpresa;";
                    MySqlCommand commandEmpresa = new MySqlCommand(queryEmpresa, connection);
                    commandEmpresa.Parameters.AddWithValue("@Mail", correoElectronico);
                    commandEmpresa.Parameters.AddWithValue("@RUT", rut);
                    commandEmpresa.Parameters.AddWithValue("@NombreEmpresa", nombreEmpresa);
                    commandEmpresa.ExecuteNonQuery();
                }
            }
        }

       

        public void EliminarCliente(int nroCliente)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Cliente WHERE NroCliente = @NroCliente";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NroCliente", nroCliente);

                command.ExecuteNonQuery();
            }
        }

        public void ModificarClienteComun(int nroCliente, string nombre, string apellido, string correoElectronico, string telefono, string ci, string direccion)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                UPDATE Cliente
                SET Nombre = @Nombre, Apellido = @Apellido, Mail = @Mail, Telefono = @Telefono, CI = @CI, Direccion = @Direccion
                WHERE NroCliente = @NroCliente";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NroCliente", nroCliente);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Mail", correoElectronico);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@CI", ci);
                command.Parameters.AddWithValue("@Direccion", direccion);

                command.ExecuteNonQuery();
            }
        }
        public void ModificarClienteEmpresa(int nroCliente, string rut, string nombreEmpresa)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                UPDATE Cliente
                SET RUT = @RUT, NombreEmpresa = @NombreEmpresa,
                WHERE NroCliente = @NroCliente";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NroCliente", nroCliente);
                command.Parameters.AddWithValue("@RUT", rut);
                command.Parameters.AddWithValue("@NombreEmpresa", nombreEmpresa);

                command.ExecuteNonQuery();
            }
        }






    }

}





















































