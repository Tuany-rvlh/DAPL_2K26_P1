using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro2._0
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            string cpf = txbCpf.Text;
            string idade_texto = txbIdade.Text;
            string senha = txbSenha.Text;
            string senha_confirmada = txbConfirmar.Text;
            cpf = cpf.Replace(".", "").Replace("-", "");

            bool nome_valido, cpf_valido, idade_valida, senha_iguais;

            int idade;

            if (!int.TryParse(idade_texto, out idade))
            {
                lblIdade.ForeColor = Color.Red;
                MessageBox.Show("Digite apenas números!");
                idade_valida = false;
            }
            else if (idade < 0 || idade > 115)
            {
                lblIdade.ForeColor = Color.Red;
                MessageBox.Show("Idade digitada inválida!");
                idade_valida = false;
            }
            else
                idade_valida = true;

            if (nome.Length < 2 || nome.Length > 20)
            {
                lblNome.ForeColor = Color.Red;
                MessageBox.Show("Nome digitado inválido!");
                nome_valido = false;
            }
            else
                nome_valido = true;

            if (cpf.Length != 11)
            {
                lblCpf.ForeColor = Color.Red;
                MessageBox.Show("Cpf digitado inválido!");
                cpf_valido = false;
            }
            else
                cpf_valido = true;

            if (senha != senha_confirmada || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(senha_confirmada))
            {
                lblSenha.ForeColor = Color.Red;
                lblConfirmar.ForeColor = Color.Red;
                MessageBox.Show("As senhas não coincidem!");
                senha_iguais = false;
            }
            else
                senha_iguais = true;

            if (nome_valido && cpf_valido && idade_valida && senha_iguais)
            {
                lblIdade.ForeColor = Color.Black;
                lblCpf.ForeColor = Color.Black;
                lblNome.ForeColor = Color.Black;
                lblSenha.ForeColor = Color.Black;
                lblConfirmar.ForeColor = Color.Black;

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
                MessageBox.Show("Cadastro não foi realizado com sucesso!");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblIdade.ForeColor = Color.Black;
            lblCpf.ForeColor = Color.Black;
            lblNome.ForeColor = Color.Black;
            lblSenha.ForeColor = Color.Black;
            lblConfirmar.ForeColor = Color.Black;

            txbNome.Text = "";
            txbCpf.Text = "";
            txbIdade.Text = "";
            txbSenha.Text = "";
            txbConfirmar.Text = "";
        }

        private void chkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSenha.Checked)
            {
                txbSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txbSenha.UseSystemPasswordChar = true;
            }

        }

        private void chkConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfirmar.Checked)
            {
                txbConfirmar.UseSystemPasswordChar = false;
            }
            else
            {
                txbConfirmar.UseSystemPasswordChar = true;
            }

        }
    }
}
