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

            AtualizarGrid();
        }
        public void AtualizarGrid()
        {
            dGClientes.DataSource = ListarClientes();
            dGClientes.Columns[0].HeaderText = "Cód";
            dGClientes.Columns[1].HeaderText = "Nome";
            dGClientes.Columns[2].HeaderText = "CPF";
            dGClientes.Columns[3].HeaderText = "Rua";
            dGClientes.Columns[4].HeaderText = "N°";
            dGClientes.Columns[5].HeaderText = "Telefone";
            dGClientes.Columns[6].HeaderText = "Cidade";
            dGClientes.Columns[7].HeaderText = "UF";
            dGClientes.Columns[8].HeaderText = "Compl.";
            dGClientes.Columns[9].HeaderText = "CEP";
            dGClientes.Columns[10].HeaderText = "DtNasc.";

            //Define a largura das colunas
            dGClientes.Columns[0].Width = 50;
            dGClientes.Columns[1].Width = 120;
            dGClientes.Columns[2].Width = 100;
            dGClientes.Columns[3].Width = 100;
            dGClientes.Columns[4].Width = 50;
            dGClientes.Columns[5].Width = 100;
            dGClientes.Columns[6].Width = 120;
            dGClientes.Columns[7].Width = 50;
            dGClientes.Columns[8].Width = 120;
            dGClientes.Columns[9].Width = 100;
            dGClientes.Columns[10].Width = 100;
            
            //Define o modo de seleção do campo
            dGClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Permissões do Usuário
            dGClientes.AllowUserToAddRows = false;
            dGClientes.AllowUserToDeleteRows= false;
            dGClientes.ReadOnly = true;
        }

        public DataTable ListarClientes()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(BD.StringConexao);
                conexao.Open();
                string selecionarClientes = "SELECT * FROM cliente";
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
        private void btnNovoCli_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(BD.StringConexao);
                conexao.Open();

                string sqlInserir = "INSERT INTO cliente(nome, cpf, rua, numero, telefone, cidade, uf, complemento, cep, dtnascimento) VALUES (@nome, @cpf, @rua, @numero, @telefone, @cidade, @uf, @complemento, @cep, @dtnascimento)";

                SqlCommand comando = new SqlCommand(sqlInserir, conexao);

                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = tbNome.Text;
                comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = mTBCPF2.Text;
                comando.Parameters.Add("@rua", SqlDbType.VarChar).Value = tBEndereço.Text;
                comando.Parameters.Add("@numero", SqlDbType.Int).Value = Convert.ToInt32(tBNumero.Text);
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = mTBTelefone.Text;
                comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = tBCidade.Text;
                comando.Parameters.Add("@uf", SqlDbType.VarChar).Value = cBUf.Text;
                comando.Parameters.Add("@complemento", SqlDbType.VarChar).Value = tbComplemento.Text;
                comando.Parameters.Add("@cep", SqlDbType.VarChar).Value = mTBCep.Text;
                comando.Parameters.Add("@dtnascimento", SqlDbType.DateTime).Value = Convert.ToDateTime(mTBDtNasc.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente inserido com sucesso!", "TI Tech26", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tbComplemento.Clear();
            mTBDtNasc.Clear();
            tBEndereço.Clear();
            tBNumero.Clear();
            mTBTelefone.Clear();
            mTBCPF2.Clear();
            cBUf.SelectedIndex = -1;
            tbNome.Focus();
        }
        private void cBUf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dGClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
