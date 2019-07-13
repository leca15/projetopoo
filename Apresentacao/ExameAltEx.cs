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
    public partial class ExameAltEx : Form
    {
        string NomeExame;
        bool status;

        ExameServiço exameServiço = new ExameServiço();
        CaixaServiço caixaServiço = new CaixaServiço();

        long Id;
        string nomedono, nomepet, cpf, contato, data, nomeEx;
        bool statu;
        double valor;


        public ExameAltEx(long id, string nomedono, string nomepet, string cpf, string contato, string data, string nomeexame, bool situacao, double valor )
        {
            this.Id = id;
            this.nomedono = nomedono;
            this.nomepet = nomepet;
            this.cpf = cpf;
            this.contato = contato;
            this.data = data;
            nomeEx = nomeexame;
            statu = situacao;
            this.valor = valor;

            InitializeComponent();
            gbAlterar.Visible = false;
            gbExcluir.Visible = false;
        }

        private void txtNomeDono_TextChanged(object sender, EventArgs e)
        {

        }

        public void PopularAlt()
        {
            txtID.Text = Convert.ToString(Id);
            txtNomePet.Text = nomepet;
            txtNomeDono.Text = nomedono;
            mksCPF.Text = cpf;
            mksContato.Text = contato;
            mksDataReali.Text = data;
        }

        public void PopularEx()
        {
            textBox1.Text = Convert.ToString(Id);
            txtNomeEX.Text = nomedono;
            txtNomePetEx.Text = nomepet;
            txtNomeExame.Text = nomeEx;
            mksCPFEX.Text = cpf;
            mksDataEx.Text = data;
        }


        private void btAltEx_Click(object sender, EventArgs e)
        {
            PopularAlt();
            gbExcluir.Visible = false;
            gbAlterar.Visible = true;

        }

        private void gbExcluir_Enter(object sender, EventArgs e)
        {

        }

        private void btExcluirEx_Click(object sender, EventArgs e)
        {
            PopularEx();
            gbAlterar.Visible = false;
            gbExcluir.Visible = true;
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

        private void ExameAltEx_Load(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            NomeExame = "Ultrassonografia";
        }

        public void Limpar()
        {
            txtID.Clear();
            txtNomeDono.Clear();
            txtNomePet.Clear();
            mksCPF.Clear();
            mksContato.Clear();
            mksDataReali.Clear();
        }

        public void LimparEx()
        {
            txtNomeEX.Clear();
            txtNomePetEx.Clear();
            txtNomeExame.Clear();
            mksCPFEX.Clear();
            mksDataEx.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ALTERAR

            try
            {
                exameServiço.MarcarExame(
                    new Exame()
                    {
                        ExameID = Id,
                        NomeEx = NomeExame,
                        NomeAnimal = txtNomePet.Text,
                        NomeDono = txtNomeDono.Text,
                        CPFDono = mksCPF.Text,
                        Contato = mksContato.Text,
                        DataRealizacao = Convert.ToDateTime(mksDataReali.Text),
                        Status = status
                    });

                //caixaServiço.InserirRegistro(
                //    new Modelo.Caixa()
                //    {

                //        CPFCliente = mksCPF.Text,
                //        DataCons = Convert.ToDateTime(mksDataReali.Text),
                //        Status = status,
                //        Procedencia = "Exame"
                //    });

            }
            catch
            {
                MessageBox.Show("Erro ao atualizar o exame");
            }
            Limpar();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //EXCLUIR

            if (textBox1.Text.Trim() == string.Empty)
                MessageBox.Show("Selecione uma consulta");
            else
            {
                exameServiço.RemoverExame(Convert.ToInt64(textBox1.Text));
            }

            LimparEx();
        }
    }
}
