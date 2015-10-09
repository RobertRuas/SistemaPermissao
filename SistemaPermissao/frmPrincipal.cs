using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace SistemaPermissao
{
    public partial class frmPrincipal : Form
    {
        private AcessoBancoDados acessoBancoDados = new AcessoBancoDados(Properties.Settings.Default.StringConexso_SQLServer);

        private DataTable dataTableUsuarios = new DataTable();
        private DataTable dataTablePrevilegios = new DataTable();
        private DataTable dataTablePermissoes = new DataTable();

        public frmPrincipal()
        {
            InitializeComponent();

            dataTableUsuarios = acessoBancoDados.executarConsulta(CommandType.StoredProcedure, "procedUsuarioConsulta");
            dataTablePrevilegios = acessoBancoDados.executarConsulta(CommandType.StoredProcedure, "procedUsuarioPrevilegioConsulta");
            dataTablePermissoes = acessoBancoDados.executarConsulta(CommandType.StoredProcedure, "procedUsuarioPermissaoConsulta");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CarregarComboBoxUsuarios();
            CarregarListBoxUsuarios();
            CarregarListBoxPrevilegios();
            CarregarListBoxPermissoes();
        }

        private bool TestarPermissao(string TipoPermissao)
        {
            acessoBancoDados.LimparParametros();
            acessoBancoDados.AdcionarParametros("@IDUsuario", GerarIDUsuarioSelecionado());
            acessoBancoDados.AdcionarParametros("@Permissao", TipoPermissao);

            if(acessoBancoDados.executarConsulta(CommandType.StoredProcedure, "procedTestarPermissao").Rows.Count > 0)
            {
                label_Verifcar.Text = "Usuario tem permissão!";
                label_Verifcar.ForeColor = Color.Green; 
                
                return true;
            }
            else 
            {
                label_Verifcar.Text = "Usuario não tem permissão!";
                label_Verifcar.ForeColor = Color.Red; 
                
                return false;
            }
        }

        private void comboBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Verifcar.Text = "Verificar";
            label_Verifcar.ForeColor = Color.DimGray;
        }

        private void CarregarComboBoxUsuarios()
        {
            comboBoxUsuarios.Items.Clear();

            foreach (DataRow Rows in dataTableUsuarios.Rows)
            {
                comboBoxUsuarios.Items.Add(Rows[1].ToString());
            }

            if(comboBoxUsuarios.Items.Count > 0)
            { comboBoxUsuarios.SelectedIndex = 0; }
        }

        private void CarregarListBoxUsuarios()
        {
            listView_Usuarios.Items.Clear();

            foreach (DataRow Rows in dataTableUsuarios.Rows)
            {
                ListViewItem lvi = new ListViewItem(Rows[0].ToString());
                lvi.SubItems.Add(Rows[1].ToString());
                lvi.SubItems.Add(Rows[2].ToString());

                listView_Usuarios.Items.Add(lvi);
            }
        }

        private void CarregarListBoxPrevilegios()
        {
            listView_Previlegios.Items.Clear();

            foreach (DataRow Rows in dataTablePrevilegios.Rows)
            {
                ListViewItem lvi = new ListViewItem(Rows[0].ToString());
                lvi.SubItems.Add(Rows[1].ToString());

                listView_Previlegios.Items.Add(lvi);
            }
        }

        private void CarregarListBoxPermissoes()
        {
            listView_Permissoes.Items.Clear();

            foreach (DataRow Rows in dataTablePermissoes.Rows)
            {
                ListViewItem lvi = new ListViewItem(Rows[0].ToString());
                lvi.SubItems.Add(Rows[1].ToString());
                lvi.SubItems.Add(Rows[2].ToString());

                listView_Permissoes.Items.Add(lvi);
            }
        }

        private int GerarIDUsuarioSelecionado()
        {
            return Convert.ToInt32(dataTableUsuarios.Rows[comboBoxUsuarios.SelectedIndex][0]);
        }

        private void buttonTestarLer_Click(object sender, EventArgs e)
        {
            TestarPermissao("Ler");
        }

        private void buttonTestarInserir_Click(object sender, EventArgs e)
        {
            TestarPermissao("Gravar");
        }

        private void buttonTestarEditar_Click(object sender, EventArgs e)
        {
            TestarPermissao("Editar");
        }

        private void buttonTestarExcluir_Click(object sender, EventArgs e)
        {
            TestarPermissao("Excluir");
        }
    }
}
