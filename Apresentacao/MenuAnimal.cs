using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class MenuAnimal : Form
    {
        public MenuAnimal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesquisaAnimal pesquisaAnimal = new PesquisaAnimal();
            pesquisaAnimal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadAnimal cadAnimal = new FormCadAnimal("");
            cadAnimal.Show();
        }
    }
}
