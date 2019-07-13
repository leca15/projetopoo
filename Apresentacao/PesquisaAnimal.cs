using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servico;
using Modelo;

namespace Apresentacao
{
    public partial class PesquisaAnimal : Form
    {
        long id;
        string nome, raça, porte, idade, necessidade, cpfcli;
        public AnimalServico animalServico = new AnimalServico();

        public PesquisaAnimal()
        {
            InitializeComponent();
        }

        private void PesquisaAnimal_Load(object sender, EventArgs e)
        {

        }

        

        private void btPesqAnimal_Click(object sender, EventArgs e)
        {
            dgvPesqAnimal.DataSource = animalServico.BuscarAnimal(Convert.ToString(mksPesqAniCPF.Text));
        }

        private void dgvPesqAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int cont = dgvPesqAnimal.CurrentRow.Index;
            id = Convert.ToInt64(dgvPesqAnimal["AnimalID", cont].Value);
            nome = Convert.ToString(dgvPesqAnimal["NomePet", cont].Value);
            raça = Convert.ToString(dgvPesqAnimal["Raça", cont].Value);
            porte = Convert.ToString(dgvPesqAnimal["Porte", cont].Value);
            idade = Convert.ToString(dgvPesqAnimal["IdadePet", cont].Value);
            necessidade = Convert.ToString(dgvPesqAnimal["NecesPet", cont].Value);
            cpfcli = Convert.ToString(dgvPesqAnimal["CliCPF", cont].Value);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltExAnimal altExAnimal = new AltExAnimal(id, nome, raça, porte, idade, necessidade, cpfcli);
            altExAnimal.Show();
        }
    }
}
