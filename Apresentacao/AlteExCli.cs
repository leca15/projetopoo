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
    public partial class AlteExCli : Form
    {
        ClienteServiço clienteServico = new ClienteServiço();

        long id;
        string nome, contato, cpf, email, endereco, cidade;

        public AlteExCli(long id, string nome, string contato, string cpf, string email, string endereco, string cidade)
        {
            this.id = id;
            this.nome = nome;
            this.contato = contato;
            this.cpf = cpf;
            this.email = email;
            this.endereco = endereco;
            this.cidade = cidade;

            InitializeComponent();
        }

        private void btAltCliente_Click(object sender, EventArgs e)
        {
            Popular1();
            groupAtualizar.Visible = true;
            //faltando comando para popular
            panelExcluir.Visible = false;
        }

        private void idcli_TextChanged(object sender, EventArgs e)
        {

        }

        public void Popular1()
        {
            txtID.Text = Convert.ToString(id);
            TbCadCliNome.Text = Convert.ToString(nome);
            TbCadCliCpf.Text = Convert.ToString(cpf);
            TbCadCliCont.Text = Convert.ToString(contato);
            TbCadCliEnd.Text = Convert.ToString(endereco);
            TbCadCliCity.Text = Convert.ToString(cidade);
            txtxemail.Text = Convert.ToString(email);
        }

        public void Popular2()
        {
            idcli.Text = Convert.ToString(id);
            nomecli.Text = Convert.ToString(nome);
            cpfcli.Text = Convert.ToString(cpf);
            contcli.Text = Convert.ToString(contato);
            emailcli.Text = Convert.ToString(email);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                clienteServico.GravarCliente(
                     new Cliente()
                 {
                        ClienteID = (txtID.Text.Trim() == string.Empty) ? 0 : Convert.ToInt32(txtID.Text),
                        NomeCli = TbCadCliNome.Text,
                        CPFCli = TbCadCliCpf.Text,
                        ContatoCli = TbCadCliCont.Text,
                        EndereçoCli = TbCadCliEnd.Text,
                        EmailCli = txtxemail.Text,
                        CidadeCli = TbCadCliCity.Text,
                 });
                    txtID.Text = string.Empty;
                    TbCadCliNome.Clear();
                    TbCadCliCpf.Clear();
                    TbCadCliCont.Clear();
                    TbCadCliEnd.Clear();
                    TbCadCliCity.Clear();
                    txtxemail.Clear();
            }
            catch
            {
                MessageBox.Show("Não foi possivel atualizar o cliente selecionado");
            }
        }

        private void btExCliente_Click(object sender, EventArgs e)
        {
            panelExcluir.Visible = true;
            Popular2();
            groupAtualizar.Visible = false;
        }

        private void btExcluirCliente_Click(object sender, EventArgs e)
        {
            if (idcli.Text.Trim() == string.Empty)
                MessageBox.Show("Selecione um cliente");
            else
            {
                clienteServico.Remover(Convert.ToInt64(idcli.Text));
                idcli.Text = string.Empty;
                nomecli.Clear();
                cpfcli.Clear();
                contcli.Clear();
                emailcli.Clear();
                
            }
        }

        private void AlteExCli_Load(object sender, EventArgs e)
        {

        }
    }
}
