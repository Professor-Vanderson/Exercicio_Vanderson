
namespace Atitividade
{
    partial class frmMedia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.btnMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1: ";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(63, 9);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 2:";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(63, 35);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota 3";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(63, 61);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota 4";
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(63, 87);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 20);
            this.txtNota4.TabIndex = 7;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(209, 49);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(96, 23);
            this.btnMedia.TabIndex = 8;
            this.btnMedia.Text = "Calcular Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 153);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label1);
            this.Name = "frmMedia";
            this.Text = "Media dos alunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Button btnMedia;
    }
}

