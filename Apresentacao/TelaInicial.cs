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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void BtCliente_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente();
          
            menuCliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAnimal menuAnimal = new MenuAnimal();
            menuAnimal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuConsulta menuConsulta = new MenuConsulta();
            menuConsulta.Show();
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtdAvulso atdAvulso = new AtdAvulso();
            atdAvulso.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuCaixa menuCaixa = new MenuCaixa();
            menuCaixa.Show();
        }

        private void btExame_Click(object sender, EventArgs e)
        {
            MenuExame menuExame = new MenuExame();
            menuExame.Show();
        }
    }
}
