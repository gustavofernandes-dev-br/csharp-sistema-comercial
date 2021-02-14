using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ObservacaoVisualizar : Form
    {
        public ObservacaoVisualizar()
        {
            InitializeComponent();
        }

        private void bntVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Visualizar(string mensagem)
        {
            // txtVisualizarObservacao.AppendText(System.Environment.NewLine + mensagem);
            txtVisualizarObservacao.Text = mensagem;
        }

        private void ObservacaoVisualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
