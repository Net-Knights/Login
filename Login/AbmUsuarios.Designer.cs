namespace Login
{
    partial class AbmUsuarios
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            BtnLimpiar = new Button();
            BtnEliminar = new Button();
            BtnGuardar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            NroEmpleado = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            BtnBuscar = new Button();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BtnLimpiar);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(BtnGuardar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 491);
            panel1.TabIndex = 0;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.DarkTurquoise;
            BtnLimpiar.FlatAppearance.BorderSize = 0;
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Image = Properties.Resources._3792033_broom_halloween_magic_witch_109010;
            BtnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLimpiar.Location = new Point(25, 363);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(149, 31);
            BtnLimpiar.TabIndex = 11;
            BtnLimpiar.Text = "Modificar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Red;
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Image = Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(25, 400);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(149, 28);
            BtnEliminar.TabIndex = 10;
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
            BtnGuardar.Location = new Point(25, 330);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(149, 27);
            BtnGuardar.TabIndex = 9;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 212);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 156);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 7;
            label4.Text = "Nro de empleado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 102);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 39);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(8, 240);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 23);
            textBox4.TabIndex = 4;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(8, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(8, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 2;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Detalle del Usuario";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Correo, NroEmpleado, Cargo });
            dataGridView1.Location = new Point(229, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(465, 352);
            dataGridView1.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre empleado";
            Nombre.Name = "Nombre";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo Electronico";
            Correo.Name = "Correo";
            // 
            // NroEmpleado
            // 
            NroEmpleado.HeaderText = "Numero de empleado";
            NroEmpleado.Name = "NroEmpleado";
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 35);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 2;
            label6.Text = "Lista de Usuarios";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(476, 27);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 3;
            label7.Text = "Buscar:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(538, 24);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(128, 23);
            textBox5.TabIndex = 4;
            // 
            // BtnBuscar
            // 
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Image = Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            BtnBuscar.Location = new Point(672, 21);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(35, 29);
            BtnBuscar.TabIndex = 5;
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // AbmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 491);
            Controls.Add(BtnBuscar);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AbmUsuarios";
            Text = "AbmUsuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Button BtnLimpiar;
        private Button BtnEliminar;
        private Button BtnGuardar;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn NroEmpleado;
        private DataGridViewTextBoxColumn Cargo;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private Button BtnBuscar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}