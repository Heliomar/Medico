using System;
using System.Configuration;
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
    public partial class Formulario : Form
    {
        public Formulario()

        {
            InitializeComponent();
        }


        # region Variaveis  locais

         string nome;
         string telefone;
         string endereco;
         string cpf;
         string numerosus;
        

        # endregion
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Formulario_Load(object sender, EventArgs e)
        {
                CarregarListView();
;
                                
        }
       

        private void textnomecompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void GravarMetodo(string Nome, string Telefone, string Endereco, string Cpf, string NumeroSus)
        {
                 Banco_de_Dados objbanco = new Banco_de_Dados();
            

            
                objbanco.Gravar(Nome,Telefone,Endereco,Cpf,NumeroSus);


               MessageBox.Show("Gravou no banco com sucesso   uhuhuhu");




        }
        private void Atualizar(string Nome, string Telefone, string Endereco, string Cpf, string NumeroSus)
        {

               Banco_de_Dados objbanco = new Banco_de_Dados();

               objbanco.Atualizar(Nome,Telefone,Endereco,Cpf,NumeroSus);

              

                MessageBox.Show("Atualizado com sucesso");



        }

        private void butalteraregistro_Click(object sender, EventArgs e)
        {

        }


        private void butexcluiregistro_Click(object sender, EventArgs e)
        {  

            Banco_de_Dados objbanco = new Banco_de_Dados();
            try
            {

           if(maskcartao_sus.Equals(maskcartao_sus.Text))
               objbanco.Excluir(maskcartao_sus.Text);

         

           MessageBox.Show("lisata limpando com sucesso como a exclusao !!");
            }

            catch (Exception ex)
            {

                MessageBox.Show("ocorreu um erro na exclusao "+ex);
            }
           
           
            
        }

        private void butpesquisar_Click(object sender, EventArgs e)
        {
           // Banco_de_Dados objbanco = new Banco_de_Dados();
            this.LimpaListview();
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


                lstcliente1.Items.Add(objviweitem);
           }

        }

        private void LimpaListview()
        {
            Banco_de_Dados objbanco = new Banco_de_Dados();
            List<medicalOline1.Banco_de_Dados.Cliente> lstCliente = new List<Banco_de_Dados.Cliente>();
            lstCliente = objbanco.Remover();


           // ListViewItem objviweitem = new ListViewItem();
           
               
               // objviweitem.SubItems.Clear();
            

                  lstcliente1.Items.Clear();
                
       
        }
        private void textendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        # region botoes

        private void butsavar_Click(object sender, EventArgs e)
        {
           Banco_de_Dados objbanco = new Banco_de_Dados();

           
           try{

               if

                   (!String.IsNullOrEmpty(textnomecompleto.Text) &&  !String .IsNullOrEmpty(masktelefone.Text)
                &&  !String.IsNullOrEmpty(maskcpf.Text)  &&  !String.IsNullOrEmpty(maskcartao_sus.Text))
               {

                   GravarMetodo(textnomecompleto.Text, masktelefone.Text, textendereco.Text, maskcpf.Text,maskcartao_sus.Text);

                  

                   MessageBox.Show("gravou no banco com sucesso");

                
               }
               else
               {


                   MessageBox.Show(" campos obrigatorio de preenchimento");

               }


           }catch(Exception ex)
           {
           
           

               MessageBox.Show("Nao conseguiu gravar no banco! :"+ex);
           }

      }

        private void butaltera_Click(object sender, EventArgs e)
        {
            
            //Atualizar(Nome, Telefone, Endereco, Cpf, NumeroSus);
            string  nome;
            string telefone;
            string endereco;
            string cpf;
            string numerosus;
           // int Id;
   
             
          try
          {
               nome = textnomecompleto.Text ;
               telefone = masktelefone.Text ;
               endereco = textendereco.Text ;
               cpf = maskcpf.Text;
               numerosus =  maskcartao_sus.Text;

               Requisicao objRequisicao = new Requisicao();
              // objRequisicao.nome = nome;
              // objRequisicao.textNomeSolic = nome;

               Atualizar(textnomecompleto.Text, masktelefone.Text, textendereco.Text, maskcpf.Text, maskcartao_sus.Text);
              
            
 

            MessageBox.Show("Atualizado com sucesso  uhuhu");
        
        }

        catch(Exception ex)
         {
    
            MessageBox.Show("Erro ematualizar o Banco"  +ex);
          }

   
          
    
        }

        private void butlimpa_Click(object sender, EventArgs e)
        {

            Banco_de_Dados.Cliente Cli = new Banco_de_Dados.Cliente();

            Cli.Nome = textnomecompleto.Text = " "; ;
            Cli.Endereco = textendereco.Text = " "; ;
            Cli.Telefone = masktelefone.Text = " "; ;
            Cli.Cpf = maskcpf.Text = " ";
            Cli.NumeroSus = maskcartao_sus.Text = " ";
            //Cli.id = Convert.ToInt32(makID.Text = " ");



            MessageBox.Show("Limpando informações  uhuhu");



           

        }
        private void textnomecompleto_TextChanged_1(object sender, EventArgs e)
        {

        }
        public void Exclusao(string NumeroSus) 
        {
            

            Banco_de_Dados objbanco = new Banco_de_Dados();

            try
            {
                objbanco.Excluir(NumeroSus);

            }
            catch (Exception  ex)
            {

                MessageBox.Show("Problemas de exclusao no banco"+ex);
            }
           
            

        }

        private void butexcluir_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                if(!String.IsNullOrEmpty(maskcpf.Text) && !String.IsNullOrEmpty(maskcartao_sus.Text)
                    && !String.IsNullOrEmpty(textnomecompleto.Text) && !String.IsNullOrEmpty(masktelefone.Text))

                {
                    Exclusao(maskcartao_sus.Text);
            
                     MessageBox.Show("Exclusao feita com sucesso");

                }else



                MessageBox.Show("não exclui vazio por favor !:");
	          }
          
        
               

        catch (Exception ex)

            {


                MessageBox.Show("Problemas na eclusao conserte por favor:" + ex);

            }

            

          }
        


        #endregion
        private void lstcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarListView();
        }

        private void texpesquisaregistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void maskcartao_sus_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void makID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void masktelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textendereco_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btFazPesquisa_Click(object sender, EventArgs e)
        {

            CarregarListView();
        }

        private void butPedidConsul_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form1 objform = new Form1();
            objform.ShowDialog();
            
            
        }
      }
    }

