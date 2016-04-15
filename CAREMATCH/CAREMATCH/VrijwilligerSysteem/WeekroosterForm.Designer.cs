namespace CAREMATCH.VrijwilligerSysteem
{
    partial class WeekroosterForm
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
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.pnlAgenda = new System.Windows.Forms.Panel();
            this.dtpDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.lvlKiesDatum = new System.Windows.Forms.Label();
            this.btnNieuwAgendaPunt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpslaan.Location = new System.Drawing.Point(12, 464);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(139, 61);
            this.btnOpslaan.TabIndex = 0;
            this.btnOpslaan.Text = "Opslaan en Sluiten";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // pnlAgenda
            // 
            this.pnlAgenda.Location = new System.Drawing.Point(157, 12);
            this.pnlAgenda.Name = "pnlAgenda";
            this.pnlAgenda.Size = new System.Drawing.Size(904, 513);
            this.pnlAgenda.TabIndex = 1;
            this.pnlAgenda.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAgenda_Paint);
            // 
            // dtpDatumPicker
            // 
            this.dtpDatumPicker.Location = new System.Drawing.Point(12, 37);
            this.dtpDatumPicker.Name = "dtpDatumPicker";
            this.dtpDatumPicker.Size = new System.Drawing.Size(139, 20);
            this.dtpDatumPicker.TabIndex = 2;
            // 
            // lvlKiesDatum
            // 
            this.lvlKiesDatum.AutoSize = true;
            this.lvlKiesDatum.Location = new System.Drawing.Point(12, 12);
            this.lvlKiesDatum.Name = "lvlKiesDatum";
            this.lvlKiesDatum.Size = new System.Drawing.Size(68, 13);
            this.lvlKiesDatum.TabIndex = 3;
            this.lvlKiesDatum.Text = "lvlKiesDatum";
            // 
            // btnNieuwAgendaPunt
            // 
            this.btnNieuwAgendaPunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNieuwAgendaPunt.Location = new System.Drawing.Point(12, 318);
            this.btnNieuwAgendaPunt.Name = "btnNieuwAgendaPunt";
            this.btnNieuwAgendaPunt.Size = new System.Drawing.Size(139, 89);
            this.btnNieuwAgendaPunt.TabIndex = 4;
            this.btnNieuwAgendaPunt.Text = "Nieuw Agenda Punt";
            this.btnNieuwAgendaPunt.UseVisualStyleBackColor = true;
            this.btnNieuwAgendaPunt.Click += new System.EventHandler(this.btnNieuwAgendaPunt_Click);
            // 
            // AgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 537);
            this.Controls.Add(this.btnNieuwAgendaPunt);
            this.Controls.Add(this.lvlKiesDatum);
            this.Controls.Add(this.dtpDatumPicker);
            this.Controls.Add(this.pnlAgenda);
            this.Controls.Add(this.btnOpslaan);
            this.Name = "AgendaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeekroosterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Panel pnlAgenda;
        private System.Windows.Forms.DateTimePicker dtpDatumPicker;
        private System.Windows.Forms.Label lvlKiesDatum;
        private System.Windows.Forms.Button btnNieuwAgendaPunt;
    }
}