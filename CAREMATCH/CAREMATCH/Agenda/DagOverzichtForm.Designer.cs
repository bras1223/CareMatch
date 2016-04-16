namespace CAREMATCH.Agenda
{
    partial class DagOverzichtForm
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
            this.lblDatumVandaag = new System.Windows.Forms.Label();
            this.lblDatumWaarde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(22, 498);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(114, 54);
            this.btnSluiten.TabIndex = 0;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // pnlWeekrooster
            // 
            this.pnlWeekrooster.Location = new System.Drawing.Point(171, 63);
            this.pnlWeekrooster.Name = "pnlWeekrooster";
            this.pnlWeekrooster.Size = new System.Drawing.Size(835, 496);
            this.pnlWeekrooster.TabIndex = 1;
            this.pnlWeekrooster.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWeekrooster_Paint);
            // 
            // dtpTijdPicker
            // 
            this.dtpTijdPicker.Location = new System.Drawing.Point(13, 68);
            this.dtpTijdPicker.Name = "dtpTijdPicker";
            this.dtpTijdPicker.Size = new System.Drawing.Size(142, 20);
            this.dtpTijdPicker.TabIndex = 2;
            // 
            // btnAgendaPuntToevoegen
            // 
            this.btnAgendaPuntToevoegen.Location = new System.Drawing.Point(22, 386);
            this.btnAgendaPuntToevoegen.Name = "btnAgendaPuntToevoegen";
            this.btnAgendaPuntToevoegen.Size = new System.Drawing.Size(114, 54);
            this.btnAgendaPuntToevoegen.TabIndex = 3;
            this.btnAgendaPuntToevoegen.Text = "Afspraak Toevoegen";
            this.btnAgendaPuntToevoegen.UseVisualStyleBackColor = true;
            this.btnAgendaPuntToevoegen.Click += new System.EventHandler(this.btnAgendaPuntToevoegen_Click);
            // 
            // btnKiesKleur
            // 
            this.btnKiesKleur.Location = new System.Drawing.Point(22, 272);
            this.btnKiesKleur.Name = "btnKiesKleur";
            this.btnKiesKleur.Size = new System.Drawing.Size(114, 54);
            this.btnKiesKleur.TabIndex = 4;
            this.btnKiesKleur.Text = "Kies Kleur";
            this.btnKiesKleur.UseVisualStyleBackColor = true;
            this.btnKiesKleur.Click += new System.EventHandler(this.btnKiesKleur_Click);
            // 
            // lblDatumVandaag
            // 
            this.lblDatumVandaag.AutoSize = true;
            this.lblDatumVandaag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumVandaag.Location = new System.Drawing.Point(168, 21);
            this.lblDatumVandaag.Name = "lblDatumVandaag";
            this.lblDatumVandaag.Size = new System.Drawing.Size(223, 26);
            this.lblDatumVandaag.TabIndex = 5;
            this.lblDatumVandaag.Text = "Actuele Datum && Tijd:";
            this.lblDatumVandaag.Click += new System.EventHandler(this.lblDatumVandaag_Click);
            // 
            // lblDatumWaarde
            // 
            this.lblDatumWaarde.AutoSize = true;
            this.lblDatumWaarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumWaarde.Location = new System.Drawing.Point(397, 21);
            this.lblDatumWaarde.Name = "lblDatumWaarde";
            this.lblDatumWaarde.Size = new System.Drawing.Size(153, 26);
            this.lblDatumWaarde.TabIndex = 6;
            this.lblDatumWaarde.Text = "DatumWaarde";
            this.lblDatumWaarde.Click += new System.EventHandler(this.lblDatumWaarde_Click);
            // 
            // DagOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 571);
            this.Controls.Add(this.lblDatumWaarde);
            this.Controls.Add(this.lblDatumVandaag);
            this.Controls.Add(this.btnKiesKleur);
            this.Controls.Add(this.btnAgendaPuntToevoegen);
            this.Controls.Add(this.dtpTijdPicker);
            this.Controls.Add(this.pnlWeekrooster);
            this.Controls.Add(this.btnSluiten);
            this.Name = "DagOverzichtForm";
            this.Text = "Weekrooster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Panel pnlWeekrooster;
        private System.Windows.Forms.DateTimePicker dtpTijdPicker;
        private System.Windows.Forms.Button btnAgendaPuntToevoegen;
        private System.Windows.Forms.ColorDialog cdKiesKleur;
        private System.Windows.Forms.Button btnKiesKleur;
        private System.Windows.Forms.Label lblDatumVandaag;
        private System.Windows.Forms.Label lblDatumWaarde;
    }
}