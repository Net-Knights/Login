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
    public partial class AbmCliente : Form
    {
        private UserModel userModel;
        public AbmCliente()
        {
            InitializeComponent();
            userModel = new UserModel();
        }

        private void AbmCliente_Load(object sender, EventArgs e)
        {
            // Cargar todos los datos de las tablas Cliente, Comun, Empresa y login en el DataGridView
            DataTable datosClientesComunesEmpresas = userModel.ObtenerDatosClientesComunesEmpresas();
            dgvClientes.DataSource = datosClientesComunesEmpresas;

            // Ajustar el diseño del DataGridView, si es necesario
            // Ejemplo:
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNroCliente.Text, out int nroCliente))
            {
                // Buscar cliente por NroCliente y mostrar resultados en el DataGridView
                DataTable clienteEncontrado = userModel.BuscarClientePorNroCliente(nroCliente);
                dgvClientes.DataSource = clienteEncontrado;
            }
            else
            {
                MessageBox.Show("Ingrese un NroCliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

