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
    public partial class AtdAvulso : Form
    {
        private AtdAvulsoServiço AtdavulsoServiço = new AtdAvulsoServiço();
        private CaixaServiço CaixaServiço = new CaixaServiço();
        bool valor = true;

        public AtdAvulso()
        {
            InitializeComponent();
            
        }

        
        private void txtNomeProp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAtdAvulso_Click(object sender, EventArgs e)
        {

            AtdavulsoServiço.RegistrarAtendimento(
                new Modelo.AtdAvulso()
                {
                    NomeResponsavel = Convert.ToString(txtNomeProp.Text),
                    ContatoResp = Convert.ToString(mksCont.Text),
                    NomeAnimal = Convert.ToString(txtNomeAnimal.Text),
                    CPFResp = Convert.ToString(mksCPF.Text),
                    Raça = Convert.ToString(txtRaça.Text),
                    Porte = Convert.ToString(txtPorte.Text),
                    NomeServ = Convert.ToString(DescService.Text),
                    PreçoServ = Convert.ToDouble(txtCustoAtd.Text),
                    Remedios = Convert.ToString(rtbMedicamentos.Text),
                    DataAtendimento = Convert.ToDateTime(mkstDataAtd.Text),

                });

            CaixaServiço.InserirRegistro(
                        new Modelo.Caixa()
                        {
                            CPFCliente = mksCPF.Text,
                            DataCons = Convert.ToDateTime(mkstDataAtd.Text),
                            ValorCons = Convert.ToDouble(txtCustoAtd.Text),
                            Status = valor,
                            Procedencia = "Atendimento"

                        });


            txtNomeProp.Clear();
            txtNomeAnimal.Clear();
            mksCont.Clear();
            mksCPF.Clear();
            txtPorte.Clear();
            txtRaça.Clear();
            DescService.Clear();
            txtCustoAtd.Clear();
            mkstDataAtd.Clear();
            rtbMedicamentos.Clear();
        }

        private void AtdAvulso_Load(object sender, EventArgs e)
        {

        }

        

        private void btPesqMedi_Click(object sender, EventArgs e)
        {
        }

        private void dgvPesqMedi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustoAtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
