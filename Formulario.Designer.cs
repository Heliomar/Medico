namespace medicalOline1
{
    partial class Formulario
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
            this.gBrequisicaoPessoal = new System.Windows.Forms.GroupBox();
            this.textendereco = new System.Windows.Forms.TextBox();
            this.textnomecompleto = new System.Windows.Forms.TextBox();
            this.maskcpf = new System.Windows.Forms.MaskedTextBox();
            this.masktelefone = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maskcartao_sus = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LimpaPesqui = new System.Windows.Forms.Button();
            this.butsavar = new System.Windows.Forms.Button();
            this.butaltera = new System.Windows.Forms.Button();
            this.butlimpa = new System.Windows.Forms.Button();
            this.butexcluir = new System.Windows.Forms.Button();
            this.lstcliente1 = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Endereco1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumeroSus1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cpf1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btFazPesquisa = new System.Windows.Forms.Button();
            this.butvoltar_Form = new System.Windows.Forms.Button();
            this.gBrequisicaoPessoal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBrequisicaoPessoal
            // 
            this.gBrequisicaoPessoal.Controls.Add(this.textendereco);
            this.gBrequisicaoPessoal.Controls.Add(this.textnomecompleto);
            this.gBrequisicaoPessoal.Controls.Add(this.maskcpf);
            this.gBrequisicaoPessoal.Controls.Add(this.masktelefone);
            this.gBrequisicaoPessoal.Controls.Add(this.label12);
            this.gBrequisicaoPessoal.Controls.Add(this.label11);
            this.gBrequisicaoPessoal.Controls.Add(this.label10);
            this.gBrequisicaoPessoal.Controls.Add(this.maskcartao_sus);
            this.gBrequisicaoPessoal.Controls.Add(this.label9);
            this.gBrequisicaoPessoal.Controls.Add(this.label8);
            this.gBrequisicaoPessoal.Location = new System.Drawing.Point(3, 28);
            this.gBrequisicaoPessoal.Name = "gBrequisicaoPessoal";
            this.gBrequisicaoPessoal.Size = new System.Drawing.Size(317, 193);
            this.gBrequisicaoPessoal.TabIndex = 0;
            this.gBrequisicaoPessoal.TabStop = false;
            this.gBrequisicaoPessoal.Text = "Inscrição Pessoal";
            this.gBrequisicaoPessoal.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textendereco
            // 
            this.textendereco.Location = new System.Drawing.Point(108, 79);
            this.textendereco.Name = "textendereco";
            this.textendereco.Size = new System.Drawing.Size(140, 20);
            this.textendereco.TabIndex = 12;
            this.textendereco.TextChanged += new System.EventHandler(this.textendereco_TextChanged_1);
            // 
            // textnomecompleto
            // 
            this.textnomecompleto.Location = new System.Drawing.Point(107, 20);
            this.textnomecompleto.Name = "textnomecompleto";
            this.textnomecompleto.Size = new System.Drawing.Size(140, 20);
            this.textnomecompleto.TabIndex = 11;
            this.textnomecompleto.TextChanged += new System.EventHandler(this.textnomecompleto_TextChanged_1);
            // 
            // maskcpf
            // 
            this.maskcpf.Location = new System.Drawing.Point(107, 140);
            this.maskcpf.Margin = new System.Windows.Forms.Padding(5);
            this.maskcpf.Mask = "000-000-000-00";
            this.maskcpf.Name = "maskcpf";
            this.maskcpf.Size = new System.Drawing.Size(100, 20);
            this.maskcpf.TabIndex = 10;
            this.maskcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskcpf_MaskInputRejected);
            // 
            // masktelefone
            // 
            this.masktelefone.Location = new System.Drawing.Point(108, 115);
            this.masktelefone.Margin = new System.Windows.Forms.Padding(5);
            this.masktelefone.Mask = "(###)####-####";
            this.masktelefone.Name = "masktelefone";
            this.masktelefone.Size = new System.Drawing.Size(123, 20);
            this.masktelefone.TabIndex = 9;
            this.masktelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.masktelefone_MaskInputRejected);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cpf";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Telefone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Endereço";
            // 
            // maskcartao_sus
            // 
            this.maskcartao_sus.Location = new System.Drawing.Point(108, 50);
            this.maskcartao_sus.Margin = new System.Windows.Forms.Padding(5);
            this.maskcartao_sus.Mask = "000 000 000 00";
            this.maskcartao_sus.Name = "maskcartao_sus";
            this.maskcartao_sus.Size = new System.Drawing.Size(99, 20);
            this.maskcartao_sus.TabIndex = 3;
            this.maskcartao_sus.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskcartao_sus_MaskInputRejected);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cartão SUS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nome Completo";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // LimpaPesqui
            // 
            this.LimpaPesqui.Location = new System.Drawing.Point(425, 251);
            this.LimpaPesqui.Name = "LimpaPesqui";
            this.LimpaPesqui.Size = new System.Drawing.Size(94, 23);
            this.LimpaPesqui.TabIndex = 2;
            this.LimpaPesqui.Text = "Limpar Pesquisa";
            this.LimpaPesqui.UseVisualStyleBackColor = true;
            this.LimpaPesqui.Click += new System.EventHandler(this.butpesquisar_Click);
            // 
            // butsavar
            // 
            this.butsavar.Location = new System.Drawing.Point(12, 251);
            this.butsavar.Name = "butsavar";
            this.butsavar.Size = new System.Drawing.Size(75, 23);
            this.butsavar.TabIndex = 8;
            this.butsavar.Text = "Salvar";
            this.butsavar.UseVisualStyleBackColor = true;
            this.butsavar.Click += new System.EventHandler(this.butsavar_Click);
            // 
            // butaltera
            // 
            this.butaltera.Location = new System.Drawing.Point(93, 251);
            this.butaltera.Name = "butaltera";
            this.butaltera.Size = new System.Drawing.Size(75, 23);
            this.butaltera.TabIndex = 9;
            this.butaltera.Text = "Alterar";
            this.butaltera.UseVisualStyleBackColor = true;
            this.butaltera.Click += new System.EventHandler(this.butaltera_Click);
            // 
            // butlimpa
            // 
            this.butlimpa.Location = new System.Drawing.Point(176, 251);
            this.butlimpa.Name = "butlimpa";
            this.butlimpa.Size = new System.Drawing.Size(75, 23);
            this.butlimpa.TabIndex = 10;
            this.butlimpa.Text = "Limpar";
            this.butlimpa.UseVisualStyleBackColor = true;
            this.butlimpa.Click += new System.EventHandler(this.butlimpa_Click);
            // 
            // butexcluir
            // 
            this.butexcluir.Location = new System.Drawing.Point(257, 251);
            this.butexcluir.Name = "butexcluir";
            this.butexcluir.Size = new System.Drawing.Size(75, 23);
            this.butexcluir.TabIndex = 11;
            this.butexcluir.Text = "Excluir";
            this.butexcluir.UseVisualStyleBackColor = true;
            this.butexcluir.Click += new System.EventHandler(this.butexcluir_Click);
            // 
            // lstcliente1
            // 
            this.lstcliente1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Telefone1,
            this.Endereco1,
            this.NumeroSus1,
            this.Cpf1});
            this.lstcliente1.FullRowSelect = true;
            this.lstcliente1.GridLines = true;
            this.lstcliente1.Location = new System.Drawing.Point(326, 28);
            this.lstcliente1.MultiSelect = false;
            this.lstcliente1.Name = "lstcliente1";
            this.lstcliente1.Size = new System.Drawing.Size(593, 199);
            this.lstcliente1.TabIndex = 14;
            this.lstcliente1.UseCompatibleStateImageBehavior = false;
            this.lstcliente1.View = System.Windows.Forms.View.Details;
            this.lstcliente1.SelectedIndexChanged += new System.EventHandler(this.lstcliente_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 113;
            // 
            // Telefone1
            // 
            this.Telefone1.Text = "Telefone";
            this.Telefone1.Width = 103;
            // 
            // Endereco1
            // 
            this.Endereco1.Text = "Endereco";
            this.Endereco1.Width = 109;
            // 
            // NumeroSus1
            // 
            this.NumeroSus1.Text = "NumeroSus";
            this.NumeroSus1.Width = 132;
            // 
            // Cpf1
            // 
            this.Cpf1.Text = "Cpf";
            this.Cpf1.Width = 133;
            // 
            // btFazPesquisa
            // 
            this.btFazPesquisa.Location = new System.Drawing.Point(558, 251);
            this.btFazPesquisa.Name = "btFazPesquisa";
            this.btFazPesquisa.Size = new System.Drawing.Size(101, 23);
            this.btFazPesquisa.TabIndex = 15;
            this.btFazPesquisa.Text = "Fazer Pesquisa";
            this.btFazPesquisa.UseVisualStyleBackColor = true;
            this.btFazPesquisa.Click += new System.EventHandler(this.btFazPesquisa_Click);
            // 
            // butvoltar_Form
            // 
            this.butvoltar_Form.Location = new System.Drawing.Point(701, 251);
            this.butvoltar_Form.Name = "butvoltar_Form";
            this.butvoltar_Form.Size = new System.Drawing.Size(64, 23);
            this.butvoltar_Form.TabIndex = 16;
            this.butvoltar_Form.Text = "Voltar";
            this.butvoltar_Form.UseVisualStyleBackColor = true;
            this.butvoltar_Form.Click += new System.EventHandler(this.butPedidConsul_Click);
            // 
            // Formulario
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::medicalOline1.Properties.Resources._4942_128x128;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 326);
            this.Controls.Add(this.butvoltar_Form);
            this.Controls.Add(this.btFazPesquisa);
            this.Controls.Add(this.lstcliente1);
            this.Controls.Add(this.butexcluir);
            this.Controls.Add(this.butlimpa);
            this.Controls.Add(this.butaltera);
            this.Controls.Add(this.butsavar);
            this.Controls.Add(this.LimpaPesqui);
            this.Controls.Add(this.gBrequisicaoPessoal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Formulario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.gBrequisicaoPessoal.ResumeLayout(false);
            this.gBrequisicaoPessoal.PerformLayout();
            this.ResumeLayout(false);

        }

        private void texnomecompleto_TextChanged(object sender, System.EventArgs e)
        {
            

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTregistrogeral;
        private System.Windows.Forms.MaskedTextBox maskedTdata;
        private System.Windows.Forms.MaskedTextBox maskedTcartaosus;
        private System.Windows.Forms.TextBox textBendereco;
        private System.Windows.Forms.TextBox textBexameespecial;
        private System.Windows.Forms.TextBox textBmotivosolicitacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butlimpar;
        private System.Windows.Forms.Button butsalvar;
        private System.Windows.Forms.Button butalterar;
        private System.Windows.Forms.Button butexculir;
        private System.Windows.Forms.GroupBox gBrequisicaoPessoal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskcartao_sus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button LimpaPesqui;
        private System.Windows.Forms.MaskedTextBox maskcpf;
        private System.Windows.Forms.MaskedTextBox masktelefone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textendereco;
        private System.Windows.Forms.TextBox textnomecompleto;
        private System.Windows.Forms.Button butsavar;
        private System.Windows.Forms.Button butaltera;
        private System.Windows.Forms.Button butlimpa;
        private System.Windows.Forms.Button butexcluir;
        private System.Windows.Forms.ListView lstcliente1;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Telefone1;
        private System.Windows.Forms.ColumnHeader Endereco1;
        private System.Windows.Forms.ColumnHeader NumeroSus1;
        private System.Windows.Forms.ColumnHeader Cpf1;
        private System.Windows.Forms.Button btFazPesquisa;
        private System.Windows.Forms.Button butvoltar_Form;
    }
}