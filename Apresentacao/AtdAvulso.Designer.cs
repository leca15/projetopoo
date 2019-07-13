namespace Apresentacao
{
    partial class AtdAvulso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtdAvulso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeProp = new System.Windows.Forms.TextBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.txtCustoAtd = new System.Windows.Forms.TextBox();
            this.btAtdAvulso = new System.Windows.Forms.Button();
            this.mkstDataAtd = new System.Windows.Forms.MaskedTextBox();
            this.DescService = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRaça = new System.Windows.Forms.TextBox();
            this.txtPorte = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbMedicamentos = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mksCPF = new System.Windows.Forms.MaskedTextBox();
            this.mksCont = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do proprietário :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do animal :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serviço prestado :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(877, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Custo total do atendimento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data do atendimento :";
            // 
            // txtNomeProp
            // 
            this.txtNomeProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeProp.Location = new System.Drawing.Point(357, 158);
            this.txtNomeProp.Name = "txtNomeProp";
            this.txtNomeProp.Size = new System.Drawing.Size(397, 30);
            this.txtNomeProp.TabIndex = 5;
            this.txtNomeProp.TextChanged += new System.EventHandler(this.txtNomeProp_TextChanged);
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeAnimal.Location = new System.Drawing.Point(693, 234);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(340, 30);
            this.txtNomeAnimal.TabIndex = 6;
            // 
            // txtCustoAtd
            // 
            this.txtCustoAtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustoAtd.Location = new System.Drawing.Point(933, 415);
            this.txtCustoAtd.Name = "txtCustoAtd";
            this.txtCustoAtd.Size = new System.Drawing.Size(210, 30);
            this.txtCustoAtd.TabIndex = 8;
            this.txtCustoAtd.TextChanged += new System.EventHandler(this.txtCustoAtd_TextChanged);
            // 
            // btAtdAvulso
            // 
            this.btAtdAvulso.BackColor = System.Drawing.Color.Transparent;
            this.btAtdAvulso.FlatAppearance.BorderSize = 0;
            this.btAtdAvulso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtdAvulso.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtdAvulso.Image = ((System.Drawing.Image)(resources.GetObject("btAtdAvulso.Image")));
            this.btAtdAvulso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtdAvulso.Location = new System.Drawing.Point(904, 535);
            this.btAtdAvulso.Name = "btAtdAvulso";
            this.btAtdAvulso.Size = new System.Drawing.Size(288, 55);
            this.btAtdAvulso.TabIndex = 11;
            this.btAtdAvulso.Text = "Cadastrar";
            this.btAtdAvulso.UseVisualStyleBackColor = false;
            this.btAtdAvulso.Click += new System.EventHandler(this.btAtdAvulso_Click);
            // 
            // mkstDataAtd
            // 
            this.mkstDataAtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkstDataAtd.Location = new System.Drawing.Point(348, 83);
            this.mkstDataAtd.Mask = "00/00/0000";
            this.mkstDataAtd.Name = "mkstDataAtd";
            this.mkstDataAtd.Size = new System.Drawing.Size(127, 30);
            this.mkstDataAtd.TabIndex = 12;
            this.mkstDataAtd.ValidatingType = typeof(System.DateTime);
            // 
            // DescService
            // 
            this.DescService.Location = new System.Drawing.Point(85, 415);
            this.DescService.Name = "DescService";
            this.DescService.Size = new System.Drawing.Size(356, 175);
            this.DescService.TabIndex = 14;
            this.DescService.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lista de Medicamentos :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Raça :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(465, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Porte :";
            // 
            // txtRaça
            // 
            this.txtRaça.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRaça.Location = new System.Drawing.Point(169, 303);
            this.txtRaça.Name = "txtRaça";
            this.txtRaça.Size = new System.Drawing.Size(272, 30);
            this.txtRaça.TabIndex = 20;
            // 
            // txtPorte
            // 
            this.txtPorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPorte.Location = new System.Drawing.Point(570, 305);
            this.txtPorte.Name = "txtPorte";
            this.txtPorte.Size = new System.Drawing.Size(280, 30);
            this.txtPorte.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 32);
            this.label9.TabIndex = 22;
            this.label9.Text = "Contato :";
            // 
            // rtbMedicamentos
            // 
            this.rtbMedicamentos.Location = new System.Drawing.Point(471, 415);
            this.rtbMedicamentos.Name = "rtbMedicamentos";
            this.rtbMedicamentos.Size = new System.Drawing.Size(356, 175);
            this.rtbMedicamentos.TabIndex = 26;
            this.rtbMedicamentos.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label10.Location = new System.Drawing.Point(760, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 29);
            this.label10.TabIndex = 28;
            this.label10.Text = "CPF :";
            // 
            // mksCPF
            // 
            this.mksCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mksCPF.Location = new System.Drawing.Point(848, 157);
            this.mksCPF.Mask = "000.000.000-00";
            this.mksCPF.Name = "mksCPF";
            this.mksCPF.Size = new System.Drawing.Size(252, 30);
            this.mksCPF.TabIndex = 29;
            // 
            // mksCont
            // 
            this.mksCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mksCont.Location = new System.Drawing.Point(203, 232);
            this.mksCont.Mask = "(00)00000-0000";
            this.mksCont.Name = "mksCont";
            this.mksCont.Size = new System.Drawing.Size(238, 30);
            this.mksCont.TabIndex = 30;
            // 
            // AtdAvulso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.mksCont);
            this.Controls.Add(this.mksCPF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rtbMedicamentos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPorte);
            this.Controls.Add(this.txtRaça);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DescService);
            this.Controls.Add(this.mkstDataAtd);
            this.Controls.Add(this.btAtdAvulso);
            this.Controls.Add(this.txtCustoAtd);
            this.Controls.Add(this.txtNomeAnimal);
            this.Controls.Add(this.txtNomeProp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "AtdAvulso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtdAvulso";
            this.Load += new System.EventHandler(this.AtdAvulso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeProp;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.TextBox txtCustoAtd;
        private System.Windows.Forms.Button btAtdAvulso;
        private System.Windows.Forms.MaskedTextBox mkstDataAtd;
        private System.Windows.Forms.RichTextBox DescService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRaça;
        private System.Windows.Forms.TextBox txtPorte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtbMedicamentos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mksCPF;
        private System.Windows.Forms.MaskedTextBox mksCont;
    }
}