namespace CAREMATCH.Agenda
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
            this.btnSluiten = new System.Windows.Forms.Button();
            this.pnlWeekrooster = new System.Windows.Forms.Panel();
            this.dtpTijdPicker = new System.Windows.Forms.DateTimePicker();
            this.btnAgendaPuntToevoegen = new System.Windows.Forms.Button();
            this.cdKiesKleur = new System.Windows.Forms.ColorDialog();
            this.btnKiesKleur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(21, 445);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(114, 54);
            this.btnSluiten.TabIndex = 0;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // pnlWeekrooster
            // 
            this.pnlWeekrooster.Location = new System.Drawing.Point(160, 12);
            this.pnlWeekrooster.Name = "pnlWeekrooster";
            this.pnlWeekrooster.Size = new System.Drawing.Size(835, 496);
            this.pnlWeekrooster.TabIndex = 1;
            this.pnlWeekrooster.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWeekrooster_Paint);
            // 
            // dtpTijdPicker
            // 
            this.dtpTijdPicker.Location = new System.Drawing.Point(12, 15);
            this.dtpTijdPicker.Name = "dtpTijdPicker";
            this.dtpTijdPicker.Size = new System.Drawing.Size(142, 20);
            this.dtpTijdPicker.TabIndex = 2;
            // 
            // btnAgendaPuntToevoegen
            // 
            this.btnAgendaPuntToevoegen.Location = new System.Drawing.Point(21, 333);
            this.btnAgendaPuntToevoegen.Name = "btnAgendaPuntToevoegen";
            this.btnAgendaPuntToevoegen.Size = new System.Drawing.Size(114, 54);
            this.btnAgendaPuntToevoegen.TabIndex = 3;
            this.btnAgendaPuntToevoegen.Text = "Afspraak Toevoegen";
            this.btnAgendaPuntToevoegen.UseVisualStyleBackColor = true;
            this.btnAgendaPuntToevoegen.Click += new System.EventHandler(this.btnAgendaPuntToevoegen_Click);
            // 
            // btnKiesKleur
            // 
            this.btnKiesKleur.Location = new System.Drawing.Point(21, 219);
            this.btnKiesKleur.Name = "btnKiesKleur";
            this.btnKiesKleur.Size = new System.Drawing.Size(114, 54);
            this.btnKiesKleur.TabIndex = 4;
            this.btnKiesKleur.Text = "Kies Kleur";
            this.btnKiesKleur.UseVisualStyleBackColor = true;
            this.btnKiesKleur.Click += new System.EventHandler(this.btnKiesKleur_Click);
            // 
            // WeekroosterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 520);
            this.Controls.Add(this.btnKiesKleur);
            this.Controls.Add(this.btnAgendaPuntToevoegen);
            this.Controls.Add(this.dtpTijdPicker);
            this.Controls.Add(this.pnlWeekrooster);
            this.Controls.Add(this.btnSluiten);
            this.Name = "WeekroosterForm";
            this.Text = "Weekrooster";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Panel pnlWeekrooster;
        private System.Windows.Forms.DateTimePicker dtpTijdPicker;
        private System.Windows.Forms.Button btnAgendaPuntToevoegen;
        private System.Windows.Forms.ColorDialog cdKiesKleur;
        private System.Windows.Forms.Button btnKiesKleur;
    }
}