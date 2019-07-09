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
            this.BoxMenu = new System.Windows.Forms.GroupBox();
            this.ckbCriarPasta = new System.Windows.Forms.CheckBox();
            this.checkValidarDesconto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CapturarEhLerArquivo = new System.Windows.Forms.Button();
            this.BoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxMenu
            // 
            this.BoxMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.BoxMenu.AutoSize = true;
            this.BoxMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BoxMenu.BackgroundImage = global::PaygoLogValidator.Properties.Resources.Logo_Branco;
            this.BoxMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoxMenu.Controls.Add(this.ckbCriarPasta);
            this.BoxMenu.Controls.Add(this.checkValidarDesconto);
            this.BoxMenu.Controls.Add(this.label1);
            this.BoxMenu.Controls.Add(this.CapturarEhLerArquivo);
            this.BoxMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.BoxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BoxMenu.ImeMode = System.Windows.Forms.ImeMode.On;
            this.BoxMenu.Location = new System.Drawing.Point(0, 0);
            this.BoxMenu.Name = "BoxMenu";
            this.BoxMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxMenu.Size = new System.Drawing.Size(800, 451);
            this.BoxMenu.TabIndex = 0;
            this.BoxMenu.TabStop = false;
            this.BoxMenu.UseCompatibleTextRendering = true;
            // 
            // ckbCriarPasta
            // 
            this.ckbCriarPasta.AutoSize = true;
            this.ckbCriarPasta.BackColor = System.Drawing.Color.Transparent;
            this.ckbCriarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCriarPasta.Location = new System.Drawing.Point(166, 259);
            this.ckbCriarPasta.Name = "ckbCriarPasta";
            this.ckbCriarPasta.Size = new System.Drawing.Size(149, 29);
            this.ckbCriarPasta.TabIndex = 1;
            this.ckbCriarPasta.Text = "Criar Pasta";
            this.ckbCriarPasta.UseVisualStyleBackColor = false;
            // 
            // checkValidarDesconto
            // 
            this.checkValidarDesconto.AutoSize = true;
            this.checkValidarDesconto.Checked = true;
            this.checkValidarDesconto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkValidarDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkValidarDesconto.Location = new System.Drawing.Point(166, 294);
            this.checkValidarDesconto.Name = "checkValidarDesconto";
            this.checkValidarDesconto.Size = new System.Drawing.Size(327, 29);
            this.checkValidarDesconto.TabIndex = 2;
            this.checkValidarDesconto.Text = "Validar Desconto/Acrescimo";
            this.checkValidarDesconto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(166, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o arquivo de log";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // CapturarEhLerArquivo
            // 
            this.CapturarEhLerArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(1)))));
            this.CapturarEhLerArquivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CapturarEhLerArquivo.FlatAppearance.BorderSize = 0;
            this.CapturarEhLerArquivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.CapturarEhLerArquivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.CapturarEhLerArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CapturarEhLerArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapturarEhLerArquivo.ForeColor = System.Drawing.Color.White;
            this.CapturarEhLerArquivo.Location = new System.Drawing.Point(237, 169);
            this.CapturarEhLerArquivo.Name = "CapturarEhLerArquivo";
            this.CapturarEhLerArquivo.Size = new System.Drawing.Size(276, 63);
            this.CapturarEhLerArquivo.TabIndex = 0;
            this.CapturarEhLerArquivo.Text = "Abrir arquivo";
            this.CapturarEhLerArquivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CapturarEhLerArquivo.UseVisualStyleBackColor = false;
            this.CapturarEhLerArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BoxMenu.ResumeLayout(false);
            this.BoxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxMenu;
        private System.Windows.Forms.Button CapturarEhLerArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbCriarPasta;
        private System.Windows.Forms.CheckBox checkValidarDesconto;
    }
}

