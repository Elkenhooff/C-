namespace ListasdeTarefas
{
    partial class FrmTarefas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTarefas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.pBImagem = new System.Windows.Forms.PictureBox();
            this.btnImagem = new System.Windows.Forms.Button();
            this.mTBCPF = new System.Windows.Forms.MaskedTextBox();
            this.mTBTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Pessoal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 139);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(268, 26);
            this.txtNome.TabIndex = 5;
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(12, 247);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(194, 26);
            this.dtNascimento.TabIndex = 7;
            // 
            // pBImagem
            // 
            this.pBImagem.BackColor = System.Drawing.Color.Transparent;
            this.pBImagem.ErrorImage = null;
            this.pBImagem.InitialImage = null;
            this.pBImagem.Location = new System.Drawing.Point(362, 139);
            this.pBImagem.Name = "pBImagem";
            this.pBImagem.Size = new System.Drawing.Size(190, 179);
            this.pBImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBImagem.TabIndex = 9;
            this.pBImagem.TabStop = false;
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(362, 324);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(190, 32);
            this.btnImagem.TabIndex = 10;
            this.btnImagem.Text = "Inserir Imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // mTBCPF
            // 
            this.mTBCPF.Location = new System.Drawing.Point(12, 193);
            this.mTBCPF.Mask = "000,000,000-00";
            this.mTBCPF.Name = "mTBCPF";
            this.mTBCPF.Size = new System.Drawing.Size(194, 26);
            this.mTBCPF.TabIndex = 11;
            // 
            // mTBTelefone
            // 
            this.mTBTelefone.Location = new System.Drawing.Point(12, 301);
            this.mTBTelefone.Mask = "(00) 00000-0000";
            this.mTBTelefone.Name = "mTBTelefone";
            this.mTBTelefone.Size = new System.Drawing.Size(194, 26);
            this.mTBTelefone.TabIndex = 12;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(362, 371);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(190, 34);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Salvar Tela";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(219, 371);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(137, 34);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 426);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.mTBTelefone);
            this.Controls.Add(this.mTBCPF);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.pBImagem);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private DateTimePicker dtNascimento;
        private PictureBox pBImagem;
        private Button btnImagem;
        private MaskedTextBox mTBCPF;
        private MaskedTextBox mTBTelefone;
        private Button btnPrint;
        private Button btnLimpar;
    }
}