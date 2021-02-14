namespace WindowsFormsApplication1
{
    partial class FormCadastroCliente
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
            this.bntConsultar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.gbPesquisar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bntPesquisar = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntIncluir
            // 
            this.bntIncluir.Location = new System.Drawing.Point(12, 12);
            this.bntIncluir.Name = "bntIncluir";
            this.bntIncluir.Size = new System.Drawing.Size(75, 23);
            this.bntIncluir.TabIndex = 0;
            this.bntIncluir.Text = "Incluir";
            this.bntIncluir.UseVisualStyleBackColor = true;
            this.bntIncluir.Click += new System.EventHandler(this.bntIncluir_Click);
            // 
            // bntAlterar
            // 
            this.bntAlterar.Location = new System.Drawing.Point(93, 12);
            this.bntAlterar.Name = "bntAlterar";
            this.bntAlterar.Size = new System.Drawing.Size(75, 23);
            this.bntAlterar.TabIndex = 1;
            this.bntAlterar.Text = "Alterar";
            this.bntAlterar.UseVisualStyleBackColor = true;
            // 
            // bntConsultar
            // 
            this.bntConsultar.Location = new System.Drawing.Point(174, 12);
            this.bntConsultar.Name = "bntConsultar";
            this.bntConsultar.Size = new System.Drawing.Size(75, 23);
            this.bntConsultar.TabIndex = 2;
            this.bntConsultar.Text = "Consultar";
            this.bntConsultar.UseVisualStyleBackColor = true;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(255, 12);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 3;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // gbPesquisar
            // 
            this.gbPesquisar.Controls.Add(this.label1);
            this.gbPesquisar.Controls.Add(this.textBox1);
            this.gbPesquisar.Location = new System.Drawing.Point(14, 50);
            this.gbPesquisar.Name = "gbPesquisar";
            this.gbPesquisar.Size = new System.Drawing.Size(972, 83);
            this.gbPesquisar.TabIndex = 4;
            this.gbPesquisar.TabStop = false;
            this.gbPesquisar.Text = "Filtros de pesquisa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 0;
            // 
            // bntPesquisar
            // 
            this.bntPesquisar.Location = new System.Drawing.Point(911, 21);
            this.bntPesquisar.Name = "bntPesquisar";
            this.bntPesquisar.Size = new System.Drawing.Size(75, 23);
            this.bntPesquisar.TabIndex = 0;
            this.bntPesquisar.Text = "Pesquisar";
            this.bntPesquisar.UseVisualStyleBackColor = true;
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(830, 21);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 5;
            this.bntLimpar.Text = "Limpar Filtros";
            this.bntLimpar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(973, 391);
            this.dataGridView1.TabIndex = 6;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntPesquisar);
            this.Controls.Add(this.gbPesquisar);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntConsultar);
            this.Controls.Add(this.bntAlterar);
            this.Controls.Add(this.bntIncluir);
            this.Name = "FormCadastroCliente";
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.gbPesquisar.ResumeLayout(false);
            this.gbPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntIncluir;
        private System.Windows.Forms.Button bntAlterar;
        private System.Windows.Forms.Button bntConsultar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.GroupBox gbPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bntPesquisar;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}