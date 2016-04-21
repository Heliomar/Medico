using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicalOline1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            Formulario For = new Formulario();
            For.ShowDialog();
            //this.Visible = false;
            
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario For = new Formulario();
            For.ShowDialog();
            this.Visible = false;
           
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formulario For = new Formulario();
            For.ShowDialog();
           
           
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario For = new Formulario();
            For.ShowDialog();
            this.Close();
        }

        private void solicitarToolStripMenuItem_Click(object sender, EventArgs e)
          {
              this.Visible = false;
              Requisicao objReq = new Requisicao();
              objReq.ShowDialog();
              this.Close();
            }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anotações anat = new Anotações();
            anat.ShowDialog();
            this.Visible = false;

            Form1 objform = new Form1();
            objform.ShowDialog();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Printform objprint = new Printform();
            objprint.ShowDialog();
        }
    }
}
