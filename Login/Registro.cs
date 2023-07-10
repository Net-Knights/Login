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
using RegistroUsuarios.Entities;



namespace Login
{
    public partial class Registro : Form
    {

        private readonly RegistroBLL registroBLL;
        public Registro()
        {
            InitializeComponent();
            registroBLL = new RegistroBLL();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Show(this);
            Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
