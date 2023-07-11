using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Persistencia;
using RegistroUsuarios.Entities;



namespace Login
{
    public partial class Registro : Form
    {

        private DatosU datosU;
        private UserModel userModel;
        public Registro()
        {
            InitializeComponent();

            OcultarCamposClienteEmpresa();

            OcultarCamposClienteComun();
            userModel = new UserModel();
        }


        private void Closebtn_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Show(this);
            Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string tipoUsuario = cmbTipoUsuario.SelectedItem.ToString();
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;
            string correoElectronico = txtCorreoElectronico.Text;

            // Validar campos
            if (!ValidarCampos(tipoUsuario, nombreUsuario, contraseña, correoElectronico))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Encriptar contraseña
            string contraseñaEncriptada = EncriptarContraseña(contraseña);

            // Crear objeto Usuario
            Usuario? usuario = null;

            if (tipoUsuario == "Cliente Comun")
            {
                string direccion = txtDireccion.Text;
                string ci = txtCI.Text;
                string telefono = txtTelefono.Text;
                usuario = new ClienteComun(nombreUsuario, contraseñaEncriptada, direccion, ci, correoElectronico, telefono);
            }
            else if (tipoUsuario == "Cliente Empresa")
            {
                string nombreEmpresa = txtNombreEmpresa.Text;
                string rut = txtRUT.Text;
                string direccionEmpresa = txtDireccionEmpresa.Text;
                string telefonoEmpresa = txtTelefonoEmpresa.Text;
                usuario = new ClienteEmpresa(nombreUsuario, contraseñaEncriptada, nombreEmpresa, rut, direccionEmpresa, correoElectronico, telefonoEmpresa);
            }
            else if (tipoUsuario == "Usuario Sistema")
            {
                usuario = new UsuarioSistema(nombreUsuario, contraseñaEncriptada, correoElectronico);
            }

            // Registrar usuario
            bool registroExitoso = userModel.RegistrarUsuario(usuario);

            if (registroExitoso)
            {
                MessageBox.Show("Registro exitoso.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar usuario.");
            }
        }

        private bool ValidarCampos(string tipoUsuario, string nombreUsuario, string contraseña, string correoElectronico)
        {
            if (string.IsNullOrWhiteSpace(tipoUsuario) || string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(correoElectronico))
            {
                return false;
            }

            // Validar campos adicionales según el tipo de usuario
            if (tipoUsuario == "Cliente Comun")
            {
                if (string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtCI.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    return false;
                }
            }
            else if (tipoUsuario == "Cliente Empresa")
            {
                if (string.IsNullOrWhiteSpace(txtNombreEmpresa.Text) || string.IsNullOrWhiteSpace(txtRUT.Text) || string.IsNullOrWhiteSpace(txtDireccionEmpresa.Text) || string.IsNullOrWhiteSpace(txtTelefonoEmpresa.Text))
                {
                    return false;
                }
            }

            return true;
        }

        private string EncriptarContraseña(string contraseña)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytesContraseña = System.Text.Encoding.UTF8.GetBytes(contraseña);
                byte[] hashContraseña = sha256.ComputeHash(bytesContraseña);
                string contraseñaEncriptada = Convert.ToBase64String(hashContraseña);
                return contraseñaEncriptada;
            }
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCI.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtNombreEmpresa.Text = string.Empty;
            txtRUT.Text = string.Empty;
            txtDireccionEmpresa.Text = string.Empty;
            txtTelefonoEmpresa.Text = string.Empty;
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            string tipoUsuario = cmbTipoUsuario.SelectedItem.ToString();

            if (tipoUsuario == "Cliente Comun")
            {
                MostrarCamposClienteComun();
                OcultarCamposClienteEmpresa();

            }
            else if (tipoUsuario == "Cliente Empresa")
            {
                OcultarCamposClienteComun();
                MostrarCamposClienteEmpresa();

            }
            else if (tipoUsuario == "Usuario Sistema")
            {
                OcultarCamposClienteComun();
                OcultarCamposClienteEmpresa();
                MostrarCamposUsuarioSistema();
            }
        }

        private void MostrarCamposClienteComun()
        {
            lblNombreUsuario.Visible = true;
            lblContraseña.Visible = true;
            lblDireccion.Visible = true;
            lblCI.Visible = true;
            lblTelefono.Visible = true;
            txtDireccion.Visible = true;
            txtCI.Visible = true;
            txtTelefono.Visible = true;
            txtNombreUsuario.Visible = true;
            txtContraseña.Visible = true;
        }

        private void OcultarCamposClienteComun()
        {
            lblDireccion.Visible = false;
            lblCI.Visible = false;
            lblTelefono.Visible = false;
            txtDireccion.Visible = false;
            txtCI.Visible = false;
            txtTelefono.Visible = false;
        }

        private void MostrarCamposClienteEmpresa()
        {
            lblNombreUsuario.Visible = true;
            lblContraseña.Visible = true;
            lblNombreEmpresa.Visible = true;
            lblRUT.Visible = true;
            lblDireccionEmpresa.Visible = true;
            lblTelefonoEmpresa.Visible = true;
            txtNombreEmpresa.Visible = true;
            txtRUT.Visible = true;
            txtDireccionEmpresa.Visible = true;
            txtTelefonoEmpresa.Visible = true;
            txtNombreUsuario.Visible = true;
            txtContraseña.Visible = true;
        }

        private void OcultarCamposClienteEmpresa()
        {
            lblNombreEmpresa.Visible = false;
            lblRUT.Visible = false;
            lblDireccionEmpresa.Visible = false;
            lblTelefonoEmpresa.Visible = false;
            txtNombreEmpresa.Visible = false;
            txtRUT.Visible = false;
            txtDireccionEmpresa.Visible = false;
            txtTelefonoEmpresa.Visible = false;
        }

        private void MostrarCamposUsuarioSistema()
        {
            lblNombreUsuario.Visible = true;
            lblContraseña.Visible = true;
            lblCorreoElectronico.Visible = true;
            txtNombreUsuario.Visible = true;
            txtContraseña.Visible = true;
            txtCorreoElectronico.Visible = true;
        }


    }
}





