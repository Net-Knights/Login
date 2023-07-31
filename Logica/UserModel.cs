using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
//using Persistencia;
using RegistroUsuarios.Entities;
using System.Text.RegularExpressions;
using Persistencia;

namespace Logica
{
    //public class UserModel
    //{
    //    DatosU datosU = new DatosU();
    //    public bool LoginUser(string user, string pass)
    //    {
    //       return datosU.login(user, pass);

    //    }

       
    //    }

    public class LogicaUsuarios
    {
        private List<UsuarioPrueba> usuariosPrueba;

        public LogicaUsuarios()
        {
            usuariosPrueba = new List<UsuarioPrueba>
        {
            new UsuarioPrueba { NombreUsuario = "Prueba", Contraseña = "prueba" },
            new UsuarioPrueba { NombreUsuario = "usuario1", Contraseña = "contraseña1" },
            new UsuarioPrueba { NombreUsuario = "usuario2", Contraseña = "contraseña2" }
            // Agrega más usuarios de prueba si es necesario
        };
        }

        public UsuarioPrueba ObtenerUsuario(string nombreUsuario, string contraseña)
        {
            return usuariosPrueba.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña);
        }
    }
     public class NegocioCliente
    {
        private DataAccessLayer dataAccessLayer;

        public NegocioCliente()
        {
            dataAccessLayer = new DataAccessLayer();
        }

        public int GenerarNumeroCliente()
        {
            Random random = new Random();
            return random.Next(1000, 9999); // Números aleatorios de 4 dígitos
        }

        public bool RegistrarCliente(string nombreUsuario, string contraseña, string ci, string direccion, string email, string nombre, string apellido)
        {
            int numeroCliente = GenerarNumeroCliente();
            return dataAccessLayer.RegistrarCliente(numeroCliente, nombreUsuario, contraseña, ci, direccion, email, nombre, apellido);
        }
    }


}

    
    

