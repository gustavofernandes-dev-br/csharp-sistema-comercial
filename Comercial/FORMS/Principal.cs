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
    public partial class btnTrocarUsuario : Form
    {

        CLASSES.Versao versao = new CLASSES.Versao();
        public btnTrocarUsuario()
        {
            InitializeComponent();
            this.Text = this.Text + versao.Data();
            lblUsuario.Text = UsuarioLogado.usuario.nome;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                       
        }

           
        

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroClientes1 formClientes = new CadastroClientes1();
            formClientes.Show();

            
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOperadores formoperadores = new formOperadores();
            formoperadores.Show();
            
        }



        private void bntContato_Click(object sender, EventArgs e)
        {

            FormContato formcontato = new FormContato();
            formcontato.Show();
        }

        private void bntVisita_Click(object sender, EventArgs e)
        {
            FormVisita formvisita = new FormVisita();
            formvisita.Show();
        }

        private void bntProposta_Click(object sender, EventArgs e)
        {
            FormProposta formproposta = new FormProposta();
            formproposta.Show();
        }

        private void bntContrato_Click(object sender, EventArgs e)
        {
            FormContrato formcontrato = new FormContrato();
            formcontrato.Show();
        }

        private void bntProspeccao_Click(object sender, EventArgs e)
        {
            formProspeccao formprospeccao = new formProspeccao();
            formprospeccao.ShowDialog();
        }

        private void bntClientes_Click(object sender, EventArgs e)
        {
            CadastroClientes1 formClientes = new CadastroClientes1();
            formClientes.Show();
        }

       
        private void bntSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ramoDeAtuaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRamoAtuacao ramo = new formRamoAtuacao();
            ramo.Show();
        }

        private void consultorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Indicacao indica = new Indicacao();
            indica.Show();
        }

        private void concorrrentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Concorrente concorr = new Concorrente();
            concorr.Show();
        }

        private void meioDeProspecçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            meioDeProspeccao meio = new meioDeProspeccao();
            meio.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
           string perfil = UsuarioLogado.usuario.perfil.ToString();

            if(perfil.Trim() == "1")
                perfil = "Master";
            else if (perfil.Trim() == "2")
                perfil = "Administrativo";
            else 
                perfil = "Consultor";


            MessageBox.Show( "Id: " + UsuarioLogado.usuario.id.ToString() + "\n" +   
                             "Usuário: " + UsuarioLogado.usuario.usuario.ToString() + "\n" +
                             "Perfil: " + perfil + "\n" +
                            "Cadastrado em: " +  UsuarioLogado.usuario.cadastro.ToString() + "\n"
                             ,"Dados do Usuário"
                             );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();

            frmLogin.ShowDialog();

            this.Show();


        }

     

      

       
    }
}
