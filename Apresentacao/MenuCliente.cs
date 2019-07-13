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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void BtCadastrar_Click(object sender, EventArgs e)
        {
            FormCadCli cadCli = new FormCadCli();
            cadCli.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesquisaCli pesquisaCli = new PesquisaCli();
            pesquisaCli.Show();
        }
    }
}
