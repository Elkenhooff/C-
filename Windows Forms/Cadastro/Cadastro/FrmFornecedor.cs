using System.Data;
using System.Data.SqlClient;

namespace Cadastro
{
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToLongDateString();
            cBUf.DataSource = CarregaComboUf();
            cBUf.ValueMember = "iduf";
            cBUf.DisplayMember = "uf";
        }
        private DataTable CarregaComboUf()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(BD.StringConexao);
                conexao.Open();
                string sql = "SELECT iduf, uf FROM uf";
                SqlCommand comando = new SqlCommand(sql, conexao);
                SqlDataReader exsql = comando.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(exsql);
                conexao.Close();
                return tabela;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }
    }
}
