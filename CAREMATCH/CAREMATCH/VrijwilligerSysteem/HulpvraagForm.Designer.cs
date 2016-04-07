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
            this.btnReageer = new System.Windows.Forms.Button();
            this.lblReactie = new System.Windows.Forms.Label();
            this.rtxtReactieInhoud = new System.Windows.Forms.RichTextBox();
            this.btnSlaOp = new System.Windows.Forms.Button();
            this.rtxtHulpvraag = new System.Windows.Forms.RichTextBox();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.txtHulpvrager = new System.Windows.Forms.TextBox();
            this.lblDuur = new System.Windows.Forms.Label();
            this.txtDuur = new System.Windows.Forms.TextBox();
            this.txtFrequentie = new System.Windows.Forms.TextBox();
            this.lblFrequentie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(88, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(58, 26);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Titel:";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmschrijving.Location = new System.Drawing.Point(219, 176);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(145, 26);
            this.lblOmschrijving.TabIndex = 2;
            this.lblOmschrijving.Text = "Omschrijving:";
            // 
            // lblHulpvrager
            // 
            this.lblHulpvrager.AutoSize = true;
            this.lblHulpvrager.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHulpvrager.Location = new System.Drawing.Point(88, 66);
            this.lblHulpvrager.Name = "lblHulpvrager";
            this.lblHulpvrager.Size = new System.Drawing.Size(130, 26);
            this.lblHulpvrager.TabIndex = 4;
            this.lblHulpvrager.Text = "Hulpvrager: ";
            // 
            // btnSluit
            // 
            this.btnSluit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSluit.Location = new System.Drawing.Point(22, 414);
            this.btnSluit.Name = "btnSluit";
            this.btnSluit.Size = new System.Drawing.Size(141, 64);
            this.btnSluit.TabIndex = 7;
            this.btnSluit.Text = "Hulpvraag Sluiten";
            this.btnSluit.UseVisualStyleBackColor = true;
            this.btnSluit.Click += new System.EventHandler(this.btnSluit_Click);
            // 
            // btnReageer
            // 
            this.btnReageer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReageer.Location = new System.Drawing.Point(22, 205);
            this.btnReageer.Name = "btnReageer";
            this.btnReageer.Size = new System.Drawing.Size(141, 64);
            this.btnReageer.TabIndex = 8;
            this.btnReageer.Text = "Reageer";
            this.btnReageer.UseVisualStyleBackColor = true;
            this.btnReageer.Click += new System.EventHandler(this.btnReageer_Click);
            // 
            // lblReactie
            // 
            this.lblReactie.AutoSize = true;
            this.lblReactie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReactie.Location = new System.Drawing.Point(219, 356);
            this.lblReactie.Name = "lblReactie";
            this.lblReactie.Size = new System.Drawing.Size(92, 26);
            this.lblReactie.TabIndex = 4;
            this.lblReactie.Text = "Reactie:";
            // 
            // rtxtReactieInhoud
            // 
            this.rtxtReactieInhoud.Enabled = false;
            this.rtxtReactieInhoud.Location = new System.Drawing.Point(224, 385);
            this.rtxtReactieInhoud.Name = "rtxtReactieInhoud";
            this.rtxtReactieInhoud.Size = new System.Drawing.Size(635, 136);
            this.rtxtReactieInhoud.TabIndex = 9;
            this.rtxtReactieInhoud.Text = "";
            // 
            // btnSlaOp
            // 
            this.btnSlaOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlaOp.Location = new System.Drawing.Point(22, 319);
            this.btnSlaOp.Name = "btnSlaOp";
            this.btnSlaOp.Size = new System.Drawing.Size(141, 64);
            this.btnSlaOp.TabIndex = 10;
            this.btnSlaOp.Text = "Sla reactie op";
            this.btnSlaOp.UseVisualStyleBackColor = true;
            this.btnSlaOp.Click += new System.EventHandler(this.btnSlaOp_Click);
            // 
            // rtxtHulpvraag
            // 
            this.rtxtHulpvraag.Enabled = false;
            this.rtxtHulpvraag.Location = new System.Drawing.Point(224, 205);
            this.rtxtHulpvraag.Name = "rtxtHulpvraag";
            this.rtxtHulpvraag.Size = new System.Drawing.Size(635, 136);
            this.rtxtHulpvraag.TabIndex = 12;
            this.rtxtHulpvraag.Text = "";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(224, 9);
            this.txtTitel.Multiline = true;
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(548, 41);
            this.txtTitel.TabIndex = 13;
            // 
            // txtHulpvrager
            // 
            this.txtHulpvrager.Location = new System.Drawing.Point(224, 66);
            this.txtHulpvrager.Multiline = true;
            this.txtHulpvrager.Name = "txtHulpvrager";
            this.txtHulpvrager.Size = new System.Drawing.Size(548, 39);
            this.txtHulpvrager.TabIndex = 14;
            // 
            // lblDuur
            // 
            this.lblDuur.AutoSize = true;
            this.lblDuur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuur.Location = new System.Drawing.Point(219, 127);
            this.lblDuur.Name = "lblDuur";
            this.lblDuur.Size = new System.Drawing.Size(157, 26);
            this.lblDuur.TabIndex = 15;
            this.lblDuur.Text = "Duur Afspraak:";
            // 
            // txtDuur
            // 
            this.txtDuur.Location = new System.Drawing.Point(382, 127);
            this.txtDuur.Multiline = true;
            this.txtDuur.Name = "txtDuur";
            this.txtDuur.Size = new System.Drawing.Size(107, 26);
            this.txtDuur.TabIndex = 16;
            // 
            // txtFrequentie
            // 
            this.txtFrequentie.Location = new System.Drawing.Point(667, 127);
            this.txtFrequentie.Multiline = true;
            this.txtFrequentie.Name = "txtFrequentie";
            this.txtFrequentie.Size = new System.Drawing.Size(107, 26);
            this.txtFrequentie.TabIndex = 18;
            // 
            // lblFrequentie
            // 
            this.lblFrequentie.AutoSize = true;
            this.lblFrequentie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequentie.Location = new System.Drawing.Point(540, 127);
            this.lblFrequentie.Name = "lblFrequentie";
            this.lblFrequentie.Size = new System.Drawing.Size(121, 26);
            this.lblFrequentie.TabIndex = 17;
            this.lblFrequentie.Text = "Frequentie:";
            // 
            // HulpvraagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 533);
            this.Controls.Add(this.txtFrequentie);
            this.Controls.Add(this.lblFrequentie);
            this.Controls.Add(this.txtDuur);
            this.Controls.Add(this.lblDuur);
            this.Controls.Add(this.txtHulpvrager);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.rtxtHulpvraag);
            this.Controls.Add(this.btnSlaOp);
            this.Controls.Add(this.rtxtReactieInhoud);
            this.Controls.Add(this.lblReactie);
            this.Controls.Add(this.btnReageer);
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
        private System.Windows.Forms.Button btnReageer;
        private System.Windows.Forms.Label lblReactie;
        private System.Windows.Forms.RichTextBox rtxtReactieInhoud;
        private System.Windows.Forms.Button btnSlaOp;
        private System.Windows.Forms.RichTextBox rtxtHulpvraag;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.TextBox txtHulpvrager;
        private System.Windows.Forms.Label lblDuur;
        private System.Windows.Forms.TextBox txtDuur;
        private System.Windows.Forms.TextBox txtFrequentie;
        private System.Windows.Forms.Label lblFrequentie;
    }
}