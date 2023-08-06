using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Login
{
    public partial class AbmCliente : Form
    {
        private UserModel userModel;
        private DataTable dataTableClientes;

        public AbmCliente()
        {
            InitializeComponent();
            userModel = new UserModel();
            dataTableClientes = new DataTable();

            // Configuración inicial del ComboBox y DataGridView
            cbTipoCliente.Items.AddRange(new string[] { "Comun", "Empresa" });
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OcultarCampos();

            CargarDatosClientesComunes();
            CargarDatosClientesEmpresa();
        }
        private void OcultarCampos()
        {
            // Ocultar campos correspondientes a cliente común
            lblNombre.Visible = false;
            lblApellido.Visible = false;
            lblCorreoElectronico.Visible = false;
            lblTelefono.Visible = false;
            lblCi.Visible = false;
            lblDireccion.Visible = false;

            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtCorreoElectronico.Visible = false;
            txtTelefono.Visible = false;
            txtCI.Visible = false;
            txtDireccion.Visible = false;

            // Ocultar campos correspondientes a cliente empresa
            lblRUT.Visible = false;
            lblNombreEmpresa.Visible = false;
            lblDireccionEmpresa.Visible = false;

            txtRUT.Visible = false;
            txtNombreEmpresa.Visible = false;
            txtDireccionEmpresa.Visible = false;
        }

        private void MostrarCampos(string tipoCliente)
        {
            OcultarCampos();

            if (tipoCliente == "Comun")
            {
                lblNombre.Visible = true;
                lblApellido.Visible = true;
                lblCorreoElectronico.Visible = true;
                lblTelefono.Visible = true;
                lblCi.Visible = true;
                lblDireccion.Visible = true;

                txtNombre.Visible = true;
                txtApellido.Visible = true;
                txtCorreoElectronico.Visible = true;
                txtTelefono.Visible = true;
                txtCI.Visible = true;
                txtDireccion.Visible = true;
            }
            else if (tipoCliente == "Empresa")
            {
                lblRUT.Visible = true;
                lblNombreEmpresa.Visible = true;
                lblDireccionEmpresa.Visible = true;

                txtRUT.Visible = true;
                txtNombreEmpresa.Visible = true;
                txtDireccionEmpresa.Visible = true;
            }
        }
        private void CargarDatosClientesComunes()
        {
            DataTable clientesComunes = userModel.ObtenerDatosClientesComunes();
            dgvClientes.DataSource = clientesComunes;
        }

        // Método para cargar los datos de clientes empresa en dgvEmpresa
        private void CargarDatosClientesEmpresa()
        {
            DataTable clientesEmpresa = userModel.ObtenerDatosClientesEmpresa();
            dvgEmpresa.DataSource = clientesEmpresa;
        }


        private void AbmCliente_Load(object sender, EventArgs e)
        {
            // Cargar todos los datos de las tablas Cliente, Comun, Empresa y login en el DataGridView
            CargarDatosClientesComunes();
            CargarDatosClientesEmpresa();
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

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoCliente = cbTipoCliente.SelectedItem.ToString();
            MostrarCampos(tipoCliente);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (cbTipoCliente.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de cliente.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tipoCliente = cbTipoCliente.SelectedItem.ToString();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correoElectronico = txtCorreoElectronico.Text;
            string telefono = txtTelefono.Text;
            string ci = txtCI.Text;
            string direccion = txtDireccion.Text;
            string rut = txtRUT.Text;
            string nombreEmpresa = txtNombreEmpresa.Text;
            string direccionEmpresa = txtDireccionEmpresa.Text;



            userModel.GuardarCliente(tipoCliente, nombre, apellido, correoElectronico, telefono, ci, direccion, rut, nombreEmpresa, direccionEmpresa);

            MessageBox.Show("Registro exitoso.");
            CargarDatosClientesComunes();
            CargarDatosClientesEmpresa();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int nroCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["NroCliente"].Value);
                if (MessageBox.Show("¿Está seguro de que desea eliminar el cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userModel.EliminarCliente(nroCliente);
                    MessageBox.Show("Cliente eliminado correctamente.");
                    CargarDatosClientesComunes();
                }
            }
            else if (dvgEmpresa.SelectedRows.Count > 0)
            {
                int nroClienteEmpresa = Convert.ToInt32(dvgEmpresa.SelectedRows[0].Cells["NroClienteEmpresa"].Value);
                if (MessageBox.Show("¿Está seguro de que desea eliminar el cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userModel.EliminarCliente(nroClienteEmpresa);
                    MessageBox.Show("Cliente eliminado correctamente.");
                    CargarDatosClientesEmpresa();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0 || dvgEmpresa.SelectedRows.Count > 0)
            {
                int nroCliente;
                DataGridView selectedDgv;

                if (dgvClientes.SelectedRows.Count > 0)
                {
                    selectedDgv = dgvClientes;
                }
                else
                {
                    selectedDgv = dvgEmpresa;
                }

                nroCliente = Convert.ToInt32(selectedDgv.SelectedRows[0].Cells["NroCliente"].Value);
                string tipoCliente = selectedDgv.SelectedRows[0].Cells["TipoCliente"].Value.ToString();

                if (tipoCliente == "Común")
                {
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string correoElectronico = txtCorreoElectronico.Text;
                    string telefono = txtTelefono.Text;
                    string ci = txtCI.Text;
                    string direccion = txtDireccion.Text;

                    userModel.ModificarClienteComun(nroCliente, nombre, apellido, correoElectronico, telefono, ci, direccion);
                }
                else if (tipoCliente == "Empresa")
                {
                    string rut = txtRUT.Text;
                    string nombreEmpresa = txtNombreEmpresa.Text;
                    string correoElectronico = txtCorreoElectronico.Text;
                    string telefono = txtTelefono.Text;
                    string ci = txtCI.Text;
                    string direccionEmpresa = txtDireccionEmpresa.Text;

                    userModel.ModificarClienteEmpresa(nroCliente, rut, nombreEmpresa, correoElectronico, telefono, ci, direccionEmpresa);
                }

                MessageBox.Show("Cliente modificado correctamente.");
                CargarDatosClientesComunes();
                CargarDatosClientesEmpresa();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para modificar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}



