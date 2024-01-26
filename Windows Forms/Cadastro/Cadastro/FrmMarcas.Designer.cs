namespace Cadastro
{
    partial class FrmMarcas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarcas));
            groupBox1 = new GroupBox();
            btnImprimirTela = new Button();
            btnLimparDados = new Button();
            btnNovaMarca = new Button();
            btnAlteraMarca = new Button();
            btnExcluirMarca = new Button();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            lblCódigo = new Label();
            tbCódigo = new TextBox();
            lblVerificaNome = new Label();
            btnPesquisar = new Button();
            label2 = new Label();
            dGMarcas = new DataGridView();
            tbNome = new TextBox();
            lblNome = new Label();
            richTBDescrição = new RichTextBox();
            lblComplemento = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGMarcas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnImprimirTela);
            groupBox1.Controls.Add(btnLimparDados);
            groupBox1.Controls.Add(btnNovaMarca);
            groupBox1.Controls.Add(btnAlteraMarca);
            groupBox1.Controls.Add(btnExcluirMarca);
            groupBox1.Location = new Point(591, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 239);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comandos";
            // 
            // btnImprimirTela
            // 
            btnImprimirTela.Font = new Font("Arial", 12.7F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimirTela.Image = (Image)resources.GetObject("btnImprimirTela.Image");
            btnImprimirTela.ImageAlign = ContentAlignment.BottomLeft;
            btnImprimirTela.Location = new Point(6, 190);
            btnImprimirTela.Name = "btnImprimirTela";
            btnImprimirTela.Size = new Size(149, 42);
            btnImprimirTela.TabIndex = 4;
            btnImprimirTela.Text = "Imprimir Tela";
            btnImprimirTela.TextAlign = ContentAlignment.MiddleRight;
            btnImprimirTela.UseVisualStyleBackColor = true;
            // 
            // btnLimparDados
            // 
            btnLimparDados.Font = new Font("Arial", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimparDados.Image = (Image)resources.GetObject("btnLimparDados.Image");
            btnLimparDados.ImageAlign = ContentAlignment.BottomLeft;
            btnLimparDados.Location = new Point(6, 148);
            btnLimparDados.Name = "btnLimparDados";
            btnLimparDados.Size = new Size(149, 42);
            btnLimparDados.TabIndex = 3;
            btnLimparDados.Text = "Limpar Dados";
            btnLimparDados.TextAlign = ContentAlignment.MiddleRight;
            btnLimparDados.UseVisualStyleBackColor = true;
            // 
            // btnNovaMarca
            // 
            btnNovaMarca.Image = (Image)resources.GetObject("btnNovaMarca.Image");
            btnNovaMarca.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovaMarca.Location = new Point(6, 24);
            btnNovaMarca.Name = "btnNovaMarca";
            btnNovaMarca.Size = new Size(149, 42);
            btnNovaMarca.TabIndex = 0;
            btnNovaMarca.Text = "Nova Marca";
            btnNovaMarca.TextAlign = ContentAlignment.MiddleRight;
            btnNovaMarca.UseVisualStyleBackColor = true;
            // 
            // btnAlteraMarca
            // 
            btnAlteraMarca.Image = (Image)resources.GetObject("btnAlteraMarca.Image");
            btnAlteraMarca.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlteraMarca.Location = new Point(6, 65);
            btnAlteraMarca.Name = "btnAlteraMarca";
            btnAlteraMarca.Size = new Size(149, 42);
            btnAlteraMarca.TabIndex = 1;
            btnAlteraMarca.Text = "Alterar Marca";
            btnAlteraMarca.TextAlign = ContentAlignment.MiddleRight;
            btnAlteraMarca.UseVisualStyleBackColor = true;
            // 
            // btnExcluirMarca
            // 
            btnExcluirMarca.Image = (Image)resources.GetObject("btnExcluirMarca.Image");
            btnExcluirMarca.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirMarca.Location = new Point(6, 106);
            btnExcluirMarca.Name = "btnExcluirMarca";
            btnExcluirMarca.Size = new Size(149, 42);
            btnExcluirMarca.TabIndex = 2;
            btnExcluirMarca.Text = "Excluir Marca";
            btnExcluirMarca.TextAlign = ContentAlignment.MiddleRight;
            btnExcluirMarca.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(777, 91);
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(lblCódigo);
            groupBox2.Controls.Add(tbCódigo);
            groupBox2.Controls.Add(lblVerificaNome);
            groupBox2.Controls.Add(btnPesquisar);
            groupBox2.Location = new Point(12, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(550, 61);
            groupBox2.TabIndex = 56;
            groupBox2.TabStop = false;
            groupBox2.Text = "Efetuar Pesquisa";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 26);
            textBox1.TabIndex = 67;
            // 
            // lblCódigo
            // 
            lblCódigo.AutoSize = true;
            lblCódigo.Location = new Point(14, 28);
            lblCódigo.Name = "lblCódigo";
            lblCódigo.Size = new Size(60, 18);
            lblCódigo.TabIndex = 1;
            lblCódigo.Text = "Código";
            // 
            // tbCódigo
            // 
            tbCódigo.Location = new Point(80, 24);
            tbCódigo.Name = "tbCódigo";
            tbCódigo.Size = new Size(78, 26);
            tbCódigo.TabIndex = 11;
            // 
            // lblVerificaNome
            // 
            lblVerificaNome.AutoSize = true;
            lblVerificaNome.Location = new Point(175, 28);
            lblVerificaNome.Name = "lblVerificaNome";
            lblVerificaNome.Size = new Size(50, 18);
            lblVerificaNome.TabIndex = 8;
            lblVerificaNome.Text = "Nome";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(425, 17);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(119, 34);
            btnPesquisar.TabIndex = 17;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 346);
            label2.Name = "label2";
            label2.Size = new Size(155, 18);
            label2.TabIndex = 59;
            label2.Text = "Marcas Cadastradas";
            // 
            // dGMarcas
            // 
            dGMarcas.BackgroundColor = SystemColors.ActiveBorder;
            dGMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGMarcas.Location = new Point(12, 367);
            dGMarcas.Name = "dGMarcas";
            dGMarcas.RowTemplate.Height = 25;
            dGMarcas.Size = new Size(748, 202);
            dGMarcas.TabIndex = 58;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(114, 170);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(448, 26);
            tbNome.TabIndex = 61;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(58, 173);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 18);
            lblNome.TabIndex = 60;
            lblNome.Text = "Nome";
            // 
            // richTBDescrição
            // 
            richTBDescrição.Location = new Point(114, 202);
            richTBDescrição.Name = "richTBDescrição";
            richTBDescrição.Size = new Size(448, 84);
            richTBDescrição.TabIndex = 63;
            richTBDescrição.Text = "";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(28, 202);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(80, 18);
            lblComplemento.TabIndex = 62;
            lblComplemento.Text = "Descrição";
            // 
            // FrmMarcas
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(773, 581);
            Controls.Add(richTBDescrição);
            Controls.Add(lblComplemento);
            Controls.Add(tbNome);
            Controls.Add(lblNome);
            Controls.Add(label2);
            Controls.Add(dGMarcas);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMarcas";
            Text = "Cadastro de Marcas";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnImprimirTela;
        private Button btnLimparDados;
        private Button btnNovaMarca;
        private Button btnAlteraMarca;
        private Button btnExcluirMarca;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label lblCódigo;
        private TextBox tbCódigo;
        private Label lblVerificaNome;
        private Button btnPesquisar;
        private Label label2;
        private DataGridView dGMarcas;
        private TextBox tbNome;
        private Label lblNome;
        private RichTextBox richTBDescrição;
        private Label lblComplemento;
    }
}