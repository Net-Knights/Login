namespace Login
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
            label9 = new Label();
            txtNombreEmpresa = new TextBox();
            label8 = new Label();
            txtRUT = new TextBox();
            label3 = new Label();
            cbTipoCliente = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            BtnEliminar = new Button();
            BtnGuardar = new Button();
            label4 = new Label();
            txtNombre = new TextBox();
            txtCorreoElectronico = new TextBox();
            txtApellido = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvClientes = new DataGridView();
            pbBuscar = new PictureBox();
            txtNroCliente = new TextBox();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtNombreEmpresa);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtRUT);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbTipoCliente);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(BtnGuardar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtCorreoElectronico);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 258);
            label9.Name = "label9";
            label9.Size = new Size(127, 15);
            label9.TabIndex = 28;
            label9.Text = "Nombrede la Empresa:";
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Location = new Point(3, 276);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(193, 23);
            txtNombreEmpresa.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 215);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 26;
            label8.Text = "RUT:";
            // 
            // txtRUT
            // 
            txtRUT.Location = new Point(3, 233);
            txtRUT.Name = "txtRUT";
            txtRUT.Size = new Size(193, 23);
            txtRUT.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 77);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 24;
            label3.Text = "Nombre:";
            // 
            // cbTipoCliente
            // 
            cbTipoCliente.FormattingEnabled = true;
            cbTipoCliente.Items.AddRange(new object[] { "Comun", "Empresa" });
            cbTipoCliente.Location = new Point(3, 51);
            cbTipoCliente.Name = "cbTipoCliente";
            cbTipoCliente.Size = new Size(190, 23);
            cbTipoCliente.TabIndex = 23;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 121);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 21;
            label5.Text = "Apellido:";
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Red;
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Image = Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(12, 413);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(149, 25);
            BtnEliminar.TabIndex = 19;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Green;
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Image = Properties.Resources.savetheapplication_guardar_2958;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(12, 381);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(149, 26);
            BtnGuardar.TabIndex = 18;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 165);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 17;
            label4.Text = "Email";
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
            panel2.Controls.Add(dgvClientes);
            panel2.Controls.Add(pbBuscar);
            panel2.Controls.Add(txtNroCliente);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 450);
            panel2.TabIndex = 1;
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
            dgvClientes.Size = new Size(555, 343);
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
            ClientSize = new Size(800, 450);
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
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtCorreoElectronico;
        private TextBox txtApellido;
        private Label label1;
        private Label label5;
        private ComboBox cbTipoCliente;
        private Label label2;
        private Label label3;
        private Label label8;
        private TextBox txtRUT;
        private PictureBox pbBuscar;
        private Label label9;
        private TextBox txtNombreEmpresa;
        private DataGridView dgvClientes;
    }
}