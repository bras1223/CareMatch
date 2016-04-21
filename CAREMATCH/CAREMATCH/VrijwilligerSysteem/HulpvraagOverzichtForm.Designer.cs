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
            this.btnBekijkHulpvraag = new System.Windows.Forms.Button();
            this.lblIngelogdAls = new System.Windows.Forms.Label();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.lvHulpvragen = new System.Windows.Forms.ListView();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBekijkHulpvraag
            // 
            this.btnBekijkHulpvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBekijkHulpvraag.Location = new System.Drawing.Point(984, 492);
            this.btnBekijkHulpvraag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBekijkHulpvraag.Name = "btnBekijkHulpvraag";
            this.btnBekijkHulpvraag.Size = new System.Drawing.Size(261, 70);
            this.btnBekijkHulpvraag.TabIndex = 3;
            this.btnBekijkHulpvraag.Text = "Bekijk Hulpvraag";
            this.btnBekijkHulpvraag.UseVisualStyleBackColor = true;
            this.btnBekijkHulpvraag.Click += new System.EventHandler(this.btnBekijkHulpvraag_Click);
            // 
            // lblIngelogdAls
            // 
            this.lblIngelogdAls.AutoSize = true;
            this.lblIngelogdAls.Location = new System.Drawing.Point(16, 11);
            this.lblIngelogdAls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngelogdAls.Name = "lblIngelogdAls";
            this.lblIngelogdAls.Size = new System.Drawing.Size(88, 17);
            this.lblIngelogdAls.TabIndex = 2;
            this.lblIngelogdAls.Text = "Ingelogd als:";
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Location = new System.Drawing.Point(113, 11);
            this.lblGebruikersnaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(113, 17);
            this.lblGebruikersnaam.TabIndex = 3;
            this.lblGebruikersnaam.Text = "Gebruikersnaam";
            // 
            // btnSluiten
            // 
            this.btnSluiten.BackColor = System.Drawing.Color.Transparent;
            this.btnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSluiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSluiten.Image = global::CAREMATCH.Properties.Resources.buildings;
            this.btnSluiten.Location = new System.Drawing.Point(29, 482);
            this.btnSluiten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(88, 80);
            this.btnSluiten.TabIndex = 2;
            this.btnSluiten.UseVisualStyleBackColor = false;
            this.btnSluiten.Click += new System.EventHandler(this.btnLogUit_Click);
            // 
            // lvHulpvragen
            // 
            this.lvHulpvragen.Location = new System.Drawing.Point(281, 30);
            this.lvHulpvragen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvHulpvragen.Name = "lvHulpvragen";
            this.lvHulpvragen.Size = new System.Drawing.Size(963, 454);
            this.lvHulpvragen.TabIndex = 1;
            this.lvHulpvragen.UseCompatibleStateImageBehavior = false;
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(16, 94);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(251, 39);
            this.cbFilter.TabIndex = 4;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(13, 58);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(150, 31);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Filteren op:";
            // 
            // HulpvraagOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 578);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lvHulpvragen);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.lblGebruikersnaam);
            this.Controls.Add(this.lblIngelogdAls);
            this.Controls.Add(this.btnBekijkHulpvraag);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HulpvraagOverzichtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HulpvragenOverzichtForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBekijkHulpvraag;
        private System.Windows.Forms.Label lblIngelogdAls;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.ListView lvHulpvragen;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilter;
    }
}