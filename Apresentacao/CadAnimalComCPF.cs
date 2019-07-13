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
    public partial class CadAnimalComCPF : Form
    {
        private AnimalServico animalServico = new AnimalServico();
        public CadAnimalComCPF()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void CadAnimalComCPF_Load(object sender, EventArgs e)
        {

        }
        private void RefreshDataGridView()
        {
            dgvCadAniAvulso.DataSource = animalServico.TodosOsAnimais();
        }

        private void btCadAniAvulso_Click(object sender, EventArgs e)
        {
            animalServico.GravarAnimal(
                new Modelo.Animal()
                {
                    CliCPF = txtCPFdonoCadAvuAnimal.Text,
                    NomePet = txtNomeAniCadAvul.Text,
                    Porte = txtPorteAniCadAvul.Text,
                    Raça = txtRaçaCadAniAvul.Text
                });
            txtCPFdonoCadAvuAnimal.Clear();
            txtNomeAniCadAvul.Clear();
            txtPorteAniCadAvul.Clear();
            txtRaçaCadAniAvul.Clear();
            RefreshDataGridView();
        }
    }
}
