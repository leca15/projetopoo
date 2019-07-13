namespace Apresentacao
{
    partial class PesqExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesqExame));
            this.btPesqExame = new System.Windows.Forms.Button();
            this.opPesqEx = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mksPesqEx = new System.Windows.Forms.MaskedTextBox();
            this.dgvPesqEx = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqEx)).BeginInit();
            this.SuspendLayout();
            // 
            // btPesqExame
            // 
            this.btPesqExame.BackColor = System.Drawing.Color.Transparent;
            this.btPesqExame.FlatAppearance.BorderSize = 0;
            this.btPesqExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqExame.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesqExame.Location = new System.Drawing.Point(783, 121);
            this.btPesqExame.Name = "btPesqExame";
            this.btPesqExame.Size = new System.Drawing.Size(184, 59);
            this.btPesqExame.TabIndex = 1;
            this.btPesqExame.Text = "Ir";
            this.btPesqExame.UseVisualStyleBackColor = false;
            this.btPesqExame.Click += new System.EventHandler(this.btPesqExame_Click);
            // 
            // opPesqEx
            // 
            this.opPesqEx.BackColor = System.Drawing.Color.Transparent;
            this.opPesqEx.FlatAppearance.BorderSize = 0;
            this.opPesqEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opPesqEx.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opPesqEx.Location = new System.Drawing.Point(1022, 558);
            this.opPesqEx.Name = "opPesqEx";
            this.opPesqEx.Size = new System.Drawing.Size(184, 61);
            this.opPesqEx.TabIndex = 2;
            this.opPesqEx.Text = "Opções";
            this.opPesqEx.UseVisualStyleBackColor = false;
            this.opPesqEx.Click += new System.EventHandler(this.opPesqEx_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(197, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF do dono :";
            // 
            // mksPesqEx
            // 
            this.mksPesqEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mksPesqEx.Location = new System.Drawing.Point(397, 139);
            this.mksPesqEx.Mask = "000.000.000-00";
            this.mksPesqEx.Name = "mksPesqEx";
            this.mksPesqEx.Size = new System.Drawing.Size(371, 30);
            this.mksPesqEx.TabIndex = 0;
            // 
            // dgvPesqEx
            // 
            this.dgvPesqEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesqEx.Location = new System.Drawing.Point(209, 246);
            this.dgvPesqEx.Name = "dgvPesqEx";
            this.dgvPesqEx.RowTemplate.Height = 24;
            this.dgvPesqEx.Size = new System.Drawing.Size(777, 373);
            this.dgvPesqEx.TabIndex = 4;
            this.dgvPesqEx.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesqEx_CellContentClick);
            // 
            // PesqExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.dgvPesqEx);
            this.Controls.Add(this.mksPesqEx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opPesqEx);
            this.Controls.Add(this.btPesqExame);
            this.DoubleBuffered = true;
            this.Name = "PesqExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesqExame";
            this.Load += new System.EventHandler(this.PesqExame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqEx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPesqExame;
        private System.Windows.Forms.Button opPesqEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mksPesqEx;
        private System.Windows.Forms.DataGridView dgvPesqEx;
    }
}