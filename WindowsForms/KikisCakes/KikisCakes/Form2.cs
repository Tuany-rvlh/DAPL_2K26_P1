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
    public partial class login: Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senha = txbSenha.Text;
            string confirma = txbConfirmar.Text;

            if (senha == confirma)
            {
                HomeForm login = new HomeForm();
                login.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Confirmação de senha incorreta. Tente novamente!");
            }
        }

        private void chkVisuSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVisuSenha.Checked)
            {
                txbSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txbSenha.UseSystemPasswordChar = true;
            }
        }

        private void chkVisuConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVisuConfirmar.Checked)
            {
                txbConfirmar.UseSystemPasswordChar = false;
            }
            else
            {
                txbConfirmar.UseSystemPasswordChar = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txbUsuario.Text = " ";
            txbSenha.Text = " ";
            txbConfirmar.Text = " ";
        }
    }
}
