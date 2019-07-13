namespace Apresentacao
{
    partial class MenuAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAtendimento));
            this.btRegAtd = new System.Windows.Forms.Button();
            this.btConsultaAtd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRegAtd
            // 
            this.btRegAtd.BackColor = System.Drawing.Color.Transparent;
            this.btRegAtd.FlatAppearance.BorderSize = 0;
            this.btRegAtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegAtd.Font = new System.Drawing.Font("Script MT Bold", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegAtd.Image = ((System.Drawing.Image)(resources.GetObject("btRegAtd.Image")));
            this.btRegAtd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRegAtd.Location = new System.Drawing.Point(280, 309);
            this.btRegAtd.Name = "btRegAtd";
            this.btRegAtd.Size = new System.Drawing.Size(300, 76);
            this.btRegAtd.TabIndex = 0;
            this.btRegAtd.Text = "Registrar";
            this.btRegAtd.UseVisualStyleBackColor = false;
            // 
            // btConsultaAtd
            // 
            this.btConsultaAtd.BackColor = System.Drawing.Color.Transparent;
            this.btConsultaAtd.FlatAppearance.BorderSize = 0;
            this.btConsultaAtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultaAtd.Font = new System.Drawing.Font("Script MT Bold", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultaAtd.Image = ((System.Drawing.Image)(resources.GetObject("btConsultaAtd.Image")));
            this.btConsultaAtd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConsultaAtd.Location = new System.Drawing.Point(781, 309);
            this.btConsultaAtd.Name = "btConsultaAtd";
            this.btConsultaAtd.Size = new System.Drawing.Size(282, 76);
            this.btConsultaAtd.TabIndex = 1;
            this.btConsultaAtd.Text = "Consultar";
            this.btConsultaAtd.UseVisualStyleBackColor = false;
            // 
            // MenuAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.btConsultaAtd);
            this.Controls.Add(this.btRegAtd);
            this.DoubleBuffered = true;
            this.Name = "MenuAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAtendimento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRegAtd;
        private System.Windows.Forms.Button btConsultaAtd;
    }
}