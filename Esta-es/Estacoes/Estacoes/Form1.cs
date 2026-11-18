using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rad_primeiro_CheckedChanged(object sender, EventArgs e)
        {
            pic_primeiro.Image = Properties.Resources.forza;//Buscando a imagem para a Pic
            txt_primeiro.Text = "UAUUUUUU DEU CERTO!!!!!";//Trazendo o texto dentro do TextBox
        }
    }
}
