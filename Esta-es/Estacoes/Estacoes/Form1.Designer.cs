namespace Estacoes
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
            this.pic_primeiro = new System.Windows.Forms.PictureBox();
            this.lbl_primeiro = new System.Windows.Forms.Label();
            this.txt_primeiro = new System.Windows.Forms.TextBox();
            this.rad_primeiro = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_primeiro)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_primeiro
            // 
            this.pic_primeiro.Location = new System.Drawing.Point(319, 57);
            this.pic_primeiro.Name = "pic_primeiro";
            this.pic_primeiro.Size = new System.Drawing.Size(443, 381);
            this.pic_primeiro.TabIndex = 0;
            this.pic_primeiro.TabStop = false;
            // 
            // lbl_primeiro
            // 
            this.lbl_primeiro.AutoSize = true;
            this.lbl_primeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primeiro.Location = new System.Drawing.Point(373, 26);
            this.lbl_primeiro.Name = "lbl_primeiro";
            this.lbl_primeiro.Size = new System.Drawing.Size(96, 16);
            this.lbl_primeiro.TabIndex = 1;
            this.lbl_primeiro.Text = "Informações:";
            // 
            // txt_primeiro
            // 
            this.txt_primeiro.Enabled = false;
            this.txt_primeiro.Location = new System.Drawing.Point(462, 26);
            this.txt_primeiro.Name = "txt_primeiro";
            this.txt_primeiro.Size = new System.Drawing.Size(169, 20);
            this.txt_primeiro.TabIndex = 2;
            // 
            // rad_primeiro
            // 
            this.rad_primeiro.AutoSize = true;
            this.rad_primeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_primeiro.Location = new System.Drawing.Point(70, 68);
            this.rad_primeiro.Name = "rad_primeiro";
            this.rad_primeiro.Size = new System.Drawing.Size(83, 20);
            this.rad_primeiro.TabIndex = 3;
            this.rad_primeiro.Text = "Primeiro";
            this.rad_primeiro.UseVisualStyleBackColor = true;
            this.rad_primeiro.CheckedChanged += new System.EventHandler(this.rad_primeiro_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rad_primeiro);
            this.Controls.Add(this.txt_primeiro);
            this.Controls.Add(this.lbl_primeiro);
            this.Controls.Add(this.pic_primeiro);
            this.Name = "Form1";
            this.Text = "Estações";
            ((System.ComponentModel.ISupportInitialize)(this.pic_primeiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_primeiro;
        private System.Windows.Forms.Label lbl_primeiro;
        private System.Windows.Forms.TextBox txt_primeiro;
        private System.Windows.Forms.RadioButton rad_primeiro;
    }
}

