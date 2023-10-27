using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;

namespace ListasdeTarefas
{
    public partial class FrmTarefas : Form
    {
        public FrmTarefas()
        {
            InitializeComponent();
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
    }
}
