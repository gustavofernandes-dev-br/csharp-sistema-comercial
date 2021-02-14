namespace WindowsFormsApplication1
{
    partial class FormContato
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
            this.txtDDDDecisor = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.bntVoltar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnGerarContato = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObsPropeccao = new System.Windows.Forms.TextBox();
            this.btnProcurarCliente = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelDescisor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDecisor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataProspeccao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConsultor = new System.Windows.Forms.ComboBox();
            this.consultoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comercial = new WindowsFormsApplication1.comercial();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbVisitaNao = new System.Windows.Forms.RadioButton();
            this.rdbVisitaSim = new System.Windows.Forms.RadioButton();
            this.lblVisita = new System.Windows.Forms.Label();
            this.dtpProximoContato = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAlterarEndereco = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visita = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Decisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneDecisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximoContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntLimparPesquisa = new System.Windows.Forms.Button();
            this.bntPesquisar = new System.Windows.Forms.Button();
            this.comercialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.consultoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comercial)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comercialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDDDDecisor
            // 
            this.txtDDDDecisor.Location = new System.Drawing.Point(189, 131);
            this.txtDDDDecisor.MaxLength = 3;
            this.txtDDDDecisor.Name = "txtDDDDecisor";
            this.txtDDDDecisor.Size = new System.Drawing.Size(28, 20);
            this.txtDDDDecisor.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(187, 117);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 93;
            this.label23.Text = "DDD";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(261, 85);
            this.txtNome.MaxLength = 70;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(564, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 85;
            this.label18.Text = "Cod.";
            // 
            // bntVoltar
            // 
            this.bntVoltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bntVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bntVoltar.Image = global::WindowsFormsApplication1.Properties.Resources.cancel;
            this.bntVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntVoltar.Location = new System.Drawing.Point(890, 12);
            this.bntVoltar.Name = "bntVoltar";
            this.bntVoltar.Size = new System.Drawing.Size(80, 31);
            this.bntVoltar.TabIndex = 11;
            this.bntVoltar.Text = "&Voltar";
            this.bntVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntVoltar.UseVisualStyleBackColor = false;
            this.bntVoltar.Click += new System.EventHandler(this.bntVoltar_Click);
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
            // 
            // btnGerarContato
            // 
            this.btnGerarContato.Image = global::WindowsFormsApplication1.Properties.Resources.accept;
            this.btnGerarContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarContato.Location = new System.Drawing.Point(804, 12);
            this.btnGerarContato.Name = "btnGerarContato";
            this.btnGerarContato.Size = new System.Drawing.Size(80, 31);
            this.btnGerarContato.TabIndex = 10;
            this.btnGerarContato.Text = "Gerar";
            this.btnGerarContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarContato.UseVisualStyleBackColor = true;
            this.btnGerarContato.Click += new System.EventHandler(this.btnGerarContato_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 84;
            this.label11.Text = "Observação";
            // 
            // txtObsPropeccao
            // 
            this.txtObsPropeccao.Location = new System.Drawing.Point(12, 187);
            this.txtObsPropeccao.MaxLength = 30000;
            this.txtObsPropeccao.Multiline = true;
            this.txtObsPropeccao.Name = "txtObsPropeccao";
            this.txtObsPropeccao.Size = new System.Drawing.Size(972, 41);
            this.txtObsPropeccao.TabIndex = 9;
            // 
            // btnProcurarCliente
            // 
            this.btnProcurarCliente.Image = global::WindowsFormsApplication1.Properties.Resources.zoom;
            this.btnProcurarCliente.Location = new System.Drawing.Point(536, 83);
            this.btnProcurarCliente.Name = "btnProcurarCliente";
            this.btnProcurarCliente.Size = new System.Drawing.Size(23, 23);
            this.btnProcurarCliente.TabIndex = 82;
            this.btnProcurarCliente.UseVisualStyleBackColor = true;
            this.btnProcurarCliente.Click += new System.EventHandler(this.btnProcurarCliente_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(344, 131);
            this.txtEndereco.MaxLength = 300;
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(520, 31);
            this.txtEndereco.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Telefone do decisor";
            // 
            // txtTelDescisor
            // 
            this.txtTelDescisor.Location = new System.Drawing.Point(223, 131);
            this.txtTelDescisor.MaxLength = 10;
            this.txtTelDescisor.Name = "txtTelDescisor";
            this.txtTelDescisor.Size = new System.Drawing.Size(115, 20);
            this.txtTelDescisor.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Decisor";
            // 
            // txtDecisor
            // 
            this.txtDecisor.Location = new System.Drawing.Point(12, 131);
            this.txtDecisor.MaxLength = 30;
            this.txtDecisor.Name = "txtDecisor";
            this.txtDecisor.Size = new System.Drawing.Size(171, 20);
            this.txtDecisor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Data do contato";
            // 
            // dtpDataProspeccao
            // 
            this.dtpDataProspeccao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataProspeccao.Location = new System.Drawing.Point(164, 84);
            this.dtpDataProspeccao.Name = "dtpDataProspeccao";
            this.dtpDataProspeccao.Size = new System.Drawing.Size(91, 20);
            this.dtpDataProspeccao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Consultor";
            // 
            // cmbConsultor
            // 
            this.cmbConsultor.DataSource = this.consultoresBindingSource;
            this.cmbConsultor.DisplayMember = "US_NOME";
            this.cmbConsultor.FormattingEnabled = true;
            this.cmbConsultor.Location = new System.Drawing.Point(12, 84);
            this.cmbConsultor.Name = "cmbConsultor";
            this.cmbConsultor.Size = new System.Drawing.Size(148, 21);
            this.cmbConsultor.TabIndex = 0;
            this.cmbConsultor.ValueMember = "US_ID";
            // 
            // consultoresBindingSource
            // 
            this.consultoresBindingSource.DataMember = "Consultores";
            this.consultoresBindingSource.DataSource = this.comercial;
            // 
            // comercial
            // 
            this.comercial.DataSetName = "comercial";
            this.comercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbVisitaNao);
            this.groupBox1.Controls.Add(this.rdbVisitaSim);
            this.groupBox1.Location = new System.Drawing.Point(712, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 36);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcou Visita";
            // 
            // rdbVisitaNao
            // 
            this.rdbVisitaNao.AutoSize = true;
            this.rdbVisitaNao.Location = new System.Drawing.Point(64, 14);
            this.rdbVisitaNao.Name = "rdbVisitaNao";
            this.rdbVisitaNao.Size = new System.Drawing.Size(45, 17);
            this.rdbVisitaNao.TabIndex = 1;
            this.rdbVisitaNao.TabStop = true;
            this.rdbVisitaNao.Text = "Não";
            this.rdbVisitaNao.UseVisualStyleBackColor = true;
            this.rdbVisitaNao.CheckedChanged += new System.EventHandler(this.rdbVisitaNao_CheckedChanged);
            // 
            // rdbVisitaSim
            // 
            this.rdbVisitaSim.AutoSize = true;
            this.rdbVisitaSim.Location = new System.Drawing.Point(16, 15);
            this.rdbVisitaSim.Name = "rdbVisitaSim";
            this.rdbVisitaSim.Size = new System.Drawing.Size(42, 17);
            this.rdbVisitaSim.TabIndex = 0;
            this.rdbVisitaSim.TabStop = true;
            this.rdbVisitaSim.Text = "Sim";
            this.rdbVisitaSim.UseVisualStyleBackColor = true;
            this.rdbVisitaSim.CheckedChanged += new System.EventHandler(this.rdbVisitaSim_CheckedChanged);
            // 
            // lblVisita
            // 
            this.lblVisita.Location = new System.Drawing.Point(837, 66);
            this.lblVisita.Name = "lblVisita";
            this.lblVisita.Size = new System.Drawing.Size(125, 15);
            this.lblVisita.TabIndex = 96;
            this.lblVisita.Text = "Data Próximo Contato";
            // 
            // dtpProximoContato
            // 
            this.dtpProximoContato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProximoContato.Location = new System.Drawing.Point(840, 84);
            this.dtpProximoContato.Name = "dtpProximoContato";
            this.dtpProximoContato.Size = new System.Drawing.Size(96, 20);
            this.dtpProximoContato.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(344, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "Endereço da Visita";
            // 
            // btnAlterarEndereco
            // 
            this.btnAlterarEndereco.Image = global::WindowsFormsApplication1.Properties.Resources.table_refresh;
            this.btnAlterarEndereco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarEndereco.Location = new System.Drawing.Point(870, 131);
            this.btnAlterarEndereco.Name = "btnAlterarEndereco";
            this.btnAlterarEndereco.Size = new System.Drawing.Size(114, 31);
            this.btnAlterarEndereco.TabIndex = 97;
            this.btnAlterarEndereco.Text = "Trocar Endereco";
            this.btnAlterarEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarEndereco.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCliente,
            this.Consultor,
            this.NomeCliente,
            this.DataContato,
            this.Visita,
            this.Decisor,
            this.TelefoneDecisor,
            this.ProximoContato});
            this.dataGridView1.Location = new System.Drawing.Point(3, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(966, 244);
            this.dataGridView1.TabIndex = 98;
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.HeaderText = "Código";
            this.CodigoCliente.Name = "CodigoCliente";
            this.CodigoCliente.Visible = false;
            this.CodigoCliente.Width = 120;
            // 
            // Consultor
            // 
            this.Consultor.HeaderText = "Consultor";
            this.Consultor.Name = "Consultor";
            // 
            // NomeCliente
            // 
            this.NomeCliente.HeaderText = "Cliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.Width = 250;
            // 
            // DataContato
            // 
            this.DataContato.HeaderText = "Data";
            this.DataContato.Name = "DataContato";
            // 
            // Visita
            // 
            this.Visita.HeaderText = "Marcou Visita";
            this.Visita.Name = "Visita";
            this.Visita.Width = 70;
            // 
            // Decisor
            // 
            this.Decisor.HeaderText = "Decisor";
            this.Decisor.Name = "Decisor";
            this.Decisor.Width = 180;
            // 
            // TelefoneDecisor
            // 
            this.TelefoneDecisor.HeaderText = "Tel Decisor";
            this.TelefoneDecisor.Name = "TelefoneDecisor";
            this.TelefoneDecisor.Width = 120;
            // 
            // ProximoContato
            // 
            this.ProximoContato.HeaderText = "Proximo Contato";
            this.ProximoContato.Name = "ProximoContato";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntLimparPesquisa);
            this.panel1.Controls.Add(this.bntPesquisar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 315);
            this.panel1.TabIndex = 99;
            // 
            // bntLimparPesquisa
            // 
            this.bntLimparPesquisa.Image = global::WindowsFormsApplication1.Properties.Resources.eraser_icon_icons3;
            this.bntLimparPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLimparPesquisa.Location = new System.Drawing.Point(887, 3);
            this.bntLimparPesquisa.Name = "bntLimparPesquisa";
            this.bntLimparPesquisa.Size = new System.Drawing.Size(80, 30);
            this.bntLimparPesquisa.TabIndex = 100;
            this.bntLimparPesquisa.Text = "&Limpar";
            this.bntLimparPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntLimparPesquisa.UseVisualStyleBackColor = true;
            // 
            // bntPesquisar
            // 
            this.bntPesquisar.Image = global::WindowsFormsApplication1.Properties.Resources.zoom;
            this.bntPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntPesquisar.Location = new System.Drawing.Point(801, 3);
            this.bntPesquisar.Name = "bntPesquisar";
            this.bntPesquisar.Size = new System.Drawing.Size(80, 30);
            this.bntPesquisar.TabIndex = 99;
            this.bntPesquisar.Text = "&Pesquisar";
            this.bntPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntPesquisar.UseVisualStyleBackColor = true;
            // 
            // comercialBindingSource
            // 
            this.comercialBindingSource.DataSource = this.comercial;
            this.comercialBindingSource.Position = 0;
            // 
            // FormContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 561);
            this.Controls.Add(this.dtpProximoContato);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAlterarEndereco);
            this.Controls.Add(this.lblVisita);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDDDDecisor);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.bntVoltar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnGerarContato);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtObsPropeccao);
            this.Controls.Add(this.btnProcurarCliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelDescisor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDecisor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataProspeccao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbConsultor);
            this.Name = "FormContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "contato";
            this.Load += new System.EventHandler(this.FormContato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comercial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comercialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDDDDecisor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button bntVoltar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnGerarContato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtObsPropeccao;
        private System.Windows.Forms.Button btnProcurarCliente;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelDescisor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDecisor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataProspeccao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConsultor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbVisitaNao;
        private System.Windows.Forms.RadioButton rdbVisitaSim;
        private System.Windows.Forms.Label lblVisita;
        private System.Windows.Forms.DateTimePicker dtpProximoContato;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAlterarEndereco;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntLimparPesquisa;
        private System.Windows.Forms.Button bntPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataContato;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Visita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneDecisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximoContato;
        private System.Windows.Forms.BindingSource consultoresBindingSource;
        private comercial comercial;
        private System.Windows.Forms.BindingSource comercialBindingSource;
    }
}