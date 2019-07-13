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
    public partial class ConsultaMarcar2 : Form
    {
        private ConsultaServiço consultaServiço = new ConsultaServiço();
        private string date;
        public ConsultaMarcar2(string data)
        {
            this.date = data;
            InitializeComponent();
            textBox1.Text = date;
        }

        
        private void ConsultaMarcar2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtConsNomePropi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConsNomePet_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                consultaServiço.MarcarConsulta(
                    new Consulta()
                    {
                        NomeDono = txtConsNomePropi.Text,
                        CPFDono = mksCPF.Text,
                        Contato = mksCont.Text,
                        NomePet = txtConsNomePet.Text,
                        RaçaPet = txtRaçaPet.Text,
                        PortePet = txtPortePet.Text,
                        DataCons = Convert.ToDateTime(date),
                        HoraCons = Convert.ToString(mskHoraCons.Text),

                    });
                
            } catch
            {
                MessageBox.Show("Erro ao cadastrar consulta");
            }
            txtConsNomePet.Clear();
            txtConsNomePropi.Clear();
            mksCPF.Clear();
            mksCont.Clear();
            mskHoraCons.Clear();
            txtPortePet.Clear();
            txtRaçaPet.Clear();
            
        }
       

        private void dgvConsutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mskHoraCons_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
