using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using Persistencia;

namespace Logica
{
    public class UserModel
    {
        DatosU datosU = new DatosU();
        public bool LoginUser(string user, string pass)
        {
           return datosU.login(user, pass);

        }

    }
}