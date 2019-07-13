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
    public partial class PesqArdCons : Form
    {
        RegistrarAtdConServiço RegAtdCons = new RegistrarAtdConServiço();
        ConsultaServiço consultaServiço = new ConsultaServiço();
        CaixaServiço caixaServiço = new CaixaServiço();


        bool valor;
        long id;
        string nomedono, cpf, contato, nomepet, raça, porte, data, hora;

        public PesqArdCons(long id, string nomedono, string cpf, string contato, string nomepet, string raça, string porte, string data, string hora)
        {
            this.id = id;
            this.nomedono = nomedono;
            this.cpf = cpf;
            this.contato = contato;
            this.nomepet = nomepet;
            this.raça = raça;
            this.porte = porte;
            this.data = data;
            this.hora = hora;
            InitializeComponent();
            Popular();
        }
        
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            //dgvDonos.DataSource = consultaServiço.BuscarConsulta(txtcpfDono.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtValorMed_TextChanged(object sender, EventArgs e)
        {

        }

        //private void dgvDonos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        
        //}

        public void Popular()
        {
            txtId.Text = Convert.ToString(id);
            txtNomeDono.Text = Convert.ToString(nomedono);
            mksCPF.Text = Convert.ToString(cpf);
            mksContato.Text = Convert.ToString(contato);
            txtNomePet.Text = Convert.ToString(nomepet);
            maskedTextBox1.Text = Convert.ToString(data);
            mksHoraCons.Text = Convert.ToString(hora);
            txtPortePet.Text = Convert.ToString(porte);
            txtRaçaPet.Text = Convert.ToString(raça);
        }

        private void LimparTodo()
        {
            txtId.Clear();
            txtNomeDono.Clear();
            mksCPF.Clear();
            mksContato.Clear();
            txtNomePet.Clear();
            txtPortePet.Clear();
            txtRaçaPet.Clear();
            maskedTextBox1.Clear();
            mksHoraCons.Clear();
            DescCons.Clear();
            textBox1.Clear();
        }

        private void PesqArdCons_Load(object sender, EventArgs e)
        {
        }

        private void lbValor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAddMed_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            valor = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            valor = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                RegAtdCons.GravarAtdCons(
                    new RegistrarAtdCons()
                    {
                        ConsultaId = Convert.ToInt64(txtId.Text),
                        NomeResponsavel = txtNomeDono.Text,
                        CPFResponsavel = mksCPF.Text,
                        ContResponsavel = mksContato.Text,
                        NomeAnimal = txtNomePet.Text,
                        Raça = txtRaçaPet.Text,
                        Porte = txtPortePet.Text,
                        DataConsula = Convert.ToDateTime(maskedTextBox1.Text),
                        HoraConsulta = mksHoraCons.Text,
                        DescAtd = DescCons.Text,
                        Receita = richTextBox1.Text,
                        ValorConsulta = Convert.ToDouble(textBox1.Text)


                    });

                
                    caixaServiço.InserirRegistro(
                        new Modelo.Caixa()
                        {
                            CPFCliente = mksCPF.Text,
                            DataCons = Convert.ToDateTime(maskedTextBox1.Text),
                            ValorCons = Convert.ToDouble(textBox1.Text),
                            Status = valor,
                            Procedencia = "Consulta"
                       
                        });


                LimparTodo();
                richTextBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Erro ao finalizar atendimento!");
            }
        }

        private void txtRaçaPet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtxCPFDono_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
