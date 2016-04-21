namespace medicalOline1
{
    partial class Printform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Printform));
            this.Documento = new System.Drawing.Printing.PrintDocument();
            this.butpreviaVisual = new System.Windows.Forms.Button();
            this.pre_visualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.butvoltaForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Documento
            // 
            this.Documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // butpreviaVisual
            // 
            this.butpreviaVisual.Location = new System.Drawing.Point(506, 272);
            this.butpreviaVisual.Name = "butpreviaVisual";
            this.butpreviaVisual.Size = new System.Drawing.Size(75, 23);
            this.butpreviaVisual.TabIndex = 0;
            this.butpreviaVisual.Text = "Prever......";
            this.butpreviaVisual.UseVisualStyleBackColor = true;
            this.butpreviaVisual.Click += new System.EventHandler(this.button1_Click);
            // 
            // pre_visualizacao
            // 
            this.pre_visualizacao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pre_visualizacao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pre_visualizacao.ClientSize = new System.Drawing.Size(400, 300);
            this.pre_visualizacao.Enabled = true;
            this.pre_visualizacao.Icon = ((System.Drawing.Icon)(resources.GetObject("pre_visualizacao.Icon")));
            this.pre_visualizacao.Name = "pre_visualizacao";
            this.pre_visualizacao.Visible = false;
            this.pre_visualizacao.Load += new System.EventHandler(this.pre_visualizacao_Load);
            // 
            // butvoltaForm
            // 
            this.butvoltaForm.Location = new System.Drawing.Point(141, 272);
            this.butvoltaForm.Name = "butvoltaForm";
            this.butvoltaForm.Size = new System.Drawing.Size(75, 23);
            this.butvoltaForm.TabIndex = 1;
            this.butvoltaForm.Text = "Formulario";
            this.butvoltaForm.UseVisualStyleBackColor = true;
            this.butvoltaForm.Click += new System.EventHandler(this.butvoltaForm_Click);
            // 
            // Printform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(667, 377);
            this.Controls.Add(this.butvoltaForm);
            this.Controls.Add(this.butpreviaVisual);
            this.Name = "Printform";
            this.ShowIcon = false;
            this.Text = "Printform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument Documento;
        private System.Windows.Forms.Button butpreviaVisual;
        private System.Windows.Forms.PrintPreviewDialog pre_visualizacao;
        private System.Windows.Forms.Button butvoltaForm;
    }
}