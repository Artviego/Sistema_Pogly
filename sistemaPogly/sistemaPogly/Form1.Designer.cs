namespace sistemaPogly
{
    partial class Tela
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            btn_Maximizar = new Button();
            btn_Fechar = new Button();
            panelChildForm = new Panel();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel_SubMenu = new Panel();
            btn_Visu = new Button();
            button3 = new Button();
            button2 = new Button();
            panelMenu = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel_SubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 21, 32);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 54);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += mouse_Down;
            panel1.MouseMove += mouse_Move;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-19, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 94);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_Maximizar);
            panel2.Controls.Add(btn_Fechar);
            panel2.Location = new Point(838, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 57);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(23, 12);
            button1.Name = "button1";
            button1.Size = new Size(39, 27);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Maximizar
            // 
            btn_Maximizar.BackColor = Color.Transparent;
            btn_Maximizar.BackgroundImage = (Image)resources.GetObject("btn_Maximizar.BackgroundImage");
            btn_Maximizar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Maximizar.FlatStyle = FlatStyle.Flat;
            btn_Maximizar.Location = new Point(82, 12);
            btn_Maximizar.Name = "btn_Maximizar";
            btn_Maximizar.Size = new Size(40, 27);
            btn_Maximizar.TabIndex = 1;
            btn_Maximizar.UseVisualStyleBackColor = false;
            btn_Maximizar.Click += btn_Maximizar_Click;
            // 
            // btn_Fechar
            // 
            btn_Fechar.BackColor = Color.Tomato;
            btn_Fechar.BackgroundImage = (Image)resources.GetObject("btn_Fechar.BackgroundImage");
            btn_Fechar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Fechar.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btn_Fechar.FlatAppearance.MouseOverBackColor = Color.Salmon;
            btn_Fechar.FlatStyle = FlatStyle.Flat;
            btn_Fechar.Location = new Point(137, 12);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new Size(40, 27);
            btn_Fechar.TabIndex = 0;
            btn_Fechar.UseVisualStyleBackColor = false;
            btn_Fechar.Click += btn_Fechar_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(32, 30, 45);
            panelChildForm.Controls.Add(pictureBox2);
            panelChildForm.Controls.Add(panel5);
            panelChildForm.Controls.Add(panel4);
            panelChildForm.Controls.Add(panel3);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(0, 54);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1027, 458);
            panelChildForm.TabIndex = 1;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(197, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(811, 432);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(21, 23, 32);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1014, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(13, 441);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(23, 21, 32);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(191, 441);
            panel4.Name = "panel4";
            panel4.Size = new Size(836, 17);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(11, 7, 17);
            panel3.Controls.Add(panel_SubMenu);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(panelMenu);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(191, 458);
            panel3.TabIndex = 0;
            // 
            // panel_SubMenu
            // 
            panel_SubMenu.BackColor = Color.FromArgb(35, 32, 39);
            panel_SubMenu.Controls.Add(btn_Visu);
            panel_SubMenu.Controls.Add(button3);
            panel_SubMenu.Dock = DockStyle.Top;
            panel_SubMenu.Location = new Point(0, 132);
            panel_SubMenu.Name = "panel_SubMenu";
            panel_SubMenu.Size = new Size(191, 61);
            panel_SubMenu.TabIndex = 1;
            // 
            // btn_Visu
            // 
            btn_Visu.Dock = DockStyle.Top;
            btn_Visu.FlatAppearance.BorderSize = 0;
            btn_Visu.FlatStyle = FlatStyle.Flat;
            btn_Visu.ForeColor = Color.Gainsboro;
            btn_Visu.Location = new Point(0, 30);
            btn_Visu.Name = "btn_Visu";
            btn_Visu.Padding = new Padding(35, 0, 0, 0);
            btn_Visu.Size = new Size(191, 23);
            btn_Visu.TabIndex = 1;
            btn_Visu.Text = "Estoque";
            btn_Visu.TextAlign = ContentAlignment.MiddleLeft;
            btn_Visu.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(191, 30);
            button3.TabIndex = 2;
            button3.Text = "Cadastro";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(0, 101);
            button2.Name = "button2";
            button2.Size = new Size(191, 31);
            button2.TabIndex = 1;
            button2.Text = "Produtos";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(191, 101);
            panelMenu.TabIndex = 1;
            // 
            // Tela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 512);
            Controls.Add(panelChildForm);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Tela_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel_SubMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_Fechar;
        private Panel panel2;
        private Button btn_Maximizar;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panelChildForm;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Panel panelMenu;
        private Panel panel_SubMenu;
        private Button btn_Visu;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox2;
    }
}
