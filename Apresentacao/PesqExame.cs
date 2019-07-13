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
    public partial class PesqExame : Form
    {

        ExameServiço exameServiço = new ExameServiço();

        public PesqExame()
        {
            InitializeComponent();
        }

        private void PesqExame_Load(object sender, EventArgs e)
        {

        }

        private void btPesqExame_Click(object sender, EventArgs e)
        {
            dgvPesqEx.DataSource = exameServiço.BuscarExame(mksPesqEx.Text);
        }

        private void opPesqEx_Click(object sender, EventArgs e)
        {
            ExameAltEx exameAltEx = new ExameAltEx(id, nomedono, nomepet, cpf, contato, data, nomeEx, jeito, valor);
            exameAltEx.Show();
        }

        long id;
        string nomedono, nomeEx, cpf, contato, nomepet, data;
        double valor;
        bool jeito;

        private void dgvPesqEx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvPesqEx.CurrentRow.Index;
            id = Convert.ToInt64(dgvPesqEx["ExameID", cont].Value);
            nomedono = Convert.ToString(dgvPesqEx["NomeDono", cont].Value);
            nomeEx = Convert.ToString(dgvPesqEx["NomeEx", cont].Value);
            cpf = Convert.ToString(dgvPesqEx["CPFDono", cont].Value);
            contato = Convert.ToString(dgvPesqEx["Contato", cont].Value);
            nomepet = Convert.ToString(dgvPesqEx["NomeAnimal", cont].Value);
            data = Convert.ToString(dgvPesqEx["DataRealizacao", cont].Value);
            valor = Convert.ToDouble(dgvPesqEx["ValorEx", cont].Value);
            jeito = Convert.ToBoolean(dgvPesqEx["Status", cont].Value);
        }
    }
}
