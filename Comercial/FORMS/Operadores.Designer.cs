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
            this.bntIncluir = new System.Windows.Forms.Button();
            this.bntAlterar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxPerfil = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtAuxiliarAdm = new System.Windows.Forms.RadioButton();
            this.cmbConsultor = new System.Windows.Forms.ComboBox();
            this.rbtConsultor = new System.Windows.Forms.RadioButton();
            this.rbtAdministrador = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntLocalizarTodos = new System.Windows.Forms.Button();
            this.gbxPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // bntIncluir
            // 
            this.bntIncluir.Location = new System.Drawing.Point(24, 12);
            this.bntIncluir.Name = "bntIncluir";
            this.bntIncluir.Size = new System.Drawing.Size(75, 23);
            this.bntIncluir.TabIndex = 7;
            this.bntIncluir.Text = "Incluir";
            this.bntIncluir.UseVisualStyleBackColor = true;
            this.bntIncluir.Click += new System.EventHandler(this.bntIncluir_Click);
            // 
            // bntAlterar
            // 
            this.bntAlterar.Location = new System.Drawing.Point(105, 12);
            this.bntAlterar.Name = "bntAlterar";
            this.bntAlterar.Size = new System.Drawing.Size(75, 23);
            this.bntAlterar.TabIndex = 10;
            this.bntAlterar.Text = "Alterar";
            this.bntAlterar.UseVisualStyleBackColor = true;
            // 
            // bntExcluir
            // 
            this.bntExcluir.Location = new System.Drawing.Point(187, 13);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(75, 23);
            this.bntExcluir.TabIndex = 11;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(716, 13);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 12;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(163, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(122, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(163, 71);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(122, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(309, 71);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(121, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário (login)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // gbxPerfil
            // 
            this.gbxPerfil.Controls.Add(this.label5);
            this.gbxPerfil.Controls.Add(this.rbtAuxiliarAdm);
            this.gbxPerfil.Controls.Add(this.cmbConsultor);
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
            this.gbxPerfil.Location = new System.Drawing.Point(24, 42);
            this.gbxPerfil.Name = "gbxPerfil";
            this.gbxPerfil.Size = new System.Drawing.Size(767, 104);
            this.gbxPerfil.TabIndex = 4;
            this.gbxPerfil.TabStop = false;
            this.gbxPerfil.Text = "Perfil";
            this.gbxPerfil.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Consultor";
            // 
            // rbtAuxiliarAdm
            // 
            this.rbtAuxiliarAdm.AutoSize = true;
            this.rbtAuxiliarAdm.Location = new System.Drawing.Point(12, 40);
            this.rbtAuxiliarAdm.Name = "rbtAuxiliarAdm";
            this.rbtAuxiliarAdm.Size = new System.Drawing.Size(111, 17);
            this.rbtAuxiliarAdm.TabIndex = 2;
            this.rbtAuxiliarAdm.TabStop = true;
            this.rbtAuxiliarAdm.Text = "Aux.Administrativo";
            this.rbtAuxiliarAdm.UseVisualStyleBackColor = true;
            // 
            // cmbConsultor
            // 
            this.cmbConsultor.FormattingEnabled = true;
            this.cmbConsultor.Location = new System.Drawing.Point(309, 29);
            this.cmbConsultor.Name = "cmbConsultor";
            this.cmbConsultor.Size = new System.Drawing.Size(121, 21);
            this.cmbConsultor.TabIndex = 13;
            this.cmbConsultor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbConsultor_KeyPress);
            // 
            // rbtConsultor
            // 
            this.rbtConsultor.AutoSize = true;
            this.rbtConsultor.Location = new System.Drawing.Point(12, 63);
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
            this.rbtAdministrador.Location = new System.Drawing.Point(12, 19);
            this.rbtAdministrador.Name = "rbtAdministrador";
            this.rbtAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rbtAdministrador.TabIndex = 0;
            this.rbtAdministrador.TabStop = true;
            this.rbtAdministrador.Text = "Administrador";
            this.rbtAdministrador.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(441, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Consultor,
            this.nome,
            this.Usuario,
            this.Perfil,
            this.Email});
            this.dgvUsuarios.Location = new System.Drawing.Point(24, 195);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(713, 452);
            this.dgvUsuarios.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // Consultor
            // 
            this.Consultor.HeaderText = "Consultor";
            this.Consultor.Name = "Consultor";
            this.Consultor.Width = 120;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 120;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            // 
            // Perfil
            // 
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // bntLocalizarTodos
            // 
            this.bntLocalizarTodos.Location = new System.Drawing.Point(24, 166);
            this.bntLocalizarTodos.Name = "bntLocalizarTodos";
            this.bntLocalizarTodos.Size = new System.Drawing.Size(100, 23);
            this.bntLocalizarTodos.TabIndex = 14;
            this.bntLocalizarTodos.Text = "Localizar Todos";
            this.bntLocalizarTodos.UseVisualStyleBackColor = true;
            this.bntLocalizarTodos.Click += new System.EventHandler(this.bntLocalizarTodos_Click);
            // 
            // formOperadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.bntLocalizarTodos);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntAlterar);
            this.Controls.Add(this.bntIncluir);
            this.Controls.Add(this.gbxPerfil);
            this.Name = "formOperadores";
            this.Text = "Operadores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formOperadores_Load);
            this.gbxPerfil.ResumeLayout(false);
            this.gbxPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntIncluir;
        private System.Windows.Forms.Button bntAlterar;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtAuxiliarAdm;
        private System.Windows.Forms.ComboBox cmbConsultor;
        private System.Windows.Forms.RadioButton rbtConsultor;
        private System.Windows.Forms.RadioButton rbtAdministrador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button bntLocalizarTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}