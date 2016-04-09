namespace CAREMATCH.VrijwilligerSysteem
{
    partial class HulpvraagOverzichtForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("HulpvraagID", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Hulpbehoevende", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("HulpvraagInhoud", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Aangenomen", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("DatumTijd", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Urgent", System.Windows.Forms.HorizontalAlignment.Left);
            this.btnBekijkHulpvraag = new System.Windows.Forms.Button();
            this.lblIngelogdAls = new System.Windows.Forms.Label();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.lblGebruikerType = new System.Windows.Forms.Label();
            this.lvHulpvragenOverzicht = new System.Windows.Forms.ListView();
            this.chHulpvraagID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGebruikerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHulpvraagInhoud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDatumTijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAangenomen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUrgent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnBekijkHulpvraag
            // 
            this.btnBekijkHulpvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBekijkHulpvraag.Location = new System.Drawing.Point(189, 383);
            this.btnBekijkHulpvraag.Name = "btnBekijkHulpvraag";
            this.btnBekijkHulpvraag.Size = new System.Drawing.Size(196, 57);
            this.btnBekijkHulpvraag.TabIndex = 1;
            this.btnBekijkHulpvraag.Text = "Bekijk Hulpvraag";
            this.btnBekijkHulpvraag.UseVisualStyleBackColor = true;
            this.btnBekijkHulpvraag.Click += new System.EventHandler(this.btnBekijkHulpvraag_Click);
            // 
            // lblIngelogdAls
            // 
            this.lblIngelogdAls.AutoSize = true;
            this.lblIngelogdAls.Location = new System.Drawing.Point(12, 12);
            this.lblIngelogdAls.Name = "lblIngelogdAls";
            this.lblIngelogdAls.Size = new System.Drawing.Size(67, 13);
            this.lblIngelogdAls.TabIndex = 2;
            this.lblIngelogdAls.Text = "Ingelogd als:";
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Location = new System.Drawing.Point(85, 12);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(84, 13);
            this.lblGebruikersnaam.TabIndex = 3;
            this.lblGebruikersnaam.Text = "Gebruikersnaam";
            // 
            // btnSluiten
            // 
            this.btnSluiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSluiten.Location = new System.Drawing.Point(12, 404);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(110, 36);
            this.btnSluiten.TabIndex = 4;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnLogUit_Click);
            // 
            // lblGebruikerType
            // 
            this.lblGebruikerType.AutoSize = true;
            this.lblGebruikerType.Location = new System.Drawing.Point(85, 25);
            this.lblGebruikerType.Name = "lblGebruikerType";
            this.lblGebruikerType.Size = new System.Drawing.Size(52, 13);
            this.lblGebruikerType.TabIndex = 5;
            this.lblGebruikerType.Text = "Vrijwilliger";
            // 
            // lvHulpvragenOverzicht
            // 
            this.lvHulpvragenOverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chHulpvraagID,
            this.chGebruikerID,
            this.chHulpvraagInhoud,
            this.chDatumTijd,
            this.chAangenomen,
            this.chUrgent});
            listViewGroup1.Header = "HulpvraagID";
            listViewGroup1.Name = "lvgHulpvraagID";
            listViewGroup2.Header = "Hulpbehoevende";
            listViewGroup2.Name = "lvgHulpbehoevende";
            listViewGroup3.Header = "HulpvraagInhoud";
            listViewGroup3.Name = "lvgHulpvraagInhoud";
            listViewGroup4.Header = "Aangenomen";
            listViewGroup4.Name = "lvgAangenomen";
            listViewGroup5.Header = "DatumTijd";
            listViewGroup5.Name = "lvgDatumTijd";
            listViewGroup6.Header = "Urgent";
            listViewGroup6.Name = "lvgUrgent";
            this.lvHulpvragenOverzicht.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.lvHulpvragenOverzicht.Location = new System.Drawing.Point(189, 12);
            this.lvHulpvragenOverzicht.Name = "lvHulpvragenOverzicht";
            this.lvHulpvragenOverzicht.Size = new System.Drawing.Size(677, 365);
            this.lvHulpvragenOverzicht.TabIndex = 6;
            this.lvHulpvragenOverzicht.UseCompatibleStateImageBehavior = false;
            this.lvHulpvragenOverzicht.SelectedIndexChanged += new System.EventHandler(this.lvHulpvragenOverzicht_SelectedIndexChanged);
            // 
            // chHulpvraagID
            // 
            this.chHulpvraagID.Text = "HulpvraagID";
            // 
            // chGebruikerID
            // 
            this.chGebruikerID.Text = "GebruikerID";
            // 
            // chHulpvraagInhoud
            // 
            this.chHulpvraagInhoud.Text = "HulpvraagInhoud";
            // 
            // chDatumTijd
            // 
            this.chDatumTijd.Text = "DatumTijd";
            // 
            // chAangenomen
            // 
            this.chAangenomen.Text = "Aangenomen";
            // 
            // chUrgent
            // 
            this.chUrgent.Text = "Urgent";
            // 
            // HulpvraagOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 455);
            this.Controls.Add(this.lvHulpvragenOverzicht);
            this.Controls.Add(this.lblGebruikerType);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.lblGebruikersnaam);
            this.Controls.Add(this.lblIngelogdAls);
            this.Controls.Add(this.btnBekijkHulpvraag);
            this.Name = "HulpvraagOverzichtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HulpvragenOverzichtForm";
            this.Load += new System.EventHandler(this.HulpvraagOverzichtForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBekijkHulpvraag;
        private System.Windows.Forms.Label lblIngelogdAls;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Label lblGebruikerType;
        private System.Windows.Forms.ListView lvHulpvragenOverzicht;
        private System.Windows.Forms.ColumnHeader chHulpvraagID;
        private System.Windows.Forms.ColumnHeader chGebruikerID;
        private System.Windows.Forms.ColumnHeader chHulpvraagInhoud;
        private System.Windows.Forms.ColumnHeader chDatumTijd;
        private System.Windows.Forms.ColumnHeader chAangenomen;
        private System.Windows.Forms.ColumnHeader chUrgent;
    }
}