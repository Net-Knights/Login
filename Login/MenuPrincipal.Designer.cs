namespace Login
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            BarraTitulo = new Panel();
            BtnRestaurar = new PictureBox();
            BtnMin = new PictureBox();
            BtnMax = new PictureBox();
            BtnClose = new PictureBox();
            MenuVertical = new Panel();
            panel7 = new Panel();
            button7 = new Button();
            panel6 = new Panel();
            button6 = new Button();
            panel5 = new Panel();
            button5 = new Button();
            panel4 = new Panel();
            button4 = new Button();
            panel3 = new Panel();
            button3 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = SystemColors.MenuHighlight;
            BarraTitulo.Controls.Add(BtnRestaurar);
            BarraTitulo.Controls.Add(BtnMin);
            BarraTitulo.Controls.Add(BtnMax);
            BarraTitulo.Controls.Add(BtnClose);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(815, 33);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.Image = Properties.Resources.window_restore_icon_144027;
            BtnRestaurar.Location = new Point(730, -1);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(44, 33);
            BtnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnRestaurar.TabIndex = 3;
            BtnRestaurar.TabStop = false;
            BtnRestaurar.Visible = false;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // BtnMin
            // 
            BtnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMin.Image = Properties.Resources._1904666_calculate_close_delete_hide_minimize_minus_remove_122516;
            BtnMin.Location = new Point(689, 0);
            BtnMin.Name = "BtnMin";
            BtnMin.Size = new Size(44, 32);
            BtnMin.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMin.TabIndex = 2;
            BtnMin.TabStop = false;
            BtnMin.Click += BtnMin_Click;
            // 
            // BtnMax
            // 
            BtnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMax.Image = Properties.Resources.window_maximize_icon_1812281;
            BtnMax.Location = new Point(730, 0);
            BtnMax.Name = "BtnMax";
            BtnMax.Size = new Size(44, 33);
            BtnMax.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMax.TabIndex = 1;
            BtnMax.TabStop = false;
            BtnMax.Click += BtnMax_Click;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources._1492790846_9cancel_84247;
            BtnClose.InitialImage = (Image)resources.GetObject("BtnClose.InitialImage");
            BtnClose.Location = new Point(771, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(41, 33);
            BtnClose.SizeMode = PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 0;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(41, 128, 185);
            MenuVertical.Controls.Add(panel7);
            MenuVertical.Controls.Add(button7);
            MenuVertical.Controls.Add(panel6);
            MenuVertical.Controls.Add(button6);
            MenuVertical.Controls.Add(panel5);
            MenuVertical.Controls.Add(button5);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(button4);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(button3);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(button2);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(button1);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 33);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(169, 458);
            MenuVertical.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(49, 66, 82);
            panel7.Location = new Point(0, 410);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 34);
            panel7.TabIndex = 14;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.log_out_icon_icons_com_50106;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(6, 412);
            button7.Name = "button7";
            button7.Size = new Size(157, 34);
            button7.TabIndex = 13;
            button7.Text = "LogOut";
            button7.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(49, 66, 82);
            panel6.Location = new Point(-3, 326);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 23);
            panel6.TabIndex = 12;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.Why_Us_80_icon_icons_com_57240;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 326);
            button6.Name = "button6";
            button6.Size = new Size(157, 23);
            button6.TabIndex = 11;
            button6.Text = "Cliente";
            button6.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(49, 66, 82);
            panel5.Location = new Point(0, 281);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 23);
            panel5.TabIndex = 10;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.checkbox_103909;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 281);
            button5.Name = "button5";
            button5.Size = new Size(157, 23);
            button5.TabIndex = 9;
            button5.Text = "Estados";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(49, 66, 82);
            panel4.Location = new Point(0, 227);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 23);
            panel4.TabIndex = 8;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.store_icon_icons_com_54371;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(6, 227);
            button4.Name = "button4";
            button4.Size = new Size(157, 23);
            button4.TabIndex = 7;
            button4.Text = "Sucursales";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(49, 66, 82);
            panel3.Location = new Point(3, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 42);
            panel3.TabIndex = 6;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.Truck_Yellow_icon_icons_com_54884;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(9, 159);
            button3.Name = "button3";
            button3.Size = new Size(157, 42);
            button3.TabIndex = 5;
            button3.Text = "Transporte";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 66, 82);
            panel2.Location = new Point(3, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 23);
            panel2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources._1496676725_rounded_high_ultra_colour02_maps_84627;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 120);
            button2.Name = "button2";
            button2.Size = new Size(157, 23);
            button2.TabIndex = 3;
            button2.Text = "Zonas";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 66, 82);
            panel1.Location = new Point(3, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 23);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources._meal_89750;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 81);
            button1.Name = "button1";
            button1.Size = new Size(157, 23);
            button1.TabIndex = 1;
            button1.Text = "Menus";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_1;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(169, 33);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(646, 458);
            panelContenedor.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 491);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuVertical;
        private Panel panelContenedor;
        private PictureBox BtnMin;
        private PictureBox BtnMax;
        private PictureBox BtnClose;
        private PictureBox BtnRestaurar;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel1;
        private Panel panel7;
        private Button button7;
        private Panel panel6;
        private Button button6;
        private Panel panel5;
        private Button button5;
        private Panel panel4;
        private Button button4;
        private Panel panel3;
        private Button button3;
        private Panel panel2;
        private Button button2;
    }
}