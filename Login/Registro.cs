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
using MySql.Data.MySqlClient;
using Persistencia;
using RegistroUsuarios.Entities;



namespace Login
{
    public partial class Registro : Form
    {

        private UserModel userModel;

        public Registro()
        {
            InitializeComponent();
            userModel = new UserModel();
            txtContraseña.PasswordChar = '*';

        }





        private void btnRegistrar_Click_1(object sender, EventArgs e)

        {
            try
            {
                string mail = txtCorreoElectronico.Text;
                string telefono = txtTelefono.Text;
                string direccion = txtDireccion.Text;
                string ci = txtCI.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string usuario = txtNombreUsuario.Text;
                string contraseña = txtContraseña.Text;

                userModel.RegistrarCliente(mail, telefono, direccion, ci, nombre, apellido, usuario, contraseña);

                MessageBox.Show("Registro exitoso.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
                LimpiarCampos();
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
            txtApellido.Text = "";
            txtNombre.Text = "";

        }










        private void btnVolver_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Show(this);
            Hide();
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtContraseña.PasswordChar = '\0';


        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtContraseña.PasswordChar = '*';
        }
    }
}






