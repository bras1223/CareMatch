namespace CAREMATCH.VrijwilligerSysteem
{
    partial class HulpvraagForm
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lblHulpvrager = new System.Windows.Forms.Label();
            this.btnSluit = new System.Windows.Forms.Button();
            this.lblReactie = new System.Windows.Forms.Label();
            this.rtxtReactieInhoud = new System.Windows.Forms.RichTextBox();
            this.btnReactieOpslaan = new System.Windows.Forms.Button();
            this.rtxtHulpvraag = new System.Windows.Forms.RichTextBox();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.txtHulpvrager = new System.Windows.Forms.TextBox();
            this.lblDuur = new System.Windows.Forms.Label();
            this.txtDuur = new System.Windows.Forms.TextBox();
            this.txtFrequentie = new System.Windows.Forms.TextBox();
            this.lblFrequentie = new System.Windows.Forms.Label();
            this.cbUrgent = new System.Windows.Forms.CheckBox();
            this.lblUrgent = new System.Windows.Forms.Label();
            this.btnHulpvraagOpslaan = new System.Windows.Forms.Button();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(45, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(58, 26);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Titel:";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmschrijving.Location = new System.Drawing.Point(205, 269);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(145, 26);
            this.lblOmschrijving.TabIndex = 2;
            this.lblOmschrijving.Text = "Omschrijving:";
            // 
            // lblHulpvrager
            // 
            this.lblHulpvrager.AutoSize = true;
            this.lblHulpvrager.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHulpvrager.Location = new System.Drawing.Point(45, 66);
            this.lblHulpvrager.Name = "lblHulpvrager";
            this.lblHulpvrager.Size = new System.Drawing.Size(130, 26);
            this.lblHulpvrager.TabIndex = 4;
            this.lblHulpvrager.Text = "Hulpvrager: ";
            // 
            // btnSluit
            // 
            this.btnSluit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSluit.Location = new System.Drawing.Point(20, 607);
            this.btnSluit.Name = "btnSluit";
            this.btnSluit.Size = new System.Drawing.Size(141, 64);
            this.btnSluit.TabIndex = 11;
            this.btnSluit.Text = "Hulpvraag Sluiten";
            this.btnSluit.UseVisualStyleBackColor = true;
            this.btnSluit.Click += new System.EventHandler(this.btnSluit_Click);
            // 
            // lblReactie
            // 
            this.lblReactie.AutoSize = true;
            this.lblReactie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReactie.Location = new System.Drawing.Point(205, 449);
            this.lblReactie.Name = "lblReactie";
            this.lblReactie.Size = new System.Drawing.Size(92, 26);
            this.lblReactie.TabIndex = 4;
            this.lblReactie.Text = "Reactie:";
            // 
            // rtxtReactieInhoud
            // 
            this.rtxtReactieInhoud.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtReactieInhoud.Location = new System.Drawing.Point(210, 478);
            this.rtxtReactieInhoud.Name = "rtxtReactieInhoud";
            this.rtxtReactieInhoud.Size = new System.Drawing.Size(635, 196);
            this.rtxtReactieInhoud.TabIndex = 8;
            this.rtxtReactieInhoud.Text = "";
            // 
            // btnReactieOpslaan
            // 
            this.btnReactieOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactieOpslaan.Location = new System.Drawing.Point(20, 512);
            this.btnReactieOpslaan.Name = "btnReactieOpslaan";
            this.btnReactieOpslaan.Size = new System.Drawing.Size(141, 64);
            this.btnReactieOpslaan.TabIndex = 10;
            this.btnReactieOpslaan.Text = "Sla reactie op";
            this.btnReactieOpslaan.UseVisualStyleBackColor = true;
            this.btnReactieOpslaan.Click += new System.EventHandler(this.btnSlaOp_Click);
            // 
            // rtxtHulpvraag
            // 
            this.rtxtHulpvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtHulpvraag.Location = new System.Drawing.Point(210, 298);
            this.rtxtHulpvraag.Name = "rtxtHulpvraag";
            this.rtxtHulpvraag.Size = new System.Drawing.Size(635, 136);
            this.rtxtHulpvraag.TabIndex = 7;
            this.rtxtHulpvraag.Text = "";
            // 
            // txtTitel
            // 
            this.txtTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitel.Location = new System.Drawing.Point(224, 9);
            this.txtTitel.Multiline = true;
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(548, 41);
            this.txtTitel.TabIndex = 1;
            // 
            // txtHulpvrager
            // 
            this.txtHulpvrager.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHulpvrager.Location = new System.Drawing.Point(224, 66);
            this.txtHulpvrager.Multiline = true;
            this.txtHulpvrager.Name = "txtHulpvrager";
            this.txtHulpvrager.Size = new System.Drawing.Size(548, 39);
            this.txtHulpvrager.TabIndex = 2;
            // 
            // lblDuur
            // 
            this.lblDuur.AutoSize = true;
            this.lblDuur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuur.Location = new System.Drawing.Point(45, 130);
            this.lblDuur.Name = "lblDuur";
            this.lblDuur.Size = new System.Drawing.Size(157, 26);
            this.lblDuur.TabIndex = 15;
            this.lblDuur.Text = "Duur Afspraak:";
            // 
            // txtDuur
            // 
            this.txtDuur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuur.Location = new System.Drawing.Point(224, 130);
            this.txtDuur.Multiline = true;
            this.txtDuur.Name = "txtDuur";
            this.txtDuur.Size = new System.Drawing.Size(107, 39);
            this.txtDuur.TabIndex = 3;
            // 
            // txtFrequentie
            // 
            this.txtFrequentie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrequentie.Location = new System.Drawing.Point(665, 130);
            this.txtFrequentie.Multiline = true;
            this.txtFrequentie.Name = "txtFrequentie";
            this.txtFrequentie.Size = new System.Drawing.Size(107, 39);
            this.txtFrequentie.TabIndex = 4;
            // 
            // lblFrequentie
            // 
            this.lblFrequentie.AutoSize = true;
            this.lblFrequentie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequentie.Location = new System.Drawing.Point(415, 130);
            this.lblFrequentie.Name = "lblFrequentie";
            this.lblFrequentie.Size = new System.Drawing.Size(213, 26);
            this.lblFrequentie.TabIndex = 17;
            this.lblFrequentie.Text = "Frequentie Afspraak:";
            // 
            // cbUrgent
            // 
            this.cbUrgent.AutoSize = true;
            this.cbUrgent.Location = new System.Drawing.Point(665, 196);
            this.cbUrgent.Name = "cbUrgent";
            this.cbUrgent.Size = new System.Drawing.Size(15, 14);
            this.cbUrgent.TabIndex = 6;
            this.cbUrgent.UseVisualStyleBackColor = true;
            // 
            // lblUrgent
            // 
            this.lblUrgent.AutoSize = true;
            this.lblUrgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrgent.Location = new System.Drawing.Point(539, 193);
            this.lblUrgent.Name = "lblUrgent";
            this.lblUrgent.Size = new System.Drawing.Size(89, 26);
            this.lblUrgent.TabIndex = 20;
            this.lblUrgent.Text = "Urgent: ";
            // 
            // btnHulpvraagOpslaan
            // 
            this.btnHulpvraagOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHulpvraagOpslaan.Location = new System.Drawing.Point(20, 512);
            this.btnHulpvraagOpslaan.Name = "btnHulpvraagOpslaan";
            this.btnHulpvraagOpslaan.Size = new System.Drawing.Size(141, 64);
            this.btnHulpvraagOpslaan.TabIndex = 9;
            this.btnHulpvraagOpslaan.Text = "Hulpvraag Opslaan";
            this.btnHulpvraagOpslaan.UseVisualStyleBackColor = true;
            this.btnHulpvraagOpslaan.Click += new System.EventHandler(this.btnHulpvraagOpslaan_Click);
            // 
            // txtLocatie
            // 
            this.txtLocatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocatie.Location = new System.Drawing.Point(224, 193);
            this.txtLocatie.Multiline = true;
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(201, 45);
            this.txtLocatie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Afspreek locatie:";
            // 
            // HulpvraagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 687);
            this.Controls.Add(this.txtLocatie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHulpvraagOpslaan);
            this.Controls.Add(this.lblUrgent);
            this.Controls.Add(this.cbUrgent);
            this.Controls.Add(this.txtFrequentie);
            this.Controls.Add(this.lblFrequentie);
            this.Controls.Add(this.txtDuur);
            this.Controls.Add(this.lblDuur);
            this.Controls.Add(this.txtHulpvrager);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.rtxtHulpvraag);
            this.Controls.Add(this.btnReactieOpslaan);
            this.Controls.Add(this.rtxtReactieInhoud);
            this.Controls.Add(this.lblReactie);
            this.Controls.Add(this.btnSluit);
            this.Controls.Add(this.lblHulpvrager);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.lblTitel);
            this.Name = "HulpvraagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HulpvraagForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Label lblHulpvrager;
        private System.Windows.Forms.Button btnSluit;
        private System.Windows.Forms.Label lblReactie;
        private System.Windows.Forms.RichTextBox rtxtReactieInhoud;
        private System.Windows.Forms.Button btnReactieOpslaan;
        private System.Windows.Forms.RichTextBox rtxtHulpvraag;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.TextBox txtHulpvrager;
        private System.Windows.Forms.Label lblDuur;
        private System.Windows.Forms.TextBox txtDuur;
        private System.Windows.Forms.TextBox txtFrequentie;
        private System.Windows.Forms.Label lblFrequentie;
        private System.Windows.Forms.CheckBox cbUrgent;
        private System.Windows.Forms.Label lblUrgent;
        private System.Windows.Forms.Button btnHulpvraagOpslaan;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.Label label1;
    }
}