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
    public partial class FormCadAnimal : Form
    {
        string cpfcli { get; set; }
        string neces { get; set; }

        public FormCadAnimal(string cpf)
        {
            this.cpfcli = cpf;
            InitializeComponent();
            mksCpf.Text = cpfcli;
        }

        private void FormCadAnimal_Load(object sender, EventArgs e)
        {

        }
        private AnimalServico animalServico = new AnimalServico();

        private void radioSim_CheckedChanged(object sender, EventArgs e)
        {
            neces = "Sim";
        }

        private void radioNao_CheckedChanged(object sender, EventArgs e)
        {
            neces = "Não";
        }

        private void btCadAnimal_Click(object sender, EventArgs e)
        {
            
            try
            {
                animalServico.GravarAnimal(
                    new Modelo.Animal()
                    {
                        //CliCPF = Convert.ToString(this.cpfcli),
                        CliCPF = Convert.ToString(mksCpf.Text),
                        NomePet = txtNomeAnimal.Text,
                        Raça = txtRacaAnimal.Text,
                        Porte = txtPorteAnimal.Text,
                        IdadePet = textBox1.Text,
                        NecesPet = neces,

                    });
            }
            catch
            {
                MessageBox.Show("Por favor preencha todos os campos");
            }
            mksCpf.Clear();
            txtNomeAnimal.Clear();
            txtPorteAnimal.Clear();
            txtRacaAnimal.Clear();
            textBox1.Clear();
            radioSim.Checked = false;
            radioNao.Checked = false;
            
        }

        public void PopularControlesAnimal(string cod, string nome, string porte, string raca)
        {
            Animal animal = new Animal()
            {
                AnimalID = Convert.ToInt64(cod),
                NomePet = nome,
                Raça = raca,
                Porte = porte,
            };
        }

        private void dgvCadAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int cont = dgvCadAnimal.CurrentRow.Index;
            //txtNomeAnimal.Text = Convert.ToString(dgvCadAnimal["NomePet", cont].Value);
            //txtRacaAnimal.Text = Convert.ToString(dgvCadAnimal["Raça", cont].Value);
            //txtPorteAnimal.Text = Convert.ToString(dgvCadAnimal["Porte", cont].Value);
            //txtIdAnimal.Text = Convert.ToString(dgvCadAnimal["AnimalID", cont].Value);
            //PopularControlesAnimal(txtIdAnimal.Text, txtNomeAnimal.Text, txtPorteAnimal.Text, txtRacaAnimal.Text);


        }

        private void BtAtualizaAnimal_Click(object sender, EventArgs e)
        {
            //animalServico.GravarAnimal(
            //   new Animal()
            //   {
            //       AnimalID = (txtIdAnimal.Text.Trim() == string.Empty) ? 0 : Convert.ToInt32(txtIdAnimal.Text),
            //       NomePet = txtNomeAnimal.Text,
            //       Raça = txtRacaAnimal.Text,
            //       Porte = txtPorteAnimal.Text,
            //   });
            //txtIdAnimal.Text = string.Empty;
            //txtRacaAnimal.Clear();
            //txtPorteAnimal.Clear();
            //txtNomeAnimal.Clear();
            //RefreshDataGridView();
        }

        //private void LimparControles()
        //{
        //    txtIdAnimal.Text = string.Empty;
        //    txtNomeAnimal.Clear();
        //    txtPorteAnimal.Clear();
        //    txtRacaAnimal.Clear();
        //    RefreshDataGridView();
        //}

        private void BtExcluirAnimal_Click(object sender, EventArgs e)
        {
            //if (txtIdAnimal.Text.Trim() == string.Empty)
            //    MessageBox.Show("Selecione um animal");
            //else
            //{
            //    animalServico.RemoverAnimal(Convert.ToInt64(txtIdAnimal.Text));
            //    LimparControles();
            //}
            //RefreshDataGridView();
        }

        

        private void mksCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
