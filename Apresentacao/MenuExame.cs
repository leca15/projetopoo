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
    public partial class MenuExame : Form
    {
        public MenuExame()
        {
            InitializeComponent();
        }

        private void btMarcarExame_Click(object sender, EventArgs e)
        {
            MarcarExame marcarExame = new MarcarExame();
            marcarExame.Show();
        }

        private void btConsultarExame_Click(object sender, EventArgs e)
        {
            PesqExame pesqExame = new PesqExame();
            pesqExame.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgendaExames agendaExames = new AgendaExames();
            agendaExames.Show();
        }
    }
}
