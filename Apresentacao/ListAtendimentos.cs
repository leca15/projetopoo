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
    public partial class ListAtendimentos : Form
    {
        AtdAvulsoServiço avulsoServiço = new AtdAvulsoServiço();
        public ListAtendimentos()
        {
            InitializeComponent();
            dgvAtendimentos.DataSource = avulsoServiço.TodosOsAtendimentos();
        }

        private void btAtend_Click(object sender, EventArgs e)
        {
            dgvAtendimentos.DataSource = avulsoServiço.BuscarPorData(Calendario.SelectionStart, Calendario.SelectionEnd);
            txtinicio.Text = Convert.ToString(Calendario.SelectionStart);
            txtfim.Text = Convert.ToString(Calendario.SelectionEnd);
        }
    }
}
