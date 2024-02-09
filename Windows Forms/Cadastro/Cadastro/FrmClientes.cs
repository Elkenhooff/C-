using Microsoft.Identity.Client;
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
            dGClientes.AllowUserToDeleteRows = false;
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

                string sqlInserir = "INSERT INTO cliente(nome, rua, numero, cidade, uf, cep, cpf, complemento, datanascimento, telefone) VALUES (@nome, @rua, @numero, @cidade, @uf, @cep, @cpf, @complemento, @datanascimento, @telefone)";

                SqlCommand comando = new SqlCommand(sqlInserir, conexao);

                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = tbNome.Text;
                comando.Parameters.Add("@rua", SqlDbType.VarChar).Value = tBEndereço.Text;
                comando.Parameters.Add("@numero", SqlDbType.Int).Value = Convert.ToInt32(tBNumero.Text);
                comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = tBCidade.Text;
                comando.Parameters.Add("@uf", SqlDbType.VarChar).Value = cBUf.Text;
                comando.Parameters.Add("@cep", SqlDbType.VarChar).Value = mTBCep.Text;
                comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = mTBCPF2.Text;
                comando.Parameters.Add("@complemento", SqlDbType.VarChar).Value = tbComplemento.Text;
                comando.Parameters.Add("@datanascimento", SqlDbType.Date).Value = Convert.ToDateTime(mTBDtNasc.Text);
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = mTBTelefone.Text;

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

        private void dGClientes_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //Vai verificar se há linhas selecionadas no dtgrid
                int linha = dGClientes.SelectedRows[0].Index;
                if (linha >= 0)
                {
                    //Vai pegar o código do cliente que foi selecionado na linha
                    int codigo = Convert.ToInt32(dGClientes.Rows[linha].Cells[0].Value);
                    //Chamar o método que fará o select dos dados do cliente
                    ClienteInformation cli = selecionarCliente(codigo);
                    //Ao retornar o método, vai trazer os dados do banco para o textbox
                    tbCódigo.Text = cli.Codigo.ToString();
                    tbNome.Text = cli.Nome.ToString();
                    tBEndereço.Text = cli.Rua.ToString();
                    tBNumero.Text = cli.Numero.ToString();
                    tBCidade.Text = cli.Cidade.ToString();
                    cBUf.Text = cli.Uf.ToString();
                    mTBCep.Text = cli.Cep.ToString();
                    mTBCPF2.Text = cli.Cpf.ToString();
                    tbComplemento.Text = cli.Complemento.ToString();
                    mTBDtNasc.Text = cli.Datanascimento.ToString();
                    mTBTelefone.Text = cli.Telefone.ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao clicar no cliente: " + erro.Message);
            }
        }
        public static ClienteInformation selecionarCliente(int codigo)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(BD.StringConexao);
                conexao.Open();
                string sql = "SELECT * FROM cliente WHERE codigo=@codigo";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                //Vai usar o código do cliente para fazer o filtro na busca
                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;

                //Vai retornar dados percorrendo a tabela
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    //Seguir a sequência do BD
                    ClienteInformation cli = new ClienteInformation();
                    cli.Codigo = Convert.ToInt32(dr[0]);
                    cli.Nome = dr[1].ToString();
                    cli.Rua = dr[2].ToString();
                    cli.Numero = Convert.ToInt32(dr[3]);
                    cli.Cidade = dr[4].ToString();
                    cli.Uf = dr[5].ToString();
                    cli.Cep = dr[6].ToString();
                    cli.Cpf = dr[7].ToString();
                    cli.Complemento = dr[8].ToString();
                    cli.Datanascimento = Convert.ToDateTime(dr[9]);
                    cli.Telefone = dr[10].ToString();

                    conexao.Close();
                    return cli;
                }
                else
                {
                    conexao.Close();
                    return null;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar cliente." + erro.Message);
                return null;
            }
        }
    }
}
