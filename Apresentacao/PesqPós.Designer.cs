﻿namespace Apresentacao
{
    partial class PesqPós
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesqPós));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPesqPós = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.mksPesqPós = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqPós)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(988, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(112, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF do dono do animal :";
            // 
            // dgvPesqPós
            // 
            this.dgvPesqPós.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesqPós.Location = new System.Drawing.Point(219, 241);
            this.dgvPesqPós.Name = "dgvPesqPós";
            this.dgvPesqPós.RowTemplate.Height = 24;
            this.dgvPesqPós.Size = new System.Drawing.Size(791, 370);
            this.dgvPesqPós.TabIndex = 3;
            this.dgvPesqPós.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesqPós_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(1047, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "Próximo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mksPesqPós
            // 
            this.mksPesqPós.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mksPesqPós.Location = new System.Drawing.Point(454, 119);
            this.mksPesqPós.Mask = "000.000.000-00";
            this.mksPesqPós.Name = "mksPesqPós";
            this.mksPesqPós.Size = new System.Drawing.Size(301, 30);
            this.mksPesqPós.TabIndex = 0;
            // 
            // PesqPós
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.mksPesqPós);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvPesqPós);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "PesqPós";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesqPós";
            this.Load += new System.EventHandler(this.PesqPós_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqPós)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPesqPós;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mksPesqPós;
    }
}