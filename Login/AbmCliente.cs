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
            OcultarCampos();

            CargarDatosClientes();
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
        private void CargarDatosClientes()
        {
            dataTableClientes = userModel.ObtenerDatosClientesComunesEmpresas();
            dgvClientes.DataSource = dataTableClientes;
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

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoCliente = cbTipoCliente.SelectedItem.ToString();
            MostrarCampos(tipoCliente);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
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
            CargarDatosClientes();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Obtener los datos del cliente seleccionado
                int nroCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["NroCliente"].Value);
                string tipoCliente = dgvClientes.SelectedRows[0].Cells["TipoCliente"].Value.ToString();

                // Mostrar los campos correspondientes al tipo de cliente seleccionado
                cbTipoCliente.SelectedItem = tipoCliente;
                MostrarCampos(tipoCliente);

                // Asignar los valores del cliente seleccionado a los campos correspondientes
                if (tipoCliente == "Común")
                {
                    txtNombre.Text = dgvClientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dgvClientes.SelectedRows[0].Cells["Apellido"].Value.ToString();
                    txtCorreoElectronico.Text = dgvClientes.SelectedRows[0].Cells["CorreoElectronico"].Value.ToString();
                    txtTelefono.Text = dgvClientes.SelectedRows[0].Cells["Telefono"].Value.ToString();
                    txtCI.Text = dgvClientes.SelectedRows[0].Cells["CI"].Value.ToString();
                    txtDireccion.Text = dgvClientes.SelectedRows[0].Cells["Direccion"].Value.ToString();
                }
                else if (tipoCliente == "Empresa")
                {
                    txtNombreEmpresa.Text = dgvClientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    txtCorreoElectronico.Text = dgvClientes.SelectedRows[0].Cells["CorreoElectronico"].Value.ToString();
                    txtTelefono.Text = dgvClientes.SelectedRows[0].Cells["Telefono"].Value.ToString();
                    txtCI.Text = dgvClientes.SelectedRows[0].Cells["CI"].Value.ToString();
                    txtDireccionEmpresa.Text = dgvClientes.SelectedRows[0].Cells["Direccion"].Value.ToString();
                    txtRUT.Text = dgvClientes.SelectedRows[0].Cells["RUT"].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para modificar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    int nroCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["NroCliente"].Value);
                    string tipoCliente = dgvClientes.SelectedRows[0].Cells["TipoCliente"].Value.ToString();
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string correoElectronico = txtCorreoElectronico.Text;
                    string telefono = txtTelefono.Text;
                    string ci = txtCI.Text;
                    string direccion = txtDireccion.Text;
                    string rut = txtRUT.Text;
                    string nombreEmpresa = txtNombreEmpresa.Text;
                    string direccionEmpresa = txtDireccionEmpresa.Text;

                    userModel.ModificarCliente(nroCliente, tipoCliente, nombre, apellido, correoElectronico, telefono, ci, direccion, rut, nombreEmpresa, direccionEmpresa);

                    // Actualizar los datos en el DataGridView
                    dgvClientes.SelectedRows[0].Cells["CorreoElectronico"].Value = correoElectronico;
                    // ... Actualizar otros campos según el tipo de cliente ...

                    MessageBox.Show("Cliente modificado correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente para modificar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message);
            }
        }
    }
    }



