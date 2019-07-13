namespace Apresentacao
{
    partial class MenuExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuExame));
            this.btMarcarExame = new System.Windows.Forms.Button();
            this.btConsultarExame = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMarcarExame
            // 
            this.btMarcarExame.BackColor = System.Drawing.Color.Transparent;
            this.btMarcarExame.FlatAppearance.BorderSize = 0;
            this.btMarcarExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMarcarExame.Font = new System.Drawing.Font("Script MT Bold", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btMarcarExame.Location = new System.Drawing.Point(298, 268);
            this.btMarcarExame.Name = "btMarcarExame";
            this.btMarcarExame.Size = new System.Drawing.Size(270, 72);
            this.btMarcarExame.TabIndex = 0;
            this.btMarcarExame.Text = "Marcar";
            this.btMarcarExame.UseVisualStyleBackColor = false;
            this.btMarcarExame.Click += new System.EventHandler(this.btMarcarExame_Click);
            // 
            // btConsultarExame
            // 
            this.btConsultarExame.BackColor = System.Drawing.Color.Transparent;
            this.btConsultarExame.FlatAppearance.BorderSize = 0;
            this.btConsultarExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultarExame.Font = new System.Drawing.Font("Script MT Bold", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btConsultarExame.Location = new System.Drawing.Point(790, 268);
            this.btConsultarExame.Name = "btConsultarExame";
            this.btConsultarExame.Size = new System.Drawing.Size(270, 72);
            this.btConsultarExame.TabIndex = 1;
            this.btConsultarExame.Text = "Consultar";
            this.btConsultarExame.UseVisualStyleBackColor = false;
            this.btConsultarExame.Click += new System.EventHandler(this.btConsultarExame_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Script MT Bold", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.Location = new System.Drawing.Point(556, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 71);
            this.button3.TabIndex = 2;
            this.button3.Text = "Agenda";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MenuExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btConsultarExame);
            this.Controls.Add(this.btMarcarExame);
            this.DoubleBuffered = true;
            this.Name = "MenuExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuExame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMarcarExame;
        private System.Windows.Forms.Button btConsultarExame;
        private System.Windows.Forms.Button button3;
    }
}