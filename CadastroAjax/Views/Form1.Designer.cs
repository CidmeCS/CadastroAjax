namespace CadastroAjax
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmpresa = new System.Windows.Forms.TabPage();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.lblLogradouro_return = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblLocalidade_return = new System.Windows.Forms.Label();
            this.lblUF_return = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabFornecedor = new System.Windows.Forms.TabPage();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnMaisTelefone = new System.Windows.Forms.Button();
            this.mtbCNPJ_Forn = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarForn = new System.Windows.Forms.Button();
            this.Pesquisa = new System.Windows.Forms.TextBox();
            this.cbbPesquisa = new System.Windows.Forms.ComboBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.lbldataHora_Resp = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblCNPJ_Forn = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome_Forn = new System.Windows.Forms.Label();
            this.txtNome_Forn = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.tabFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmpresa);
            this.tabControl1.Controls.Add(this.tabFornecedor);
            this.tabControl1.Location = new System.Drawing.Point(16, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1035, 606);
            this.tabControl1.TabIndex = 2;
            // 
            // tabEmpresa
            // 
            this.tabEmpresa.Controls.Add(this.mtbCNPJ);
            this.tabEmpresa.Controls.Add(this.dgvEmpresa);
            this.tabEmpresa.Controls.Add(this.lblLogradouro_return);
            this.tabEmpresa.Controls.Add(this.lblLogradouro);
            this.tabEmpresa.Controls.Add(this.lblLocalidade);
            this.tabEmpresa.Controls.Add(this.lblLocalidade_return);
            this.tabEmpresa.Controls.Add(this.lblUF_return);
            this.tabEmpresa.Controls.Add(this.lblUF);
            this.tabEmpresa.Controls.Add(this.lblCNPJ);
            this.tabEmpresa.Controls.Add(this.lblCep);
            this.tabEmpresa.Controls.Add(this.mtbCep);
            this.tabEmpresa.Controls.Add(this.lblNome);
            this.tabEmpresa.Controls.Add(this.txtNome);
            this.tabEmpresa.Controls.Add(this.btnSalvar);
            this.tabEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tabEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.tabEmpresa.Name = "tabEmpresa";
            this.tabEmpresa.Padding = new System.Windows.Forms.Padding(4);
            this.tabEmpresa.Size = new System.Drawing.Size(1027, 577);
            this.tabEmpresa.TabIndex = 0;
            this.tabEmpresa.Text = "Cadastro da Empresa";
            this.tabEmpresa.UseVisualStyleBackColor = true;
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Location = new System.Drawing.Point(201, 100);
            this.mtbCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCNPJ.Mask = "999.999.999/9999-99";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(159, 22);
            this.mtbCNPJ.TabIndex = 30;
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(35, 294);
            this.dgvEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.Size = new System.Drawing.Size(961, 256);
            this.dgvEmpresa.TabIndex = 13;
            // 
            // lblLogradouro_return
            // 
            this.lblLogradouro_return.AutoSize = true;
            this.lblLogradouro_return.Location = new System.Drawing.Point(197, 238);
            this.lblLogradouro_return.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogradouro_return.Name = "lblLogradouro_return";
            this.lblLogradouro_return.Size = new System.Drawing.Size(13, 17);
            this.lblLogradouro_return.TabIndex = 12;
            this.lblLogradouro_return.Text = "*";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(33, 238);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(82, 17);
            this.lblLogradouro.TabIndex = 11;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(33, 196);
            this.lblLocalidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(77, 17);
            this.lblLocalidade.TabIndex = 10;
            this.lblLocalidade.Text = "Localidade";
            // 
            // lblLocalidade_return
            // 
            this.lblLocalidade_return.AutoSize = true;
            this.lblLocalidade_return.Location = new System.Drawing.Point(197, 196);
            this.lblLocalidade_return.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidade_return.Name = "lblLocalidade_return";
            this.lblLocalidade_return.Size = new System.Drawing.Size(13, 17);
            this.lblLocalidade_return.TabIndex = 9;
            this.lblLocalidade_return.Text = "*";
            // 
            // lblUF_return
            // 
            this.lblUF_return.AutoSize = true;
            this.lblUF_return.Location = new System.Drawing.Point(197, 151);
            this.lblUF_return.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUF_return.Name = "lblUF_return";
            this.lblUF_return.Size = new System.Drawing.Size(13, 17);
            this.lblUF_return.TabIndex = 8;
            this.lblUF_return.Text = "*";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(31, 151);
            this.lblUF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(26, 17);
            this.lblUF.TabIndex = 7;
            this.lblUF.Text = "UF";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(27, 100);
            this.lblCNPJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(43, 17);
            this.lblCNPJ.TabIndex = 6;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(27, 54);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(33, 17);
            this.lblCep.TabIndex = 4;
            this.lblCep.Text = "Cep";
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(201, 50);
            this.mtbCep.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCep.Mask = "00000-999";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(88, 22);
            this.mtbCep.TabIndex = 20;
            this.mtbCep.Leave += new System.EventHandler(this.MtbCepAsync);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 11);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(201, 7);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(444, 22);
            this.txtNome.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(568, 225);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 40;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // tabFornecedor
            // 
            this.tabFornecedor.Controls.Add(this.rbJuridica);
            this.tabFornecedor.Controls.Add(this.rbFisica);
            this.tabFornecedor.Controls.Add(this.dateTimePicker1);
            this.tabFornecedor.Controls.Add(this.mtbTelefone);
            this.tabFornecedor.Controls.Add(this.btnMaisTelefone);
            this.tabFornecedor.Controls.Add(this.mtbCNPJ_Forn);
            this.tabFornecedor.Controls.Add(this.btnSalvarForn);
            this.tabFornecedor.Controls.Add(this.Pesquisa);
            this.tabFornecedor.Controls.Add(this.cbbPesquisa);
            this.tabFornecedor.Controls.Add(this.lblNascimento);
            this.tabFornecedor.Controls.Add(this.lblRG);
            this.tabFornecedor.Controls.Add(this.txtRG);
            this.tabFornecedor.Controls.Add(this.lblEmpresa);
            this.tabFornecedor.Controls.Add(this.txtEmpresa);
            this.tabFornecedor.Controls.Add(this.dgvFornecedor);
            this.tabFornecedor.Controls.Add(this.lbldataHora_Resp);
            this.tabFornecedor.Controls.Add(this.lblDataHora);
            this.tabFornecedor.Controls.Add(this.lblCNPJ_Forn);
            this.tabFornecedor.Controls.Add(this.lblTelefone);
            this.tabFornecedor.Controls.Add(this.lblNome_Forn);
            this.tabFornecedor.Controls.Add(this.txtNome_Forn);
            this.tabFornecedor.Controls.Add(this.btnPesquisar);
            this.tabFornecedor.Location = new System.Drawing.Point(4, 25);
            this.tabFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.tabFornecedor.Name = "tabFornecedor";
            this.tabFornecedor.Padding = new System.Windows.Forms.Padding(4);
            this.tabFornecedor.Size = new System.Drawing.Size(1027, 577);
            this.tabFornecedor.TabIndex = 1;
            this.tabFornecedor.Text = "Cadastro do Fornecedor";
            this.tabFornecedor.UseVisualStyleBackColor = true;
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(201, 96);
            this.rbJuridica.Margin = new System.Windows.Forms.Padding(4);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(78, 21);
            this.rbJuridica.TabIndex = 40;
            this.rbJuridica.TabStop = true;
            this.rbJuridica.Text = "Juridica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Location = new System.Drawing.Point(31, 96);
            this.rbFisica.Margin = new System.Windows.Forms.Padding(4);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(65, 21);
            this.rbFisica.TabIndex = 30;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Fisica";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 207);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 22);
            this.dateTimePicker1.TabIndex = 70;
            this.dateTimePicker1.Value = new System.DateTime(2020, 2, 2, 0, 0, 0, 0);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(655, 90);
            this.mtbTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.mtbTelefone.Mask = "(99) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(116, 22);
            this.mtbTelefone.TabIndex = 80;
            // 
            // btnMaisTelefone
            // 
            this.btnMaisTelefone.BackColor = System.Drawing.Color.Lime;
            this.btnMaisTelefone.Location = new System.Drawing.Point(804, 89);
            this.btnMaisTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaisTelefone.Name = "btnMaisTelefone";
            this.btnMaisTelefone.Size = new System.Drawing.Size(28, 28);
            this.btnMaisTelefone.TabIndex = 90;
            this.btnMaisTelefone.Text = "+";
            this.btnMaisTelefone.UseVisualStyleBackColor = false;
            this.btnMaisTelefone.Click += new System.EventHandler(this.btnMaisTelefone_Click);
            // 
            // mtbCNPJ_Forn
            // 
            this.mtbCNPJ_Forn.Enabled = false;
            this.mtbCNPJ_Forn.Location = new System.Drawing.Point(201, 137);
            this.mtbCNPJ_Forn.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCNPJ_Forn.Mask = "999.999.999/9999-99";
            this.mtbCNPJ_Forn.Name = "mtbCNPJ_Forn";
            this.mtbCNPJ_Forn.Size = new System.Drawing.Size(156, 22);
            this.mtbCNPJ_Forn.TabIndex = 50;
            // 
            // btnSalvarForn
            // 
            this.btnSalvarForn.Location = new System.Drawing.Point(379, 256);
            this.btnSalvarForn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarForn.Name = "btnSalvarForn";
            this.btnSalvarForn.Size = new System.Drawing.Size(100, 28);
            this.btnSalvarForn.TabIndex = 200;
            this.btnSalvarForn.Text = "Salvar";
            this.btnSalvarForn.UseVisualStyleBackColor = true;
            this.btnSalvarForn.Click += new System.EventHandler(this.btnSalvarForn_Click);
            // 
            // Pesquisa
            // 
            this.Pesquisa.Location = new System.Drawing.Point(656, 260);
            this.Pesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(225, 22);
            this.Pesquisa.TabIndex = 310;
            // 
            // cbbPesquisa
            // 
            this.cbbPesquisa.FormattingEnabled = true;
            this.cbbPesquisa.Items.AddRange(new object[] {
            "Empresa",
            "Nome",
            "CPF_CNPJ",
            "DataHora"});
            this.cbbPesquisa.Location = new System.Drawing.Point(487, 258);
            this.cbbPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPesquisa.Name = "cbbPesquisa";
            this.cbbPesquisa.Size = new System.Drawing.Size(160, 24);
            this.cbbPesquisa.TabIndex = 300;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(28, 207);
            this.lblNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(136, 17);
            this.lblNascimento.TabIndex = 33;
            this.lblNascimento.Text = "Data de Nascimento";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(27, 172);
            this.lblRG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(29, 17);
            this.lblRG.TabIndex = 31;
            this.lblRG.Text = "RG";
            // 
            // txtRG
            // 
            this.txtRG.Enabled = false;
            this.txtRG.Location = new System.Drawing.Point(201, 169);
            this.txtRG.Margin = new System.Windows.Forms.Padding(4);
            this.txtRG.MaxLength = 15;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(225, 22);
            this.txtRG.TabIndex = 60;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(27, 25);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(64, 17);
            this.lblEmpresa.TabIndex = 29;
            this.lblEmpresa.Text = "Empresa";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(201, 21);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(444, 22);
            this.txtEmpresa.TabIndex = 10;
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Location = new System.Drawing.Point(36, 294);
            this.dgvFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(961, 252);
            this.dgvFornecedor.TabIndex = 27;
            // 
            // lbldataHora_Resp
            // 
            this.lbldataHora_Resp.AutoSize = true;
            this.lbldataHora_Resp.Location = new System.Drawing.Point(199, 252);
            this.lbldataHora_Resp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldataHora_Resp.Name = "lbldataHora_Resp";
            this.lbldataHora_Resp.Size = new System.Drawing.Size(13, 17);
            this.lbldataHora_Resp.TabIndex = 24;
            this.lbldataHora_Resp.Text = "*";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(32, 252);
            this.lblDataHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(73, 17);
            this.lblDataHora.TabIndex = 21;
            this.lblDataHora.Text = "Data/Hora";
            // 
            // lblCNPJ_Forn
            // 
            this.lblCNPJ_Forn.AutoSize = true;
            this.lblCNPJ_Forn.Location = new System.Drawing.Point(28, 140);
            this.lblCNPJ_Forn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCNPJ_Forn.Name = "lblCNPJ_Forn";
            this.lblCNPJ_Forn.Size = new System.Drawing.Size(43, 17);
            this.lblCNPJ_Forn.TabIndex = 20;
            this.lblCNPJ_Forn.Text = "CNPJ";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(581, 94);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 17);
            this.lblTelefone.TabIndex = 18;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNome_Forn
            // 
            this.lblNome_Forn.AutoSize = true;
            this.lblNome_Forn.Location = new System.Drawing.Point(28, 57);
            this.lblNome_Forn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome_Forn.Name = "lblNome_Forn";
            this.lblNome_Forn.Size = new System.Drawing.Size(45, 17);
            this.lblNome_Forn.TabIndex = 16;
            this.lblNome_Forn.Text = "Nome";
            // 
            // txtNome_Forn
            // 
            this.txtNome_Forn.Location = new System.Drawing.Point(203, 53);
            this.txtNome_Forn.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome_Forn.Name = "txtNome_Forn";
            this.txtNome_Forn.Size = new System.Drawing.Size(444, 22);
            this.txtNome_Forn.TabIndex = 20;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(897, 258);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 28);
            this.btnPesquisar.TabIndex = 320;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 650);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabEmpresa.ResumeLayout(false);
            this.tabEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.tabFornecedor.ResumeLayout(false);
            this.tabFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabEmpresa;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.Label lblLogradouro_return;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblLocalidade_return;
        private System.Windows.Forms.Label lblUF_return;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.Label lbldataHora_Resp;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblCNPJ_Forn;
        private System.Windows.Forms.Label lblNome_Forn;
        private System.Windows.Forms.TextBox txtNome_Forn;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSalvarForn;
        private System.Windows.Forms.TextBox Pesquisa;
        private System.Windows.Forms.ComboBox cbbPesquisa;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ_Forn;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Button btnMaisTelefone;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabFornecedor;
    }
}

