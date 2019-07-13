namespace Apresentacao
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.BtCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btExame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtCliente
            // 
            this.BtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtCliente.BackColor = System.Drawing.SystemColors.Info;
            this.BtCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtCliente.FlatAppearance.BorderSize = 0;
            this.BtCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCliente.Font = new System.Drawing.Font("Script MT Bold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCliente.Location = new System.Drawing.Point(285, 90);
            this.BtCliente.Name = "BtCliente";
            this.BtCliente.Size = new System.Drawing.Size(128, 69);
            this.BtCliente.TabIndex = 0;
            this.BtCliente.Text = "Cliente";
            this.BtCliente.UseVisualStyleBackColor = false;
            this.BtCliente.Click += new System.EventHandler(this.BtCliente_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Script MT Bold", 16.8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(477, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Animal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Script MT Bold", 16.8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(654, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Consulta";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Script MT Bold", 16.8F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(839, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "Atendimento";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Script MT Bold", 16.8F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(811, 541);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "Gerenciamento";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btExame
            // 
            this.btExame.BackColor = System.Drawing.Color.Transparent;
            this.btExame.FlatAppearance.BorderSize = 0;
            this.btExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExame.Font = new System.Drawing.Font("Script MT Bold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btExame.Location = new System.Drawing.Point(285, 541);
            this.btExame.Name = "btExame";
            this.btExame.Size = new System.Drawing.Size(128, 52);
            this.btExame.TabIndex = 5;
            this.btExame.Text = "Exame";
            this.btExame.UseVisualStyleBackColor = false;
            this.btExame.Click += new System.EventHandler(this.btExame_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 683);
            this.Controls.Add(this.btExame);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btExame;
    }
}