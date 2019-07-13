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
    public partial class Caixa : Form
    {
        CaixaServiço caixaServiço = new CaixaServiço();

        public Caixa()
        {
            InitializeComponent();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = caixaServiço.BuscarPorData(Calendario.SelectionStart, Calendario.SelectionEnd);
            dtinicio.Text = Convert.ToString(Calendario.SelectionStart);
            dtfim.Text = Convert.ToString(Calendario.SelectionEnd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = caixaServiço.TodosOsRegistros();
        }
    }
}
