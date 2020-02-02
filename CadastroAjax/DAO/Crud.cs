using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace CadastroAjax.DAO
{
    internal class Crud
    {
        static DataSet ds;
        internal static DataSet SalvarFornecdor(string empresa, string nome, string rg, DateTime dataNasc, StringBuilder telefones )
        {

            OleDbConnection con = new OleDbConnection(DAO.ConnectionString.strinConn);

            try
            {
                using (OleDbCommand comm = new OleDbCommand("Insert Into tblFornecedor (Empresa, Nome, RG, DataNascimento, DataHora, Telefone) " +
                    "values(@Empresa, @Nome, @RG, @DataNascimento, @DataHora, @Telefone)", con))
                {
                    comm.Parameters.Add("@Empresa", OleDbType.VarChar).Value = empresa;
                    comm.Parameters.Add("@Nome", OleDbType.VarChar).Value = nome;
                    comm.Parameters.Add("@RG", OleDbType.VarChar).Value = rg;
                    comm.Parameters.Add("@DataNascimento", OleDbType.Date).Value = dataNasc;
                    comm.Parameters.Add("@DataHora", OleDbType.Date).Value = DateTime.Now;
                    comm.Parameters.Add("@Telefone", OleDbType.VarChar).Value = telefones.ToString();

                    con.Open();
                    var x = comm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            ds = new DataSet();
            ds = Pesquisar("DataHora", DateTime.Now.ToShortDateString(), "tblFornecedor");
            return ds;
        }

        internal static DataSet SalvarEmpresa(string nome, string cep, string cnpj, string uf, string localidade, string logradouro)
        {
            OleDbConnection con = new OleDbConnection(DAO.ConnectionString.strinConn);


            try
            {
                using (OleDbCommand comm = new OleDbCommand("Insert Into tblEmpresa (Nome, CEP, CNPJ, UF, Localidade, Logradouro) values(@Nome, @CEP, @CNPJ, @UF, @Localidade, @Logradouro)", con))
                {
                    comm.Parameters.Add("@Nome", OleDbType.VarChar).Value = nome;
                    comm.Parameters.Add("@CEP", OleDbType.VarChar).Value = cep;
                    comm.Parameters.Add("@CNPJ", OleDbType.VarChar).Value = cnpj;
                    comm.Parameters.Add("@UF", OleDbType.VarChar).Value = uf;
                    comm.Parameters.Add("@Localidade", OleDbType.VarChar).Value = localidade;
                    comm.Parameters.Add("@Logradouro", OleDbType.VarChar).Value = logradouro;

                    con.Open();
                    var x = comm.ExecuteNonQuery();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            ds = new DataSet();
            ds = Pesquisar("Nome", "", "tblEmpresa");
            return ds;
        }

        internal static void TruncateTable()
        {
            OleDbConnection con = new OleDbConnection(DAO.ConnectionString.strinConn);


            try
            {
                using (OleDbCommand comm = new OleDbCommand("DELETE FROM tblEmpresa", con))
                {
                    con.Open();
                    var x = comm.ExecuteNonQuery();
                }
                using (OleDbCommand comm = new OleDbCommand("DELETE FROM tblFornecedor", con))
                {
                    var x = comm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        internal static DataSet Pesquisar(string cbb, string texto, string tabela)
        {
            OleDbConnection con = new OleDbConnection(ConnectionString.strinConn);
            
            try
            {
                using (OleDbCommand comm = new OleDbCommand($"select * from {tabela} where {cbb} like '%{texto}%' ", con))
                using (OleDbDataAdapter da = new OleDbDataAdapter(comm))
                {
                    ds = new DataSet();
                    
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

            return ds;
        }

        internal static DataSet SalvarFornecedor(string empresa, string nome, MaskedTextBox cpf_cnpj, StringBuilder telefones)
        {
            OleDbConnection con = new OleDbConnection(DAO.ConnectionString.strinConn);
            

            try
            {
                using (OleDbCommand comm = new OleDbCommand("Insert Into tblFornecedor (Empresa, Nome, CPF_CNPJ, DataHora, Telefone) values(@Empresa, @Nome, @CPF_CNPJ, @DataHora, @Telefone)", con))
                {
                    comm.Parameters.Add("@Empresa", OleDbType.VarChar).Value = empresa;
                    comm.Parameters.Add("@Nome", OleDbType.VarChar).Value = nome;
                    comm.Parameters.Add("@CPF_CNPJ", OleDbType.VarChar).Value = cpf_cnpj.Text;
                    comm.Parameters.Add("@DataHora", OleDbType.Date).Value = DateTime.Now;
                    comm.Parameters.Add("@Telefone", OleDbType.VarChar).Value = telefones.ToString();

                    con.Open();
                    var x = comm.ExecuteNonQuery();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            ds = new DataSet();
            ds = Pesquisar("DataHora", DateTime.Now.ToShortDateString(), "tblFornecedor");
            return ds;
        }

        
    }
}