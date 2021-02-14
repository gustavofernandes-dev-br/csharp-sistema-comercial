namespace WindowsFormsApplication1
{
    partial class ObservacaoVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObservacaoVisualizar));
            this.txtVisualizarObservacao = new System.Windows.Forms.TextBox();
            this.bntVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisualizarObservacao
            // 
            this.txtVisualizarObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisualizarObservacao.HideSelection = false;
            this.txtVisualizarObservacao.Location = new System.Drawing.Point(13, 13);
            this.txtVisualizarObservacao.Multiline = true;
            this.txtVisualizarObservacao.Name = "txtVisualizarObservacao";
            this.txtVisualizarObservacao.Size = new System.Drawing.Size(626, 237);
            this.txtVisualizarObservacao.TabIndex = 0;
            // 
            // bntVoltar
            // 
            this.bntVoltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bntVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bntVoltar.Image = global::WindowsFormsApplication1.Properties.Resources.cancel;
            this.bntVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntVoltar.Location = new System.Drawing.Point(559, 256);
            this.bntVoltar.Name = "bntVoltar";
            this.bntVoltar.Size = new System.Drawing.Size(80, 30);
            this.bntVoltar.TabIndex = 3;
            this.bntVoltar.Text = "&Voltar";
            this.bntVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntVoltar.UseVisualStyleBackColor = false;
            this.bntVoltar.Click += new System.EventHandler(this.bntVoltar_Click);
            // 
            // ObservacaoVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 298);
            this.Controls.Add(this.bntVoltar);
            this.Controls.Add(this.txtVisualizarObservacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObservacaoVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObservacaoVisualizar";
            this.Load += new System.EventHandler(this.ObservacaoVisualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisualizarObservacao;
        private System.Windows.Forms.Button bntVoltar;
    }
}