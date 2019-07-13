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
    public partial class ConsultasMarcadas : Form
    {
        private ConsultaServiço consultaServiço = new ConsultaServiço();

        long id;
        string nomedono, cpf, contato, nomepet, raça, porte, data, hora;

        public ConsultasMarcadas(long id,string nomedono, string cpf, string contato, string nomepet, string raça, string porte, string data, string hora)
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
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void PopularAlt()
        {
            txtNomeDono.Text = nomedono ;
            mksCPF.Text = cpf;
            txtNomeAnimal.Text = nomepet;
            txtId.Text = Convert.ToString(id);
            textBox1.Text = porte;
            textBox2.Text = raça;
            mksHoraCons.Text = hora;
            txtDataCons.Text = data;
        }

        public void PopularEx()
        {
            txtIdCons.Text = Convert.ToString(id);
            txtNomeDonoEx.Text = nomedono;
            txtNomePetEx.Text = nomepet;
        }

        private void btAltCons_Click(object sender, EventArgs e)
        {
            PopularAlt();
            panelExcluir.Visible = false;
            groupAlterar.Visible = true;
        }

        private void btExCons_Click(object sender, EventArgs e)
        {
            PopularEx();
            groupAlterar.Visible = false;
            panelExcluir.Visible = true;
        }

        private void ConsultasMarcadas_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            txtNomeDonoEx.Clear();
            txtIdCons.Clear();
            txtNomePetEx.Clear();
        }

        private void btExcluiCons_Click(object sender, EventArgs e)
        {
            try {
                if (txtIdCons.Text.Trim() == string.Empty)
                    MessageBox.Show("Selecione uma consulta");
                else
                {
                    consultaServiço.RemoverConsulta(Convert.ToInt64(txtIdCons.Text));
                    LimparCampos();
                }

                panelExcluir.Visible = false;

            }
            catch
            {
                MessageBox.Show("Erro ao excluir consulta");
            }
        }

        private void btDataCons_Click(object sender, EventArgs e)
        {
            var data = monthCalendar1.SelectionStart.Day.ToString() + "/" +
                monthCalendar1.SelectionStart.Month.ToString() + "/" + monthCalendar1.SelectionStart.Year.ToString();
            txtDataCons.Text = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                consultaServiço.MarcarConsulta(
                    new Consulta()
                    {
                        ConsultaID = Convert.ToInt64(txtId.Text),
                        CPFDono = mksCPF.Text,
                        NomeDono = txtNomeDono.Text,
                        Contato = contato,
                        NomePet = txtNomeAnimal.Text,
                        PortePet = textBox1.Text,
                        RaçaPet = textBox2.Text,
                        DataCons = Convert.ToDateTime(txtDataCons.Text),
                        HoraCons = mksHoraCons.Text,
                    });
                MessageBox.Show("Consulta alterada");
                txtDataCons.Clear();
                txtNomeAnimal.Clear();
                txtDataCons.Clear();
                mksHoraCons.Clear();
                textBox1.Clear();
                textBox2.Clear();
                txtId.Clear();
                txtNomeDono.Clear();
                mksCPF.Clear();
            }
            catch
            {
                MessageBox.Show("Erro ao marcar consulta");
            }
        }
    }
}
