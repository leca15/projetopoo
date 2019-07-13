namespace Apresentacao
{
    partial class MenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btConsulta = new System.Windows.Forms.Button();
            this.BtCadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btConsulta);
            this.panel1.Controls.Add(this.BtCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 673);
            this.panel1.TabIndex = 0;
            // 
            // btConsulta
            // 
            this.btConsulta.BackColor = System.Drawing.Color.Transparent;
            this.btConsulta.FlatAppearance.BorderSize = 0;
            this.btConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuBar;
            this.btConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsulta.Font = new System.Drawing.Font("Script MT Bold", 24.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btConsulta.Image")));
            this.btConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConsulta.Location = new System.Drawing.Point(747, 308);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(325, 101);
            this.btConsulta.TabIndex = 1;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.UseVisualStyleBackColor = false;
            this.btConsulta.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtCadastrar
            // 
            this.BtCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.BtCadastrar.FlatAppearance.BorderSize = 0;
            this.BtCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.BtCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCadastrar.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("BtCadastrar.Image")));
            this.BtCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCadastrar.Location = new System.Drawing.Point(281, 309);
            this.BtCadastrar.Name = "BtCadastrar";
            this.BtCadastrar.Size = new System.Drawing.Size(308, 101);
            this.BtCadastrar.TabIndex = 0;
            this.BtCadastrar.Text = "Cadastrar";
            this.BtCadastrar.UseVisualStyleBackColor = false;
            this.BtCadastrar.Click += new System.EventHandler(this.BtCadastrar_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.panel1);
            this.Name = "MenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCliente";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button BtCadastrar;
    }
}