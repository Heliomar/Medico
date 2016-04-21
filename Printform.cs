using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicalOline1
{
    public partial class Printform : Form
    {
        public Printform()
        {
            InitializeComponent();
        }
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("hello printing",new Font ("Arial",12,FontStyle.Regular),Brushes.Black,new Point(0,0));
            
        } 

        private void button1_Click(object sender, EventArgs e)
        {




            pre_visualizacao.Document = Documento;
            pre_visualizacao.ShowDialog();

              
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butvoltaForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 objform = new Form1();
            objform.ShowDialog();
        }

        private void pre_visualizacao_Load(object sender, EventArgs e)
        {
            
            
        }

        private void CarregarListView()
        {
            Banco_de_Dados objbanco = new Banco_de_Dados();
            List<medicalOline1.Banco_de_Dados.Cliente> lstCliente = new List<Banco_de_Dados.Cliente>();
            lstCliente = objbanco.Consultar();



            foreach (var itemLista in lstCliente)
            {
                ListViewItem objviweitem = new ListViewItem();

                objviweitem.Text = itemLista.Nome;
                objviweitem.SubItems.Add(itemLista.Telefone);
                objviweitem.SubItems.Add(itemLista.Endereco);
                objviweitem.SubItems.Add(itemLista.NumeroSus);
                objviweitem.SubItems.Add(itemLista.Cpf);
                // objviweitem.SubItems.Add(itemLista.id);


                //lstcliente1.Items.Add(objviweitem);
            }
        
        }
       
    }
}
