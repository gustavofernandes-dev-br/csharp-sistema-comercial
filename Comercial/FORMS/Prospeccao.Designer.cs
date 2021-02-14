namespace WindowsFormsApplication1
{
    partial class formProspeccao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProspeccao));
            this.cmbConsultor = new System.Windows.Forms.ComboBox();
            this.consultoresBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.comercial = new WindowsFormsApplication1.comercial();
            this.consultoresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.consultoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataProspeccao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numPontos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDecisor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelDescisor = new System.Windows.Forms.TextBox();
            this.cmbMeiosPropeccao = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObsPropeccao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvProspeccao = new System.Windows.Forms.DataGridView();
            this.us_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_nome_fantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mei_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxPesquisar = new System.Windows.Forms.GroupBox();
            this.txtPesquisarCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisarProspeccao = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpPesquisarFim = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpPesquisarInicio = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbPesquisarConsultor = new System.Windows.Forms.ComboBox();
            this.btnGerarProspeccao = new System.Windows.Forms.Button();
            this.btnProcurarCliente = new System.Windows.Forms.Button();
            this.consultoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.bntVoltar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTelefone1 = new System.Windows.Forms.TextBox();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTelResp = new System.Windows.Forms.TextBox();
            this.viewRamoAtuacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewConcorrentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESCONCORRENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESRAMOATUACAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDDDResp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDDDDecisor = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbConcorrente = new System.Windows.Forms.ComboBox();
            this.cmbRamoAtuacao = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultoresBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProspeccao)).BeginInit();
            this.gbxPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRamoAtuacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConcorrentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESCONCORRENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESRAMOATUACAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbConsultor
            // 
            this.cmbConsultor.DataSource = this.consultoresBindingSource3;
            this.cmbConsultor.DisplayMember = "US_NOME";
            this.cmbConsultor.FormattingEnabled = true;
            this.cmbConsultor.Location = new System.Drawing.Point(12, 84);
            this.cmbConsultor.Name = "cmbConsultor";
            this.cmbConsultor.Size = new System.Drawing.Size(148, 21);
            this.cmbConsultor.TabIndex = 0;
            this.cmbConsultor.ValueMember = "US_ID";
            this.cmbConsultor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbConsultor_KeyPress);
            // 
            // consultoresBindingSource3
            // 
            this.consultoresBindingSource3.DataMember = "Consultores";
            this.consultoresBindingSource3.DataSource = this.comercial;
            // 
            // comercial
            // 
            this.comercial.DataSetName = "comercial";
            this.comercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultoresBindingSource2
            // 
            this.consultoresBindingSource2.DataMember = "Consultores";
            // 
            // consultoresBindingSource1
            // 
            this.consultoresBindingSource1.DataMember = "Consultores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultor";
            // 
            // dtpDataProspeccao
            // 
            this.dtpDataProspeccao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataProspeccao.Location = new System.Drawing.Point(164, 84);
            this.dtpDataProspeccao.Name = "dtpDataProspeccao";
            this.dtpDataProspeccao.Size = new System.Drawing.Size(91, 20);
            this.dtpDataProspeccao.TabIndex = 1;
            this.dtpDataProspeccao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDataProspeccao_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente";
            // 
            // numPontos
            // 
            this.numPontos.Location = new System.Drawing.Point(712, 84);
            this.numPontos.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numPontos.Name = "numPontos";
            this.numPontos.Size = new System.Drawing.Size(60, 20);
            this.numPontos.TabIndex = 4;
            this.numPontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numPontos_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qtd. Pontos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(136, 132);
            this.txtResponsavel.MaxLength = 30;
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(170, 20);
            this.txtResponsavel.TabIndex = 9;
            this.txtResponsavel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResponsavel_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Responsável (Quem atendeu)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDecisor
            // 
            this.txtDecisor.Location = new System.Drawing.Point(468, 132);
            this.txtDecisor.MaxLength = 30;
            this.txtDecisor.Name = "txtDecisor";
            this.txtDecisor.Size = new System.Drawing.Size(171, 20);
            this.txtDecisor.TabIndex = 11;
            this.txtDecisor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecisor_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Decisor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(677, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefone do decisor";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTelDescisor
            // 
            this.txtTelDescisor.Location = new System.Drawing.Point(679, 132);
            this.txtTelDescisor.MaxLength = 10;
            this.txtTelDescisor.Name = "txtTelDescisor";
            this.txtTelDescisor.Size = new System.Drawing.Size(115, 20);
            this.txtTelDescisor.TabIndex = 12;
            this.txtTelDescisor.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtTelDescisor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelDescisor_KeyPress);
            // 
            // cmbMeiosPropeccao
            // 
            this.cmbMeiosPropeccao.DataSource = this.comercial;
            this.cmbMeiosPropeccao.DisplayMember = "PROSPECCAO_MEIOS.MEI_NOME";
            this.cmbMeiosPropeccao.FormattingEnabled = true;
            this.cmbMeiosPropeccao.Location = new System.Drawing.Point(781, 84);
            this.cmbMeiosPropeccao.Name = "cmbMeiosPropeccao";
            this.cmbMeiosPropeccao.Size = new System.Drawing.Size(147, 21);
            this.cmbMeiosPropeccao.TabIndex = 5;
            this.cmbMeiosPropeccao.ValueMember = "PROSPECCAO_MEIOS.MEI_CODIGO";
            this.cmbMeiosPropeccao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMeiosPropeccao_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(780, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Meio da prospecção";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(12, 170);
            this.txtEndereco.MaxLength = 300;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(601, 20);
            this.txtEndereco.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Endereço";
            // 
            // txtObsPropeccao
            // 
            this.txtObsPropeccao.Location = new System.Drawing.Point(12, 209);
            this.txtObsPropeccao.MaxLength = 30000;
            this.txtObsPropeccao.Multiline = true;
            this.txtObsPropeccao.Name = "txtObsPropeccao";
            this.txtObsPropeccao.Size = new System.Drawing.Size(1094, 64);
            this.txtObsPropeccao.TabIndex = 16;
            this.txtObsPropeccao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObsPropeccao_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Observação";
            // 
            // dgvProspeccao
            // 
            this.dgvProspeccao.AllowUserToAddRows = false;
            this.dgvProspeccao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProspeccao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.us_nome,
            this.pro_Data,
            this.cli_nome_fantasia,
            this.mei_nome,
            this.pro_obs});
            this.dgvProspeccao.Enabled = false;
            this.dgvProspeccao.Location = new System.Drawing.Point(12, 365);
            this.dgvProspeccao.Name = "dgvProspeccao";
            this.dgvProspeccao.Size = new System.Drawing.Size(1094, 211);
            this.dgvProspeccao.TabIndex = 34;
            // 
            // us_nome
            // 
            this.us_nome.DataPropertyName = "us_nome";
            this.us_nome.HeaderText = "Consultor";
            this.us_nome.Name = "us_nome";
            this.us_nome.Width = 130;
            // 
            // pro_Data
            // 
            this.pro_Data.DataPropertyName = "pro_Data";
            this.pro_Data.HeaderText = "Data";
            this.pro_Data.Name = "pro_Data";
            // 
            // cli_nome_fantasia
            // 
            this.cli_nome_fantasia.DataPropertyName = "cli_nome_fantasia";
            this.cli_nome_fantasia.HeaderText = "Cliente";
            this.cli_nome_fantasia.Name = "cli_nome_fantasia";
            this.cli_nome_fantasia.Width = 150;
            // 
            // mei_nome
            // 
            this.mei_nome.DataPropertyName = "mei_nome";
            this.mei_nome.HeaderText = "Meio";
            this.mei_nome.Name = "mei_nome";
            this.mei_nome.Width = 120;
            // 
            // pro_obs
            // 
            this.pro_obs.DataPropertyName = "pro_obs";
            this.pro_obs.HeaderText = "Observações";
            this.pro_obs.Name = "pro_obs";
            this.pro_obs.Width = 400;
            // 
            // gbxPesquisar
            // 
            this.gbxPesquisar.Controls.Add(this.txtPesquisarCliente);
            this.gbxPesquisar.Controls.Add(this.btnPesquisarProspeccao);
            this.gbxPesquisar.Controls.Add(this.label17);
            this.gbxPesquisar.Controls.Add(this.dtpPesquisarFim);
            this.gbxPesquisar.Controls.Add(this.label16);
            this.gbxPesquisar.Controls.Add(this.button1);
            this.gbxPesquisar.Controls.Add(this.dtpPesquisarInicio);
            this.gbxPesquisar.Controls.Add(this.label14);
            this.gbxPesquisar.Controls.Add(this.label15);
            this.gbxPesquisar.Controls.Add(this.cmbPesquisarConsultor);
            this.gbxPesquisar.Location = new System.Drawing.Point(12, 279);
            this.gbxPesquisar.Name = "gbxPesquisar";
            this.gbxPesquisar.Size = new System.Drawing.Size(1094, 80);
            this.gbxPesquisar.TabIndex = 35;
            this.gbxPesquisar.TabStop = false;
            this.gbxPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisarCliente
            // 
            this.txtPesquisarCliente.Location = new System.Drawing.Point(159, 32);
            this.txtPesquisarCliente.Name = "txtPesquisarCliente";
            this.txtPesquisarCliente.Size = new System.Drawing.Size(211, 20);
            this.txtPesquisarCliente.TabIndex = 41;
            // 
            // btnPesquisarProspeccao
            // 
            this.btnPesquisarProspeccao.Image = global::WindowsFormsApplication1.Properties.Resources.zoom;
            this.btnPesquisarProspeccao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarProspeccao.Location = new System.Drawing.Point(974, 27);
            this.btnPesquisarProspeccao.Name = "btnPesquisarProspeccao";
            this.btnPesquisarProspeccao.Size = new System.Drawing.Size(95, 33);
            this.btnPesquisarProspeccao.TabIndex = 4;
            this.btnPesquisarProspeccao.Text = "Procurar";
            this.btnPesquisarProspeccao.UseVisualStyleBackColor = true;
            this.btnPesquisarProspeccao.Click += new System.EventHandler(this.btnPesquisarProspeccao_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(502, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Fim";
            // 
            // dtpPesquisarFim
            // 
            this.dtpPesquisarFim.CustomFormat = "";
            this.dtpPesquisarFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPesquisarFim.Location = new System.Drawing.Point(502, 32);
            this.dtpPesquisarFim.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpPesquisarFim.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpPesquisarFim.Name = "dtpPesquisarFim";
            this.dtpPesquisarFim.Size = new System.Drawing.Size(83, 20);
            this.dtpPesquisarFim.TabIndex = 3;
            this.dtpPesquisarFim.Value = new System.DateTime(2017, 10, 17, 0, 0, 0, 0);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(413, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Inicio";
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.zoom;
            this.button1.Location = new System.Drawing.Point(376, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtpPesquisarInicio
            // 
            this.dtpPesquisarInicio.CustomFormat = "";
            this.dtpPesquisarInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPesquisarInicio.Location = new System.Drawing.Point(413, 32);
            this.dtpPesquisarInicio.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpPesquisarInicio.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpPesquisarInicio.Name = "dtpPesquisarInicio";
            this.dtpPesquisarInicio.Size = new System.Drawing.Size(83, 20);
            this.dtpPesquisarInicio.TabIndex = 2;
            this.dtpPesquisarInicio.Value = new System.DateTime(2017, 10, 17, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Consultor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(156, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Cliente";
            // 
            // cmbPesquisarConsultor
            // 
            this.cmbPesquisarConsultor.FormattingEnabled = true;
            this.cmbPesquisarConsultor.Location = new System.Drawing.Point(6, 33);
            this.cmbPesquisarConsultor.Name = "cmbPesquisarConsultor";
            this.cmbPesquisarConsultor.Size = new System.Drawing.Size(144, 21);
            this.cmbPesquisarConsultor.TabIndex = 0;
            // 
            // btnGerarProspeccao
            // 
            this.btnGerarProspeccao.Image = global::WindowsFormsApplication1.Properties.Resources.accept;
            this.btnGerarProspeccao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarProspeccao.Location = new System.Drawing.Point(941, 12);
            this.btnGerarProspeccao.Name = "btnGerarProspeccao";
            this.btnGerarProspeccao.Size = new System.Drawing.Size(80, 31);
            this.btnGerarProspeccao.TabIndex = 17;
            this.btnGerarProspeccao.Text = "Gerar";
            this.btnGerarProspeccao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarProspeccao.UseVisualStyleBackColor = true;
            this.btnGerarProspeccao.Click += new System.EventHandler(this.btnGerarProspeccao_Click);
            // 
            // btnProcurarCliente
            // 
            this.btnProcurarCliente.Image = global::WindowsFormsApplication1.Properties.Resources.zoom;
            this.btnProcurarCliente.Location = new System.Drawing.Point(536, 83);
            this.btnProcurarCliente.Name = "btnProcurarCliente";
            this.btnProcurarCliente.Size = new System.Drawing.Size(23, 23);
            this.btnProcurarCliente.TabIndex = 28;
            this.btnProcurarCliente.UseVisualStyleBackColor = true;
            this.btnProcurarCliente.Click += new System.EventHandler(this.btnProcurarCliente_Click);
            // 
            // consultoresBindingSource
            // 
            this.consultoresBindingSource.DataMember = "Consultores";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtId.Location = new System.Drawing.Point(564, 85);
            this.txtId.MaxLength = 17;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(142, 20);
            this.txtId.TabIndex = 3;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // bntVoltar
            // 
            this.bntVoltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bntVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bntVoltar.Image = global::WindowsFormsApplication1.Properties.Resources.cancel;
            this.bntVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntVoltar.Location = new System.Drawing.Point(1026, 12);
            this.bntVoltar.Name = "bntVoltar";
            this.bntVoltar.Size = new System.Drawing.Size(80, 31);
            this.bntVoltar.TabIndex = 18;
            this.bntVoltar.Text = "&Voltar";
            this.bntVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntVoltar.UseVisualStyleBackColor = false;
            this.bntVoltar.Click += new System.EventHandler(this.bntVoltar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(564, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Cod.";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(261, 85);
            this.txtNome.MaxLength = 70;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(344, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Telefone Responsável";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(969, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 46;
            this.label20.Text = "Telefone 1";
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(935, 83);
            this.txtDDD.MaxLength = 3;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(28, 20);
            this.txtDDD.TabIndex = 6;
            this.txtDDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDDD_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(933, 69);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 45;
            this.label21.Text = "DDD";
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Location = new System.Drawing.Point(970, 83);
            this.txtTelefone1.MaxLength = 10;
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(136, 20);
            this.txtTelefone1.TabIndex = 7;
            this.txtTelefone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone1_KeyPress);
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Location = new System.Drawing.Point(12, 131);
            this.txtTelefone2.MaxLength = 10;
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(115, 20);
            this.txtTelefone2.TabIndex = 8;
            this.txtTelefone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone2_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 48;
            this.label22.Text = "Telefone 2";
            // 
            // txtTelResp
            // 
            this.txtTelResp.Location = new System.Drawing.Point(347, 132);
            this.txtTelResp.MaxLength = 10;
            this.txtTelResp.Name = "txtTelResp";
            this.txtTelResp.Size = new System.Drawing.Size(115, 20);
            this.txtTelResp.TabIndex = 10;
            this.txtTelResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelResp_KeyPress);
            // 
            // viewRamoAtuacaoBindingSource
            // 
            this.viewRamoAtuacaoBindingSource.DataMember = "view_RamoAtuacao";
            this.viewRamoAtuacaoBindingSource.DataSource = this.comercial;
            // 
            // viewConcorrentesBindingSource
            // 
            this.viewConcorrentesBindingSource.DataMember = "view_Concorrentes";
            this.viewConcorrentesBindingSource.DataSource = this.comercial;
            // 
            // cLIENTESCONCORRENTEBindingSource
            // 
            this.cLIENTESCONCORRENTEBindingSource.DataMember = "CLIENTES_CONCORRENTE";
            this.cLIENTESCONCORRENTEBindingSource.DataSource = this.comercial;
            // 
            // cLIENTESRAMOATUACAOBindingSource
            // 
            this.cLIENTESRAMOATUACAOBindingSource.DataMember = "CLIENTES_RAMOATUACAO";
            this.cLIENTESRAMOATUACAOBindingSource.DataSource = this.comercial;
            // 
            // txtDDDResp
            // 
            this.txtDDDResp.Location = new System.Drawing.Point(312, 132);
            this.txtDDDResp.MaxLength = 3;
            this.txtDDDResp.Name = "txtDDDResp";
            this.txtDDDResp.Size = new System.Drawing.Size(28, 20);
            this.txtDDDResp.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "DDD";
            // 
            // txtDDDDecisor
            // 
            this.txtDDDDecisor.Location = new System.Drawing.Point(645, 132);
            this.txtDDDDecisor.MaxLength = 3;
            this.txtDDDDecisor.Name = "txtDDDDecisor";
            this.txtDDDDecisor.Size = new System.Drawing.Size(28, 20);
            this.txtDDDDecisor.TabIndex = 51;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(643, 118);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 52;
            this.label23.Text = "DDD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(801, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sistema Atual(Concorrente)";
            // 
            // cmbConcorrente
            // 
            this.cmbConcorrente.DataSource = this.viewConcorrentesBindingSource;
            this.cmbConcorrente.DisplayMember = "CON_NOME";
            this.cmbConcorrente.FormattingEnabled = true;
            this.cmbConcorrente.Location = new System.Drawing.Point(800, 131);
            this.cmbConcorrente.Name = "cmbConcorrente";
            this.cmbConcorrente.Size = new System.Drawing.Size(150, 21);
            this.cmbConcorrente.TabIndex = 14;
            this.cmbConcorrente.ValueMember = "CON_CODIGO";
            this.cmbConcorrente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbConcorrente_KeyPress);
            // 
            // cmbRamoAtuacao
            // 
            this.cmbRamoAtuacao.DataSource = this.viewRamoAtuacaoBindingSource;
            this.cmbRamoAtuacao.DisplayMember = "RAM_NOME";
            this.cmbRamoAtuacao.FormattingEnabled = true;
            this.cmbRamoAtuacao.Location = new System.Drawing.Point(956, 131);
            this.cmbRamoAtuacao.Name = "cmbRamoAtuacao";
            this.cmbRamoAtuacao.Size = new System.Drawing.Size(150, 21);
            this.cmbRamoAtuacao.TabIndex = 15;
            this.cmbRamoAtuacao.ValueMember = "RAM_CODIGO";
            this.cmbRamoAtuacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRamoAtuacao_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(953, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Ramo de Atuação";
            // 
            // formProspeccao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 592);
            this.Controls.Add(this.txtDDDDecisor);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtDDDResp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtTelefone2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtTelefone1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.bntVoltar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.gbxPesquisar);
            this.Controls.Add(this.dgvProspeccao);
            this.Controls.Add(this.btnGerarProspeccao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtObsPropeccao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbRamoAtuacao);
            this.Controls.Add(this.btnProcurarCliente);
            this.Controls.Add(this.cmbConcorrente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbMeiosPropeccao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelDescisor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDecisor);
            this.Controls.Add(this.txtTelResp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPontos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataProspeccao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbConsultor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formProspeccao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV NET Inteligencia em sistemas - Prospecção";
            this.Load += new System.EventHandler(this.formProspeccao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultoresBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProspeccao)).EndInit();
            this.gbxPesquisar.ResumeLayout(false);
            this.gbxPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRamoAtuacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConcorrentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESCONCORRENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESRAMOATUACAOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbConsultor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataProspeccao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPontos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDecisor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelDescisor;
        private System.Windows.Forms.ComboBox cmbMeiosPropeccao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnProcurarCliente;
        private System.Windows.Forms.TextBox txtObsPropeccao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGerarProspeccao;
        private System.Windows.Forms.DataGridView dgvProspeccao;
        private System.Windows.Forms.GroupBox gbxPesquisar;
        private System.Windows.Forms.Button btnPesquisarProspeccao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpPesquisarFim;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpPesquisarInicio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbPesquisarConsultor;
        private System.Windows.Forms.BindingSource consultoresBindingSource1;
        private System.Windows.Forms.BindingSource consultoresBindingSource;
        private System.Windows.Forms.BindingSource consultoresBindingSource2;
        
        private System.Windows.Forms.BindingSource consultoresBindingSource3;
        private comercial comercial;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button bntVoltar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTelefone1;
        private System.Windows.Forms.TextBox txtTelefone2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtTelResp;
        private System.Windows.Forms.BindingSource cLIENTESRAMOATUACAOBindingSource;
        private System.Windows.Forms.BindingSource cLIENTESCONCORRENTEBindingSource;
        private System.Windows.Forms.BindingSource viewRamoAtuacaoBindingSource;
        private System.Windows.Forms.BindingSource viewConcorrentesBindingSource;
        private System.Windows.Forms.TextBox txtDDDResp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDDDDecisor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbConcorrente;
        private System.Windows.Forms.ComboBox cmbRamoAtuacao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPesquisarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn us_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome_fantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn mei_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_obs;
    }
}