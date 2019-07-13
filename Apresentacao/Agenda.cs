using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Servico;

namespace Apresentacao
{
    public partial class Agenda : Form
    {
        ConsultaServiço consultaServiço = new ConsultaServiço();

        public Agenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvAgenda.DataSource = consultaServiço.BuscarPorData(Calendario.SelectionStart, Calendario.SelectionEnd);
            txtinicio.Text = Convert.ToString(Calendario.SelectionStart);
            txttermino.Text = Convert.ToString(Calendario.SelectionEnd);
        }

        private void Agenda_Load(object sender, EventArgs e)
        {

        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txtinicio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
