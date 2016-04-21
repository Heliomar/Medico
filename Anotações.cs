using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace medicalOline1
{
    public partial class Anotações : Form
    {
        public Anotações()
        {
            InitializeComponent();
        }

        private void Anotações_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 objform = new Form1();
            objform.ShowDialog();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
           // SaveFileDialog sfd1 = new SaveFileDialog();

            sfd.Filter = "Arquivo Text | * .txt";
            sfd.Filter = "Arquivo | * .Doc";
      
            sfd.ShowDialog();
            sfd.ShowDialog();

           // Redirect(@c:"Documentos.PdfouDoc");

            if(string.IsNullOrEmpty(sfd.FileName)== false)
            {
                try
                {
                     using (StreamWriter writer = new StreamWriter(sfd.FileName,false,Encoding.UTF8))
              
              {
                  writer.Write(txtConteudo.Text);
                  writer.Flush();
              }
                     
                }
                catch (Exception  ex)
                {

                    MessageBox.Show(string.Format("messagem de error nao salvou arquivo error {0}",ex.Message),"Atencao",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
           
            ofd.Filter = "Arquivo Doc  | * .doc";
            ofd.Filter = "Arquivo Text | * .txt";
          //  ofd.Filter = "Arquivo Pdf  | * .pdf";
            ofd.ShowDialog();

            //System.Diagnostics.Process.Start(@"C:\Documentos.Pdfoudoc");

            if(string.IsNullOrEmpty(ofd.FileName)==false)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(ofd.FileName, Encoding.GetEncoding(CultureInfo.GetCultureInfo("ptr-BR").TextInfo.ANSICodePage)))

                        txtConteudo.Text = reader.ReadToEnd();
                }
                catch (Exception  ex)
                {

                    MessageBox.Show("mesagem de erro no abrir arquivo"+ex);
                }
            }
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
