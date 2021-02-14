namespace WindowsFormsApplication1
{
    partial class formOperadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOperadores));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxPerfil = new System.Windows.Forms.GroupBox();
            this.chkInativo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.rbtAuxiliarAdm = new System.Windows.Forms.RadioButton();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.rbtConsultor = new System.Windows.Forms.RadioButton();
            this.rbtAdministrador = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.US_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.US_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesq = new System.Windows.Forms.Button();
            this.chkQualquerParte = new System.Windows.Forms.CheckBox();
            this.bntLimparPesquisa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkPesqInativos = new System.Windows.Forms.CheckBox();
            this.txtUsuarioPesquisar = new System.Windows.Forms.TextBox();
            this.txtNomePesquisar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntIncluir = new System.Windows.Forms.Button();
            this.gbxPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AccessibleDescription = "Nome";
            this.txtNome.Location = new System.Drawing.Point(56, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 20);
            this.txtNome.TabIndex = 1;
            //this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do funcionário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AccessibleDescription = "Usuário(login)";
            this.txtUsuario.AccessibleName = "";
            this.txtUsuario.Location = new System.Drawing.Point(529, 37);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(122, 20);
            this.txtUsuario.TabIndex = 3;
            //this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.AccessibleDescription = "Senha";
            this.txtSenha.AccessibleName = "";
            this.txtSenha.Location = new System.Drawing.Point(657, 37);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(121, 20);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário (login)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // gbxPerfil
            // 
            this.gbxPerfil.Controls.Add(this.chkInativo);
            this.gbxPerfil.Controls.Add(this.label5);
            this.gbxPerfil.Controls.Add(this.txtID);
            this.gbxPerfil.Controls.Add(this.bntExcluir);
            this.gbxPerfil.Controls.Add(this.bntCancelar);
            this.gbxPerfil.Controls.Add(this.rbtAuxiliarAdm);
            this.gbxPerfil.Controls.Add(this.bntSalvar);
            this.gbxPerfil.Controls.Add(this.rbtConsultor);
            this.gbxPerfil.Controls.Add(this.rbtAdministrador);
            this.gbxPerfil.Controls.Add(this.txtNome);
            this.gbxPerfil.Controls.Add(this.label1);
            this.gbxPerfil.Controls.Add(this.label4);
            this.gbxPerfil.Controls.Add(this.txtUsuario);
            this.gbxPerfil.Controls.Add(this.txtEmail);
            this.gbxPerfil.Controls.Add(this.txtSenha);
            this.gbxPerfil.Controls.Add(this.label2);
            this.gbxPerfil.Controls.Add(this.label3);
            this.gbxPerfil.Enabled = false;
            this.gbxPerfil.Location = new System.Drawing.Point(24, 51);
            this.gbxPerfil.Name = "gbxPerfil";
            this.gbxPerfil.Size = new System.Drawing.Size(909, 122);
            this.gbxPerfil.TabIndex = 4;
            this.gbxPerfil.TabStop = false;
            this.gbxPerfil.Text = "Dados Cadastrais";
           // this.gbxPerfil.Enter += new System.EventHandler(this.gbxPerfil_Enter);
            // 
            // chkInativo
            // 
            this.chkInativo.AutoSize = true;
            this.chkInativo.Location = new System.Drawing.Point(359, 80);
            this.chkInativo.Name = "chkInativo";
            this.chkInativo.Size = new System.Drawing.Size(58, 17);
            this.chkInativo.TabIndex = 20;
            this.chkInativo.Text = "Inativo";
            this.chkInativo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Id";
            // 
            // txtID
            // 
            this.txtID.AccessibleDescription = "Id";
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(15, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 20);
            this.txtID.TabIndex = 18;
            //this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntExcluir.Image = global::WindowsFormsApplication1.Properties.Resources.database_error;
            this.bntExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntExcluir.Location = new System.Drawing.Point(723, 88);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(80, 30);
            this.bntExcluir.TabIndex = 6;
            this.bntExcluir.Text = "I&nativar";
            this.bntExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCancelar.Enabled = false;
            this.bntCancelar.Image = global::WindowsFormsApplication1.Properties.Resources.cancel;
            this.bntCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntCancelar.Location = new System.Drawing.Point(809, 88);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(80, 30);
            this.bntCancelar.TabIndex = 7;
            this.bntCancelar.Text = "&Cancelar";
            this.bntCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // rbtAuxiliarAdm
            // 
            this.rbtAuxiliarAdm.AutoSize = true;
            this.rbtAuxiliarAdm.Location = new System.Drawing.Point(75, 80);
            this.rbtAuxiliarAdm.Name = "rbtAuxiliarAdm";
            this.rbtAuxiliarAdm.Size = new System.Drawing.Size(90, 17);
            this.rbtAuxiliarAdm.TabIndex = 2;
            this.rbtAuxiliarAdm.TabStop = true;
            this.rbtAuxiliarAdm.Text = "Administrativo";
            this.rbtAuxiliarAdm.UseVisualStyleBackColor = true;
            // 
            // bntSalvar
            // 
            this.bntSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSalvar.Enabled = false;
            this.bntSalvar.Image = global::WindowsFormsApplication1.Properties.Resources.accept;
            this.bntSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSalvar.Location = new System.Drawing.Point(637, 88);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(80, 30);
            this.bntSalvar.TabIndex = 5;
            this.bntSalvar.Text = "S&alvar";
            this.bntSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // rbtConsultor
            // 
            this.rbtConsultor.AutoSize = true;
            this.rbtConsultor.Location = new System.Drawing.Point(171, 80);
            this.rbtConsultor.Name = "rbtConsultor";
            this.rbtConsultor.Size = new System.Drawing.Size(69, 17);
            this.rbtConsultor.TabIndex = 1;
            this.rbtConsultor.TabStop = true;
            this.rbtConsultor.Text = "Consultor";
            this.rbtConsultor.UseVisualStyleBackColor = true;
            // 
            // rbtAdministrador
            // 
            this.rbtAdministrador.AutoSize = true;
            this.rbtAdministrador.Location = new System.Drawing.Point(12, 80);
            this.rbtAdministrador.Name = "rbtAdministrador";
            this.rbtAdministrador.Size = new System.Drawing.Size(57, 17);
            this.rbtAdministrador.TabIndex = 0;
            this.rbtAdministrador.TabStop = true;
            this.rbtAdministrador.Text = "Master";
            this.rbtAdministrador.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleDescription = "E-mail";
            this.txtEmail.AccessibleName = "";
            this.txtEmail.Location = new System.Drawing.Point(261, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.US_ID,
            this.US_NOME,
            this.email,
            this.login,
            this.perfil,
            this.cadastro,
            this.senha,
            this.inativo});
            this.dgvUsuarios.Location = new System.Drawing.Point(24, 265);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(909, 382);
            this.dgvUsuarios.TabIndex = 13;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick_1);
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            //this.dgvUsuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsuarios_CellMouseClick);
            // 
            // US_ID
            // 
            this.US_ID.DataPropertyName = "US_ID";
            this.US_ID.Frozen = true;
            this.US_ID.HeaderText = "Id";
            this.US_ID.Name = "US_ID";
            this.US_ID.ReadOnly = true;
            this.US_ID.Width = 30;
            // 
            // US_NOME
            // 
            this.US_NOME.DataPropertyName = "US_NOME";
            this.US_NOME.Frozen = true;
            this.US_NOME.HeaderText = "Nome do Funcionário";
            this.US_NOME.Name = "US_NOME";
            this.US_NOME.ReadOnly = true;
            this.US_NOME.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "US_EMAIL";
            this.email.Frozen = true;
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // login
            // 
            this.login.DataPropertyName = "US_LOGIN";
            this.login.Frozen = true;
            this.login.HeaderText = "Usuario";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Width = 150;
            // 
            // perfil
            // 
            this.perfil.DataPropertyName = "US_PERFIL";
            this.perfil.Frozen = true;
            this.perfil.HeaderText = "Perfil";
            this.perfil.Name = "perfil";
            this.perfil.ReadOnly = true;
            this.perfil.Width = 150;
            // 
            // cadastro
            // 
            this.cadastro.DataPropertyName = "US_CADASTRO";
            this.cadastro.Frozen = true;
            this.cadastro.HeaderText = "Cadastro";
            this.cadastro.Name = "cadastro";
            this.cadastro.ReadOnly = true;
            this.cadastro.Width = 150;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "US_SENHA";
            this.senha.Frozen = true;
            this.senha.HeaderText = "senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Visible = false;
            // 
            // inativo
            // 
            this.inativo.DataPropertyName = "US_INATIVO";
            this.inativo.HeaderText = "inativo";
            this.inativo.Name = "inativo";
            this.inativo.ReadOnly = true;
            this.inativo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesq);
            this.groupBox1.Controls.Add(this.chkQualquerParte);
            this.groupBox1.Controls.Add(this.bntLimparPesquisa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkPesqInativos);
            this.groupBox1.Controls.Add(this.txtUsuarioPesquisar);
            this.groupBox1.Controls.Add(this.txtNomePesquisar);
            this.groupBox1.Location = new System.Drawing.Point(24, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 66);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // btnPesq
            // 
            this.btnPesq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesq.Image = global::WindowsFormsApplication1.Properties.Resources.zoom;
            this.btnPesq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesq.Location = new System.Drawing.Point(723, 26);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(80, 30);
            this.btnPesq.TabIndex = 27;
            this.btnPesq.Text = "&Pesquisar";
            this.btnPesq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesquisar2_Click);
            // 
            // chkQualquerParte
            // 
            this.chkQualquerParte.AutoSize = true;
            this.chkQualquerParte.Location = new System.Drawing.Point(330, 18);
            this.chkQualquerParte.Name = "chkQualquerParte";
            this.chkQualquerParte.Size = new System.Drawing.Size(146, 17);
            this.chkQualquerParte.TabIndex = 26;
            this.chkQualquerParte.Text = "&Qualquer parte do campo";
            this.chkQualquerParte.UseVisualStyleBackColor = true;
            this.chkQualquerParte.Visible = false;
            // 
            // bntLimparPesquisa
            // 
            this.bntLimparPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLimparPesquisa.Image = global::WindowsFormsApplication1.Properties.Resources.eraser_icon_icons3;
            this.bntLimparPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLimparPesquisa.Location = new System.Drawing.Point(809, 26);
            this.bntLimparPesquisa.Name = "bntLimparPesquisa";
            this.bntLimparPesquisa.Size = new System.Drawing.Size(80, 30);
            this.bntLimparPesquisa.TabIndex = 25;
            this.bntLimparPesquisa.Text = "&Limpar";
            this.bntLimparPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntLimparPesquisa.UseVisualStyleBackColor = true;
            this.bntLimparPesquisa.Click += new System.EventHandler(this.bntLimparPesquisa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Usuário";
            // 
            // chkPesqInativos
            // 
            this.chkPesqInativos.AutoSize = true;
            this.chkPesqInativos.Location = new System.Drawing.Point(330, 42);
            this.chkPesqInativos.Name = "chkPesqInativos";
            this.chkPesqInativos.Size = new System.Drawing.Size(63, 17);
            this.chkPesqInativos.TabIndex = 19;
            this.chkPesqInativos.Text = "Ina&tivos";
            this.chkPesqInativos.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioPesquisar
            // 
            this.txtUsuarioPesquisar.Location = new System.Drawing.Point(125, 39);
            this.txtUsuarioPesquisar.Name = "txtUsuarioPesquisar";
            this.txtUsuarioPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioPesquisar.TabIndex = 1;
            // 
            // txtNomePesquisar
            // 
            this.txtNomePesquisar.Location = new System.Drawing.Point(125, 16);
            this.txtNomePesquisar.Name = "txtNomePesquisar";
            this.txtNomePesquisar.Size = new System.Drawing.Size(199, 20);
            this.txtNomePesquisar.TabIndex = 0;
            this.txtNomePesquisar.TextChanged += new System.EventHandler(this.txtNomePesquisar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 650);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(462, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Para alterar ou excluir um cadastro, dê um duplo clique sobre o registro para hab" +
    "ilitar a alteração.\r\n";
            // 
            // bntSair
            // 
            this.bntSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSair.Image = global::WindowsFormsApplication1.Properties.Resources.door_out;
            this.bntSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSair.Location = new System.Drawing.Point(853, 12);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(80, 30);
            this.bntSair.TabIndex = 1;
            this.bntSair.Text = "&Sair";
            this.bntSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntIncluir
            // 
            this.bntIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntIncluir.Image = global::WindowsFormsApplication1.Properties.Resources.add;
            this.bntIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntIncluir.Location = new System.Drawing.Point(24, 12);
            this.bntIncluir.Name = "bntIncluir";
            this.bntIncluir.Size = new System.Drawing.Size(80, 30);
            this.bntIncluir.TabIndex = 0;
            this.bntIncluir.Text = "&Incluir";
            this.bntIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntIncluir.UseVisualStyleBackColor = true;
            this.bntIncluir.Click += new System.EventHandler(this.bntIncluir_Click);
            // 
            // formOperadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntIncluir);
            this.Controls.Add(this.gbxPerfil);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formOperadores";
            this.Text = "Cadastro de Funcionários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formOperadores_Load);
            this.gbxPerfil.ResumeLayout(false);
            this.gbxPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntIncluir;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxPerfil;
        private System.Windows.Forms.RadioButton rbtAuxiliarAdm;
        private System.Windows.Forms.RadioButton rbtConsultor;
        private System.Windows.Forms.RadioButton rbtAdministrador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkInativo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkQualquerParte;
        private System.Windows.Forms.Button bntLimparPesquisa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkPesqInativos;
        private System.Windows.Forms.TextBox txtUsuarioPesquisar;
        private System.Windows.Forms.TextBox txtNomePesquisar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn US_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn US_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn inativo;
    }
}