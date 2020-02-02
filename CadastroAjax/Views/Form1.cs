using CadastroAjax.Entidades;
using System;
using System.Data;
using System.Windows.Forms;
using CadastroAjax.Modelos;
using System.Text;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using CadastroAjax.DAO;

namespace CadastroAjax
{
    public partial class Form1 : Form
    {
        Empresa empresa = new Empresa();
       
        
        StringBuilder telefones = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
            lbldataHora_Resp.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private async void MtbCepAsync(object sender, EventArgs e)
        {
            var empresa = await LocalizaCep.StartAsync(mtbCep.Text);
            lblUF_return.Text = empresa.UF;
            lblLocalidade_return.Text = empresa.Localidade;
            lblLogradouro_return.Text = empresa.Logradouro;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            dgvEmpresa.DataSource = 
                Crud.SalvarEmpresa
                (
                    txtNome.Text, mtbCep.Text, mtbCNPJ.Text, lblUF_return.Text, lblLocalidade_return.Text, lblLogradouro_return.Text
                ).Tables[0];
        }

        private void btnMaisTelefone_Click(object sender, EventArgs e)
        {
            MaisTelefone.Add(tabFornecedor);
        }

        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataSet ds = Crud.Pesquisar(cbbPesquisa.Text, Pesquisa.Text, "tblFornecedor");
            dgvFornecedor.DataSource = ds.Tables[0];
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            
            mtbCNPJ_Forn.Clear();
            mtbCNPJ_Forn.Enabled = false;
            txtRG.Clear();
            txtRG.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            
            mtbCNPJ_Forn.Clear();
            mtbCNPJ_Forn.Enabled = true;
            txtRG.Clear();
            txtRG.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void TruncateTable(object sender, EventArgs e)
        {
            Crud.TruncateTable();
        }

        private void btnSalvarForn_Click(object sender, EventArgs e)
        {
            
            if (rbJuridica.Checked == true)
            {
               dgvFornecedor.DataSource =  
                    Crud.SalvarFornecedor(txtEmpresa.Text, txtNome_Forn.Text, mtbCNPJ_Forn, Telefone.Buscar(tabFornecedor)).Tables[0];
            }
            else
            {
                dgvFornecedor.DataSource = 
                    Crud.SalvarFornecdor(txtEmpresa.Text, txtNome_Forn.Text, txtRG.Text, dateTimePicker1.Value, Telefone.Buscar(tabFornecedor)).Tables[0];
            }
            
        }
    }
}
