using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.ProviderBase;
using System.Configuration;
using System.Data.SqlTypes;
using System.Data.Common;

namespace medicalOline1
{
    public class Banco_de_Dados
    {
        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

      
        public const string strDelete = "DELETE  FROM CLIENTE WHERE NumeroSus = @NumeroSus";

        public const string strInsert = " INSERT INTO Cliente  values "+"(@Nome,@Telefone,@Endereco,@Cpf, @NumeroSus)";

        public const string strUpdate = "UPDATE CLIENTE set Nome = @Nome,Telefone = @Telefone,Endereco = @Endereco ,Cpf = @Cpf,NumeroSus = @NumeroSus  WHERE NumeroSus = @NumeroSus";
        public const string strSelect = "Select * from Cliente";
        public const string select = " select * from solicitacao";

        public const string Insert = "INSERT INTO Solicitacao  values " + " (@TipoSolicitacao,@ID_Solicitacao,@CRM_Medico,@Nome_Id)";

        public const string Delete = "Delete from Solicitacao WHERE ID_Solicitacao = @Id_Solicitacao";


        public class Cliente
        {


            public string Nome { get; set; }
            public string Cpf { get; set; }
            public string Endereco { get; set; }
            public string Telefone { get; set; }
            public string NumeroSus { get; set; }
           // public int Id { get; set; }
            

        }
        public class consulte 
        {
            public string ID_Solicitacao { get; set; }
            public string TipoSolicitacao { get; set; }
            public string CRM_Medico { get; set; }
            public string Nome_Id { get; set; }
        
        }


        # region metodos

        public List<Cliente> Consultar()
        {

            List<Cliente> lstCliente = new List<Cliente>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {


                using (SqlCommand objcomand = new SqlCommand(strSelect, objConexao))
                {

                    objConexao.Open();

                    SqlDataReader objDatareader = objcomand.ExecuteReader();

                    if (objDatareader.HasRows)
                    {

                        while (objDatareader.Read())
                        {
                            Cliente objcliente = new Cliente();
                            objcliente.Nome = objDatareader["Nome"].ToString();
                            objcliente.NumeroSus = objDatareader["NumeroSus"].ToString();
                            objcliente.Telefone = objDatareader["Telefone"].ToString();
                            objcliente.Endereco = objDatareader["Endereco"].ToString();
                            objcliente.Cpf = objDatareader["Cpf"].ToString();
                           
                        
                           
                            lstCliente.Add(objcliente);

                             
                        }
                        objDatareader.Close();  
                    }
                    objConexao.Close();
                }
            }
            return lstCliente;
        }

        public void selecionar(string Nome, string Telefone,string Endereco,string Cpf,string NumeroSus) { 

        using (SqlConnection objconexao = new SqlConnection(strConexao)) 
        {


            using (SqlCommand objcomand = new SqlCommand(strSelect, objconexao))
            {
                objcomand.Parameters.AddWithValue("@Nome", Nome);
                objcomand.Parameters.AddWithValue("@Telefone",Telefone);
                objcomand.Parameters.AddWithValue("@Endereco", Endereco);
                objcomand.Parameters.AddWithValue("@Cpf", Cpf);
                objcomand.Parameters.AddWithValue("@NumeroSus", NumeroSus);
                
                objconexao.Open();

                objcomand.ExecuteNonQuery();

                objconexao.Close();

             }
            }
        
        }
        public List<Cliente> Remover()
        {

            List<Cliente> lstCliente = new List<Cliente>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {


                using (SqlCommand objcomand = new SqlCommand(strSelect, objConexao))
                {

                    objConexao.Open();

                    SqlDataReader objDatareader = objcomand.ExecuteReader();

                    if (objDatareader.HasRows)
                    {

                        while (objDatareader.Read())
                        {
                            Cliente objcliente = new Cliente();
                            objcliente.Nome = objDatareader["Nome"].ToString();
                            objcliente.NumeroSus = objDatareader["NumeroSus"].ToString();
                            objcliente.Telefone = objDatareader["Telefone"].ToString();
                            objcliente.Endereco = objDatareader["Endereco"].ToString();
                            objcliente.Cpf = objDatareader["Cpf"].ToString();



                            lstCliente.Clear();


                        }
                        objDatareader.Close();
                    }
                    objConexao.Close();
                }
            }
            return lstCliente;
        }

