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
    public partial class ListadePets : Form
    {
        long id;
        string nome;
        string cpf;

        ClienteServiço clienteServiço = new ClienteServiço();
        AnimalServico animalServico = new AnimalServico();



        public ListadePets(long id, string nome, string cpf)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            InitializeComponent();
            Popular();
        }

        public void Popular()
        {
            txtID.Text = Convert.ToString(id);
            txtNomeli.Text = Convert.ToString(nome);
            mksCpf.Text = Convert.ToString(cpf);
        }

        private void ListadePets_Load(object sender, EventArgs e)
        {

        }

        private void btBuscarPets_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = animalServico.BuscarAnimal(mksCpf.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mksCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
