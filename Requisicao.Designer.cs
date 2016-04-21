namespace medicalOline1
{
    partial class Requisicao
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNomeSolic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butComfirmSolici = new System.Windows.Forms.Button();
            this.butcancelaSolic = new System.Windows.Forms.Button();
            this.butretorna = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mask_Idsol = new System.Windows.Forms.MaskedTextBox();
            this.listRequisicao = new System.Windows.Forms.ListView();
            this.Nome_completo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Motivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CRM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butrelatorio = new System.Windows.Forms.Button();
            this.butSair = new System.Windows.Forms.Button();
            this.btlimpaSoli = new System.Windows.Forms.Button();
            this.butexcluirSolic = new System.Windows.Forms.Button();
            this.coBselecaoItem = new System.Windows.Forms.ComboBox();
            this.combCrMedic = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // textNomeSolic
            // 
            this.textNomeSolic.Location = new System.Drawing.Point(157, 28);
            this.textNomeSolic.Name = "textNomeSolic";
            this.textNomeSolic.Size = new System.Drawing.Size(215, 20);
            this.textNomeSolic.TabIndex = 1;
            this.textNomeSolic.TextChanged += new System.EventHandler(this.textNomeSolic_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motivo da Solicitaçâo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medico CRM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // butComfirmSolici
            // 
            this.butComfirmSolici.Location = new System.Drawing.Point(12, 247);
            this.butComfirmSolici.Name = "butComfirmSolici";
            this.butComfirmSolici.Size = new System.Drawing.Size(119, 23);
            this.butComfirmSolici.TabIndex = 6;
            this.butComfirmSolici.Text = "Comfirmar Solicitção";
            this.butComfirmSolici.UseVisualStyleBackColor = true;
            this.butComfirmSolici.Click += new System.EventHandler(this.butComfirmSolici_Click);
            // 
            // butcancelaSolic
            // 
            this.butcancelaSolic.Location = new System.Drawing.Point(147, 247);
            this.butcancelaSolic.Name = "butcancelaSolic";
            this.butcancelaSolic.Size = new System.Drawing.Size(114, 23);
            this.butcancelaSolic.TabIndex = 7;
            this.butcancelaSolic.Text = "Cancelar Solicitação";
            this.butcancelaSolic.UseVisualStyleBackColor = true;
            this.butcancelaSolic.Click += new System.EventHandler(this.butcancelaSolic_Click);
            // 
            // butretorna
            // 
            this.butretorna.Location = new System.Drawing.Point(392, 198);
            this.butretorna.Name = "butretorna";
            this.butretorna.Size = new System.Drawing.Size(89, 23);
            this.butretorna.TabIndex = 8;
            this.butretorna.Text = "Retornar";
            this.butretorna.UseVisualStyleBackColor = true;
            this.butretorna.Click += new System.EventHandler(this.butretorna_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID_Solicitacao";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // mask_Idsol
            // 
            this.mask_Idsol.Location = new System.Drawing.Point(161, 80);
            this.mask_Idsol.Mask = "00";
            this.mask_Idsol.Name = "mask_Idsol";
            this.mask_Idsol.Size = new System.Drawing.Size(21, 20);
            this.mask_Idsol.TabIndex = 12;
            this.mask_Idsol.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_Idsol_MaskInputRejected);
            // 
            // listRequisicao
            // 
            this.listRequisicao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome_completo,
            this.ID,
            this.Motivo,
            this.CRM});
            this.listRequisicao.GridLines = true;
            this.listRequisicao.Location = new System.Drawing.Point(392, 12);
            this.listRequisicao.Name = "listRequisicao";
            this.listRequisicao.Size = new System.Drawing.Size(468, 164);
            this.listRequisicao.TabIndex = 13;
            this.listRequisicao.UseCompatibleStateImageBehavior = false;
            this.listRequisicao.View = System.Windows.Forms.View.Details;
            this.listRequisicao.SelectedIndexChanged += new System.EventHandler(this.listRequisicao_SelectedIndexChanged);
            // 
            // Nome_completo
            // 
            this.Nome_completo.Text = "Nome Completo";
            this.Nome_completo.Width = 150;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 52;
            // 
            // Motivo
            // 
            this.Motivo.Text = "Motivo";
            this.Motivo.Width = 142;
            // 
            // CRM
            // 
            this.CRM.Text = "CRM";
            this.CRM.Width = 117;
            // 
            // butrelatorio
            // 
            this.butrelatorio.Location = new System.Drawing.Point(529, 198);
            this.butrelatorio.Name = "butrelatorio";
            this.butrelatorio.Size = new System.Drawing.Size(79, 23);
            this.butrelatorio.TabIndex = 14;
            this.butrelatorio.Text = "Relatório";
            this.butrelatorio.UseVisualStyleBackColor = true;
            this.butrelatorio.Click += new System.EventHandler(this.butrelatorio_Click);
            // 
            // butSair
            // 
            this.butSair.Location = new System.Drawing.Point(674, 227);
            this.butSair.Name = "butSair";
            this.butSair.Size = new System.Drawing.Size(75, 23);
            this.butSair.TabIndex = 15;
            this.butSair.Text = "Sair";
            this.butSair.UseVisualStyleBackColor = true;
            this.butSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btlimpaSoli
            // 
            this.btlimpaSoli.Location = new System.Drawing.Point(392, 247);
            this.btlimpaSoli.Name = "btlimpaSoli";
            this.btlimpaSoli.Size = new System.Drawing.Size(75, 23);
            this.btlimpaSoli.TabIndex = 16;
            this.btlimpaSoli.Text = "Limpar";
            this.btlimpaSoli.UseVisualStyleBackColor = true;
            this.btlimpaSoli.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // butexcluirSolic
            // 
            this.butexcluirSolic.Location = new System.Drawing.Point(529, 247);
            this.butexcluirSolic.Name = "butexcluirSolic";
            this.butexcluirSolic.Size = new System.Drawing.Size(75, 23);
            this.butexcluirSolic.TabIndex = 17;
            this.butexcluirSolic.Text = "Excluir";
            this.butexcluirSolic.UseVisualStyleBackColor = true;
            this.butexcluirSolic.Click += new System.EventHandler(this.butexcluirSolic_Click);
            // 
            // coBselecaoItem
            // 
            this.coBselecaoItem.FormattingEnabled = true;
            this.coBselecaoItem.Items.AddRange(new object[] {
            "",
            "Dermatologia ",
            "Cirurgia Geral",
            "Oftalmologia",
            "Cardiologia",
            "Clinico",
            "Ginecologia",
            "Ultrassonografia"});
            this.coBselecaoItem.Location = new System.Drawing.Point(157, 113);
            this.coBselecaoItem.Name = "coBselecaoItem";
            this.coBselecaoItem.Size = new System.Drawing.Size(121, 21);
            this.coBselecaoItem.TabIndex = 18;
            this.coBselecaoItem.SelectedIndexChanged += new System.EventHandler(this.coBselecaoItem_SelectedIndexChanged);
            // 
            // combCrMedic
            // 
            this.combCrMedic.FormattingEnabled = true;
            this.combCrMedic.Items.AddRange(new object[] {
            "24241 Gine",
            "14145 Geral",
            "9087 Card",
            "12020 Oftal"});
            this.combCrMedic.Location = new System.Drawing.Point(157, 149);
            this.combCrMedic.Name = "combCrMedic";
            this.combCrMedic.Size = new System.Drawing.Size(121, 21);
            this.combCrMedic.TabIndex = 19;
            // 
            // Requisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 282);
            this.Controls.Add(this.combCrMedic);
            this.Controls.Add(this.coBselecaoItem);
            this.Controls.Add(this.butexcluirSolic);
            this.Controls.Add(this.btlimpaSoli);
            this.Controls.Add(this.butSair);
            this.Controls.Add(this.butrelatorio);
            this.Controls.Add(this.listRequisicao);
            this.Controls.Add(this.mask_Idsol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butretorna);
            this.Controls.Add(this.butcancelaSolic);
            this.Controls.Add(this.butComfirmSolici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNomeSolic);
            this.Controls.Add(this.label1);
            this.Name = "Requisicao";
            this.ShowIcon = false;
            this.Text = "Requisicao";
            this.Load += new System.EventHandler(this.Requisicao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNomeSolic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butComfirmSolici;
        private System.Windows.Forms.Button butcancelaSolic;
        private System.Windows.Forms.Button butretorna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mask_Idsol;
        private System.Windows.Forms.ListView listRequisicao;
        private System.Windows.Forms.ColumnHeader Nome_completo;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Motivo;
        private System.Windows.Forms.ColumnHeader CRM;
        private System.Windows.Forms.Button butrelatorio;
        private System.Windows.Forms.Button butSair;
        private System.Windows.Forms.Button btlimpaSoli;
        private System.Windows.Forms.Button butexcluirSolic;
        private System.Windows.Forms.ComboBox coBselecaoItem;
        private System.Windows.Forms.ComboBox combCrMedic;
    }
}