        public List<consulte> Consul()
        {

            List<consulte> lstConsulte = new List<consulte>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {


                using (SqlCommand objcomand = new SqlCommand(select, objConexao))
                {

                    objConexao.Open();

                    SqlDataReader objDatareader = objcomand.ExecuteReader();

                    if (objDatareader.HasRows)
                    {

                        while (objDatareader.Read())
                        {
                            consulte objconsulte = new consulte();
                            objconsulte.TipoSolicitacao = objDatareader["TipoSolicitacao"].ToString();
                            objconsulte.ID_Solicitacao = objDatareader["Id_Solicitacao"].ToString();
                            objconsulte.CRM_Medico = objDatareader["CRM_Medico"].ToString();
                            objconsulte.Nome_Id = objDatareader["Nome_Id"].ToString();
                           


                            lstConsulte.Add(objconsulte);


                        }
                        objDatareader.Close();
                    }
                    objConexao.Close();
                }
            }
            return lstConsulte;
        }
        public void Excluir(string NumeroSus){
        
        using (SqlConnection objConexao = new SqlConnection(strConexao)) { 
            

           using (SqlCommand objcomand = new SqlCommand (strDelete,objConexao)) 
           {
               objcomand.Parameters.AddWithValue("@NumeroSus",NumeroSus);

               objConexao.Open();

                objcomand.ExecuteNonQuery();

               objConexao.Close();
           }
        
        }
      }
              
       public void Gravar(string Nome, string Telefone, string Endereco, string Cpf, string NumeroSus){

               
          
           using (SqlConnection objConexao = new SqlConnection(strConexao))
           {


           using (SqlCommand objcomand = new SqlCommand (strInsert,objConexao)) 
           {
               objcomand.Parameters.AddWithValue("@Nome", Nome);
               objcomand.Parameters.AddWithValue("@Telefone", Telefone);
               objcomand.Parameters.AddWithValue("@Endereco", Endereco);
               objcomand.Parameters.AddWithValue("@Cpf", Cpf);
               objcomand.Parameters.AddWithValue("@NumeroSus", NumeroSus);
              // objcomand.Parameters.AddWithValue("@Id",Id);
               objConexao.Open();

               objcomand.ExecuteNonQuery();

               objConexao.Close();
           

              }

           }
       
       }

       public void Atualizar(string Nome,string Telefone,string Endereco,string Cpf,string NumeroSus) { 
       
       using (SqlConnection objConexao = new SqlConnection(strConexao)) 
       {


           using (SqlCommand objcomand = new SqlCommand(strUpdate, objConexao))
           {

               objcomand.Parameters.AddWithValue("@Nome", Nome);
               objcomand.Parameters.AddWithValue("@Telefone", Telefone);
               objcomand.Parameters.AddWithValue("@Endereco", Endereco);
              objcomand.Parameters.AddWithValue("@Cpf", Cpf);
               objcomand.Parameters.AddWithValue("@NumeroSus", NumeroSus);
             
               objConexao.Open();

               objcomand.ExecuteNonQuery();

               objConexao.Close();
            }

           }

       }
       public void GravaSolicita(string Tipo_Solicitacao,  string Id_Solicitacao, string Crm_Medico,string Nome_Id)
       {

           using (SqlConnection objConexao = new SqlConnection(strConexao))
           {


               using (SqlCommand objcomand = new SqlCommand(Insert, objConexao))
               {
                   objcomand.Parameters.AddWithValue("@TipoSolicitacao", Tipo_Solicitacao);
                   objcomand.Parameters.AddWithValue("@ID_Solicitacao", Id_Solicitacao);
                   objcomand.Parameters.AddWithValue("@CRM_Medico", Crm_Medico);
                   objcomand.Parameters.AddWithValue("@Nome_ID", Nome_Id);
                  
                  

                   objConexao.Open();

                   objcomand.ExecuteNonQuery();

                   objConexao.Close();

               }
           }
       }
       public void ExcluirSolic(string ID_Solicitacao)
       {

           using (SqlConnection objConexao = new SqlConnection(strConexao))
           {


               using (SqlCommand objcomand = new SqlCommand(Delete, objConexao))
               {
                   objcomand.Parameters.AddWithValue("@ID_Solicitacao", ID_Solicitacao);

                   objConexao.Open();

                   objcomand.ExecuteNonQuery();

                   objConexao.Close();
               }

           }
       }
        # endregion

            
       
       }
  }
