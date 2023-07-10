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


namespace Login
{
    public partial class VentanaPrincipal : Form
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            Application.Run(ventanaPrincipal);
        }


        public VentanaPrincipal()
        {
            InitializeComponent();
        }



        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                msgError("Ingrese su nombre de usuario y contraseña");
            }
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                msgError("Ingrese su nombre de usuario");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                msgError("Ingrese su contraseña");
            }
            else
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show(this);
                Hide();

            }

        }



        private void msgError(string msg)
        {
            lblErrorMesagge.Text = "     " + msg;
            lblErrorMesagge.Visible = true;

        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Registrarse_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show(this);
            Hide();
        }
    }
}
