namespace Apresentacao
{
    partial class ListAtendimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAtendimentos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.txtfim = new System.Windows.Forms.TextBox();
            this.txtinicio = new System.Windows.Forms.TextBox();
            this.btAtend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAtendimentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione um período :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Atendimentos :";
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(101, 206);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 2;
            // 
            // txtfim
            // 
            this.txtfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtfim.Location = new System.Drawing.Point(232, 590);
            this.txtfim.Name = "txtfim";
            this.txtfim.Size = new System.Drawing.Size(123, 30);
            this.txtfim.TabIndex = 3;
            // 
            // txtinicio
            // 
            this.txtinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtinicio.Location = new System.Drawing.Point(232, 533);
            this.txtinicio.Name = "txtinicio";
            this.txtinicio.Size = new System.Drawing.Size(123, 30);
            this.txtinicio.TabIndex = 4;
            // 
            // btAtend
            // 
            this.btAtend.BackColor = System.Drawing.Color.Transparent;
            this.btAtend.FlatAppearance.BorderSize = 0;
            this.btAtend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtend.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtend.Location = new System.Drawing.Point(123, 425);
            this.btAtend.Name = "btAtend";
            this.btAtend.Size = new System.Drawing.Size(194, 47);
            this.btAtend.TabIndex = 5;
            this.btAtend.Text = "Pronto";
            this.btAtend.UseVisualStyleBackColor = false;
            this.btAtend.Click += new System.EventHandler(this.btAtend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data inicio :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data termino :";
            // 
            // dgvAtendimentos
            // 
            this.dgvAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendimentos.Location = new System.Drawing.Point(633, 149);
            this.dgvAtendimentos.Name = "dgvAtendimentos";
            this.dgvAtendimentos.RowTemplate.Height = 24;
            this.dgvAtendimentos.Size = new System.Drawing.Size(568, 463);
            this.dgvAtendimentos.TabIndex = 8;
            // 
            // ListAtendimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.dgvAtendimentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAtend);
            this.Controls.Add(this.txtinicio);
            this.Controls.Add(this.txtfim);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ListAtendimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListAtendimentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.TextBox txtfim;
        private System.Windows.Forms.TextBox txtinicio;
        private System.Windows.Forms.Button btAtend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAtendimentos;
    }
}