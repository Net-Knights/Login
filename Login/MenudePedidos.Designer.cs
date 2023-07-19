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
            dataGridView1 = new DataGridView();
            TipoAlimento = new DataGridViewTextBoxColumn();
            Cocina = new DataGridViewTextBoxColumn();
            NrCliente = new DataGridViewTextBoxColumn();
            label2 = new Label();
            BtnBuscar = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(BtnBuscar);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 491);
            panel1.TabIndex = 24;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TipoAlimento, Cocina, NrCliente });
            dataGridView1.Location = new Point(39, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(344, 205);
            dataGridView1.TabIndex = 25;
            // 
            // TipoAlimento
            // 
            TipoAlimento.HeaderText = "Tipo alimento";
            TipoAlimento.Name = "TipoAlimento";
            // 
            // Cocina
            // 
            Cocina.HeaderText = "NroCocina";
            Cocina.Name = "Cocina";
            // 
            // NrCliente
            // 
            NrCliente.HeaderText = "NroCliente";
            NrCliente.Name = "NrCliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(190, 20);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 24;
            label2.Text = "Pedidos Activos";
            // 
            // BtnBuscar
            // 
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Image = Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            BtnBuscar.Location = new Point(253, 70);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(35, 38);
            BtnBuscar.TabIndex = 28;
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(108, 79);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(128, 23);
            textBox5.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 82);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 26;
            label7.Text = "Buscar:";
            // 
            // MenudePedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 491);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenudePedidos";
            Text = "MenudePedidos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TipoAlimento;
        private DataGridViewTextBoxColumn Cocina;
        private DataGridViewTextBoxColumn NrCliente;
        private Label label2;
        private Button BtnBuscar;
        private TextBox textBox5;
        private Label label7;
    }
}