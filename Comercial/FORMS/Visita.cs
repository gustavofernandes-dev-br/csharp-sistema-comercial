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
    public partial class FormVisita : Form
    {
        public FormVisita()
        {
            InitializeComponent();
        }

        private void FormVisita_Load(object sender, EventArgs e)
        {
            this.Text = "PDV NET Inteligencia em sistemas - Visita";
            if (System.IO.File.Exists("c:\\COMERCIAL\\imagem\\pdvsuite.ico"))
            {
                Icon icon = Icon.ExtractAssociatedIcon("c:\\COMERCIAL\\imagem\\pdvsuite.ico");
                this.Icon = icon;
            }
        }
    }
}
