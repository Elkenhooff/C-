namespace ListaTarefas
{
    public partial class FrmCadastroFuncionario : Form
    {
        string name, cpf, telefone, dataNasc, salario, cargo,hora,data;
        string caminho = "C:\\Users\\pedro.hdsantos4\\source\\repos\\ListasdeTarefas\\ListasdeTarefas\\arquivos\\cadastrofuncionarios.txt";
        string caminho2 = "C:\\Users\\pedro.hdsantos4\\source\\repos\\ListasdeTarefas\\ListasdeTarefas\\arquivos\\registrodeponto.txt";

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public FrmCadastroFuncionario()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            gbSaida.Enabled = false;
            using (StreamWriter writer = new StreamWriter(caminho2, true))
            {
                writer.WriteLine($"DATA DE HOJE :{data}\nENTRADA{hora}\n");
                writer.WriteLine("-------------------------------------------------");
            }
            lblSaida.Text = DateTime.Now.ToLongTimeString();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            gbSaida.Visible = true;
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
                    writer.WriteLine($"(Nome:{name}\nCPF:{cpf}\nDatadeNascimento:{dataNasc}\nTelefone:{telefone}Salário:{salario}\nCargo:{cargo})\n");
                    writer.WriteLine("---------------------------------------------------------------------------");
                }

            }
        }
        private void btRegistra_Click(object sender, EventArgs e)
        {
            lblEntrada.Text = DateTime.Now.ToLongTimeString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
