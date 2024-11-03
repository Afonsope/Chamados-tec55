using ChamadosTecnicosTec55.Adicionar;
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

namespace ChamadosTecnicosTec55.Alterar
{
    public partial class frmGerirClientes : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frmGerirClientes()
        {
            InitializeComponent();


        }
        // busca no dao o cliente
        private void listarclientes()
        {
            //chama o cliente DAO 
            ClienteDao clienteDao = new ClienteDao(_conexao);
            //Captura o valor dijitado na barra de texto TXB 
            string busca = txtBuscar.Text.ToString();
            //chama o metodo Buscacliente do objeto 
            DataSet ds = new DataSet();
            ds = clienteDao.buscacliente(busca);
            //Defini o Datasource do DataGridView
            dgvCliente.DataSource = ds;
            //Defini o membro do dataset
            dgvCliente.DataMember = "clientes";




        }

        private void frmGerirClientes_Load(object sender, EventArgs e)
        {
            listarclientes();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            var frmaddcliente = new frmAdicionarCliente();
            frmaddcliente.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           

            listarclientes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verifique se alguma linha esta selecionada no dgv
            if(dgvCliente.SelectedRows.Count > 0) 
            {
                //obtem o codico do cliente da linha selecionada 
                int codigo = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

                var frmAlterarClientes = new frmAlterarClientes(codigo);
                frmAlterarClientes.ShowDialog();


                //apos a tela fechar a listar os clientes cadastrados 
                listarclientes();

            }
            else
            {
                // exibe uma menasagem de aviso se uma linha estiver selecionada 
                MessageBox.Show("selecione um registro para alteracao");

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //botao excluir
            //selecionar data grid, capturar ID, Enviar para o DAO, Excluir
            if(dgvCliente.SelectedRows.Count > 0) 
            {
                int codigo = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show("deseja excluir ?","pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    ClienteDao cliente = new ClienteDao(_conexao);
                    cliente.Excluircliente(codigo);
                    listarclientes();

                }

            
            
            }
            else
            {
            
            
            }

        }
    }
}
