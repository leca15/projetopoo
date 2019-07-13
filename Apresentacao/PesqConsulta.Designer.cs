namespace Apresentacao
{
    partial class PesqConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesqConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btOpcoesCons = new System.Windows.Forms.Button();
            this.dgvPesqCons = new System.Windows.Forms.DataGridView();
            this.mksPesqCons = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqCons)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF dono do animal :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(1008, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btOpcoesCons
            // 
            this.btOpcoesCons.BackColor = System.Drawing.Color.Transparent;
            this.btOpcoesCons.FlatAppearance.BorderSize = 0;
            this.btOpcoesCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpcoesCons.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpcoesCons.Location = new System.Drawing.Point(1044, 527);
            this.btOpcoesCons.Name = "btOpcoesCons";
            this.btOpcoesCons.Size = new System.Drawing.Size(209, 63);
            this.btOpcoesCons.TabIndex = 3;
            this.btOpcoesCons.Text = "Opções";
            this.btOpcoesCons.UseVisualStyleBackColor = false;
            this.btOpcoesCons.Click += new System.EventHandler(this.btOpcoesCons_Click);
            // 
            // dgvPesqCons
            // 
            this.dgvPesqCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesqCons.Location = new System.Drawing.Point(143, 198);
            this.dgvPesqCons.Name = "dgvPesqCons";
            this.dgvPesqCons.RowTemplate.Height = 24;
            this.dgvPesqCons.Size = new System.Drawing.Size(895, 410);
            this.dgvPesqCons.TabIndex = 4;
            this.dgvPesqCons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesqCons_CellContentClick);
            // 
            // mksPesqCons
            // 
            this.mksPesqCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mksPesqCons.Location = new System.Drawing.Point(378, 107);
            this.mksPesqCons.Mask = "000.000.000-00";
            this.mksPesqCons.Name = "mksPesqCons";
            this.mksPesqCons.Size = new System.Drawing.Size(370, 30);
            this.mksPesqCons.TabIndex = 0;
            this.mksPesqCons.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mksPesqCons_MaskInputRejected);
            // 
            // PesqConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.mksPesqCons);
            this.Controls.Add(this.dgvPesqCons);
            this.Controls.Add(this.btOpcoesCons);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "PesqConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesqConsulta";
            this.Load += new System.EventHandler(this.PesqConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqCons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btOpcoesCons;
        private System.Windows.Forms.DataGridView dgvPesqCons;
        private System.Windows.Forms.MaskedTextBox mksPesqCons;
    }
}