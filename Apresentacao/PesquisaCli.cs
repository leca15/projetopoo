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
    public partial class PesquisaCli : Form
    {
        public ClienteServiço clienteServiço = new ClienteServiço();

        long id;
        string nome, cpf, email, contato, endereco, cidade, passar;


        public PesquisaCli()
        {
            InitializeComponent();
        }

        private void btPesqCli_Click(object sender, EventArgs e)
        {
            dgvPesqCli.DataSource = clienteServiço.Buscar(Convert.ToString(mksPesqCli.Text));
            passar = mksPesqCli.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HistoricoClli historico = new HistoricoClli(passar);
            historico.Show();

        }

        private void txtPesqCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPesqCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvPesqCli.CurrentRow.Index;

            id = Convert.ToInt64(dgvPesqCli["ClienteID", cont].Value);
            nome = Convert.ToString(dgvPesqCli["NomeCli", cont].Value);
            cpf = Convert.ToString(dgvPesqCli["CPFCli", cont].Value);
            email = Convert.ToString(dgvPesqCli["EmailCli", cont].Value);
            contato = Convert.ToString(dgvPesqCli["ContatoCli", cont].Value);
            endereco = Convert.ToString(dgvPesqCli["EndereçoCli", cont].Value);
            cidade = Convert.ToString(dgvPesqCli["CidadeCli", cont].Value);

        }

        private void PesquisaCli_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadePets listadePets = new ListadePets(id, nome, cpf);
            listadePets.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            AlteExCli alteExCli = new AlteExCli(id, nome, contato, cpf, email, endereco, cidade);
            alteExCli.Show();
            
        }
    }
}
