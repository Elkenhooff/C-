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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.tbCódigo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tBEndereço = new System.Windows.Forms.TextBox();
            this.tBCidade = new System.Windows.Forms.TextBox();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.mTBCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.mTBCep = new System.Windows.Forms.MaskedTextBox();
            this.mTBTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mTBDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.cBUf = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tBNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimirTela = new System.Windows.Forms.Button();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.btnNovoCli = new System.Windows.Forms.Button();
            this.btnAlteraCli = new System.Windows.Forms.Button();
            this.btnExcluirCli = new System.Windows.Forms.Button();
            this.dGClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTeste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(777, 91);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Location = new System.Drawing.Point(4, 33);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(60, 18);
            this.lblCódigo.TabIndex = 1;
            this.lblCódigo.Text = "Código";
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(18, 214);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(76, 18);
            this.lblEndereço.TabIndex = 2;
            this.lblEndereço.Text = "Endereço";
            this.lblEndereço.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 187);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 18);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(430, 278);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(68, 18);
            this.lblDtNasc.TabIndex = 4;
            this.lblDtNasc.Text = "Dt. Nasc";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(493, 248);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(29, 18);
            this.lblUF.TabIndex = 5;
            this.lblUF.Text = "UF";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(225, 278);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 18);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Click += new System.EventHandler(this.lblTelefone_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(350, 248);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(42, 18);
            this.lblCep.TabIndex = 7;
            this.lblCep.Text = "CEP";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(164, 33);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(41, 18);
            this.lblCpf.TabIndex = 8;
            this.lblCpf.Text = "CPF";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(18, 278);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(58, 18);
            this.lblComplemento.TabIndex = 9;
            this.lblComplemento.Text = "Compl:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(18, 246);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(60, 18);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade";
            // 
            // tbCódigo
            // 
            this.tbCódigo.Location = new System.Drawing.Point(80, 25);
            this.tbCódigo.Name = "tbCódigo";
            this.tbCódigo.Size = new System.Drawing.Size(78, 26);
            this.tbCódigo.TabIndex = 11;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(94, 179);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(497, 26);
            this.tbNome.TabIndex = 12;
            // 
            // tBEndereço
            // 
            this.tBEndereço.Location = new System.Drawing.Point(94, 211);
            this.tBEndereço.Name = "tBEndereço";
            this.tBEndereço.Size = new System.Drawing.Size(393, 26);
            this.tBEndereço.TabIndex = 13;
            // 
            // tBCidade
            // 
            this.tBCidade.Location = new System.Drawing.Point(94, 243);
            this.tBCidade.Name = "tBCidade";
            this.tBCidade.Size = new System.Drawing.Size(255, 26);
            this.tBCidade.TabIndex = 14;
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(94, 275);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(130, 26);
            this.tbComplemento.TabIndex = 15;
            // 
            // mTBCPF
            // 
            this.mTBCPF.Location = new System.Drawing.Point(211, 25);
            this.mTBCPF.Mask = "000,000,000-00";
            this.mTBCPF.Name = "mTBCPF";
            this.mTBCPF.Size = new System.Drawing.Size(124, 26);
            this.mTBCPF.TabIndex = 16;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(341, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(119, 34);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // mTBCep
            // 
            this.mTBCep.Location = new System.Drawing.Point(398, 245);
            this.mTBCep.Mask = "00000-000";
            this.mTBCep.Name = "mTBCep";
            this.mTBCep.Size = new System.Drawing.Size(89, 26);
            this.mTBCep.TabIndex = 18;
            // 
            // mTBTelefone
            // 
            this.mTBTelefone.Location = new System.Drawing.Point(297, 275);
            this.mTBTelefone.Mask = "(00) 00000-0000";
            this.mTBTelefone.Name = "mTBTelefone";
            this.mTBTelefone.Size = new System.Drawing.Size(127, 26);
            this.mTBTelefone.TabIndex = 19;
            // 
            // mTBDtNasc
            // 
            this.mTBDtNasc.Location = new System.Drawing.Point(504, 275);
            this.mTBDtNasc.Mask = "00/00/0000";
            this.mTBDtNasc.Name = "mTBDtNasc";
            this.mTBDtNasc.Size = new System.Drawing.Size(87, 26);
            this.mTBDtNasc.TabIndex = 20;
            // 
            // cBUf
            // 
            this.cBUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBUf.FormattingEnabled = true;
            this.cBUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "GO",
            "ES",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SP",
            "SC",
            "SE",
            "TO"});
            this.cBUf.Location = new System.Drawing.Point(528, 248);
            this.cBUf.Name = "cBUf";
            this.cBUf.Size = new System.Drawing.Size(63, 26);
            this.cBUf.TabIndex = 21;
            this.cBUf.SelectedIndexChanged += new System.EventHandler(this.cBUf_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblData,
            this.toolStripStatusLabel2,
            this.lbHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(777, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "Hoje é";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(118, 17);
            this.lblData.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // lbHora
            // 
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(118, 17);
            this.lbHora.Text = "toolStripStatusLabel3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "N°";
            // 
            // tBNumero
            // 
            this.tBNumero.Location = new System.Drawing.Point(528, 216);
            this.tBNumero.Name = "tBNumero";
            this.tBNumero.Size = new System.Drawing.Size(63, 26);
            this.tBNumero.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimirTela);
            this.groupBox1.Controls.Add(this.btnLimparDados);
            this.groupBox1.Controls.Add(this.btnNovoCli);
            this.groupBox1.Controls.Add(this.btnAlteraCli);
            this.groupBox1.Controls.Add(this.btnExcluirCli);
            this.groupBox1.Location = new System.Drawing.Point(597, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 239);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comandos";
            // 
            // btnImprimirTela
            // 
            this.btnImprimirTela.Font = new System.Drawing.Font("Arial", 12.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImprimirTela.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirTela.Image")));
            this.btnImprimirTela.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnImprimirTela.Location = new System.Drawing.Point(6, 190);
            this.btnImprimirTela.Name = "btnImprimirTela";
            this.btnImprimirTela.Size = new System.Drawing.Size(149, 42);
            this.btnImprimirTela.TabIndex = 4;
            this.btnImprimirTela.Text = "Imprimir Tela";
            this.btnImprimirTela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirTela.UseVisualStyleBackColor = true;
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimparDados.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparDados.Image")));
            this.btnLimparDados.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLimparDados.Location = new System.Drawing.Point(6, 148);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(149, 42);
            this.btnLimparDados.TabIndex = 3;
            this.btnLimparDados.Text = "Limpar Dados";
            this.btnLimparDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparDados.UseVisualStyleBackColor = true;
            // 
            // btnNovoCli
            // 
            this.btnNovoCli.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCli.Image")));
            this.btnNovoCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCli.Location = new System.Drawing.Point(6, 24);
            this.btnNovoCli.Name = "btnNovoCli";
            this.btnNovoCli.Size = new System.Drawing.Size(149, 42);
            this.btnNovoCli.TabIndex = 0;
            this.btnNovoCli.Text = "Novo Cliente";
            this.btnNovoCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoCli.UseVisualStyleBackColor = true;
            // 
            // btnAlteraCli
            // 
            this.btnAlteraCli.Image = ((System.Drawing.Image)(resources.GetObject("btnAlteraCli.Image")));
            this.btnAlteraCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlteraCli.Location = new System.Drawing.Point(6, 65);
            this.btnAlteraCli.Name = "btnAlteraCli";
            this.btnAlteraCli.Size = new System.Drawing.Size(149, 42);
            this.btnAlteraCli.TabIndex = 1;
            this.btnAlteraCli.Text = "Alterar Cliente";
            this.btnAlteraCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlteraCli.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCli
            // 
            this.btnExcluirCli.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCli.Image")));
            this.btnExcluirCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCli.Location = new System.Drawing.Point(6, 106);
            this.btnExcluirCli.Name = "btnExcluirCli";
            this.btnExcluirCli.Size = new System.Drawing.Size(149, 42);
            this.btnExcluirCli.TabIndex = 2;
            this.btnExcluirCli.Text = "Excluir Cliente";
            this.btnExcluirCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCli.UseVisualStyleBackColor = true;
            // 
            // dGClientes
            // 
            this.dGClientes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGClientes.Location = new System.Drawing.Point(14, 349);
            this.dGClientes.Name = "dGClientes";
            this.dGClientes.RowTemplate.Height = 25;
            this.dGClientes.Size = new System.Drawing.Size(748, 202);
            this.dGClientes.TabIndex = 26;
            this.dGClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGClientes_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Clientes Cadastrados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCódigo);
            this.groupBox2.Controls.Add(this.tbCódigo);
            this.groupBox2.Controls.Add(this.lblCpf);
            this.groupBox2.Controls.Add(this.mTBCPF);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Location = new System.Drawing.Point(14, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 61);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Efetuar Pesquisa";
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(595, 347);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(75, 23);
            this.btnTeste.TabIndex = 29;
            this.btnTeste.Text = "Teste de Conexão";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(777, 585);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tBNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cBUf);
            this.Controls.Add(this.mTBDtNasc);
            this.Controls.Add(this.mTBTelefone);
            this.Controls.Add(this.mTBCep);
            this.Controls.Add(this.tbComplemento);
            this.Controls.Add(this.tBCidade);
            this.Controls.Add(this.tBEndereço);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}