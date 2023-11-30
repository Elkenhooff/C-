using System.Data;
using System.Data.SqlClient;


namespace Cadastro
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToLongDateString();
            cBUf.DataSource = CarregaComboUf();
            cBUf.ValueMember = "iduf";
            cBUf.DisplayMember = "uf";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            //Aqui vai testar a conexão 
            try
            {
                SqlConnection conexao = new SqlConnection(BD.StringConexao);
                //Abrir Conexão
                conexao.Open();
                //Fechar conexão
                conexao.Close();
                MessageBox.Show("Conexão OK!");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro na conexão\n" + erro.Message);
            }
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
        private void cBUf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dGClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
