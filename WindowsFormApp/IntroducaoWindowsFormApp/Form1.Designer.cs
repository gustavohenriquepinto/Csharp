namespace IntroducaoWindowsFormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botao01 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botao01
            // 
            this.botao01.BackColor = System.Drawing.Color.Black;
            this.botao01.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao01.ForeColor = System.Drawing.Color.Coral;
            this.botao01.Location = new System.Drawing.Point(254, 138);
            this.botao01.Name = "botao01";
            this.botao01.Size = new System.Drawing.Size(246, 123);
            this.botao01.TabIndex = 0;
            this.botao01.Text = "Não Clique Aqui!";
            this.botao01.UseVisualStyleBackColor = false;
            this.botao01.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.botao01);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olá, Mundo!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botao01;
    }
}

