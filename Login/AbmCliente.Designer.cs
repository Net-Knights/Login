﻿namespace Login
{
    partial class AbmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            btnModificar = new Button();
            lblTelefono = new Label();
            lblCi = new Label();
            lblDireccionEmpresa = new Label();
            txtDireccionEmpresa = new TextBox();
            txtCI = new TextBox();
            lblNombreEmpresa = new Label();
            txtTelefono = new TextBox();
            txtNombreEmpresa = new TextBox();
            lblRUT = new Label();
            txtRUT = new TextBox();
            lblNombre = new Label();
            cbTipoCliente = new ComboBox();
            label2 = new Label();
            lblApellido = new Label();
            BtnEliminar = new Button();
            BtnGuardar = new Button();
            lblCorreoElectronico = new Label();
            txtNombre = new TextBox();
            txtCorreoElectronico = new TextBox();
            txtApellido = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            dvgEmpresa = new DataGridView();
            dgvClientes = new DataGridView();
            pbBuscar = new PictureBox();
            txtNroCliente = new TextBox();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgEmpresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblDireccion);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(lblCi);
            panel1.Controls.Add(lblDireccionEmpresa);
            panel1.Controls.Add(txtDireccionEmpresa);
            panel1.Controls.Add(txtCI);
            panel1.Controls.Add(lblNombreEmpresa);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtNombreEmpresa);
            panel1.Controls.Add(lblRUT);
            panel1.Controls.Add(txtRUT);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(cbTipoCliente);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(BtnGuardar);
            panel1.Controls.Add(lblCorreoElectronico);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtCorreoElectronico);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 500);
            panel1.TabIndex = 0;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(4, 297);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 35;
            lblDireccion.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(4, 317);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(193, 23);
            txtDireccion.TabIndex = 34;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Cyan;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Image = Properties.Resources.savetheapplication_guardar_2958;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(12, 409);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(149, 29);
            btnModificar.TabIndex = 33;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(3, 209);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 28;
            lblTelefono.Text = "Telefono:";
            // 
            // lblCi
            // 
            lblCi.AutoSize = true;
            lblCi.Location = new Point(4, 253);
            lblCi.Name = "lblCi";
            lblCi.Size = new Size(21, 15);
            lblCi.TabIndex = 32;
            lblCi.Text = "CI:";
            // 
            // lblDireccionEmpresa
            // 
            lblDireccionEmpresa.AutoSize = true;
            lblDireccionEmpresa.Location = new Point(4, 121);
            lblDireccionEmpresa.Name = "lblDireccionEmpresa";
            lblDireccionEmpresa.Size = new Size(136, 15);
            lblDireccionEmpresa.TabIndex = 30;
            lblDireccionEmpresa.Text = "Direccion de la empresa:";
            // 
            // txtDireccionEmpresa
            // 
            txtDireccionEmpresa.Location = new Point(4, 139);
            txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            txtDireccionEmpresa.Size = new Size(193, 23);
            txtDireccionEmpresa.TabIndex = 29;
            // 
            // txtCI
            // 
            txtCI.Location = new Point(3, 271);
            txtCI.Name = "txtCI";
            txtCI.Size = new Size(193, 23);
            txtCI.TabIndex = 31;
            // 
            // lblNombreEmpresa
            // 
            lblNombreEmpresa.AutoSize = true;
            lblNombreEmpresa.Location = new Point(4, 77);
            lblNombreEmpresa.Name = "lblNombreEmpresa";
            lblNombreEmpresa.Size = new Size(130, 15);
            lblNombreEmpresa.TabIndex = 28;
            lblNombreEmpresa.Text = "Nombre de la Empresa:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(3, 227);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(193, 23);
            txtTelefono.TabIndex = 27;
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Location = new Point(4, 95);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(193, 23);
            txtNombreEmpresa.TabIndex = 27;
            // 
            // lblRUT
            // 
            lblRUT.AutoSize = true;
            lblRUT.Location = new Point(4, 165);
            lblRUT.Name = "lblRUT";
            lblRUT.Size = new Size(31, 15);
            lblRUT.TabIndex = 26;
            lblRUT.Text = "RUT:";
            // 
            // txtRUT
            // 
            txtRUT.Location = new Point(3, 183);
            txtRUT.Name = "txtRUT";
            txtRUT.Size = new Size(193, 23);
            txtRUT.TabIndex = 25;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(4, 77);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre:";
            // 
            // cbTipoCliente
            // 
            cbTipoCliente.FormattingEnabled = true;
            cbTipoCliente.Location = new Point(3, 51);
            cbTipoCliente.Name = "cbTipoCliente";
            cbTipoCliente.Size = new Size(190, 23);
            cbTipoCliente.TabIndex = 23;
            cbTipoCliente.SelectedIndexChanged += cbTipoCliente_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 30);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 9;
            label2.Text = "Tipo";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(4, 121);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 21;
            lblApellido.Text = "Apellido:";
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Red;
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Image = Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(12, 451);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(149, 25);
            BtnEliminar.TabIndex = 19;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Green;
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Image = Properties.Resources.savetheapplication_guardar_2958;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(12, 365);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(149, 26);
            BtnGuardar.TabIndex = 18;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Location = new Point(4, 165);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(36, 15);
            lblCorreoElectronico.TabIndex = 17;
            lblCorreoElectronico.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(3, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 23);
            txtNombre.TabIndex = 15;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(3, 183);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(193, 23);
            txtCorreoElectronico.TabIndex = 14;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(4, 139);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(193, 23);
            txtApellido.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 12;
            label1.Text = "Detalle del Usuario";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dvgEmpresa);
            panel2.Controls.Add(dgvClientes);
            panel2.Controls.Add(pbBuscar);
            panel2.Controls.Add(txtNroCliente);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 500);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 59);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 14;
            label4.Text = "Cliente empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 59);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 13;
            label3.Text = "Cliente comun";
            // 
            // dvgEmpresa
            // 
            dvgEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgEmpresa.Location = new Point(423, 95);
            dvgEmpresa.Name = "dvgEmpresa";
            dvgEmpresa.RowTemplate.Height = 25;
            dvgEmpresa.Size = new Size(339, 343);
            dvgEmpresa.TabIndex = 12;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 95);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(411, 343);
            dgvClientes.TabIndex = 11;
            // 
            // pbBuscar
            // 
            pbBuscar.Image = Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            pbBuscar.Location = new Point(443, 6);
            pbBuscar.Name = "pbBuscar";
            pbBuscar.Size = new Size(32, 25);
            pbBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            pbBuscar.TabIndex = 10;
            pbBuscar.TabStop = false;
            pbBuscar.Click += pbBuscar_Click;
            // 
            // txtNroCliente
            // 
            txtNroCliente.Location = new Point(309, 6);
            txtNroCliente.Name = "txtNroCliente";
            txtNroCliente.Size = new Size(128, 23);
            txtNroCliente.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(258, 9);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 8;
            label7.Text = "Buscar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 9);
            label6.Name = "label6";
            label6.Size = new Size(155, 28);
            label6.TabIndex = 7;
            label6.Text = "Lista de Clientes:";
            // 
            // AbmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 500);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AbmCliente";
            Text = "AbmCliente";
            Load += AbmCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgEmpresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtNroCliente;
        private Label label7;
        private Label label6;
        private Button BtnEliminar;
        private Button BtnGuardar;
        private Label lblCorreoElectronico;
        private TextBox txtNombre;
        private TextBox txtCorreoElectronico;
        private TextBox txtApellido;
        private Label label1;
        private Label lblApellido;
        private ComboBox cbTipoCliente;
        private Label label2;
        private Label lblNombre;
        private Label lblRUT;
        private TextBox txtRUT;
        private PictureBox pbBuscar;
        private Label lblNombreEmpresa;
        private TextBox txtNombreEmpresa;
        private DataGridView dgvClientes;
        private Label lblDireccionEmpresa;
        private TextBox txtDireccionEmpresa;
        private Label lblCi;
        private TextBox txtCI;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Button btnModificar;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label label4;
        private Label label3;
        private DataGridView dvgEmpresa;
    }
}