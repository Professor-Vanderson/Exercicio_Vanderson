
namespace Atitividade
{
    partial class frmReajuste
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnReajuste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor do Salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(140, 12);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // btnReajuste
            // 
            this.btnReajuste.Location = new System.Drawing.Point(265, 12);
            this.btnReajuste.Name = "btnReajuste";
            this.btnReajuste.Size = new System.Drawing.Size(108, 23);
            this.btnReajuste.TabIndex = 2;
            this.btnReajuste.Text = "Calcular Reajuste";
            this.btnReajuste.UseVisualStyleBackColor = true;
            this.btnReajuste.Click += new System.EventHandler(this.btnReajuste_Click);
            // 
            // frmReajuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 98);
            this.Controls.Add(this.btnReajuste);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Name = "frmReajuste";
            this.Text = "Reajuste de salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnReajuste;
    }
}