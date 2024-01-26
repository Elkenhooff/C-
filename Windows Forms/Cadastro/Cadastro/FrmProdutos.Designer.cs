namespace Cadastro
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            groupBox1 = new GroupBox();
            btnImprimirTela = new Button();
            btnLimparDados = new Button();
            btnNovoProd = new Button();
            btnAlteraProd = new Button();
            btnExcluirProd = new Button();
            tbNome = new TextBox();
            lblValor = new Label();
            lblComplemento = new Label();
            lblNome = new Label();
            lblQuantidade = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            lblCódigo = new Label();
            tbCódigo = new TextBox();
            lblVerificaNome = new Label();
            btnPesquisar = new Button();
            label2 = new Label();
            dGClientes = new DataGridView();
            richTBDescrição = new RichTextBox();
            mTBValor = new MaskedTextBox();
            label1 = new Label();
            tBQuantidade = new TextBox();
            cBMarca = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGClientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnImprimirTela);
            groupBox1.Controls.Add(btnLimparDados);
            groupBox1.Controls.Add(btnNovoProd);
            groupBox1.Controls.Add(btnAlteraProd);
            groupBox1.Controls.Add(btnExcluirProd);
            groupBox1.Location = new Point(593, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 239);
            groupBox1.TabIndex = 52;
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
            // btnNovoProd
            // 
            btnNovoProd.Image = (Image)resources.GetObject("btnNovoProd.Image");
            btnNovoProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoProd.Location = new Point(6, 24);
            btnNovoProd.Name = "btnNovoProd";
            btnNovoProd.Size = new Size(149, 42);
            btnNovoProd.TabIndex = 0;
            btnNovoProd.Text = "Novo Produto";
            btnNovoProd.TextAlign = ContentAlignment.MiddleRight;
            btnNovoProd.UseVisualStyleBackColor = true;
            // 
            // btnAlteraProd
            // 
            btnAlteraProd.Image = (Image)resources.GetObject("btnAlteraProd.Image");
            btnAlteraProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlteraProd.Location = new Point(6, 65);
            btnAlteraProd.Name = "btnAlteraProd";
            btnAlteraProd.Size = new Size(149, 42);
            btnAlteraProd.TabIndex = 1;
            btnAlteraProd.Text = "Alterar Produto";
            btnAlteraProd.TextAlign = ContentAlignment.MiddleRight;
            btnAlteraProd.UseVisualStyleBackColor = true;
            // 
            // btnExcluirProd
            // 
            btnExcluirProd.Image = (Image)resources.GetObject("btnExcluirProd.Image");
            btnExcluirProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirProd.Location = new Point(6, 106);
            btnExcluirProd.Name = "btnExcluirProd";
            btnExcluirProd.Size = new Size(149, 42);
            btnExcluirProd.TabIndex = 2;
            btnExcluirProd.Text = "Excluir Produto";
            btnExcluirProd.TextAlign = ContentAlignment.MiddleRight;
            btnExcluirProd.UseVisualStyleBackColor = true;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(126, 169);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(335, 26);
            tbNome.TabIndex = 42;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(18, 237);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(102, 18);
            lblValor.TabIndex = 41;
            lblValor.Text = "Valor Unitário";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(40, 268);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(80, 18);
            lblComplemento.TabIndex = 40;
            lblComplemento.Text = "Descrição";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(70, 177);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 18);
            lblNome.TabIndex = 35;
            lblNome.Text = "Nome";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(31, 205);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(89, 18);
            lblQuantidade.TabIndex = 34;
            lblQuantidade.Text = "Quantidade";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.CADASTRO_DE_PRODUTOS;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(777, 91);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(lblCódigo);
            groupBox2.Controls.Add(tbCódigo);
            groupBox2.Controls.Add(lblVerificaNome);
            groupBox2.Controls.Add(btnPesquisar);
            groupBox2.Location = new Point(14, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(550, 61);
            groupBox2.TabIndex = 53;
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
            label2.Location = new Point(13, 346);
            label2.Name = "label2";
            label2.Size = new Size(166, 18);
            label2.TabIndex = 57;
            label2.Text = "Produtos Cadastrados";
            // 
            // dGClientes
            // 
            dGClientes.BackgroundColor = SystemColors.ActiveBorder;
            dGClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGClientes.Location = new Point(10, 367);
            dGClientes.Name = "dGClientes";
            dGClientes.RowTemplate.Height = 25;
            dGClientes.Size = new Size(748, 202);
            dGClientes.TabIndex = 56;
            // 
            // richTBDescrição
            // 
            richTBDescrição.Location = new Point(126, 266);
            richTBDescrição.Name = "richTBDescrição";
            richTBDescrição.Size = new Size(335, 69);
            richTBDescrição.TabIndex = 59;
            richTBDescrição.Text = "";
            // 
            // mTBValor
            // 
            mTBValor.Location = new Point(126, 234);
            mTBValor.Mask = "$ 0,000,000.00";
            mTBValor.Name = "mTBValor";
            mTBValor.Size = new Size(130, 26);
            mTBValor.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 205);
            label1.Name = "label1";
            label1.Size = new Size(52, 18);
            label1.TabIndex = 61;
            label1.Text = "Marca";
            // 
            // tBQuantidade
            // 
            tBQuantidade.Location = new Point(126, 202);
            tBQuantidade.Name = "tBQuantidade";
            tBQuantidade.Size = new Size(130, 26);
            tBQuantidade.TabIndex = 62;
            // 
            // cBMarca
            // 
            cBMarca.FormattingEnabled = true;
            cBMarca.Items.AddRange(new object[] { "ab" });
            cBMarca.Location = new Point(367, 201);
            cBMarca.Name = "cBMarca";
            cBMarca.Size = new Size(94, 26);
            cBMarca.TabIndex = 64;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ab" });
            comboBox2.Location = new Point(367, 233);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(94, 26);
            comboBox2.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 236);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 66;
            label4.Text = "Fornecedor";
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(773, 581);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(cBMarca);
            Controls.Add(tBQuantidade);
            Controls.Add(label1);
            Controls.Add(mTBValor);
            Controls.Add(richTBDescrição);
            Controls.Add(label2);
            Controls.Add(dGClientes);
            Controls.Add(groupBox1);
            Controls.Add(tbNome);
            Controls.Add(lblValor);
            Controls.Add(lblComplemento);
            Controls.Add(lblNome);
            Controls.Add(lblQuantidade);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProdutos";
            Text = "Cadastro de Produtos";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mTBCPF2;
        private Label lblCPF2;
        private GroupBox groupBox1;
        private Button btnImprimirTela;
        private Button btnLimparDados;
        private Button btnNovoProd;
        private Button btnAlteraProd;
        private Button btnExcluirProd;
        private TextBox tBNumero;
        private Label label1;
        private ComboBox cBUf;
        private MaskedTextBox mTBDtNasc;
        private MaskedTextBox mTBTelefone;
        private MaskedTextBox mTBCep;
        private TextBox tbComplemento;
        private TextBox tBCidade;
        private TextBox tBEndereço;
        private TextBox tbNome;
        private Label lblValor;
        private Label lblComplemento;
        private Label lblCep;
        private Label lblTelefone;
        private Label lblUF;
        private Label lblDtNasc;
        private Label lblNome;
        private Label lblQuantidade;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Label lblCódigo;
        private TextBox tbCódigo;
        private Label lblVerificaNome;
        private Button btnPesquisar;
        private Label label2;
        private DataGridView dGClientes;
        private RichTextBox richTBDescrição;
        private MaskedTextBox mTBValor;
        private TextBox tBQuantidade;
        private Label label3;
        private ComboBox cBMarca;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label4;
    }
}