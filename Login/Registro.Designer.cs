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
            Closebtn = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_1;
            pictureBox2.Location = new Point(171, 416);
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
            label5.Location = new Point(88, 471);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 9;
            label5.Text = "Net Knights";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 476);
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
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(Closebtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(256, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 617);
            panel2.TabIndex = 13;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cliente Comun\t", "Cliente Empresa", "Usuario del sistema(Trabajador de la empresa)" });
            comboBox1.Location = new Point(6, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(293, 23);
            comboBox1.TabIndex = 7;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(117, 99);
            label1.Name = "label1";
            label1.Size = new Size(182, 24);
            label1.TabIndex = 10;
            label1.Text = "Ingrese sus datos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(117, 192);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(6, 154);
            label2.Name = "label2";
            label2.Size = new Size(95, 24);
            label2.TabIndex = 15;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(41, 128, 185);
            label3.Location = new Point(6, 187);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 16;
            label3.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(41, 128, 185);
            label6.Location = new Point(6, 225);
            label6.Name = "label6";
            label6.Size = new Size(95, 24);
            label6.TabIndex = 17;
            label6.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(41, 128, 185);
            label8.Location = new Point(6, 259);
            label8.Name = "label8";
            label8.Size = new Size(95, 24);
            label8.TabIndex = 18;
            label8.Text = "Nombre";
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
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label7;
        private Label label2;
        private Label label8;
        private Label label6;
        private Label label3;
    }
}