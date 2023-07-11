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
    public class DatosU:ConeccionSql
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
                    command.Parameters.AddWithValue ("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if(reader.HasRows)
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
        private string connectionString = "Server=localhost;Database=mybd;Uid=root;Pwd=auditoredash3;";

        public void InsertarClienteComun(ClienteComun cliente)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO ClienteComun (NombreUsuario, Contraseña, CorreoElectronico, CI, Telefono, Direccion) " +
                            "VALUES (@NombreUsuario, @Contraseña, @CorreoElectronico, @CI, @Telefono, @Direccion)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreUsuario", cliente.NombreUsuario);
                command.Parameters.AddWithValue("@Contraseña", cliente.Contraseña);
                command.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico);
                command.Parameters.AddWithValue("@CI", cliente.CI);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.ExecuteNonQuery();
            }
        }

        public void InsertarClienteEmpresa(ClienteEmpresa cliente)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO ClienteEmpresa (NombreUsuario, Contraseña, Rut, NombreEmpresa, TelefonoEmpresa, CorreoElectronico, DireccionEmpresa) " +
                            "VALUES (@NombreUsuario, @Contraseña, @Rut, @NombreEmpresa, @TelefonoEmpresa, @CorreoElectronico, @DireccionEmpresa)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreUsuario", cliente.NombreUsuario);
                command.Parameters.AddWithValue("@Contraseña", cliente.Contraseña);
                command.Parameters.AddWithValue("@Rut", cliente.RUT);
                command.Parameters.AddWithValue("@NombreEmpresa", cliente.NombreEmpresa);
                command.Parameters.AddWithValue("@TelefonoEmpresa", cliente.TelefonoEmpresa);
                command.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico);
                command.Parameters.AddWithValue("@DireccionEmpresa", cliente.DireccionEmpresa);
                command.ExecuteNonQuery();
            }
        }

        public void InsertarUsuarioSistema(UsuarioSistema usuario)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO UsuarioSistema (NombreUsuario, Contraseña, CorreoElectronico) " +
                            "VALUES (@NombreUsuario, @Contraseña, @CorreoElectronico)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                command.Parameters.AddWithValue("@CorreoElectronico", usuario.CorreoElectronico);
                command.ExecuteNonQuery();
            }
        }



        public string VerificarCredenciales(string nombreUsuario, string contraseña)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Verificar en la tabla de ClienteComun
                var queryClienteComun = "SELECT COUNT(*) FROM ClienteComun WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";
                var commandClienteComun = new MySqlCommand(queryClienteComun, connection);
                commandClienteComun.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                commandClienteComun.Parameters.AddWithValue("@Contraseña", contraseña);
                var resultClienteComun = (long)commandClienteComun.ExecuteScalar();
                if (resultClienteComun > 0)
                {
                    return "Cliente Común";
                }

                // Verificar en la tabla de ClienteEmpresa
                var queryClienteEmpresa = "SELECT COUNT(*) FROM ClienteEmpresa WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";
                var commandClienteEmpresa = new MySqlCommand(queryClienteEmpresa, connection);
                commandClienteEmpresa.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                commandClienteEmpresa.Parameters.AddWithValue("@Contraseña", contraseña);
                var resultClienteEmpresa = (long)commandClienteEmpresa.ExecuteScalar();
                if (resultClienteEmpresa > 0)
                {
                    return "Cliente Empresa";
                }

                // Verificar en la tabla de UsuarioSistema
                var queryUsuarioSistema = "SELECT COUNT(*) FROM UsuarioSistema WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";
                var commandUsuarioSistema = new MySqlCommand(queryUsuarioSistema, connection);
                commandUsuarioSistema.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                commandUsuarioSistema.Parameters.AddWithValue("@Contraseña", contraseña);
                var resultUsuarioSistema = (long)commandUsuarioSistema.ExecuteScalar();
                if (resultUsuarioSistema > 0)
                {
                    return "Usuario del Sistema";
                }

                // Si no se encuentra en ninguna tabla, retornar null
                return null;
            }
        }




    }







}






        
     







    

 


           








