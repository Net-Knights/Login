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

    public class RegistroBLL
    {
        private readonly RegistroDAL registroDAL;

        public RegistroBLL()
        {
            registroDAL = new RegistroDAL();
        }

        public bool RegistrarUsuario(Usuario usuario)
        {
            // Validar usuario
            if (!ValidarUsuario(usuario))
            {
                return false;
            }

            // Guardar usuario en la base de datos
            bool exito = registroDAL.GuardarUsuario(usuario);

            return exito;
        }

        private bool ValidarUsuario(Usuario usuario)
        {
            // Aqui se pueden realizar validaciones extras como
            // si el usuario ya existe, si cumple con ciertas políticas, etc.

            if (usuario is ClienteComun clienteComun)
            {
                if (string.IsNullOrWhiteSpace(clienteComun.Direccion) || string.IsNullOrWhiteSpace(clienteComun.CI) || string.IsNullOrWhiteSpace(clienteComun.Telefono))
                {
                    return false;
                }
            }
            else if (usuario is ClienteEmpresa clienteEmpresa)
            {
                if (string.IsNullOrWhiteSpace(clienteEmpresa.NombreEmpresa) || string.IsNullOrWhiteSpace(clienteEmpresa.RUT) || string.IsNullOrWhiteSpace(clienteEmpresa.DireccionEmpresa) || string.IsNullOrWhiteSpace(clienteEmpresa.TelefonoEmpresa))
                {
                    return false;
                }
            }

            return true;
        }
    }

}