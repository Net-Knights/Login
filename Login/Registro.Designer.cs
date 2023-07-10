namespace Login
{
    partial class Registro
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
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtContraseña = new TextBox();
            txtCorreoElectronico = new TextBox();
            txtCI = new TextBox();
            txtNombreUsuario = new TextBox();
            label1 = new Label();
            label7 = new Label();
            cmbTipoUsuario = new ComboBox();
            Closebtn = new Button();
            btnRegistrar = new Button();
            label9 = new Label();
            txtTelefono = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtDireccion = new TextBox();
            txtNombreEmpresa = new TextBox();
            txtRUT = new TextBox();
            txtDireccionEmpresa = new TextBox();
            txtTelefonoEmpresa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_1;
            pictureBox2.Location = new Point(174, 518);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 96);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(88, 588);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 9;
            label5.Text = "Net Knights";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 593);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 8;
            label4.Text = "Developed By:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_icon_1769051;
            pictureBox1.Location = new Point(76, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 617);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTelefonoEmpresa);
            panel2.Controls.Add(txtDireccionEmpresa);
            panel2.Controls.Add(txtRUT);
            panel2.Controls.Add(txtNombreEmpresa);
            panel2.Controls.Add(txtDireccion);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnRegistrar);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtContraseña);
            panel2.Controls.Add(txtCorreoElectronico);
            panel2.Controls.Add(txtCI);
            panel2.Controls.Add(txtNombreUsuario);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cmbTipoUsuario);
            panel2.Controls.Add(Closebtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(256, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 617);
            panel2.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(41, 128, 185);
            label8.Location = new Point(3, 259);
            label8.Name = "label8";
            label8.Size = new Size(207, 24);
            label8.TabIndex = 18;
            label8.Text = "Correo Electronico:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(41, 128, 185);
            label6.Location = new Point(6, 225);
            label6.Name = "label6";
            label6.Size = new Size(37, 24);
            label6.TabIndex = 17;
            label6.Text = "CI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(41, 128, 185);
            label3.Location = new Point(6, 187);
            label3.Name = "label3";
            label3.Size = new Size(135, 24);
            label3.TabIndex = 16;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(6, 154);
            label2.Name = "label2";
            label2.Size = new Size(177, 24);
            label2.TabIndex = 15;
            label2.Text = "Nombre Usuario:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(214, 192);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 14;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(214, 264);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(100, 23);
            txtCorreoElectronico.TabIndex = 13;
            // 
            // txtCI
            // 
            txtCI.Location = new Point(214, 225);
            txtCI.Name = "txtCI";
            txtCI.Size = new Size(100, 23);
            txtCI.TabIndex = 12;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(214, 155);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(70, 99);
            label1.Name = "label1";
            label1.Size = new Size(182, 24);
            label1.TabIndex = 10;
            label1.Text = "Ingrese sus datos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(41, 128, 185);
            label7.Location = new Point(6, 27);
            label7.Name = "label7";
            label7.Size = new Size(280, 24);
            label7.TabIndex = 9;
            label7.Text = "Seleccione tipo de usuario";
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Items.AddRange(new object[] { "Cliente Comun\t", "Cliente Empresa", "Usuario del sistema" });
            cmbTipoUsuario.Location = new Point(6, 54);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(293, 23);
            cmbTipoUsuario.TabIndex = 7;
            // 
            // Closebtn
            // 
            Closebtn.FlatAppearance.BorderSize = 0;
            Closebtn.FlatStyle = FlatStyle.Flat;
            Closebtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Closebtn.ForeColor = Color.FromArgb(41, 128, 185);
            Closebtn.Location = new Point(432, 0);
            Closebtn.Name = "Closebtn";
            Closebtn.Size = new Size(40, 40);
            Closebtn.TabIndex = 6;
            Closebtn.Text = "X";
            Closebtn.UseVisualStyleBackColor = true;
            Closebtn.Click += Closebtn_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(346, 568);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(114, 37);
            btnRegistrar.TabIndex = 19;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(41, 128, 185);
            label9.Location = new Point(6, 336);
            label9.Name = "label9";
            label9.Size = new Size(112, 24);
            label9.TabIndex = 20;
            label9.Text = "Direccion:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(214, 299);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(41, 128, 185);
            label10.Location = new Point(6, 379);
            label10.Name = "label10";
            label10.Size = new Size(194, 24);
            label10.TabIndex = 22;
            label10.Text = "Nombre Empresa:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(41, 128, 185);
            label11.Location = new Point(6, 417);
            label11.Name = "label11";
            label11.Size = new Size(49, 24);
            label11.TabIndex = 23;
            label11.Text = "RUT:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(41, 128, 185);
            label12.Location = new Point(6, 451);
            label12.Name = "label12";
            label12.Size = new Size(206, 24);
            label12.TabIndex = 24;
            label12.Text = "Direccion Empresa:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(41, 128, 185);
            label13.Location = new Point(6, 496);
            label13.Name = "label13";
            label13.Size = new Size(198, 24);
            label13.TabIndex = 25;
            label13.Text = "Telefono Empresa:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(41, 128, 185);
            label14.Location = new Point(6, 294);
            label14.Name = "label14";
            label14.Size = new Size(104, 24);
            label14.TabIndex = 26;
            label14.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(214, 337);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 27;
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Location = new Point(214, 384);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(100, 23);
            txtNombreEmpresa.TabIndex = 28;
            // 
            // txtRUT
            // 
            txtRUT.Location = new Point(214, 418);
            txtRUT.Name = "txtRUT";
            txtRUT.Size = new Size(100, 23);
            txtRUT.TabIndex = 29;
            // 
            // txtDireccionEmpresa
            // 
            txtDireccionEmpresa.Location = new Point(214, 452);
            txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            txtDireccionEmpresa.Size = new Size(100, 23);
            txtDireccionEmpresa.TabIndex = 30;
            // 
            // txtTelefonoEmpresa
            // 
            txtTelefonoEmpresa.Location = new Point(214, 496);
            txtTelefonoEmpresa.Name = "txtTelefonoEmpresa";
            txtTelefonoEmpresa.Size = new Size(100, 23);
            txtTelefonoEmpresa.TabIndex = 31;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 617);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Button Closebtn;
        private ComboBox cmbTipoUsuario;
        private TextBox txtContraseña;
        private TextBox txtCorreoElectronico;
        private TextBox txtCI;
        private TextBox txtNombreUsuario;
        private Label label1;
        private Label label7;
        private Label label2;
        private Label label8;
        private Label label6;
        private Label label3;
        private Button btnRegistrar;
        private Label label9;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtTelefono;
        private TextBox txtTelefonoEmpresa;
        private TextBox txtDireccionEmpresa;
        private TextBox txtRUT;
        private TextBox txtNombreEmpresa;
        private TextBox txtDireccion;
    }
}