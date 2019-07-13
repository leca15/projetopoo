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
    public partial class AgendaExames : Form
    {
        ExameServiço exameServiço = new ExameServiço();


        public AgendaExames()
        {
            InitializeComponent();
        }

        private void btAgendaExame_Click(object sender, EventArgs e)
        {
            dgvAgendaExame.DataSource = exameServiço.BuscarPorData(calendario.SelectionStart, calendario.SelectionEnd);
        }
    }
}
