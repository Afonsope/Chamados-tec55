using ChamadosTecnicosTec55.Adicionar;
using ChamadosTecnicosTec55.Alterar;
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
    public partial class FrmGerirTecnico : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public FrmGerirTecnico()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            var frmaddTecnico = new frmTecnicoAdicionar();
            frmaddTecnico.Show();
        }
        private void listartecnico()
        {
            //chama o cliente DAO 
            TecnicoDao tecnicoDao = new TecnicoDao(_conexao);
            //Captura o valor dijitado na barra de texto TXB 
            string busca = txtBuscar.Text.ToString();
            //chama o metodo Buscacliente do objeto 
            DataSet ds = new DataSet();
            ds = tecnicoDao.buscaTecnico(busca);
            //Defini o Datasource do DataGridView
            dgvTecnico.DataSource = ds;
            //Defini o membro do dataset
            dgvTecnico.DataMember = "clientes";




        }

        private void btnAlterar_Click(object sender, EventArgs e)
        { //verifique se alguma linha esta selecionada no dgv
            if (dgvTecnico.SelectedRows.Count > 0)
            {
                //obtem o codico do cliente da linha selecionada 
                int codigo = Convert.ToInt32(dgvTecnico.CurrentRow.Cells[0].Value);

                var frmAlterarTecnicos = new frmAlterarTecnicos(codigo);
                frmAlterarTecnicos.ShowDialog();


                //apos a tela fechar a listar os clientes cadastrados 
                listartecnico();

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //botao excluir
            //selecionar data grid, capturar ID, Enviar para o DAO, Excluir
            if (dgvTecnico.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgvTecnico.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show("deseja excluir ?", "pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    TecnicoDao Tecnico = new TecnicoDao(_conexao);
                    Tecnico.ExcluirTecnico(codigo);
                    listartecnico();

                }



            }
            else
            {


            }
        }
    }
}
