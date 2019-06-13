namespace PaygoLogValidator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbCriarPasta = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CapturarEhLerArquivo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.ckbCriarPasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CapturarEhLerArquivo);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(291, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PaygoBox";
            // 
            // ckbCriarPasta
            // 
            this.ckbCriarPasta.AutoSize = true;
            this.ckbCriarPasta.Location = new System.Drawing.Point(6, 147);
            this.ckbCriarPasta.Name = "ckbCriarPasta";
            this.ckbCriarPasta.Size = new System.Drawing.Size(77, 17);
            this.ckbCriarPasta.TabIndex = 1;
            this.ckbCriarPasta.Text = "Criar Pasta";
            this.ckbCriarPasta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha um arquivo";
            // 
            // CapturarEhLerArquivo
            // 
            this.CapturarEhLerArquivo.Location = new System.Drawing.Point(48, 45);
            this.CapturarEhLerArquivo.Name = "CapturarEhLerArquivo";
            this.CapturarEhLerArquivo.Size = new System.Drawing.Size(113, 29);
            this.CapturarEhLerArquivo.TabIndex = 0;
            this.CapturarEhLerArquivo.Text = "Abrir Arquivo";
            this.CapturarEhLerArquivo.UseVisualStyleBackColor = true;
            this.CapturarEhLerArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CapturarEhLerArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbCriarPasta;
    }
}

