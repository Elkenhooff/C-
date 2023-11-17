using System.Drawing.Printing;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument;
        private string fileCaminho;
        public Form1()
        {
            InitializeComponent();
            //Inicializar os componentes
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;

            //Configurar o PrintPreviewDialog
            printPreviewDialog1.Document = printDocument;

            //Configurar o OpenFileDialog
            openFileDialog1.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";

            //Configurar o SaveFileDialog
            saveFileDialog1.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Definir o contéudo a ser impresso
            string conteudo = $"Nome: {txtNome.Text}\nIdade: {dTPIdade.Text}\nE-mail: {txtEmail.Text}";

            //Definir a fonte e as coordenadas para a impressão
            Font fonte = new Font("Arial", 12);
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            //Imprimir o contéudo
            e.Graphics.DrawString(conteudo, fonte, Brushes.Black, x, y);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void btnArquivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileCaminho = openFileDialog1.FileName;

                //Carregar os dados do arquivo selecionado nos campos
                string[] linhas = File.ReadAllLines(fileCaminho);
                if (linhas.Length >= 3)
                {
                    txtNome.Text = linhas[0];
                    dTPIdade.Text = linhas[1];
                    txtEmail.Text = linhas[2];
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileCaminho = saveFileDialog1.FileName;

                //Salvar os dados nos campos em um arquivo
                string[] linhas = { txtNome.Text, dTPIdade.Text, txtEmail.Text };
                File.WriteAllLines(fileCaminho, linhas);
            }
        }
        private void btnPasta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //Fazer algo com o diretório selecionado, se necessário
                string pastaSelecionada = folderBrowserDialog1.SelectedPath;
            }
        }

        private void dTPIdade_ValueChanged(object sender, EventArgs e)
        {
            //Calcular a Idade e Atribuir para a LabelIdade
            int anoNascimento, idade;
            string ano;
            ano = dTPIdade.Value.ToString();
            ano = ano.Substring(6, 4);
            lblIdade.Text = ano;
            anoNascimento = Convert.ToInt32(ano);
            idade = DateTime.Now.Year - anoNascimento;
            lblIdade.Text = idade.ToString() + " anos";
        }
    }
}