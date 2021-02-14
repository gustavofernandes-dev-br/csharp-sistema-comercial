namespace WindowsFormsApplication1
{
    partial class formRamoAtuacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRamoAtuacao));
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atualizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbxDadosCadastrais = new System.Windows.Forms.GroupBox();
            this.chkInativo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntInativar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bntPesquisar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntLimparPesquisa = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomePesquisar = new System.Windows.Forms.TextBox();
            this.chkQualquerParte = new System.Windows.Forms.CheckBox();
            this.chkPesqInativo = new System.Windows.Forms.CheckBox();
            this.bntIncluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.gbxDadosCadastrais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Cadastro,
            this.Atualizacao,
            this.Usuario,
            this.Status});
            this.dgvRegistros.Location = new System.Drawing.Point(9, 219);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(573, 327);
            this.dgvRegistros.TabIndex = 47;
            this.dgvRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellClick);
            this.dgvRegistros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellDoubleClick);
            // 
            // Id
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // Nome
            // 
            this.Nome.Frozen = true;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 150;
            // 
            // Cadastro
            // 
            this.Cadastro.Frozen = true;
            this.Cadastro.HeaderText = "Cadastro";
            this.Cadastro.Name = "Cadastro";
            // 
            // Atualizacao
            // 
            this.Atualizacao.Frozen = true;
            this.Atualizacao.HeaderText = "Atualização";
            this.Atualizacao.Name = "Atualizacao";
            // 
            // Usuario
            // 
            this.Usuario.Frozen = true;
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            // 
            // Status
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Status.DefaultCellStyle = dataGridViewCellStyle2;
            this.Status.Frozen = true;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 50;
            // 
            // txtID
            // 
            this.txtID.AccessibleDescription = "Id";
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(20, 87);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 20);
            this.txtID.TabIndex = 45;
            // 
            // txtNome
            // 
            this.txtNome.AccessibleDescription = "Nome";
            this.txtNome.Location = new System.Drawing.Point(61, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 20);
            this.txtNome.TabIndex = 1;
            // 
            // gbxDadosCadastrais
            // 
            this.gbxDadosCadastrais.Controls.Add(this.chkInativo);
            this.gbxDadosCadastrais.Controls.Add(this.label5);
            this.gbxDadosCadastrais.Controls.Add(this.bntSalvar);
            this.gbxDadosCadastrais.Controls.Add(this.bntInativar);
            this.gbxDadosCadastrais.Controls.Add(this.bntCancelar);
            this.gbxDadosCadastrais.Controls.Add(this.label1);
            this.gbxDadosCadastrais.Enabled = false;
            this.gbxDadosCadastrais.Location = new System.Drawing.Point(9, 50);
            this.gbxDadosCadastrais.Name = "gbxDadosCadastrais";
            this.gbxDadosCadastrais.Size = new System.Drawing.Size(573, 81);
            this.gbxDadosCadastrais.TabIndex = 46;
            this.gbxDadosCadastrais.TabStop = false;
            this.gbxDadosCadastrais.Text = "Dados Cadastrais";
            // 
            // chkInativo
            // 
            this.chkInativo.AutoSize = true;
            this.chkInativo.Location = new System.Drawing.Point(193, 61);
            this.chkInativo.Name = "chkInativo";
            this.chkInativo.Size = new System.Drawing.Size(58, 17);
            this.chkInativo.TabIndex = 38;
            this.chkInativo.Text = "Inativo";
            this.chkInativo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Id";
            // 
            // bntSalvar
            // 
            this.bntSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSalvar.Enabled = false;
            this.bntSalvar.Image = global::WindowsFormsApplication1.Properties.Resources.accept;
            this.bntSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSalvar.Location = new System.Drawing.Point(292, 42);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(80, 30);
            this.bntSalvar.TabIndex = 0;
            this.bntSalvar.Text = "S&alvar";
            this.bntSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // bntInativar
            // 
            this.bntInativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntInativar.Image = global::WindowsFormsApplication1.Properties.Resources.database_error;
            this.bntInativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntInativar.Location = new System.Drawing.Point(378, 42);
            this.bntInativar.Name = "bntInativar";
            this.bntInativar.Size = new System.Drawing.Size(80, 30);
            this.bntInativar.TabIndex = 1;
            this.bntInativar.Text = "I&nativar";
            this.bntInativar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntInativar.UseVisualStyleBackColor = true;
            this.bntInativar.Click += new System.EventHandler(this.bntInativar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCancelar.Enabled = false;
            this.bntCancelar.Image = global::WindowsFormsApplication1.Properties.Resources.cancel;
            this.bntCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntCancelar.Location = new System.Drawing.Point(464, 42);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(80, 30);
            this.bntCancelar.TabIndex = 3;
            this.bntCancelar.Text = "&Cancelar";
            this.bntCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ramo de Atuação";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-582, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 41;
            this.button1.Text = "Incluir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bntPesquisar
            // 
            this.bntPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntPesquisar.Image = global::WindowsFormsApplication1.Properties.Resources.zoom;
            this.bntPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntPesquisar.Location = new System.Drawing.Point(381, 29);
            this.bntPesquisar.Name = "bntPesquisar";
            this.bntPesquisar.Size = new System.Drawing.Size(80, 30);
            this.bntPesquisar.TabIndex = 2;
            this.bntPesquisar.Text = "&Pesquisar";
            this.bntPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntPesquisar.UseVisualStyleBackColor = true;
            this.bntPesquisar.Click += new System.EventHandler(this.bntPesquisar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSair.Image = global::WindowsFormsApplication1.Properties.Resources.door_out;
            this.bntSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSair.Location = new System.Drawing.Point(488, 8);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(80, 30);
            this.bntSair.TabIndex = 42;
            this.bntSair.Text = "&Sair";
            this.bntSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntLimparPesquisa
            // 
            this.bntLimparPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLimparPesquisa.Image = global::WindowsFormsApplication1.Properties.Resources.eraser_icon_icons2;
            this.bntLimparPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLimparPesquisa.Location = new System.Drawing.Point(467, 29);
            this.bntLimparPesquisa.Name = "bntLimparPesquisa";
            this.bntLimparPesquisa.Size = new System.Drawing.Size(80, 30);
            this.bntLimparPesquisa.TabIndex = 3;
            this.bntLimparPesquisa.Text = "&Limpar";
            this.bntLimparPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntLimparPesquisa.UseVisualStyleBackColor = true;
            this.bntLimparPesquisa.Click += new System.EventHandler(this.bntLimparPesquisa_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 34;
            this.lblNome.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomePesquisar);
            this.groupBox1.Controls.Add(this.chkQualquerParte);
            this.groupBox1.Controls.Add(this.chkPesqInativo);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.bntPesquisar);
            this.groupBox1.Controls.Add(this.bntLimparPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(9, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 76);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // txtNomePesquisar
            // 
            this.txtNomePesquisar.Location = new System.Drawing.Point(11, 32);
            this.txtNomePesquisar.Name = "txtNomePesquisar";
            this.txtNomePesquisar.Size = new System.Drawing.Size(197, 20);
            this.txtNomePesquisar.TabIndex = 41;
            this.txtNomePesquisar.TextChanged += new System.EventHandler(this.txtNomePesquisar_TextChanged);
            // 
            // chkQualquerParte
            // 
            this.chkQualquerParte.AutoSize = true;
            this.chkQualquerParte.Location = new System.Drawing.Point(214, 33);
            this.chkQualquerParte.Name = "chkQualquerParte";
            this.chkQualquerParte.Size = new System.Drawing.Size(146, 17);
            this.chkQualquerParte.TabIndex = 40;
            this.chkQualquerParte.Text = "&Qualquer parte do campo";
            this.chkQualquerParte.UseVisualStyleBackColor = true;
            this.chkQualquerParte.Visible = false;
            // 
            // chkPesqInativo
            // 
            this.chkPesqInativo.AutoSize = true;
            this.chkPesqInativo.Location = new System.Drawing.Point(214, 55);
            this.chkPesqInativo.Name = "chkPesqInativo";
            this.chkPesqInativo.Size = new System.Drawing.Size(58, 17);
            this.chkPesqInativo.TabIndex = 39;
            this.chkPesqInativo.Text = "Inativo";
            this.chkPesqInativo.UseVisualStyleBackColor = true;
            // 
            // bntIncluir
            // 
            this.bntIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntIncluir.Image = global::WindowsFormsApplication1.Properties.Resources.add;
            this.bntIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntIncluir.Location = new System.Drawing.Point(8, 8);
            this.bntIncluir.Name = "bntIncluir";
            this.bntIncluir.Size = new System.Drawing.Size(80, 30);
            this.bntIncluir.TabIndex = 0;
            this.bntIncluir.Text = "&Incluir";
            this.bntIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntIncluir.UseVisualStyleBackColor = true;
            this.bntIncluir.Click += new System.EventHandler(this.bntIncluir_Click);
            // 
            // formRamoAtuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 562);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.bntIncluir);
            this.Controls.Add(this.gbxDadosCadastrais);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formRamoAtuacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ramo de Atuacao";
            this.Load += new System.EventHandler(this.formRamoAtuacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.gbxDadosCadastrais.ResumeLayout(false);
            this.gbxDadosCadastrais.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbxDadosCadastrais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntInativar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntPesquisar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntLimparPesquisa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkInativo;
        private System.Windows.Forms.CheckBox chkPesqInativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atualizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.CheckBox chkQualquerParte;
        private System.Windows.Forms.TextBox txtNomePesquisar;
        private System.Windows.Forms.Button bntIncluir;
    }
}