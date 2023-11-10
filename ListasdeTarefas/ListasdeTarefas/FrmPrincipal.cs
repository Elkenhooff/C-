using ListaTarefas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasdeTarefas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadastro cad = new FrmCadastro();
            cad.ShowDialog();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            FrmTarefas tarefas = new FrmTarefas();
            tarefas.ShowDialog();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionario func = new FrmCadastroFuncionario();
            func.ShowDialog();
        }
    }
}
