using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

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
                    command.CommandText = "select * from users where LoginName=@user and Password=@pass";
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
}
