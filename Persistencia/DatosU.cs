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


 public class RegistroDAL: ConeccionSql
    {


        public bool GuardarUsuario(Usuario usuario)
        {
            try
            {
                using (MySqlConnection connection = GetSqlConnection())
                {
                    string query = "";
                    MySqlCommand command = null;

                    if (usuario is ClienteComun clienteComun)
                    {
                        query = "INSERT INTO clientecomun (NombreUsuario, Contraseña, Direccion, CI, CorreoElectronico, Telefono) VALUES (@NombreUsuario, @Contraseña, @Direccion, @CI, @CorreoElectronico, @Telefono)";

                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@NombreUsuario", clienteComun.NombreUsuario);
                        command.Parameters.AddWithValue("@Contraseña", clienteComun.Contraseña);
                        command.Parameters.AddWithValue("@Direccion", clienteComun.Direccion);
                        command.Parameters.AddWithValue("@CI", clienteComun.CI);
                        command.Parameters.AddWithValue("@CorreoElectronico", clienteComun.CorreoElectronico);
                        command.Parameters.AddWithValue("@Telefono", clienteComun.Telefono);
                    }
                    else if (usuario is ClienteEmpresa clienteEmpresa)
                    {
                        query = "INSERT INTO clienteempresa (NombreUsuario, Contraseña, NombreEmpresa, RUT, DireccionEmpresa, CorreoElectronico, TelefonoEmpresa) VALUES (@NombreUsuario, @Contraseña, @NombreEmpresa, @RUT, @DireccionEmpresa, @CorreoElectronico, @TelefonoEmpresa)";

                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@NombreUsuario", clienteEmpresa.NombreUsuario);
                        command.Parameters.AddWithValue("@Contraseña", clienteEmpresa.Contraseña);
                        command.Parameters.AddWithValue("@NombreEmpresa", clienteEmpresa.NombreEmpresa);
                        command.Parameters.AddWithValue("@RUT", clienteEmpresa.RUT);
                        command.Parameters.AddWithValue("@DireccionEmpresa", clienteEmpresa.DireccionEmpresa);
                        command.Parameters.AddWithValue("@CorreoElectronico", clienteEmpresa.CorreoElectronico);
                        command.Parameters.AddWithValue("@TelefonoEmpresa", clienteEmpresa.TelefonoEmpresa);
                    }
                    else if (usuario is UsuarioSistema usuarioSistema)
                    {
                        query = "INSERT INTO usuariosistema (NombreUsuario, Contraseña, CorreoElectronico) VALUES (@NombreUsuario, @Contraseña, @CorreoElectronico)";

                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@NombreUsuario", usuarioSistema.NombreUsuario);
                        command.Parameters.AddWithValue("@Contraseña", usuarioSistema.Contraseña);
                        command.Parameters.AddWithValue("@CorreoElectronico", usuarioSistema.CorreoElectronico);
                    }

                    if (command != null)
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;  // Retorna true si se afectó al menos una fila
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones y realizar un registro de errores si es necesario
                return false;
            }

            return false;
        }
    }




}

        
     







    

 


           








