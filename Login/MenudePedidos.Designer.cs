namespace Login
{
    partial class MenudePedidos
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
            button1 = new Button();
            panel1 = new Panel();
            label13 = new Label();
            button4 = new Button();
            groupBox3 = new GroupBox();
            label11 = new Label();
            textBox10 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            groupBox2 = new GroupBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            BtnBuscar = new Button();
            label4 = new Label();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            textBox11 = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(712, 445);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Stock";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 510);
            panel1.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(3, 105);
            label13.Name = "label13";
            label13.Size = new Size(177, 19);
            label13.TabIndex = 38;
            label13.Text = "Agregar un pedido a la lista";
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.shopping_cart_add_button_icon_icons_com_56132;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(660, 135);
            button4.Name = "button4";
            button4.Size = new Size(115, 63);
            button4.TabIndex = 37;
            button4.Text = "       Agregar";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox11);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Location = new Point(3, 127);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(639, 71);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            groupBox3.Text = "Agregar un nuevo pedido";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(366, 19);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 44;
            label11.Text = "Stock:";
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.Gray;
            textBox10.Location = new Point(368, 41);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 19);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 40;
            label9.Text = "Tipo de menu:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(9, 37);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 39;
            textBox8.KeyPress += textBox8_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(BtnBuscar);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Location = new Point(427, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 75);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion del cliente";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(187, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 19);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 29;
            label5.Text = "Estado";
            // 
            // BtnBuscar
            // 
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Image = Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            BtnBuscar.Location = new Point(140, 36);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(35, 23);
            BtnBuscar.TabIndex = 28;
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 28;
            label4.Text = "Nro Cliente:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 37);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(128, 23);
            textBox5.TabIndex = 27;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 75);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion del pedido";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 19);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 4;
            label6.Text = "Nro Cocina:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 24;
            label2.Text = "Consultar pedidos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(664, 282);
            dataGridView1.TabIndex = 39;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(485, 42);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 45;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            button2.Location = new Point(336, 39);
            button2.Name = "button2";
            button2.Size = new Size(35, 23);
            button2.TabIndex = 31;
            button2.UseVisualStyleBackColor = true;
            // 
            // MenudePedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 510);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenudePedidos";
            Text = "MenudePedidos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private Label label2;
        private Button BtnBuscar;
        private TextBox textBox5;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private Label label6;
        private GroupBox groupBox3;
        private Label label9;
        private TextBox textBox8;
        private Button button4;
        private Label label11;
        private TextBox textBox10;
        private Label label13;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private TextBox textBox11;
        private Button button2;
    }
}