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
    public partial class MarcarExame : Form
    {
        ExameServiço exameServiço = new ExameServiço();
        CaixaServiço caixaServiço = new CaixaServiço();
        bool status;
        string NomeExame;

        public MarcarExame()
        {
            InitializeComponent();
        }

        private void MarcarExame_Load(object sender, EventArgs e)
        {

        }

        public void Limpar()
        {
            txtNomeDono.Clear();
            txtNomePet.Clear();
            txtValor.Clear();
            mksContato.Clear();
            mksCPF.Clear();
            mksDataReali.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }


        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            status = true;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            status = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            NomeExame = "Hemograma";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            NomeExame = "Sanguíneo";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            NomeExame = "Fezes/Urina";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            NomeExame = "Eletrocardiograma";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            NomeExame = "Check-Up";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            NomeExame = "Ultrassonografia";
        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {

                exameServiço.MarcarExame(
                    new Exame()
                    {
                        NomeEx = NomeExame,
                        NomeAnimal = txtNomePet.Text,
                        NomeDono = txtNomeDono.Text,
                        CPFDono = mksCPF.Text,
                        Contato = mksContato.Text,
                        DataRealizacao = Convert.ToDateTime(mksDataReali.Text),
                        ValorEx = Convert.ToDouble(txtValor.Text),
                        Status = status
                    });

                caixaServiço.InserirRegistro(
                    new Modelo.Caixa()
                    {
                        CPFCliente = mksCPF.Text,
                        DataCons = Convert.ToDateTime(mksDataReali.Text),
                        ValorCons = Convert.ToDouble(txtValor.Text),
                        Status = status,
                        Procedencia = "Exame"
                    });

                }
                catch
                {
                MessageBox.Show("Erro ao marcar exame");
                }
            Limpar();
        }

        
    }
}
