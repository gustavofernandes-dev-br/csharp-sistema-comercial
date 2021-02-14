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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("c:\\COMERCIAL\\imagem\\pdvsuite.ico"))
            {
                Icon icon = Icon.ExtractAssociatedIcon("c:\\COMERCIAL\\imagem\\pdvsuite.ico");
                this.Icon = icon;
            }
            //logo
            this.pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.Image = Image.FromFile("c:\\COMERCIAL\\imagem\\logo_uso_geral.jpg");
            this.Text = "PDV NET Inteligencia em sistemas - Tela Principal";
            //propect
            this.pbProspect.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProspect.Image = Image.FromFile("c:\\COMERCIAL\\imagem\\prospeccao.jpg");
           //contato
            this.pbContato.SizeMode = PictureBoxSizeMode.StretchImage;
            pbContato.Image = Image.FromFile("c:\\COMERCIAL\\imagem\\contato.jpeg");
            //visita
            this.pbVisita.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVisita.Image = Image.FromFile("c:\\COMERCIAL\\imagem\\visita.jpg");
            //proposta
            this.pbProposta.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProposta.Image = Image.FromFile("c:\\COMERCIAL\\imagem\\Proposta.png");
            //contrato
            this.pbContrato.SizeMode = PictureBoxSizeMode.StretchImage;
            pbContrato.Image = Image.FromFile("c:\\COMERCIAL\\imagem\\contrato.png");

           
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        
        private void pbVisita_Click(object sender, EventArgs e)
        {
            
            FormVisita formvisita = new FormVisita();
            formvisita.Show();
        }

        private void pbProspect_Click(object sender, EventArgs e)
        {
           
            formProspeccao formprospeccao = new formProspeccao();
            formprospeccao.Show();
        }

        private void pbContato_Click(object sender, EventArgs e)
        {
            
            FormContato formcontato = new FormContato();
            formcontato.Show();
        }

        private void pbProposta_Click(object sender, EventArgs e)
        {
            
            FormProposta formproposta = new FormProposta();
            formproposta.Show();
        }

        private void pbContrato_Click(object sender, EventArgs e)
        {
            
            FormContrato formcontrato = new FormContrato();
            formcontrato.Show();
        }

        private void pbProspect_MouseMove(object sender, MouseEventArgs e)
        {
            pbProspect.SizeMode = PictureBoxSizeMode.Zoom;
            pbProspect.Cursor = Cursors.Hand;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formClientes = new FormCadastroCliente();
            formClientes.Show();
        }

       
    }
}
