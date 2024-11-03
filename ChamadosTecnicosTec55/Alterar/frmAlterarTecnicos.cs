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
    public partial class frmAlterarTecnicos : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmAlterarTecnicos(int codigo)
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();
            TecnicoDao tecnicodao = new TecnicoDao (_conexao);

            try
            {
                tecnico.Nome = txtNome.Text;
                tecnico.Email = txtEmail.Text;
                tecnico.Especialidade = txtEspecialidade.Text;
                tecnico.Senha = txtSenha.Text;
                tecnico.Obs = txtObs.Text;

                int codigo = Convert.ToInt32(txtCod.Text);
                tecnico.CodigoTecnico = codigo;
                tecnicodao.AlterarTecnico(tecnico);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
