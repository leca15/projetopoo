namespace Apresentacao
{
    partial class PesquisaAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaAnimal));
            this.label1 = new System.Windows.Forms.Label();
            this.btPesqAnimal = new System.Windows.Forms.Button();
            this.dgvPesqAnimal = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.mksPesqAniCPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o CPF do dono do animal :";
            // 
            // btPesqAnimal
            // 
            this.btPesqAnimal.BackColor = System.Drawing.Color.Transparent;
            this.btPesqAnimal.FlatAppearance.BorderSize = 0;
            this.btPesqAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqAnimal.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btPesqAnimal.Image = ((System.Drawing.Image)(resources.GetObject("btPesqAnimal.Image")));
            this.btPesqAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesqAnimal.Location = new System.Drawing.Point(524, 241);
            this.btPesqAnimal.Name = "btPesqAnimal";
            this.btPesqAnimal.Size = new System.Drawing.Size(273, 71);
            this.btPesqAnimal.TabIndex = 1;
            this.btPesqAnimal.Text = "Pesquisar";
            this.btPesqAnimal.UseVisualStyleBackColor = false;
            this.btPesqAnimal.Click += new System.EventHandler(this.btPesqAnimal_Click);
            // 
            // dgvPesqAnimal
            // 
            this.dgvPesqAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesqAnimal.Location = new System.Drawing.Point(297, 318);
            this.dgvPesqAnimal.Name = "dgvPesqAnimal";
            this.dgvPesqAnimal.RowTemplate.Height = 24;
            this.dgvPesqAnimal.Size = new System.Drawing.Size(703, 276);
            this.dgvPesqAnimal.TabIndex = 3;
            this.dgvPesqAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesqAnimal_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1035, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Opções";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mksPesqAniCPF
            // 
            this.mksPesqAniCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mksPesqAniCPF.Location = new System.Drawing.Point(571, 158);
            this.mksPesqAniCPF.Mask = "000.000.000-00";
            this.mksPesqAniCPF.Name = "mksPesqAniCPF";
            this.mksPesqAniCPF.Size = new System.Drawing.Size(372, 30);
            this.mksPesqAniCPF.TabIndex = 0;
            // 
            // PesquisaAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.mksPesqAniCPF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPesqAnimal);
            this.Controls.Add(this.btPesqAnimal);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "PesquisaAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisaAnimal";
            this.Load += new System.EventHandler(this.PesquisaAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPesqAnimal;
        private System.Windows.Forms.DataGridView dgvPesqAnimal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mksPesqAniCPF;
    }
}