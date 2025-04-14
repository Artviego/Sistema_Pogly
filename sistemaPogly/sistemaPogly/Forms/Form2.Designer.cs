namespace sistemaPogly
{
    partial class Form2
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
            txtNome = new TextBox();
            lbl_Nome = new Label();
            lbl_Categoria = new Label();
            lbl_Preco = new Label();
            txtCategoria = new TextBox();
            txtPreco = new TextBox();
            dataGridView1 = new DataGridView();
            btn_Cadastro = new Button();
            label1 = new Label();
            lblQuantidade = new Label();
            txtQuantidade = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(303, 97);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(124, 23);
            txtNome.TabIndex = 1;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.ForeColor = Color.Gainsboro;
            lbl_Nome.Location = new Point(303, 79);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(40, 15);
            lbl_Nome.TabIndex = 2;
            lbl_Nome.Text = "Nome";
            lbl_Nome.Click += label1_Click;
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.ForeColor = Color.Gainsboro;
            lbl_Categoria.Location = new Point(303, 145);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(58, 15);
            lbl_Categoria.TabIndex = 3;
            lbl_Categoria.Text = "Categoria";
            // 
            // lbl_Preco
            // 
            lbl_Preco.AutoSize = true;
            lbl_Preco.ForeColor = Color.Gainsboro;
            lbl_Preco.Location = new Point(303, 206);
            lbl_Preco.Name = "lbl_Preco";
            lbl_Preco.Size = new Size(37, 15);
            lbl_Preco.TabIndex = 4;
            lbl_Preco.Text = "Preço";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(303, 163);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(124, 23);
            txtCategoria.TabIndex = 5;
            txtCategoria.TextChanged += textBox1_TextChanged;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(303, 224);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(77, 23);
            txtPreco.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(492, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(496, 222);
            dataGridView1.TabIndex = 7;
            // 
            // btn_Cadastro
            // 
            btn_Cadastro.BackColor = Color.Gainsboro;
            btn_Cadastro.Location = new Point(352, 296);
            btn_Cadastro.Name = "btn_Cadastro";
            btn_Cadastro.Size = new Size(75, 23);
            btn_Cadastro.TabIndex = 0;
            btn_Cadastro.Text = "Salvar";
            btn_Cadastro.UseVisualStyleBackColor = false;
            btn_Cadastro.Click += btn_Cadastro_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.ForeColor = Color.Gainsboro;
            lblQuantidade.Location = new Point(404, 206);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 9;
            lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(404, 224);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(69, 23);
            txtQuantidade.TabIndex = 10;            
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1011, 419);
            Controls.Add(txtQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(label1);
            Controls.Add(btn_Cadastro);
            Controls.Add(dataGridView1);
            Controls.Add(txtPreco);
            Controls.Add(txtCategoria);
            Controls.Add(lbl_Preco);
            Controls.Add(lbl_Categoria);
            Controls.Add(lbl_Nome);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private Label lbl_Nome;
        private Label lbl_Categoria;
        private Label lbl_Preco;
        private TextBox txtCategoria;
        private TextBox txtPreco;
        private DataGridView dataGridView1;
        private Button btn_Cadastro;
        private Label label1;
        private Label lblQuantidade;
        private TextBox txtQuantidade;
    }
}