namespace Apresentacao
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.txttermino = new System.Windows.Forms.TextBox();
            this.txtinicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(550, 63);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.RowTemplate.Height = 24;
            this.dgvAgenda.Size = new System.Drawing.Size(618, 540);
            this.dgvAgenda.TabIndex = 0;
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(116, 142);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 1;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(138, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirmar data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttermino
            // 
            this.txttermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttermino.Location = new System.Drawing.Point(228, 552);
            this.txttermino.Name = "txttermino";
            this.txttermino.Size = new System.Drawing.Size(114, 30);
            this.txttermino.TabIndex = 3;
            // 
            // txtinicio
            // 
            this.txtinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtinicio.Location = new System.Drawing.Point(228, 494);
            this.txtinicio.Name = "txtinicio";
            this.txtinicio.Size = new System.Drawing.Size(114, 30);
            this.txtinicio.TabIndex = 4;
            this.txtinicio.TextChanged += new System.EventHandler(this.txtinicio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data inicio :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data termino :";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtinicio);
            this.Controls.Add(this.txttermino);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.dgvAgenda);
            this.DoubleBuffered = true;
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttermino;
        private System.Windows.Forms.TextBox txtinicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}