using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cadastro_forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senha = txbSenha.Text;
            string login = txbLogin.Text;

            if (login != "admin" && senha != "ds@etefmc")
            {
                lblLogin.ForeColor = Color.Red;
                lblSenha.ForeColor = Color.Red;
                MessageBox.Show("Seu login e senha estão INCORRETOS!");
                return;
            }
            else if (login != "admin")
            {
                lblLogin.ForeColor = Color.Red;
                lblSenha.ForeColor = Color.Black;
                MessageBox.Show("Seu login está INCORRETO!");
                return;
            }
            else if (senha != "ds@etefmc")
            {
                lblLogin.ForeColor = Color.Black;
                lblSenha.ForeColor = Color.Red;
                MessageBox.Show("Sua senha está INCORRETA!");
                return;
            }

            lblLogin.ForeColor = Color.Black;
            lblSenha.ForeColor = Color.Black;
            MessageBox.Show("Login realizado com sucesso!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txbLogin.Text = "";
            txbSenha.Text = "";
            txbLogin.ForeColor = Color.Black;
            txbSenha.ForeColor = Color.Black;

        }

        private void chkMostrar_Senha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar_Senha.Checked)
            {
                txbSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txbSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
