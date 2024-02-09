namespace Cadastro
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            pictureBox1 = new PictureBox();
            lblCódigo = new Label();
            lblEndereço = new Label();
            lblNome = new Label();
            lblDtNasc = new Label();
            lblUF = new Label();
            lblTelefone = new Label();
            lblCep = new Label();
            lblCpf = new Label();
            lblComplemento = new Label();
            lblCidade = new Label();
            tbCódigo = new TextBox();
            tbNome = new TextBox();
            tBEndereço = new TextBox();
            tBCidade = new TextBox();
            tbComplemento = new TextBox();
            mTBCPF = new MaskedTextBox();
            btnPesquisar = new Button();
            mTBCep = new MaskedTextBox();
            mTBTelefone = new MaskedTextBox();
            mTBDtNasc = new MaskedTextBox();
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
            btnNovoCli = new Button();
            btnAlteraCli = new Button();
            btnExcluirCli = new Button();
            dGClientes = new DataGridView();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnTeste = new Button();
            lblCPF2 = new Label();
            mTBCPF2 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGClientes).BeginInit();
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
            // lblDtNasc
            // 
            lblDtNasc.AutoSize = true;
            lblDtNasc.Location = new Point(430, 278);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(68, 18);
            lblDtNasc.TabIndex = 4;
            lblDtNasc.Text = "Dt. Nasc";
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
            lblTelefone.Location = new Point(225, 278);
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
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(164, 33);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(41, 18);
            lblCpf.TabIndex = 8;
            lblCpf.Text = "CPF";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(18, 278);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(58, 18);
            lblComplemento.TabIndex = 9;
            lblComplemento.Text = "Compl:";
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
            tbNome.Size = new Size(330, 26);
            tbNome.TabIndex = 12;
            // 
            // tBEndereço
            // 
            tBEndereço.Location = new Point(94, 211);
            tBEndereço.Name = "tBEndereço";
            tBEndereço.Size = new Size(380, 26);
            tBEndereço.TabIndex = 13;
            // 
            // tBCidade
            // 
            tBCidade.Location = new Point(94, 243);
            tBCidade.Name = "tBCidade";
            tBCidade.Size = new Size(255, 26);
            tBCidade.TabIndex = 14;
            // 
            // tbComplemento
            // 
            tbComplemento.Location = new Point(94, 275);
            tbComplemento.Name = "tbComplemento";
            tbComplemento.Size = new Size(130, 26);
            tbComplemento.TabIndex = 15;
            // 
            // mTBCPF
            // 
            mTBCPF.Location = new Point(211, 25);
            mTBCPF.Mask = "000,000,000-00";
            mTBCPF.Name = "mTBCPF";
            mTBCPF.Size = new Size(124, 26);
            mTBCPF.TabIndex = 16;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(341, 20);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(119, 34);
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
            mTBTelefone.Location = new Point(297, 275);
            mTBTelefone.Mask = "(00) 00000-0000";
            mTBTelefone.Name = "mTBTelefone";
            mTBTelefone.Size = new Size(127, 26);
            mTBTelefone.TabIndex = 19;
            // 
            // mTBDtNasc
            // 
            mTBDtNasc.Location = new Point(504, 275);
            mTBDtNasc.Mask = "00/00/0000";
            mTBDtNasc.Name = "mTBDtNasc";
            mTBDtNasc.Size = new Size(87, 26);
            mTBDtNasc.TabIndex = 20;
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
            cBUf.SelectedIndexChanged += cBUf_SelectedIndexChanged;
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
            groupBox1.Controls.Add(btnNovoCli);
            groupBox1.Controls.Add(btnAlteraCli);
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
            // btnNovoCli
            // 
            btnNovoCli.Image = (Image)resources.GetObject("btnNovoCli.Image");
            btnNovoCli.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoCli.Location = new Point(6, 24);
            btnNovoCli.Name = "btnNovoCli";
            btnNovoCli.Size = new Size(149, 42);
            btnNovoCli.TabIndex = 0;
            btnNovoCli.Text = "Novo Cliente";
            btnNovoCli.TextAlign = ContentAlignment.MiddleRight;
            btnNovoCli.UseVisualStyleBackColor = true;
            btnNovoCli.Click += btnNovoCli_Click;
            // 
            // btnAlteraCli
            // 
            btnAlteraCli.Image = (Image)resources.GetObject("btnAlteraCli.Image");
            btnAlteraCli.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlteraCli.Location = new Point(6, 65);
            btnAlteraCli.Name = "btnAlteraCli";
            btnAlteraCli.Size = new Size(149, 42);
            btnAlteraCli.TabIndex = 1;
            btnAlteraCli.Text = "Alterar Cliente";
            btnAlteraCli.TextAlign = ContentAlignment.MiddleRight;
            btnAlteraCli.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCli
            // 
            btnExcluirCli.Image = (Image)resources.GetObject("btnExcluirCli.Image");
            btnExcluirCli.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirCli.Location = new Point(6, 106);
            btnExcluirCli.Name = "btnExcluirCli";
            btnExcluirCli.Size = new Size(149, 42);
            btnExcluirCli.TabIndex = 2;
            btnExcluirCli.Text = "Excluir Cliente";
            btnExcluirCli.TextAlign = ContentAlignment.MiddleRight;
            btnExcluirCli.UseVisualStyleBackColor = true;
            // 
            // dGClientes
            // 
            dGClientes.BackgroundColor = SystemColors.ActiveBorder;
            dGClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGClientes.Location = new Point(14, 349);
            dGClientes.Name = "dGClientes";
            dGClientes.RowTemplate.Height = 25;
            dGClientes.Size = new Size(748, 202);
            dGClientes.TabIndex = 26;
            dGClientes.CellContentClick += dGClientes_CellContentClick;
            dGClientes.MouseClick += dGClientes_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 328);
            label2.Name = "label2";
            label2.Size = new Size(160, 18);
            label2.TabIndex = 27;
            label2.Text = "Clientes Cadastrados";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblCódigo);
            groupBox2.Controls.Add(tbCódigo);
            groupBox2.Controls.Add(lblCpf);
            groupBox2.Controls.Add(mTBCPF);
            groupBox2.Controls.Add(btnPesquisar);
            groupBox2.Location = new Point(14, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(577, 61);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Efetuar Pesquisa";
            // 
            // btnTeste
            // 
            btnTeste.Location = new Point(595, 347);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(75, 23);
            btnTeste.TabIndex = 29;
            btnTeste.Text = "Teste de Conexão";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // lblCPF2
            // 
            lblCPF2.AutoSize = true;
            lblCPF2.Location = new Point(424, 187);
            lblCPF2.Name = "lblCPF2";
            lblCPF2.Size = new Size(41, 18);
            lblCPF2.TabIndex = 31;
            lblCPF2.Text = "CPF";
            // 
            // mTBCPF2
            // 
            mTBCPF2.Location = new Point(471, 179);
            mTBCPF2.Mask = "000,000,000-00";
            mTBCPF2.Name = "mTBCPF2";
            mTBCPF2.Size = new Size(120, 26);
            mTBCPF2.TabIndex = 32;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(777, 585);
            Controls.Add(mTBCPF2);
            Controls.Add(lblCPF2);
            Controls.Add(btnTeste);
            Controls.Add(label2);
            Controls.Add(dGClientes);
            Controls.Add(groupBox1);
            Controls.Add(tBNumero);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(cBUf);
            Controls.Add(mTBDtNasc);
            Controls.Add(mTBTelefone);
            Controls.Add(mTBCep);
            Controls.Add(tbComplemento);
            Controls.Add(tBCidade);
            Controls.Add(tBEndereço);
            Controls.Add(tbNome);
            Controls.Add(lblCidade);
            Controls.Add(lblComplemento);
            Controls.Add(lblCep);
            Controls.Add(lblTelefone);
            Controls.Add(lblUF);
            Controls.Add(lblDtNasc);
            Controls.Add(lblNome);
            Controls.Add(lblEndereço);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.Manual;
            Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGClientes).EndInit();
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
        private Label lblDtNasc;
        private Label lblUF;
        private Label lblTelefone;
        private Label lblCep;
        private Label lblCpf;
        private Label lblComplemento;
        private Label lblCidade;
        private TextBox tbCódigo;
        private TextBox tbNome;
        private TextBox tBEndereço;
        private TextBox tBCidade;
        private TextBox tbComplemento;
        private MaskedTextBox mTBCPF;
        private Button btnPesquisar;
        private MaskedTextBox mTBCep;
        private MaskedTextBox mTBTelefone;
        private MaskedTextBox mTBDtNasc;
        private ComboBox cBUf;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private TextBox tBNumero;
        private GroupBox groupBox1;
        private Button btnLimparDados;
        private Button btnNovoCli;
        private Button btnAlteraCli;
        private Button btnExcluirCli;
        private DataGridView dGClientes;
        private Label label2;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblData;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lbHora;
        private Button btnImprimirTela;
        private GroupBox groupBox2;
        private Button btnTeste;
        private Label lblCPF2;
        private MaskedTextBox mTBCPF2;
    }
}