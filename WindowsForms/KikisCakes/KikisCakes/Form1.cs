using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KikisCakes
{
    public partial class HomeForm: Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVisuItens_Click(object sender, EventArgs e)
        {

        }

        private void nudOreo_ValueChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }
  

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido(s) adicionado(s) com sucesso!");
        }

        private void cmbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            string entrega = cmbEntrega.SelectedItem.ToString();

            if (entrega == "Retirada")
            {
                txbEndereco.ReadOnly = true;
                txbEndereco.Text = "";
            }
            else
                txbEndereco.ReadOnly = false;
                

        }

        private void btnVisu_Click(object sender, EventArgs e)
        {
            if (cmbEntrega.SelectedItem == null || cmbPagamento.SelectedItem == null)
            {
                MessageBox.Show("Selecione a forma de entrega e pagamento!");
                return;
            }

            string entrega = cmbEntrega.SelectedItem.ToString();
            string endereco = txbEndereco.Text;

            if (entrega == "Delivery" && string.IsNullOrWhiteSpace(endereco))
            {
                MessageBox.Show("Esqueceu o endereço!");
                return;
            }

            decimal quantOreo = nudOreo.Value;
            decimal quantCenoura = nudCenoura.Value;
            decimal quantBrigadeiro = nudBrigadeiro.Value;
            decimal preco = (quantOreo * 8) + (quantBrigadeiro * 7) + (quantCenoura * 6);
            string pagamento = cmbPagamento.SelectedItem.ToString();

            MessageBox.Show($"Valor total: R${preco}\nTipo de entrega: {entrega}\nTipo de pagamento: {pagamento}\nEndereço: {endereco}\nFrete: Grátis");
        }

        private void nudBrigadeiro_ValueChanged(object sender, EventArgs e)
        {
            AtualizarLista();

        }

        private void nudCenoura_ValueChanged(object sender, EventArgs e)
        {
            AtualizarLista();


        }

        private void lstItens_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void AtualizarLista()
        {
            lstItens.Items.Clear();

            int quantidade1 = (int)nudOreo.Value;
            if (quantidade1 > 0)
            {
                lstItens.Items.Add($"{quantidade1} {(quantidade1 == 1 ? "Bolo" : "Bolos")} de Oreo");
            }

            int quantidade2 = (int)nudBrigadeiro.Value;
            if (quantidade2 > 0)
            {
                lstItens.Items.Add($"{quantidade2} {(quantidade2 == 1 ? "Bolo" : "Bolos")} de Brigadeiro");
            }

            int quantidade3 = (int)nudCenoura.Value;
            if (quantidade3 > 0)
            {
                lstItens.Items.Add($"{quantidade3} {(quantidade3 == 1 ? "Bolo" : "Bolos")} de Cenoura");
            }
        }

    }
}
