namespace Apresentacao
{
    partial class ListadePets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadePets));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNomeli = new System.Windows.Forms.TextBox();
            this.btBuscarPets = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mksCpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(105, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome cliente :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(753, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF cliente :";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtID.Location = new System.Drawing.Point(246, 107);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(124, 30);
            this.txtID.TabIndex = 3;
            // 
            // txtNomeli
            // 
            this.txtNomeli.Enabled = false;
            this.txtNomeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeli.Location = new System.Drawing.Point(319, 173);
            this.txtNomeli.Name = "txtNomeli";
            this.txtNomeli.Size = new System.Drawing.Size(406, 30);
            this.txtNomeli.TabIndex = 4;
            // 
            // btBuscarPets
            // 
            this.btBuscarPets.BackColor = System.Drawing.Color.Transparent;
            this.btBuscarPets.FlatAppearance.BorderSize = 0;
            this.btBuscarPets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarPets.Font = new System.Drawing.Font("Palatino Linotype", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btBuscarPets.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarPets.Image")));
            this.btBuscarPets.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscarPets.Location = new System.Drawing.Point(502, 251);
            this.btBuscarPets.Name = "btBuscarPets";
            this.btBuscarPets.Size = new System.Drawing.Size(242, 49);
            this.btBuscarPets.TabIndex = 6;
            this.btBuscarPets.Text = "Buscar";
            this.btBuscarPets.UseVisualStyleBackColor = false;
            this.btBuscarPets.Click += new System.EventHandler(this.btBuscarPets_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 285);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mksCpf
            // 
            this.mksCpf.Enabled = false;
            this.mksCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mksCpf.Location = new System.Drawing.Point(964, 173);
            this.mksCpf.Mask = "000.000.000-00";
            this.mksCpf.Name = "mksCpf";
            this.mksCpf.Size = new System.Drawing.Size(223, 30);
            this.mksCpf.TabIndex = 8;
            this.mksCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mksCpf_MaskInputRejected);
            // 
            // ListadePets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.mksCpf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btBuscarPets);
            this.Controls.Add(this.txtNomeli);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ListadePets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadePets";
            this.Load += new System.EventHandler(this.ListadePets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNomeli;
        private System.Windows.Forms.Button btBuscarPets;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mksCpf;
    }
}