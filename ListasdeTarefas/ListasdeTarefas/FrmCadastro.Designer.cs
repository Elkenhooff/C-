namespace ListasdeTarefas
{
    partial class FrmCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listTarefa = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtLimite = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblRealizado = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data de hoje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarefa a ser executada";
            // 
            // listTarefa
            // 
            this.listTarefa.BackColor = System.Drawing.Color.Gainsboro;
            this.listTarefa.FormattingEnabled = true;
            this.listTarefa.ItemHeight = 18;
            this.listTarefa.Location = new System.Drawing.Point(12, 378);
            this.listTarefa.Name = "listTarefa";
            this.listTarefa.Size = new System.Drawing.Size(388, 112);
            this.listTarefa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data limite";
            // 
            // dtLimite
            // 
            this.dtLimite.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtLimite.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtLimite.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dtLimite.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dtLimite.CalendarTrailingForeColor = System.Drawing.Color.Gainsboro;
            this.dtLimite.Location = new System.Drawing.Point(12, 300);
            this.dtLimite.Name = "dtLimite";
            this.dtLimite.Size = new System.Drawing.Size(388, 26);
            this.dtLimite.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(305, 332);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 32);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(95, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lista de Tarefas";
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(305, 496);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(95, 32);
            this.btnExibir.TabIndex = 12;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // txtTarefa
            // 
            this.txtTarefa.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTarefa.Location = new System.Drawing.Point(12, 223);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(388, 26);
            this.txtTarefa.TabIndex = 11;
            this.txtTarefa.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(12, 155);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(50, 18);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "label6";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 88);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(50, 18);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "label6";
            // 
            // lblRealizado
            // 
            this.lblRealizado.AutoSize = true;
            this.lblRealizado.Location = new System.Drawing.Point(12, 339);
            this.lblRealizado.Name = "lblRealizado";
            this.lblRealizado.Size = new System.Drawing.Size(0, 18);
            this.lblRealizado.TabIndex = 16;
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(204, 332);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 32);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(412, 544);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblRealizado);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtLimite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listTarefa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listTarefa;
        private Label label4;
        private DateTimePicker dtLimite;
        private Button btnSalvar;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        private Button btnExibir;
        private TextBox txtTarefa;
        private Label lblHora;
        private Label lblData;
        private Label lblRealizado;
        private System.Windows.Forms.Timer timer2;
        private Button btnLimpar;
    }
}