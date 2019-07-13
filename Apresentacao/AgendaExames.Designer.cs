namespace Apresentacao
{
    partial class AgendaExames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaExames));
            this.dgvAgendaExame = new System.Windows.Forms.DataGridView();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.btAgendaExame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaExame)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgendaExame
            // 
            this.dgvAgendaExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaExame.Location = new System.Drawing.Point(626, 86);
            this.dgvAgendaExame.Name = "dgvAgendaExame";
            this.dgvAgendaExame.RowTemplate.Height = 24;
            this.dgvAgendaExame.Size = new System.Drawing.Size(579, 528);
            this.dgvAgendaExame.TabIndex = 0;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(156, 239);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 1;
            // 
            // btAgendaExame
            // 
            this.btAgendaExame.BackColor = System.Drawing.Color.Transparent;
            this.btAgendaExame.FlatAppearance.BorderSize = 0;
            this.btAgendaExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgendaExame.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgendaExame.Location = new System.Drawing.Point(202, 483);
            this.btAgendaExame.Name = "btAgendaExame";
            this.btAgendaExame.Size = new System.Drawing.Size(175, 61);
            this.btAgendaExame.TabIndex = 2;
            this.btAgendaExame.Text = "Pesquisar";
            this.btAgendaExame.UseVisualStyleBackColor = false;
            this.btAgendaExame.Click += new System.EventHandler(this.btAgendaExame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione um intervalo de datas :";
            // 
            // AgendaExames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAgendaExame);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.dgvAgendaExame);
            this.DoubleBuffered = true;
            this.Name = "AgendaExames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendaExames";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaExame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgendaExame;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button btAgendaExame;
        private System.Windows.Forms.Label label1;
    }
}