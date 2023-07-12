using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Persistencia;


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
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btn_Login_Click(object sender, EventArgs e)
        {
            var nombreUsuario = txtUsername.Text;
            var contraseña = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Ingresa el nombre de usuario y la contraseña.");
                return;
            }

            try
            {
                var dataAccessLayer = new DataAccessLayer();
                var tipoUsuario = dataAccessLayer.VerificarCredenciales(nombreUsuario, contraseña);

                if (!string.IsNullOrEmpty(tipoUsuario))
                {
                    MessageBox.Show("Inicio de sesión exitoso como " + tipoUsuario);
                    this.Hide();

                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show(this);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);

            }





        }



        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Registrarse_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show(this);
            Hide();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

