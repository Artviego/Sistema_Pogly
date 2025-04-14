using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaPogly
{
    public partial class Form2 : Form
    {
        List<Produto> produtos = new List<Produto>();
        int proximoId = 1;

        public record Produto(string Nome, string Categoria, decimal Preco, int Quantidade);
        public Form2()
        {
            InitializeComponent();

            // Definir as colunas do DataGridView
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Name = "Nome";
            dataGridView1.Columns[1].Name = "Categoria";
            dataGridView1.Columns[2].Name = "Preço";
            dataGridView1.Columns[3].Name = "Quantidade";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cadastro_Click_2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
               string.IsNullOrWhiteSpace(txtPreco.Text) ||
               string.IsNullOrWhiteSpace(txtQuantidade.Text) ||
               string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            // Validação do preço
            if (!decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            // Validação da quantidade
            if (!int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }

            // Cria o novo produto com os dados fornecidos
            Produto novoProduto = new Produto(txtNome.Text, txtCategoria.Text, preco, quantidade);

            // Adiciona o produto à lista
            produtos.Add(novoProduto);

            // Atualiza o DataGridView
            AtualizarDataGridView();

            // Limpa os campos após o cadastro
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtCategoria.Clear();

            MessageBox.Show("Produto cadastrado com sucesso.");
        }

        private void AtualizarDataGridView()
        {
            // Limpa o DTG
            dataGridView1.Rows.Clear();

            // Adiciona os produtos à grid
            foreach (var produto in produtos)
            {
                dataGridView1.Rows.Add(produto.Nome, produto.Categoria, produto.Preco, produto.Quantidade);
            }
        }
    }
}
