namespace Cadastro
{
    partial class FrmFornecedor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedor));
            pictureBox1 = new PictureBox();
            lblCódigo = new Label();
            lblEndereço = new Label();
            lblNome = new Label();
            lblUF = new Label();
            lblTelefone = new Label();
            lblCep = new Label();
            lblCNPJ2 = new Label();
            lblCNPJ = new Label();
            lblCidade = new Label();
            tbCódigo = new TextBox();
            tbNome = new TextBox();
            tBEndereço = new TextBox();
            tBCidade = new TextBox();
            mTBPCNPJ = new MaskedTextBox();
            btnPesquisar = new Button();
            mTBCep = new MaskedTextBox();
            mTBTelefone = new MaskedTextBox();
            cBUf = new ComboBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblData = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lbHora = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            tBNumero = new TextBox();
            groupBox1 = new GroupBox();
            btnImprimirTela = new Button();
            btnLimparDados = new Button();
            btnNovoFornec = new Button();
            btnAlteraFornec = new Button();
            btnExcluirCli = new Button();
            dGFornecedor = new DataGridView();
            lblForcenedorCad = new Label();
            groupBox2 = new GroupBox();
            mTBCNPJ2 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGFornecedor).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(777, 91);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblCódigo
            // 
            lblCódigo.AutoSize = true;
            lblCódigo.Location = new Point(4, 33);
            lblCódigo.Name = "lblCódigo";
            lblCódigo.Size = new Size(60, 18);
            lblCódigo.TabIndex = 1;
            lblCódigo.Text = "Código";
            // 
            // lblEndereço
            // 
            lblEndereço.AutoSize = true;
            lblEndereço.Location = new Point(18, 214);
            lblEndereço.Name = "lblEndereço";
            lblEndereço.Size = new Size(76, 18);
            lblEndereço.TabIndex = 2;
            lblEndereço.Text = "Endereço";
            lblEndereço.Click += label2_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(18, 187);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 18);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Location = new Point(493, 248);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(29, 18);
            lblUF.TabIndex = 5;
            lblUF.Text = "UF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(288, 278);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 18);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            lblTelefone.Click += lblTelefone_Click;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(350, 248);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(42, 18);
            lblCep.TabIndex = 7;
            lblCep.Text = "CEP";
            // 
            // lblCNPJ2
            // 
            lblCNPJ2.AutoSize = true;
            lblCNPJ2.Location = new Point(164, 33);
            lblCNPJ2.Name = "lblCNPJ2";
            lblCNPJ2.Size = new Size(50, 18);
            lblCNPJ2.TabIndex = 8;
            lblCNPJ2.Text = "CNPJ";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Location = new Point(18, 278);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(50, 18);
            lblCNPJ.TabIndex = 9;
            lblCNPJ.Text = "CNPJ";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(18, 246);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(60, 18);
            lblCidade.TabIndex = 10;
            lblCidade.Text = "Cidade";
            // 
            // tbCódigo
            // 
            tbCódigo.Location = new Point(80, 25);
            tbCódigo.Name = "tbCódigo";
            tbCódigo.Size = new Size(78, 26);
            tbCódigo.TabIndex = 11;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(94, 179);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(497, 26);
            tbNome.TabIndex = 12;
            // 
            // tBEndereço
            // 
            tBEndereço.Location = new Point(94, 211);
            tBEndereço.Name = "tBEndereço";
            tBEndereço.Size = new Size(393, 26);
            tBEndereço.TabIndex = 13;
            // 
            // tBCidade
            // 
            tBCidade.Location = new Point(94, 243);
            tBCidade.Name = "tBCidade";
            tBCidade.Size = new Size(255, 26);
            tBCidade.TabIndex = 14;
            // 
            // mTBPCNPJ
            // 
            mTBPCNPJ.Location = new Point(220, 26);
            mTBPCNPJ.Mask = "00,000,000/0000-00";
            mTBPCNPJ.Name = "mTBPCNPJ";
            mTBPCNPJ.Size = new Size(158, 26);
            mTBPCNPJ.TabIndex = 16;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(452, 13);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(119, 42);
            btnPesquisar.TabIndex = 17;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // mTBCep
            // 
            mTBCep.Location = new Point(398, 245);
            mTBCep.Mask = "00000-000";
            mTBCep.Name = "mTBCep";
            mTBCep.Size = new Size(89, 26);
            mTBCep.TabIndex = 18;
            // 
            // mTBTelefone
            // 
            mTBTelefone.Location = new Point(360, 275);
            mTBTelefone.Mask = "(00) 00000-0000";
            mTBTelefone.Name = "mTBTelefone";
            mTBTelefone.Size = new Size(127, 26);
            mTBTelefone.TabIndex = 19;
            // 
            // cBUf
            // 
            cBUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cBUf.FormattingEnabled = true;
            cBUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "GO", "ES", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SP", "SC", "SE", "TO" });
            cBUf.Location = new Point(528, 248);
            cBUf.Name = "cBUf";
            cBUf.Size = new Size(63, 26);
            cBUf.TabIndex = 21;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblData, toolStripStatusLabel2, lbHora });
            statusStrip1.Location = new Point(0, 563);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(777, 22);
            statusStrip1.TabIndex = 22;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(41, 17);
            toolStripStatusLabel1.Text = "Hoje é";
            // 
            // lblData
            // 
            lblData.Name = "lblData";
            lblData.Size = new Size(118, 17);
            lblData.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(10, 17);
            toolStripStatusLabel2.Text = "|";
            // 
            // lbHora
            // 
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(118, 17);
            lbHora.Text = "toolStripStatusLabel3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(497, 219);
            label1.Name = "label1";
            label1.Size = new Size(25, 18);
            label1.TabIndex = 23;
            label1.Text = "N°";
            // 
            // tBNumero
            // 
            tBNumero.Location = new Point(528, 216);
            tBNumero.Name = "tBNumero";
            tBNumero.Size = new Size(63, 26);
            tBNumero.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnImprimirTela);
            groupBox1.Controls.Add(btnLimparDados);
            groupBox1.Controls.Add(btnNovoFornec);
            groupBox1.Controls.Add(btnAlteraFornec);
            groupBox1.Controls.Add(btnExcluirCli);
            groupBox1.Location = new Point(597, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 239);
            groupBox1.TabIndex = 25;
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
            // btnNovoFornec
            // 
            btnNovoFornec.Image = (Image)resources.GetObject("btnNovoFornec.Image");
            btnNovoFornec.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoFornec.Location = new Point(6, 24);
            btnNovoFornec.Name = "btnNovoFornec";
            btnNovoFornec.Size = new Size(149, 42);
            btnNovoFornec.TabIndex = 0;
            btnNovoFornec.Text = "Novo Fornec.";
            btnNovoFornec.TextAlign = ContentAlignment.MiddleRight;
            btnNovoFornec.UseVisualStyleBackColor = true;
            btnNovoFornec.Click += btnNovoCli_Click;
            // 
            // btnAlteraFornec
            // 
            btnAlteraFornec.Image = (Image)resources.GetObject("btnAlteraFornec.Image");
            btnAlteraFornec.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlteraFornec.Location = new Point(6, 65);
            btnAlteraFornec.Name = "btnAlteraFornec";
            btnAlteraFornec.Size = new Size(149, 42);
            btnAlteraFornec.TabIndex = 1;
            btnAlteraFornec.Text = "Alterar Fornec";
            btnAlteraFornec.TextAlign = ContentAlignment.MiddleRight;
            btnAlteraFornec.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCli
            // 
            btnExcluirCli.Image = (Image)resources.GetObject("btnExcluirCli.Image");
            btnExcluirCli.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirCli.Location = new Point(6, 106);
            btnExcluirCli.Name = "btnExcluirCli";
            btnExcluirCli.Size = new Size(149, 42);
            btnExcluirCli.TabIndex = 2;
            btnExcluirCli.Text = "Excluir Fornec";
            btnExcluirCli.TextAlign = ContentAlignment.MiddleRight;
            btnExcluirCli.UseVisualStyleBackColor = true;
            // 
            // dGFornecedor
            // 
            dGFornecedor.BackgroundColor = SystemColors.ActiveBorder;
            dGFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGFornecedor.Location = new Point(14, 349);
            dGFornecedor.Name = "dGFornecedor";
            dGFornecedor.RowTemplate.Height = 25;
            dGFornecedor.Size = new Size(748, 202);
            dGFornecedor.TabIndex = 26;
            // 
            // lblForcenedorCad
            // 
            lblForcenedorCad.AutoSize = true;
            lblForcenedorCad.Location = new Point(14, 328);
            lblForcenedorCad.Name = "lblForcenedorCad";
            lblForcenedorCad.Size = new Size(201, 18);
            lblForcenedorCad.TabIndex = 27;
            lblForcenedorCad.Text = "Fornecedores Cadastrados";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblCódigo);
            groupBox2.Controls.Add(tbCódigo);
            groupBox2.Controls.Add(lblCNPJ2);
            groupBox2.Controls.Add(mTBPCNPJ);
            groupBox2.Controls.Add(btnPesquisar);
            groupBox2.Location = new Point(14, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(577, 61);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Efetuar Pesquisa";
            // 
            // mTBCNPJ2
            // 
            mTBCNPJ2.Location = new Point(94, 275);
            mTBCNPJ2.Mask = "00,000,000/0000-00";
            mTBCNPJ2.Name = "mTBCNPJ2";
            mTBCNPJ2.Size = new Size(155, 26);
            mTBCNPJ2.TabIndex = 29;
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(777, 585);
            Controls.Add(mTBCNPJ2);
            Controls.Add(lblForcenedorCad);
            Controls.Add(dGFornecedor);
            Controls.Add(groupBox1);
            Controls.Add(tBNumero);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(cBUf);
            Controls.Add(mTBTelefone);
            Controls.Add(mTBCep);
            Controls.Add(tBCidade);
            Controls.Add(tBEndereço);
            Controls.Add(tbNome);
            Controls.Add(lblCidade);
            Controls.Add(lblCNPJ);
            Controls.Add(lblCep);
            Controls.Add(lblTelefone);
            Controls.Add(lblUF);
            Controls.Add(lblNome);
            Controls.Add(lblEndereço);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFornecedor";
            StartPosition = FormStartPosition.Manual;
            Text = "Cadastro de Fornecedores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGFornecedor).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCódigo;
        private Label lblEndereço;
        private Label lblNome;
        private Label lblUF;
        private Label lblTelefone;
        private Label lblCep;
        private Label lblCNPJ2;
        private Label lblCNPJ;
        private Label lblCidade;
        private TextBox tbCódigo;
        private TextBox tbNome;
        private TextBox tBEndereço;
        private TextBox tBCidade;
        private MaskedTextBox mTBPCNPJ;
        private Button btnPesquisar;
        private MaskedTextBox mTBCep;
        private MaskedTextBox mTBTelefone;
        private ComboBox cBUf;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private TextBox tBNumero;
        private GroupBox groupBox1;
        private Button btnLimparDados;
        private Button btnNovoFornec;
        private Button btnAlteraFornec;
        private Button btnExcluirCli;
        private DataGridView dGFornecedor;
        private Label lblForcenedorCad;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblData;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lbHora;
        private Button btnImprimirTela;
        private GroupBox groupBox2;
        private MaskedTextBox mTBCNPJ2;
    }
}