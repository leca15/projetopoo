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
    public partial class AltExAnimal : Form
    {
        AnimalServico animalServico = new AnimalServico();
        long id;
        string nome, raça, porte, idade, necessidade, neces, cpf;

        public AltExAnimal(long id, string nome, string raça, string porte, string idade, string necessidade, string cpf)
        {
            this.id = id;
            this.nome = nome;
            this.raça = raça;
            this.porte = porte;
            this.idade = idade;
            this.cpf = cpf;
            this.necessidade = necessidade;

            InitializeComponent();
        }

        public void PopularAlt()
        {
            txtID.Text = Convert.ToString(id);
            txtIdade.Text = idade;
            txtNomeAnimal.Text = nome;
            txtPorteAnimal.Text = porte;
            txtRacaAnimal.Text = raça;
            maskedTextBox1.Text = cpf;
        }

        private void radioSim_CheckedChanged(object sender, EventArgs e)
        {
            neces = "Sim";
        }

        private void radioNao_CheckedChanged(object sender, EventArgs e)
        {
            neces = "Não";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //EXCLUIR
            animalServico.RemoverAnimal(id);
            nomEx.Clear();
            RaçaEX.Clear();
            portEX.Clear();
            idadEX.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ATUALIZAR

            try
            {

                animalServico.GravarAnimal(
                     new Animal()
                     {
                         AnimalID = (txtID.Text.Trim() == string.Empty) ? 0 : Convert.ToInt32(txtID.Text),
                         NomePet = txtNomeAnimal.Text,
                         Raça = txtRacaAnimal.Text,
                         Porte = txtPorteAnimal.Text,
                         IdadePet = txtIdade.Text,
                         NecesPet = neces,
                         CliCPF = cpf,
                     });
                txtID.Text = string.Empty;
                txtNomeAnimal.Clear();
                txtRacaAnimal.Clear();
                txtPorteAnimal.Clear();
                txtIdade.Clear();
                maskedTextBox1.Clear();
                radioNao.Checked = false;
                radioSim.Checked = false;
            }
            catch
            {
                MessageBox.Show("Não foi possivel atualizar o animal selecionado");
            }
        }

        

        public void PopularEx()
        {
            nomEx.Text = nome;
            portEX.Text = porte;
            RaçaEX.Text = raça;
            idadEX.Text = idade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopularAlt();
            groupAltAnimal.Visible = true;
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopularEx();
            panel1.Visible = true;
            groupAltAnimal.Visible = false;
        }

        private void AltExAnimal_Load(object sender, EventArgs e)
        {

        }
    }
}
