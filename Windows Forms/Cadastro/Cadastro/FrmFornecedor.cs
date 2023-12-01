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
            
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            dGFornecedor.DataSource = ListarFornecedores();
            dGFornecedor.Columns[0].HeaderText = "Cód";
            dGFornecedor.Columns[1].HeaderText = "Nome";
            dGFornecedor.Columns[2].HeaderText = "CNPJ";
            dGFornecedor.Columns[3].HeaderText = "Rua";
            dGFornecedor.Columns[4].HeaderText = "N°";
            dGFornecedor.Columns[5].HeaderText = "Cidade";
            dGFornecedor.Columns[6].HeaderText = "UF";
            dGFornecedor.Columns[7].HeaderText = "Telefone";
            dGFornecedor.Columns[8].HeaderText = "CEP";

            //Define a largura das colunas
            dGFornecedor.Columns[0].Width = 50;
            dGFornecedor.Columns[1].Width = 120;
            dGFornecedor.Columns[2].Width = 100;
            dGFornecedor.Columns[3].Width = 100;
            dGFornecedor.Columns[4].Width = 50;
            dGFornecedor.Columns[5].Width = 100;
            dGFornecedor.Columns[6].Width = 50;
            dGFornecedor.Columns[7].Width = 100;
            dGFornecedor.Columns[8].Width = 100;

            //Define o modo de seleção do campo
            dGFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Permissões do Usuário
            dGFornecedor.AllowUserToAddRows = false;
            dGFornecedor.AllowUserToDeleteRows = false;
            dGFornecedor.ReadOnly = true;
        }

        public DataTable ListarFornecedores()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(BD.StringConexao);
                conexao.Open();
                string selecionarClientes = "SELECT * FROM fornecedor";
                SqlDataAdapter da = new SqlDataAdapter(selecionarClientes, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoCli_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(BD.StringConexao);
                conexao.Open();

                string sqlInserir = "INSERT INTO fornecedor(nome, cnpj, rua, numero, cidade, uf, telefone, cep) VALUES (@nome, @cnpj, @rua, @numero, @cidade, @uf, @telefone, @cep)";

                SqlCommand comando = new SqlCommand(sqlInserir, conexao);

                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = tbNome.Text;
                comando.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = mTBCNPJ2.Text;
                comando.Parameters.Add("@rua", SqlDbType.VarChar).Value = tBEndereço.Text;
                comando.Parameters.Add("@numero", SqlDbType.Int).Value = Convert.ToInt32(tBNumero.Text);
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = mTBTelefone.Text;
                comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = tBCidade.Text;
                comando.Parameters.Add("@uf", SqlDbType.VarChar).Value = cBUf.Text;
                comando.Parameters.Add("@cep", SqlDbType.VarChar).Value = mTBCep.Text;

                comando.ExecuteNonQuery();
                MessageBox.Show("Fornecedor inserido com sucesso!", "TI Tech26", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                LimparTudo();
                AtualizarGrid();
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void LimparTudo()
        {
            tbNome.Clear();
            mTBCep.Clear();
            tBCidade.Clear();
            tBEndereço.Clear();
            tBNumero.Clear();
            mTBTelefone.Clear();
            cBUf.SelectedIndex = -1;
            tbNome.Focus();
            mTBCNPJ2.Clear();
        }
    }
}
