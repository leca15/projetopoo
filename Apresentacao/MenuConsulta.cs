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
    public partial class MenuConsulta : Form
    {
        public MenuConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaMarcar consultaMarcar = new ConsultaMarcar();
            consultaMarcar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesqConsulta pesqConsulta = new PesqConsulta();
            pesqConsulta.Show();

            //ConsultasMarcadas consultas = new ConsultasMarcadas();
            //consultas.Show();
        }

        private void btPosConsult_Click(object sender, EventArgs e)
        {
            PesqPós pesqPós = new PesqPós();
            pesqPós.Show();
            // pesqArdCons = new PesqArdCons();
            //pesqArdCons.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
        }

        private void MenuConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
