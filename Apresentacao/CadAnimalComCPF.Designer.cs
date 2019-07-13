namespace Apresentacao
{
    partial class CadAnimalComCPF
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPFdonoCadAvuAnimal = new System.Windows.Forms.TextBox();
            this.txtNomeAniCadAvul = new System.Windows.Forms.TextBox();
            this.txtPorteAniCadAvul = new System.Windows.Forms.TextBox();
            this.txtRaçaCadAniAvul = new System.Windows.Forms.TextBox();
            this.dgvCadAniAvulso = new System.Windows.Forms.DataGridView();
            this.btCadAniAvulso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadAniAvulso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF do dono do animal :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do animal :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porte :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Raça :";
            // 
            // txtCPFdonoCadAvuAnimal
            // 
            this.txtCPFdonoCadAvuAnimal.Location = new System.Drawing.Point(233, 48);
            this.txtCPFdonoCadAvuAnimal.Name = "txtCPFdonoCadAvuAnimal";
            this.txtCPFdonoCadAvuAnimal.Size = new System.Drawing.Size(216, 22);
            this.txtCPFdonoCadAvuAnimal.TabIndex = 4;
            // 
            // txtNomeAniCadAvul
            // 
            this.txtNomeAniCadAvul.Location = new System.Drawing.Point(196, 107);
            this.txtNomeAniCadAvul.Name = "txtNomeAniCadAvul";
            this.txtNomeAniCadAvul.Size = new System.Drawing.Size(253, 22);
            this.txtNomeAniCadAvul.TabIndex = 5;
            // 
            // txtPorteAniCadAvul
            // 
            this.txtPorteAniCadAvul.Location = new System.Drawing.Point(106, 162);
            this.txtPorteAniCadAvul.Name = "txtPorteAniCadAvul";
            this.txtPorteAniCadAvul.Size = new System.Drawing.Size(343, 22);
            this.txtPorteAniCadAvul.TabIndex = 6;
            // 
            // txtRaçaCadAniAvul
            // 
            this.txtRaçaCadAniAvul.Location = new System.Drawing.Point(106, 220);
            this.txtRaçaCadAniAvul.Name = "txtRaçaCadAniAvul";
            this.txtRaçaCadAniAvul.Size = new System.Drawing.Size(343, 22);
            this.txtRaçaCadAniAvul.TabIndex = 7;
            // 
            // dgvCadAniAvulso
            // 
            this.dgvCadAniAvulso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadAniAvulso.Location = new System.Drawing.Point(499, 48);
            this.dgvCadAniAvulso.Name = "dgvCadAniAvulso";
            this.dgvCadAniAvulso.RowTemplate.Height = 24;
            this.dgvCadAniAvulso.Size = new System.Drawing.Size(380, 267);
            this.dgvCadAniAvulso.TabIndex = 8;
            // 
            // btCadAniAvulso
            // 
            this.btCadAniAvulso.Location = new System.Drawing.Point(184, 264);
            this.btCadAniAvulso.Name = "btCadAniAvulso";
            this.btCadAniAvulso.Size = new System.Drawing.Size(99, 40);
            this.btCadAniAvulso.TabIndex = 9;
            this.btCadAniAvulso.Text = "Cadastrar";
            this.btCadAniAvulso.UseVisualStyleBackColor = true;
            this.btCadAniAvulso.Click += new System.EventHandler(this.btCadAniAvulso_Click);
            // 
            // CadAnimalComCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 327);
            this.Controls.Add(this.btCadAniAvulso);
            this.Controls.Add(this.dgvCadAniAvulso);
            this.Controls.Add(this.txtRaçaCadAniAvul);
            this.Controls.Add(this.txtPorteAniCadAvul);
            this.Controls.Add(this.txtNomeAniCadAvul);
            this.Controls.Add(this.txtCPFdonoCadAvuAnimal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadAnimalComCPF";
            this.Text = "CadAnimalComCPF";
            this.Load += new System.EventHandler(this.CadAnimalComCPF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadAniAvulso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPFdonoCadAvuAnimal;
        private System.Windows.Forms.TextBox txtNomeAniCadAvul;
        private System.Windows.Forms.TextBox txtPorteAniCadAvul;
        private System.Windows.Forms.TextBox txtRaçaCadAniAvul;
        private System.Windows.Forms.DataGridView dgvCadAniAvulso;
        private System.Windows.Forms.Button btCadAniAvulso;
    }
}