namespace Apresentacao
{
    partial class PesquisaCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaCli));
            this.label1 = new System.Windows.Forms.Label();
            this.btPesqCli = new System.Windows.Forms.Button();
            this.dgvPesqCli = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mksPesqCli = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqCli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF do cliente :";
            // 
            // btPesqCli
            // 
            this.btPesqCli.BackColor = System.Drawing.Color.Transparent;
            this.btPesqCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btPesqCli.FlatAppearance.BorderSize = 0;
            this.btPesqCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqCli.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesqCli.Image = ((System.Drawing.Image)(resources.GetObject("btPesqCli.Image")));
            this.btPesqCli.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btPesqCli.Location = new System.Drawing.Point(986, 113);
            this.btPesqCli.Name = "btPesqCli";
            this.btPesqCli.Size = new System.Drawing.Size(155, 55);
            this.btPesqCli.TabIndex = 1;
            this.btPesqCli.Text = "Ir";
            this.btPesqCli.UseVisualStyleBackColor = false;
            this.btPesqCli.Click += new System.EventHandler(this.btPesqCli_Click);
            // 
            // dgvPesqCli
            // 
            this.dgvPesqCli.BackgroundColor = System.Drawing.Color.White;
            this.dgvPesqCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPesqCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesqCli.Location = new System.Drawing.Point(150, 213);
            this.dgvPesqCli.Name = "dgvPesqCli";
            this.dgvPesqCli.RowTemplate.Height = 24;
            this.dgvPesqCli.Size = new System.Drawing.Size(861, 351);
            this.dgvPesqCli.TabIndex = 3;
            this.dgvPesqCli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesqCli_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Script MT Bold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(1017, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listar Pets";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(1017, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "Opções ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mksPesqCli
            // 
            this.mksPesqCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mksPesqCli.Location = new System.Drawing.Point(423, 125);
            this.mksPesqCli.Mask = "000.000.000-00";
            this.mksPesqCli.Name = "mksPesqCli";
            this.mksPesqCli.Size = new System.Drawing.Size(319, 30);
            this.mksPesqCli.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.Location = new System.Drawing.Point(1017, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 70);
            this.button3.TabIndex = 4;
            this.button3.Text = "Histórico";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PesquisaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mksPesqCli);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPesqCli);
            this.Controls.Add(this.btPesqCli);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "PesquisaCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisaCli";
            this.Load += new System.EventHandler(this.PesquisaCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPesqCli;
        private System.Windows.Forms.DataGridView dgvPesqCli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mksPesqCli;
        private System.Windows.Forms.Button button3;
    }
}