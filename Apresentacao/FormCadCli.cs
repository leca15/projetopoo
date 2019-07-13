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
    public partial class FormCadCli : Form
    {
        string cpf;
        
        public FormCadCli()
        {
            InitializeComponent();
        }

        private ClienteServiço clienteServico = new ClienteServiço();
     

        private void FormCadCli_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtCadCli_Click(object sender, EventArgs e)
        {
            this.cpf = mksCPFCLi.Text;
            try
            {

                clienteServico.GravarCliente(
                    new Modelo.Cliente()
                    {
                        NomeCli = TbCadCliNome.Text,
                        CPFCli = mksCPFCLi.Text,
                        ContatoCli = mksContCLI.Text,
                        EndereçoCli = TbCadCliEnd.Text,
                        CidadeCli = TbCadCliCity.Text,
                        EmailCli = textBox1.Text,
                    });
                TbCadCliNome.Clear();
                //mksCPFCLi.Clear();
                mksContCLI.Clear();
                TbCadCliEnd.Clear();
                TbCadCliCity.Clear();
                textBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        public void PopularControles(string cod, string nome, string cpfc, string contato, string ende, string cidade)
        {
            Cliente cliente = new Cliente()
            {
                ClienteID = Convert.ToInt64(cod),
                NomeCli = nome,
                CPFCli = cpfc,
                ContatoCli = contato,
                EndereçoCli = ende,
                CidadeCli = cidade
            };
        }
        

        private void LimparControles()
        {
            TbCadCliNome.Clear();
            mksCPFCLi.Clear();
            mksContCLI.Clear();
            TbCadCliEnd.Clear();
            TbCadCliCity.Clear();
        }

        private void butcadAnimal_Click(object sender, EventArgs e)
        {
            //chamar o form animal, passando o CPF
            
            try
            {   
                    FormCadAnimal formCadAnimal = new FormCadAnimal(mksCPFCLi.Text);
                    formCadAnimal.Show();   
            }
            catch
            {
                MessageBox.Show("Porfavor preencha todos os campos");
            }

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}

/*FAZER A PARTE DE PESQUISA DA SEGUINTE FORMA
    - PESQUISAR POR CPF (VAI MOSTRAR TODOS OS DADOS DO CLIENTE E AS OPÇÕES DE: 1-VER LISTA DE ANIMAIS(PESQUISA POR ID) 
                                                                               2- VER HISTORICO DE CONSULTA)
                                                                                
*/