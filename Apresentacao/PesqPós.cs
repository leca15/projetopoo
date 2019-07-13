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
    public partial class PesqPós : Form
    {
        ConsultaServiço consultaServiço = new ConsultaServiço();

        long id;
        string nomedono, cpf, contato, nomepet, raça, porte, data, hora;

        public PesqPós()
        {            
            InitializeComponent();
        }


        private void PesqPós_Load(object sender, EventArgs e)
        {

        }

        private void dgvPesqPós_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvPesqPós.CurrentRow.Index;
            id = Convert.ToInt64(dgvPesqPós["ConsultaID", cont].Value);
            nomedono = Convert.ToString(dgvPesqPós["NomeDono", cont].Value);
            cpf = Convert.ToString(dgvPesqPós["CPFDono", cont].Value);
            contato = Convert.ToString(dgvPesqPós["Contato", cont].Value);
            nomepet = Convert.ToString(dgvPesqPós["NomePet", cont].Value);
            data = Convert.ToString(dgvPesqPós["DataCons", cont].Value);
            hora = Convert.ToString(dgvPesqPós["HoraCons", cont].Value);
            porte = Convert.ToString(dgvPesqPós["PortePet", cont].Value);
            raça = Convert.ToString(dgvPesqPós["RaçaPet", cont].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dgvPesqPós.DataSource = consultaServiço.TodosAsConsultas();
            dgvPesqPós.DataSource =  consultaServiço.BuscarConsulta(mksPesqPós.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesqArdCons pesqArdCons = new PesqArdCons(id, nomedono, cpf, contato, nomepet, raça, porte, data, hora);
            pesqArdCons.Show();
        }
        
    }
}
