﻿
namespace Atitividade
{
    partial class frmParImpar
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnVerficar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(121, 16);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 1;
            // 
            // btnVerficar
            // 
            this.btnVerficar.Location = new System.Drawing.Point(256, 14);
            this.btnVerficar.Name = "btnVerficar";
            this.btnVerficar.Size = new System.Drawing.Size(98, 23);
            this.btnVerficar.TabIndex = 2;
            this.btnVerficar.Text = "Verificar número";
            this.btnVerficar.UseVisualStyleBackColor = true;
            this.btnVerficar.Click += new System.EventHandler(this.btnVerficar_Click);
            // 
            // frmParImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 80);
            this.Controls.Add(this.btnVerficar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "frmParImpar";
            this.Text = "Verificar número Par ou impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnVerficar;
    }
}