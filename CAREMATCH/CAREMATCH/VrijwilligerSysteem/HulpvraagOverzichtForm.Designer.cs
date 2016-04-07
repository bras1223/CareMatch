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
            this.lbHulpvragen = new System.Windows.Forms.ListBox();
            this.btnBekijkHulpvraag = new System.Windows.Forms.Button();
            this.lblIngelogdAls = new System.Windows.Forms.Label();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.btnLogUit = new System.Windows.Forms.Button();
            this.btnProfiel = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHulpvragen
            // 
            this.lbHulpvragen.FormattingEnabled = true;
            this.lbHulpvragen.Location = new System.Drawing.Point(189, 12);
            this.lbHulpvragen.Name = "lbHulpvragen";
            this.lbHulpvragen.Size = new System.Drawing.Size(677, 355);
            this.lbHulpvragen.TabIndex = 0;
            this.lbHulpvragen.SelectedIndexChanged += new System.EventHandler(this.lbHulpvragen_SelectedIndexChanged);
            // 
            // btnBekijkHulpvraag
            // 
            this.btnBekijkHulpvraag.Location = new System.Drawing.Point(189, 383);
            this.btnBekijkHulpvraag.Name = "btnBekijkHulpvraag";
            this.btnBekijkHulpvraag.Size = new System.Drawing.Size(149, 57);
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
            // btnLogUit
            // 
            this.btnLogUit.Location = new System.Drawing.Point(12, 404);
            this.btnLogUit.Name = "btnLogUit";
            this.btnLogUit.Size = new System.Drawing.Size(110, 36);
            this.btnLogUit.TabIndex = 4;
            this.btnLogUit.Text = "Log uit";
            this.btnLogUit.UseVisualStyleBackColor = true;
            this.btnLogUit.Click += new System.EventHandler(this.btnLogUit_Click);
            // 
            // btnProfiel
            // 
            this.btnProfiel.Location = new System.Drawing.Point(12, 362);
            this.btnProfiel.Name = "btnProfiel";
            this.btnProfiel.Size = new System.Drawing.Size(110, 36);
            this.btnProfiel.TabIndex = 5;
            this.btnProfiel.Text = "Wijzig Profiel";
            this.btnProfiel.UseVisualStyleBackColor = true;
            this.btnProfiel.Click += new System.EventHandler(this.btnProfiel_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Location = new System.Drawing.Point(717, 383);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(149, 57);
            this.btnAgenda.TabIndex = 6;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // HulpvraagOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 455);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnProfiel);
            this.Controls.Add(this.btnLogUit);
            this.Controls.Add(this.lblGebruikersnaam);
            this.Controls.Add(this.lblIngelogdAls);
            this.Controls.Add(this.btnBekijkHulpvraag);
            this.Controls.Add(this.lbHulpvragen);
            this.Name = "HulpvraagOverzichtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HulpvragenOverzichtForm";
            this.Load += new System.EventHandler(this.HulpvraagOverzichtForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbHulpvragen;
        private System.Windows.Forms.Button btnBekijkHulpvraag;
        private System.Windows.Forms.Label lblIngelogdAls;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Button btnLogUit;
        private System.Windows.Forms.Button btnProfiel;
        private System.Windows.Forms.Button btnAgenda;
    }
}