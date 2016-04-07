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
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(148, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(30, 13);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Titel:";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Location = new System.Drawing.Point(229, 78);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(70, 13);
            this.lblOmschrijving.TabIndex = 2;
            this.lblOmschrijving.Text = "Omschrijving:";
            // 
            // lblHulpvrager
            // 
            this.lblHulpvrager.AutoSize = true;
            this.lblHulpvrager.Location = new System.Drawing.Point(148, 43);
            this.lblHulpvrager.Name = "lblHulpvrager";
            this.lblHulpvrager.Size = new System.Drawing.Size(65, 13);
            this.lblHulpvrager.TabIndex = 4;
            this.lblHulpvrager.Text = "Hulpvrager: ";
            // 
            // btnSluit
            // 
            this.btnSluit.Location = new System.Drawing.Point(22, 346);
            this.btnSluit.Name = "btnSluit";
            this.btnSluit.Size = new System.Drawing.Size(141, 64);
            this.btnSluit.TabIndex = 7;
            this.btnSluit.Text = "Hulpvraag Sluiten";
            this.btnSluit.UseVisualStyleBackColor = true;
            this.btnSluit.Click += new System.EventHandler(this.btnSluit_Click);
            // 
            // btnReageer
            // 
            this.btnReageer.Location = new System.Drawing.Point(22, 137);
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
            this.lblReactie.Location = new System.Drawing.Point(229, 251);
            this.lblReactie.Name = "lblReactie";
            this.lblReactie.Size = new System.Drawing.Size(47, 13);
            this.lblReactie.TabIndex = 4;
            this.lblReactie.Text = "Reactie:";
            // 
            // rtxtReactieInhoud
            // 
            this.rtxtReactieInhoud.Enabled = false;
            this.rtxtReactieInhoud.Location = new System.Drawing.Point(224, 274);
            this.rtxtReactieInhoud.Name = "rtxtReactieInhoud";
            this.rtxtReactieInhoud.Size = new System.Drawing.Size(635, 136);
            this.rtxtReactieInhoud.TabIndex = 9;
            this.rtxtReactieInhoud.Text = "";
            // 
            // btnSlaOp
            // 
            this.btnSlaOp.Location = new System.Drawing.Point(22, 251);
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
            this.rtxtHulpvraag.Location = new System.Drawing.Point(224, 94);
            this.rtxtHulpvraag.Name = "rtxtHulpvraag";
            this.rtxtHulpvraag.Size = new System.Drawing.Size(635, 136);
            this.rtxtHulpvraag.TabIndex = 12;
            this.rtxtHulpvraag.Text = "";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(224, 9);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(548, 20);
            this.txtTitel.TabIndex = 13;
            // 
            // txtHulpvrager
            // 
            this.txtHulpvrager.Location = new System.Drawing.Point(224, 40);
            this.txtHulpvrager.Name = "txtHulpvrager";
            this.txtHulpvrager.Size = new System.Drawing.Size(548, 20);
            this.txtHulpvrager.TabIndex = 14;
            // 
            // HulpvraagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 433);
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
    }
}