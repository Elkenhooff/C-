using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Policy;

namespace ListasdeTarefas
{
    public partial class FrmCadastro : Form
    {
        string dataHoje, dataLimite, hora, tarefa;//, caminhoo;
        string caminho = "C:\\Users\\pedro.hdsantos4\\Desktop\\tarefas\\tarefas";
        public FrmCadastro()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtTarefa.Text == "")
            {
                MessageBox.Show("Preencha os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTarefa.Focus();
            }
            else
            {
                dataHoje = lblData.Text;
                dataLimite = dtLimite.Text;
                hora = lblHora.Text;
                tarefa = txtTarefa.Text;

                //caminhoo = dataHoje.Substring(0, 2) + "." + dataHoje.Substring(3, 2);

                using (StreamWriter writer = new StreamWriter(caminho + "_" + "teste "+ ".txt", true))
                {
                    writer.WriteLine($"({dataHoje})\nTarefa: {tarefa}\nHorario: {hora}\nData Limite: {dataLimite}");
                    writer.WriteLine("------------------------------------------------------");
                }

                lblRealizado.Text = "Tarefa adicionada com sucesso.";
                LimparCampos();
                exibirTarefas();

                txtTarefa.Focus();
                timer2.Enabled = true;
            }
        }

        private void exibirTarefas()
        {
            listTarefa.Items.Clear();
            string[] linhas = File.ReadAllLines(caminho + "_" + "teste " + ".txt");
            listTarefa.Items.AddRange(linhas);
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            exibirTarefas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTarefa.Focus();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblRealizado.Text = "";
            timer2.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtTarefa.Clear();
            dtLimite.Text = DateTime.Now.ToShortDateString();
            txtTarefa.Focus();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}