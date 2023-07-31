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
        private DataAccessLayer dataAccessLayer;
        private NegocioCliente negocioCliente;

        public Registro()
        {
            InitializeComponent();
            dataAccessLayer = new DataAccessLayer();
            negocioCliente = new NegocioCliente();


        }





        private void btnRegistrar_Click_1(object sender, EventArgs e)

        {

            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;
            string ci = txtCI.Text;
            string direccion = txtDireccion.Text;
            string email = txtCorreoElectronico.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            bool resultado = negocioCliente.RegistrarCliente(nombreUsuario, contraseña, ci, direccion, email, nombre, apellido);

            if (resultado)
            {
                MessageBox.Show("Cliente registrado correctamente.");
                LimpiarCampos();
                // Puedes agregar aquí más acciones después de guardar, si es necesario.
            }
            else
            {
                MessageBox.Show("Error al registrar el cliente.");
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

       

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Show(this);
            Hide();
        }
    }
}






