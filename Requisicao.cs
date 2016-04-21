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
    public partial class Requisicao : Form
    {
        private string Nome_Id;
        private string Crm_Medico;
        private string Tipo_Solicitacao;
        private string Id_Solicitacao;
       
        


        public Requisicao()
        {
            InitializeComponent();
        }


        private void retorno()
        {
        }
        private void Requisicao_Load(object sender, EventArgs e)
        {
            CarregarListView1();
        }

        private void CarregarListView1()
        {
            Banco_de_Dados objbanco = new Banco_de_Dados();
            List<medicalOline1.Banco_de_Dados.consulte> lstConsulte = new List<Banco_de_Dados.consulte>();
            lstConsulte = objbanco.Consul();



            foreach (var itemLista in lstConsulte)
            {
                ListViewItem objviweitem = new ListViewItem();

                objviweitem.Text = itemLista.Nome_Id;
                objviweitem.SubItems.Add(itemLista.ID_Solicitacao);
                objviweitem.SubItems.Add(itemLista.TipoSolicitacao);
                objviweitem.SubItems.Add(itemLista.CRM_Medico);
                
                listRequisicao.Items.Add(objviweitem);
            }

        }
        private void LimpListview() 
        {

            listRequisicao.Items.Clear();
        }
        private void butretorna_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 For = new Form1();
            For.ShowDialog();
            this.Close();
           
        }

        private void textNomeSolic_TextChanged(object sender, EventArgs e)
        {

        }
        private void SolitacaoGrava(string Tipo_Solicitacao,string Id_Solicitacao,string Crm_Medico,string Nome_Id) 
        {
            Banco_de_Dados objbanco = new Banco_de_Dados();
            try 
	{	        

            objbanco.GravaSolicita(Tipo_Solicitacao,Id_Solicitacao,Crm_Medico,Nome_Id);
            
		MessageBox.Show("gravou com sucesso na requisição :!");

	}
	catch (Exception  ex)
	{
		
		MessageBox.Show("erro eminserir os dados "+ex);
	}
            
        }
        private void butComfirmSolici_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (!string.IsNullOrEmpty(mask_Idsol.Text) && !string.IsNullOrEmpty(textNomeSolic.Text))
                    SolitacaoGrava(coBselecaoItem.Text, mask_Idsol.Text,combCrMedic.Text, textNomeSolic.Text);
                {
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Problemas de exclusao no banco"+ex);  
            }


            finally
            {

                MessageBox.Show("Parabens ganhou um premio");
            }
            
           
}


        private void texId_motivSolic_TextChanged(object sender, EventArgs e)
        {

        }

        private void textID_solic_TextChanged(object sender, EventArgs e)
        {

        }

        private void mask_Idsol_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void butrelatorio_Click(object sender, EventArgs e)
        {
            CarregarListView1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 objForm = new Form1();
            objForm.ShowDialog();
        }

        private void butcancelaSolic_Click(object sender, EventArgs e)
        {
            textNomeSolic.Text = "" ;
            mask_Idsol.Text = "";
            textNomeSolic.Text = "";
            combCrMedic.Text = "";

            this.Visible = false;
            Form1 objform = new Form1();
            objform.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LimpListview();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskcrMedico_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void Deletar(string ID_Solicitacao)
        {
            Banco_de_Dados objbanco = new Banco_de_Dados();
            try
            {
                if (mask_Idsol.Text.Equals(mask_Idsol.Text)) 
                {

                    objbanco.ExcluirSolic(ID_Solicitacao);

                    MessageBox.Show("Exclusao perfeita sucesso no projeto :!!");
                }

            }
            catch (Exception  ex)
            {

                MessageBox.Show("Nao conseguiu excluir parametro da solicitacao"+ex);
            }
        
        }
        private void butexcluirSolic_Click(object sender, EventArgs e)
        {

            Deletar(mask_Idsol.Text);


            MessageBox.Show("Bem sucedido");

        }

        private void listRequisicao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void coBselecaoItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
