namespace ListaTarefas
{
    public partial class FrmCadastroFuncionario : Form
    {
        string name, cpf, telefone, dataNasc, salario, cargo;
        string caminho = "C:\\Users\\pedro.hdsantos4\\source\\repos\\ListasdeTarefas\\ListasdeTarefas\\arquivos\\cadastrofuncionarios.txt";
        string caminho2 = "C:\\Users\\pedro.hdsantos4\\source\\repos\\ListasdeTarefas\\ListasdeTarefas\\arquivos\\registrodeponto.txt";

        public FrmCadastroFuncionario()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToShortDateString();
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            lblSaida.Text = DateTime.Now.ToLongTimeString();
            gbSaida.Enabled = false;
            using (StreamWriter writer = new StreamWriter(caminho2, true))
            {
                writer.WriteLine($"Data de Hoje: {data}\nEntrada: {lblEntrada.Text}\nSaída: {lblSaida.Text}");
                writer.WriteLine("-------------------------------------------------");
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            gbSaida.Visible = true;
            gbSaida.Enabled = true;
            timer2.Enabled = false;
        }
        private void btCadastra_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mtCPF.Text == "" || dtNasc.Text == "" || mtPhone.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                name = txtNome.Text;
                cpf = mtCPF.Text;
                dataNasc = dtNasc.Text;
                telefone = mtPhone.Text;
                salario = mtSalario.Text;
                cargo = cbCargo.Text;
                using (StreamWriter writer = new StreamWriter(caminho, true))
                {
                    writer.WriteLine($"Nome: {name}\nCPF: {cpf}\nData de Nascimento: {dataNasc}\nTelefone: {telefone}\nCargo: {cargo}\nSalário: R$ {salario}\n");
                    writer.WriteLine("---------------------------------------------------------------------------");
                }
                MessageBox.Show("Cadastrado", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btRegistra_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            lblEntrada.Text = DateTime.Now.ToLongTimeString();
            gbEntrada.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToLongTimeString();
        }
        private void LimparForm()
        {
            txtNome.Text = "";
            mtSalario.Text = "";
            cbCargo.SelectedIndex = -1;
            mtCPF.Text = "";
            mtPhone.Text = "";
            dtNasc.Text = "";
            lblEntrada.Text = "";
            lblSaida.Text = "";
            gbEntrada.Enabled = true;
            gbSaida.Visible = false;
        }
    }
}
