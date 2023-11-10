using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ListasdeTarefas
{
    public partial class FrmTarefas : Form
    {
        public FrmTarefas()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.jfif";
                ofd.Title = "Selecione uma imagem";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Carrega a imagem selecionada para a picturebox
                    pBImagem.Image = new System.Drawing.Bitmap(ofd.FileName);
                }
            }
        }

        private Bitmap CapturarTela()
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap capturarTela = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics g = Graphics.FromImage(capturarTela))
            {
                g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            }
            return capturarTela;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (Bitmap capturaTela = CapturarTela())
            {
                //Salva a imagem da tela em arquvio temporario
                string tempImagePath = "C:\\Users\\pedro.hdsantos4\\source\\repos\\ListasdeTarefas\\ListasdeTarefas\\arquivos\\temp.png";
                capturaTela.Save(tempImagePath, ImageFormat.Png);

                //Cria um doct PDF
                PdfDocument pdfdoc = new PdfDocument();
                PdfPage page = pdfdoc.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                //Add a imagem da tela ao doct PDF
                XImage image = XImage.FromFile(tempImagePath);
                gfx.DrawImage(image, 0, 0);

                //Salva em Pdf
                string pdfFilePath = "C:\\Users\\pedro.hdsantos4\\source\\repos\\ListasdeTarefas\\ListasdeTarefas\\arquivos\\ScreenShot.pdf";
                pdfdoc.Save(pdfFilePath);

                //Abre o pdc apos a execução
                //Process.Start(pdfFilePath);
                MessageBox.Show("Cadastro Feito.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            mTBCPF.Text = "";
            mTBTelefone.Text = "";
            dtNascimento.Text = DateTime.Now.ToString();
            pBImagem.Image = null;
        }
    }
}
