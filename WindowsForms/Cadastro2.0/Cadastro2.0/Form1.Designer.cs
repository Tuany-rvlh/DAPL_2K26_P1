namespace Cadastro2._0
{
    partial class HomeForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbConfirmar = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkSenha = new System.Windows.Forms.CheckBox();
            this.chkConfirmar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro do usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(59, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(59, 107);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(23, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "Cpf";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(60, 150);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(59, 188);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(37, 241);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(69, 26);
            this.lblConfirmar.TabIndex = 5;
            this.lblConfirmar.Text = "Confirmação \r\nde senha";
            this.lblConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(112, 67);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(131, 20);
            this.txbNome.TabIndex = 6;
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(112, 104);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(131, 20);
            this.txbCpf.TabIndex = 7;
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(112, 147);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(131, 20);
            this.txbIdade.TabIndex = 8;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(112, 185);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(131, 20);
            this.txbSenha.TabIndex = 9;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // txbConfirmar
            // 
            this.txbConfirmar.Location = new System.Drawing.Point(112, 241);
            this.txbConfirmar.Name = "txbConfirmar";
            this.txbConfirmar.Size = new System.Drawing.Size(131, 20);
            this.txbConfirmar.TabIndex = 10;
            this.txbConfirmar.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(60, 314);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 11;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(168, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkSenha
            // 
            this.chkSenha.AutoSize = true;
            this.chkSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSenha.Location = new System.Drawing.Point(121, 211);
            this.chkSenha.Name = "chkSenha";
            this.chkSenha.Size = new System.Drawing.Size(93, 17);
            this.chkSenha.TabIndex = 13;
            this.chkSenha.Text = "Mostrar senha";
            this.chkSenha.UseVisualStyleBackColor = true;
            this.chkSenha.CheckedChanged += new System.EventHandler(this.chkSenha_CheckedChanged);
            // 
            // chkConfirmar
            // 
            this.chkConfirmar.AutoSize = true;
            this.chkConfirmar.Location = new System.Drawing.Point(121, 267);
            this.chkConfirmar.Name = "chkConfirmar";
            this.chkConfirmar.Size = new System.Drawing.Size(122, 17);
            this.chkConfirmar.TabIndex = 14;
            this.chkConfirmar.Text = "Mostrar confirmação";
            this.chkConfirmar.UseVisualStyleBackColor = true;
            this.chkConfirmar.CheckedChanged += new System.EventHandler(this.chkConfirmar_CheckedChanged);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(307, 378);
            this.Controls.Add(this.chkConfirmar);
            this.Controls.Add(this.chkSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txbConfirmar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "HomeForm";
            this.Text = "Cadastro de pessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbConfirmar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkSenha;
        private System.Windows.Forms.CheckBox chkConfirmar;
    }
}

