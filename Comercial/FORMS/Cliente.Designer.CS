namespace WindowsFormsApplication1
{
    partial class CadastroClientes1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroClientes1));
            this.gbxPesquisar = new System.Windows.Forms.GroupBox();
            this.chkInativos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bntLimparPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisarNome = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cLICODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLINOMEFANTASIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLITELEFONE1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLITELEFONE2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIDECISORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLITELDECISORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIQTDPONTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLICONCORRENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLICADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIATUALIZACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI_FASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTESGRIDVIEWBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comercial = new WindowsFormsApplication1.comercial();
            this.cntConsultar = new System.Windows.Forms.Button();
            this.bntAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.bntInativar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cLIENTESGRIDVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESGRIDVIEWBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESGRIDVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPesquisar
            // 
            this.gbxPesquisar.Controls.Add(this.chkInativos);
            this.gbxPesquisar.Controls.Add(this.label1);
            this.gbxPesquisar.Controls.Add(this.button2);
            this.gbxPesquisar.Controls.Add(this.bntLimparPesquisa);
            this.gbxPesquisar.Controls.Add(this.txtPesquisarNome);
            this.gbxPesquisar.Location = new System.Drawing.Point(14, 50);
            this.gbxPesquisar.Name = "gbxPesquisar";
            this.gbxPesquisar.Size = new System.Drawing.Size(972, 102);
            this.gbxPesquisar.TabIndex = 4;
            this.gbxPesquisar.TabStop = false;
            this.gbxPesquisar.Text = "Filtros de pesquisa";
            // 
            // chkInativos
            // 
            this.chkInativos.AutoSize = true;
            this.chkInativos.Location = new System.Drawing.Point(9, 66);
            this.chkInativos.Name = "chkInativos";
            this.chkInativos.Size = new System.Drawing.Size(63, 17);
            this.chkInativos.TabIndex = 49;
            this.chkInativos.Text = "Inativos";
            this.chkInativos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources.zoom;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(883, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 46;
            this.button2.Text = "&Pesquisar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntLimparPesquisa
            // 
            this.bntLimparPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLimparPesquisa.Image = global::WindowsFormsApplication1.Properties.Resources.eraser_icon_icons3;
            this.bntLimparPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLimparPesquisa.Location = new System.Drawing.Point(883, 58);
            this.bntLimparPesquisa.Name = "bntLimparPesquisa";
            this.bntLimparPesquisa.Size = new System.Drawing.Size(80, 30);
            this.bntLimparPesquisa.TabIndex = 48;
            this.bntLimparPesquisa.Text = "&Limpar";
            this.bntLimparPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntLimparPesquisa.UseVisualStyleBackColor = true;
            this.bntLimparPesquisa.Click += new System.EventHandler(this.bntLimparPesquisa_Click);
            // 
            // txtPesquisarNome
            // 
            this.txtPesquisarNome.Location = new System.Drawing.Point(9, 38);
            this.txtPesquisarNome.MaxLength = 50;
            this.txtPesquisarNome.Name = "txtPesquisarNome";
            this.txtPesquisarNome.Size = new System.Drawing.Size(192, 20);
            this.txtPesquisarNome.TabIndex = 0;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLICODIGODataGridViewTextBoxColumn,
            this.cLINOMEFANTASIADataGridViewTextBoxColumn,
            this.cLITELEFONE1DataGridViewTextBoxColumn,
            this.cLITELEFONE2DataGridViewTextBoxColumn,
            this.cLIDECISORDataGridViewTextBoxColumn,
            this.cLITELDECISORDataGridViewTextBoxColumn,
            this.cLIQTDPONTOSDataGridViewTextBoxColumn,
            this.cLICONCORRENTEDataGridViewTextBoxColumn,
            this.cLICADASTRODataGridViewTextBoxColumn,
            this.cLIATUALIZACAODataGridViewTextBoxColumn,
            this.CLI_FASE});
            this.dgvClientes.DataSource = this.cLIENTESGRIDVIEWBindingSource1;
            this.dgvClientes.Location = new System.Drawing.Point(13, 158);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(973, 350);
            this.dgvClientes.TabIndex = 6;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // cLICODIGODataGridViewTextBoxColumn
            // 
            this.cLICODIGODataGridViewTextBoxColumn.DataPropertyName = "CLI_CODIGO";
            this.cLICODIGODataGridViewTextBoxColumn.Frozen = true;
            this.cLICODIGODataGridViewTextBoxColumn.HeaderText = "Código";
            this.cLICODIGODataGridViewTextBoxColumn.Name = "cLICODIGODataGridViewTextBoxColumn";
            this.cLICODIGODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLICODIGODataGridViewTextBoxColumn.Width = 120;
            // 
            // cLINOMEFANTASIADataGridViewTextBoxColumn
            // 
            this.cLINOMEFANTASIADataGridViewTextBoxColumn.DataPropertyName = "CLI_NOME_FANTASIA";
            this.cLINOMEFANTASIADataGridViewTextBoxColumn.Frozen = true;
            this.cLINOMEFANTASIADataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.cLINOMEFANTASIADataGridViewTextBoxColumn.Name = "cLINOMEFANTASIADataGridViewTextBoxColumn";
            this.cLINOMEFANTASIADataGridViewTextBoxColumn.ReadOnly = true;
            this.cLINOMEFANTASIADataGridViewTextBoxColumn.Width = 180;
            // 
            // cLITELEFONE1DataGridViewTextBoxColumn
            // 
            this.cLITELEFONE1DataGridViewTextBoxColumn.DataPropertyName = "CLI_TELEFONE1";
            this.cLITELEFONE1DataGridViewTextBoxColumn.Frozen = true;
            this.cLITELEFONE1DataGridViewTextBoxColumn.HeaderText = "Tel 1";
            this.cLITELEFONE1DataGridViewTextBoxColumn.Name = "cLITELEFONE1DataGridViewTextBoxColumn";
            this.cLITELEFONE1DataGridViewTextBoxColumn.ReadOnly = true;
            this.cLITELEFONE1DataGridViewTextBoxColumn.Width = 80;
            // 
            // cLITELEFONE2DataGridViewTextBoxColumn
            // 
            this.cLITELEFONE2DataGridViewTextBoxColumn.DataPropertyName = "CLI_TELEFONE2";
            this.cLITELEFONE2DataGridViewTextBoxColumn.Frozen = true;
            this.cLITELEFONE2DataGridViewTextBoxColumn.HeaderText = "Tel 2";
            this.cLITELEFONE2DataGridViewTextBoxColumn.Name = "cLITELEFONE2DataGridViewTextBoxColumn";
            this.cLITELEFONE2DataGridViewTextBoxColumn.ReadOnly = true;
            this.cLITELEFONE2DataGridViewTextBoxColumn.Width = 80;
            // 
            // cLIDECISORDataGridViewTextBoxColumn
            // 
            this.cLIDECISORDataGridViewTextBoxColumn.DataPropertyName = "CLI_DECISOR";
            this.cLIDECISORDataGridViewTextBoxColumn.Frozen = true;
            this.cLIDECISORDataGridViewTextBoxColumn.HeaderText = "Decisor";
            this.cLIDECISORDataGridViewTextBoxColumn.Name = "cLIDECISORDataGridViewTextBoxColumn";
            this.cLIDECISORDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIDECISORDataGridViewTextBoxColumn.Width = 80;
            // 
            // cLITELDECISORDataGridViewTextBoxColumn
            // 
            this.cLITELDECISORDataGridViewTextBoxColumn.DataPropertyName = "CLI_TELDECISOR";
            this.cLITELDECISORDataGridViewTextBoxColumn.Frozen = true;
            this.cLITELDECISORDataGridViewTextBoxColumn.HeaderText = "Tel Decisor";
            this.cLITELDECISORDataGridViewTextBoxColumn.Name = "cLITELDECISORDataGridViewTextBoxColumn";
            this.cLITELDECISORDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLITELDECISORDataGridViewTextBoxColumn.Width = 80;
            // 
            // cLIQTDPONTOSDataGridViewTextBoxColumn
            // 
            this.cLIQTDPONTOSDataGridViewTextBoxColumn.DataPropertyName = "CLI_QTDPONTOS";
            this.cLIQTDPONTOSDataGridViewTextBoxColumn.Frozen = true;
            this.cLIQTDPONTOSDataGridViewTextBoxColumn.HeaderText = "Pontos";
            this.cLIQTDPONTOSDataGridViewTextBoxColumn.Name = "cLIQTDPONTOSDataGridViewTextBoxColumn";
            this.cLIQTDPONTOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIQTDPONTOSDataGridViewTextBoxColumn.Width = 50;
            // 
            // cLICONCORRENTEDataGridViewTextBoxColumn
            // 
            this.cLICONCORRENTEDataGridViewTextBoxColumn.DataPropertyName = "CLI_CONCORRENTE";
            this.cLICONCORRENTEDataGridViewTextBoxColumn.Frozen = true;
            this.cLICONCORRENTEDataGridViewTextBoxColumn.HeaderText = "Concorrente";
            this.cLICONCORRENTEDataGridViewTextBoxColumn.Name = "cLICONCORRENTEDataGridViewTextBoxColumn";
            this.cLICONCORRENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLICADASTRODataGridViewTextBoxColumn
            // 
            this.cLICADASTRODataGridViewTextBoxColumn.DataPropertyName = "CLI_CADASTRO";
            this.cLICADASTRODataGridViewTextBoxColumn.Frozen = true;
            this.cLICADASTRODataGridViewTextBoxColumn.HeaderText = "D. Cadastro";
            this.cLICADASTRODataGridViewTextBoxColumn.Name = "cLICADASTRODataGridViewTextBoxColumn";
            this.cLICADASTRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIATUALIZACAODataGridViewTextBoxColumn
            // 
            this.cLIATUALIZACAODataGridViewTextBoxColumn.DataPropertyName = "CLI_ATUALIZACAO";
            this.cLIATUALIZACAODataGridViewTextBoxColumn.Frozen = true;
            this.cLIATUALIZACAODataGridViewTextBoxColumn.HeaderText = "D. Atualização";
            this.cLIATUALIZACAODataGridViewTextBoxColumn.Name = "cLIATUALIZACAODataGridViewTextBoxColumn";
            this.cLIATUALIZACAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CLI_FASE
            // 
            this.CLI_FASE.DataPropertyName = "CLI_FASE";
            this.CLI_FASE.Frozen = true;
            this.CLI_FASE.HeaderText = "FASE";
            this.CLI_FASE.Name = "CLI_FASE";
            this.CLI_FASE.ReadOnly = true;
            this.CLI_FASE.Visible = false;
            // 
            // cLIENTESGRIDVIEWBindingSource1
            // 
            this.cLIENTESGRIDVIEWBindingSource1.DataMember = "CLIENTES_GRIDVIEW";
            this.cLIENTESGRIDVIEWBindingSource1.DataSource = this.comercial;
            // 
            // comercial
            // 
            this.comercial.DataSetName = "comercial";
            this.comercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cntConsultar
            // 
            this.cntConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cntConsultar.Image = global::WindowsFormsApplication1.Properties.Resources.eye;
            this.cntConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cntConsultar.Location = new System.Drawing.Point(193, 10);
            this.cntConsultar.Name = "cntConsultar";
            this.cntConsultar.Size = new System.Drawing.Size(80, 30);
            this.cntConsultar.TabIndex = 49;
            this.cntConsultar.Text = "&Consultar";
            this.cntConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cntConsultar.UseVisualStyleBackColor = true;
            this.cntConsultar.Click += new System.EventHandler(this.cntConsultar_Click);
            // 
            // bntAlterar
            // 
            this.bntAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAlterar.Image = global::WindowsFormsApplication1.Properties.Resources.application_edit;
            this.bntAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAlterar.Location = new System.Drawing.Point(109, 10);
            this.bntAlterar.Name = "bntAlterar";
            this.bntAlterar.Size = new System.Drawing.Size(80, 30);
            this.bntAlterar.TabIndex = 50;
            this.bntAlterar.Text = "&Alterar";
            this.bntAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntAlterar.UseVisualStyleBackColor = true;
            this.bntAlterar.Click += new System.EventHandler(this.bntAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.Image = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(25, 10);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(80, 30);
            this.btnIncluir.TabIndex = 44;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntInativar
            // 
            this.bntInativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntInativar.Image = global::WindowsFormsApplication1.Properties.Resources.cross;
            this.bntInativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntInativar.Location = new System.Drawing.Point(277, 10);
            this.bntInativar.Name = "bntInativar";
            this.bntInativar.Size = new System.Drawing.Size(80, 30);
            this.bntInativar.TabIndex = 45;
            this.bntInativar.Text = "I&nativar";
            this.bntInativar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntInativar.UseVisualStyleBackColor = true;
            this.bntInativar.Click += new System.EventHandler(this.bntInativar_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::WindowsFormsApplication1.Properties.Resources.door_out;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(897, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 30);
            this.button3.TabIndex = 49;
            this.button3.Text = "&Sair";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cLIENTESGRIDVIEWBindingSource
            // 
            this.cLIENTESGRIDVIEWBindingSource.DataMember = "CLIENTES_GRIDVIEW";
            this.cLIENTESGRIDVIEWBindingSource.DataSource = this.comercial;
            // 
            // CadastroClientes1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.cntConsultar);
            this.Controls.Add(this.bntAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.bntInativar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.gbxPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroClientes1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.CadastroClientes1_Load);
            this.gbxPesquisar.ResumeLayout(false);
            this.gbxPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESGRIDVIEWBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESGRIDVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisarNome;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button bntLimparPesquisa;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bntInativar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bntAlterar;
        private System.Windows.Forms.Button cntConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIOBSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIDDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cLIENTESGRIDVIEWBindingSource;
        private comercial comercial;
        private System.Windows.Forms.CheckBox chkInativos;
        private System.Windows.Forms.BindingSource cLIENTESGRIDVIEWBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLICODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLINOMEFANTASIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLITELEFONE1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLITELEFONE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIDECISORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLITELDECISORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIQTDPONTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLICONCORRENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLICADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIATUALIZACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_FASE;
    }
}