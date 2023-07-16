namespace Login
{
    partial class FormularioClienteEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioClienteEmpresa));
            BarraTitulo = new Panel();
            label1 = new Label();
            BtnRestaurar = new PictureBox();
            BtnMin = new PictureBox();
            BtnMax = new PictureBox();
            BtnClose = new PictureBox();
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            Closebtn = new Button();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(49, 66, 82);
            BarraTitulo.Controls.Add(Closebtn);
            BarraTitulo.Controls.Add(label1);
            BarraTitulo.Controls.Add(BtnRestaurar);
            BarraTitulo.Controls.Add(BtnMin);
            BarraTitulo.Controls.Add(BtnMax);
            BarraTitulo.Controls.Add(BtnClose);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(800, 33);
            BarraTitulo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Ink Free", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(336, 7);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 4;
            label1.Text = "Menu Principal";
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.Image = Properties.Resources.window_restore_icon_144027;
            BtnRestaurar.Location = new Point(1989, -1);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(44, 33);
            BtnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnRestaurar.TabIndex = 3;
            BtnRestaurar.TabStop = false;
            BtnRestaurar.Visible = false;
            // 
            // BtnMin
            // 
            BtnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMin.Image = Properties.Resources._1904666_calculate_close_delete_hide_minimize_minus_remove_122516;
            BtnMin.Location = new Point(1948, 0);
            BtnMin.Name = "BtnMin";
            BtnMin.Size = new Size(44, 32);
            BtnMin.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMin.TabIndex = 2;
            BtnMin.TabStop = false;
            // 
            // BtnMax
            // 
            BtnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMax.Image = Properties.Resources.window_maximize_icon_1812281;
            BtnMax.Location = new Point(1989, 0);
            BtnMax.Name = "BtnMax";
            BtnMax.Size = new Size(44, 33);
            BtnMax.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMax.TabIndex = 1;
            BtnMax.TabStop = false;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources._1492790846_9cancel_84247;
            BtnClose.InitialImage = (Image)resources.GetObject("BtnClose.InitialImage");
            BtnClose.Location = new Point(2030, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(41, 33);
            BtnClose.SizeMode = PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 0;
            BtnClose.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 417);
            panel1.TabIndex = 3;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Image = Properties.Resources.log_out_icon_icons_com_50106;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(12, 380);
            button7.Name = "button7";
            button7.Size = new Size(157, 34);
            button7.TabIndex = 22;
            button7.Text = "Cerrar Sesion";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.Why_Us_80_icon_icons_com_57240;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(12, 68);
            button6.Name = "button6";
            button6.Size = new Size(157, 23);
            button6.TabIndex = 21;
            button6.Text = "Cliente";
            button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources._1496676725_rounded_high_ultra_colour02_maps_84627;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(18, 150);
            button2.Name = "button2";
            button2.Size = new Size(157, 23);
            button2.TabIndex = 20;
            button2.Text = "Zonas";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources._meal_89750;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(18, 109);
            button1.Name = "button1";
            button1.Size = new Size(157, 23);
            button1.TabIndex = 19;
            button1.Text = "Menus";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_1;
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Closebtn
            // 
            Closebtn.Cursor = Cursors.Hand;
            Closebtn.FlatAppearance.BorderSize = 0;
            Closebtn.FlatStyle = FlatStyle.Flat;
            Closebtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Closebtn.ForeColor = Color.FromArgb(41, 128, 185);
            Closebtn.Location = new Point(760, 0);
            Closebtn.Name = "Closebtn";
            Closebtn.Size = new Size(40, 36);
            Closebtn.TabIndex = 6;
            Closebtn.Text = "X";
            Closebtn.UseVisualStyleBackColor = true;
            Closebtn.Click += Closebtn_Click;
            // 
            // FormularioClienteEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioClienteEmpresa";
            Text = "FormularioClienteEmpresa";
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Label label1;
        private PictureBox BtnRestaurar;
        private PictureBox BtnMin;
        private PictureBox BtnMax;
        private PictureBox BtnClose;
        private Panel panel1;
        private Button button6;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button7;
        private Button Closebtn;
    }
}