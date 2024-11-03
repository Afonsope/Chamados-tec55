using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55
{
    public partial class frmAlterarClientes : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmAlterarClientes(int codigo)
        {
            InitializeComponent();

            // verifiqua se o codigo é maior que zero
            if (codigo > 0)
            {
                //cria uma instancia do objeto cliente 
                Cliente cliente = new Cliente();
                ClienteDao clienteDao = new ClienteDao(_conexao);


                cliente = clienteDao.ObtemCliente(codigo);


                //se o cliente nao foi encontrado 
                if (cliente == null )
                {
                    MessageBox.Show("cliente nao encontrado");
                    this.Close();

                }
               txtObs.Text = cliente.CodigoCliente.ToString();
               txtNome.Text = cliente.Nome;
               txtProfissao.Text = cliente.Profissao;
               txtSetor.Text = cliente.Setor;
               txtObs.Text = cliente.Obs;













            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDao clientedao = new ClienteDao(_conexao);

            try
            {
                cliente.Nome = txtNome.Text;
                cliente.Profissao = txtProfissao.Text;
                cliente.Setor = txtSetor.Text;
                cliente.Obs = txtObs.Text;

                int codigo = Convert.ToInt32(txtCod.Text);
                cliente.CodigoCliente = codigo;
                clientedao.AlterarCliente(cliente);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }
    }
}
