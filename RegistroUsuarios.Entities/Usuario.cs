using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUsuarios.Entities
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string CorreoElectronico { get; set; }

        public Usuario(string nombreUsuario, string contraseña, string correoElectronico)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
            this.CorreoElectronico = correoElectronico;
        }
    }

    public class ClienteComun : Usuario
    {
        public string Direccion { get; set; }
        public string CI { get; set; }
        public string Telefono { get; set; }

        public ClienteComun(string nombreUsuario, string contraseña, string direccion, string ci, string correoElectronico, string telefono)
            : base(nombreUsuario, contraseña, correoElectronico)
        {
            this.Direccion = direccion;
            this.CI = ci;
            this.Telefono = telefono;
        }
    }

    public class ClienteEmpresa : Usuario
    {
        public string NombreEmpresa { get; set; }
        public string RUT { get; set; }
        public string DireccionEmpresa { get; set; }
        public string TelefonoEmpresa { get; set; }

        public ClienteEmpresa(string nombreUsuario, string contraseña, string nombreEmpresa, string rut, string direccionEmpresa, string correoElectronico, string telefonoEmpresa)
            : base(nombreUsuario, contraseña, correoElectronico)
        {
            this.NombreEmpresa = nombreEmpresa;
            this.RUT = rut;
            this.DireccionEmpresa = direccionEmpresa;
            this.TelefonoEmpresa = telefonoEmpresa;
        }
    }

    public class UsuarioSistema : Usuario
    {
        public UsuarioSistema(string nombreUsuario, string contraseña, string correoElectronico)
            : base(nombreUsuario, contraseña, correoElectronico)
        {
        }
    }
}