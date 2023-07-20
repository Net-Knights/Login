using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Logica;
//using Persistencia;
using RegistroUsuarios.Entities;



namespace Login
{
    public partial class Registro : Form
    {
        //private DataAccessLayer dataAccessLayer;
        //private Validaciondedatos validaciondedatos = new Validaciondedatos();

        public Registro()
        {
            InitializeComponent();
            //dataAccessLayer = new DataAccessLayer();
            OcultarCampos();

        }



        private void cmbTipoCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MostrarCampos();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (cmbTipoCliente.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tipo de cliente.");
                return;
            }

            var tipoCliente = cmbTipoCliente.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text)
                || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (!ValidarCorreoElectronico(txtCorreoElectronico.Text))
            {
                MessageBox.Show("El correo electrónico no es válido.");
                return;
            }

            try
            {
                if (tipoCliente == "Cliente Comun")
                {
                    var clienteComun = new ClienteComun
                    {
                        NombreUsuario = txtNombreUsuario.Text,
                        Contraseña = txtContraseña.Text,
                        CorreoElectronico = txtCorreoElectronico.Text,
                        CI = txtCI.Text,
                        Telefono = txtTelefono.Text,
                        Direccion = txtDireccion.Text
                    };

                    //dataAccessLayer.InsertarClienteComun(clienteComun);
                }
                else if (tipoCliente == "Cliente Empresa")
                {
                    if (string.IsNullOrWhiteSpace(txtRUT.Text) || string.IsNullOrWhiteSpace(txtNombreEmpresa.Text)
                        || string.IsNullOrWhiteSpace(txtTelefonoEmpresa.Text) || string.IsNullOrWhiteSpace(txtDireccionEmpresa.Text))
                    {
                        MessageBox.Show("Todos los campos son obligatorios para el cliente empresa.");
                        return;
                    }

                    var clienteEmpresa = new ClienteEmpresa
                    {
                        NombreUsuario = txtNombreUsuario.Text,
                        Contraseña = txtContraseña.Text,
                        RUT = txtRUT.Text,
                        NombreEmpresa = txtNombreEmpresa.Text,
                        TelefonoEmpresa = txtTelefonoEmpresa.Text,
                        CorreoElectronico = txtCorreoElectronico.Text,
                        DireccionEmpresa = txtDireccionEmpresa.Text
                    };

                    //dataAccessLayer.InsertarClienteEmpresa(clienteEmpresa);
                }
                else if (tipoCliente == "Usuario Sistema")
                {
                    var usuarioSistema = new UsuarioSistema
                    {
                        NombreUsuario = txtNombreUsuario.Text,
                        Contraseña = txtContraseña.Text,
                        CorreoElectronico = txtCorreoElectronico.Text
                    };

                    //dataAccessLayer.InsertarUsuarioSistema(usuarioSistema);
                }

                MessageBox.Show("Registro exitoso");
                LimpiarCampos();
                OcultarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtCorreoElectronico.Text = "";
            txtCI.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtRUT.Text = "";
            txtNombreEmpresa.Text = "";
            txtTelefonoEmpresa.Text = "";
            txtDireccionEmpresa.Text = "";
        }

        private void OcultarCampos()
        {
            lblNombreUsuario.Visible = false;
            lblContraseña.Visible = false;
            lblCorreoElectronico.Visible = false;
            lblCI.Visible = false;
            lblTelefono.Visible = false;
            lblDireccion.Visible = false;
            lblRUT.Visible = false;
            lblNombreEmpresa.Visible = false;
            lblTelefonoEmpresa.Visible = false;
            lblDireccionEmpresa.Visible = false;

            txtNombreUsuario.Visible = false;
            txtContraseña.Visible = false;
            txtCorreoElectronico.Visible = false;
            txtCI.Visible = false;
            txtTelefono.Visible = false;
            txtDireccion.Visible = false;
            txtRUT.Visible = false;
            txtNombreEmpresa.Visible = false;
            txtTelefonoEmpresa.Visible = false;
            txtDireccionEmpresa.Visible = false;
        }

        private void MostrarCampos()
        {
            OcultarCampos();

            var tipoCliente = cmbTipoCliente.SelectedItem.ToString();

            if (tipoCliente == "Cliente Comun")
            {
                lblNombreUsuario.Visible = true;
                lblContraseña.Visible = true;
                lblCorreoElectronico.Visible = true;
                lblCI.Visible = true;
                lblTelefono.Visible = true;
                lblDireccion.Visible = true;

                txtNombreUsuario.Visible = true;
                txtContraseña.Visible = true;
                txtCorreoElectronico.Visible = true;
                txtCI.Visible = true;
                txtTelefono.Visible = true;
                txtDireccion.Visible = true;
            }
            else if (tipoCliente == "Cliente Empresa")
            {
                lblNombreUsuario.Visible = true;
                lblContraseña.Visible = true;
                lblCorreoElectronico.Visible = true;
                lblRUT.Visible = true;
                lblNombreEmpresa.Visible = true;
                lblTelefonoEmpresa.Visible = true;
                lblDireccionEmpresa.Visible = true;

                txtNombreUsuario.Visible = true;
                txtContraseña.Visible = true;
                txtCorreoElectronico.Visible = true;
                txtRUT.Visible = true;
                txtNombreEmpresa.Visible = true;
                txtTelefonoEmpresa.Visible = true;
                txtDireccionEmpresa.Visible = true;
            }
            else if (tipoCliente == "Usuario Sistema")
            {
                lblNombreUsuario.Visible = true;
                lblContraseña.Visible = true;
                lblCorreoElectronico.Visible = true;

                txtNombreUsuario.Visible = true;
                txtContraseña.Visible = true;
                txtCorreoElectronico.Visible = true;
            }
        }
        private bool ValidarCorreoElectronico(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Show(this);
            Hide();
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}






