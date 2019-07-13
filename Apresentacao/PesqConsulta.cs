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
    public partial class PesqConsulta : Form
    {
        ConsultaServiço consultaServiço = new ConsultaServiço();

        long id;
        string nomedono, cpf, contato, nomepet, raça, porte, data, hora;

        private void mksPesqCons_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public PesqConsulta()
        {
            

            InitializeComponent();
        }

        private void PesqConsulta_Load(object sender, EventArgs e)
        {
            
        }

        private void posNext_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dgvPesqCons.DataSource = consultaServiço.TodosAsConsultas();
            dgvPesqCons.DataSource = consultaServiço.BuscarConsulta(mksPesqCons.Text);
        }

        private void btOpcoesCons_Click(object sender, EventArgs e)
        {
            
            
            ConsultasMarcadas consultasMarcadas = new ConsultasMarcadas(id, nomedono, cpf, contato, nomepet, raça, porte, data, hora);
            consultasMarcadas.Show();
        }

        private void dgvPesqCons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvPesqCons.CurrentRow.Index;
            id = Convert.ToInt64(dgvPesqCons["ConsultaID", cont].Value);
            nomedono = Convert.ToString(dgvPesqCons["NomeDono", cont].Value);
            cpf = Convert.ToString(dgvPesqCons["CPFDono", cont].Value);
            contato = Convert.ToString(dgvPesqCons["Contato", cont].Value);
            nomepet = Convert.ToString(dgvPesqCons["NomePet", cont].Value);
            raça = Convert.ToString(dgvPesqCons["RaçaPet", cont].Value);
            porte = Convert.ToString(dgvPesqCons["PortePet", cont].Value);
            data = Convert.ToString(dgvPesqCons["DataCons", cont].Value);
            hora = Convert.ToString(dgvPesqCons["HoraCons", cont].Value);


        }
    }
}
