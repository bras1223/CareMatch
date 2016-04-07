namespace CAREMATCH.VrijwilligerSysteem
{
    partial class ProfielForm
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
            this.btnWijzig = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.lblOverJezelf = new System.Windows.Forms.Label();
            this.pbProfielFoto = new System.Windows.Forms.PictureBox();
            this.txtActueelWachtwoord = new System.Windows.Forms.TextBox();
            this.lblActueelWachtwoord = new System.Windows.Forms.Label();
            this.lblNieuwWachtwoord = new System.Windows.Forms.Label();
            this.txtNieuwWachtwoord = new System.Windows.Forms.TextBox();
            this.lblHerhaalWachtwoord = new System.Windows.Forms.Label();
            this.txtHerhaalWachtwoord = new System.Windows.Forms.TextBox();
            this.gbWijzigWachtwoord = new System.Windows.Forms.GroupBox();
            this.btnWachtwoordOpslaan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfielFoto)).BeginInit();
            this.gbWijzigWachtwoord.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(12, 160);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(119, 33);
            this.btnWijzig.TabIndex = 1;
            this.btnWijzig.Text = "Wijzig Profielfoto";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(171, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(626, 286);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(12, 423);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(119, 51);
            this.btnOpslaan.TabIndex = 3;
            this.btnOpslaan.Text = "Opslaan en Sluiten";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // lblOverJezelf
            // 
            this.lblOverJezelf.AutoSize = true;
            this.lblOverJezelf.Location = new System.Drawing.Point(171, 13);
            this.lblOverJezelf.Name = "lblOverJezelf";
            this.lblOverJezelf.Size = new System.Drawing.Size(91, 13);
            this.lblOverJezelf.TabIndex = 4;
            this.lblOverJezelf.Text = "Vertel over jezelf: ";
            // 
            // pbProfielFoto
            // 
            this.pbProfielFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfielFoto.Location = new System.Drawing.Point(12, 12);
            this.pbProfielFoto.Name = "pbProfielFoto";
            this.pbProfielFoto.Size = new System.Drawing.Size(119, 142);
            this.pbProfielFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfielFoto.TabIndex = 0;
            this.pbProfielFoto.TabStop = false;
            this.pbProfielFoto.Click += new System.EventHandler(this.pbProfielFoto_Click);
            // 
            // txtActueelWachtwoord
            // 
            this.txtActueelWachtwoord.Location = new System.Drawing.Point(135, 32);
            this.txtActueelWachtwoord.Name = "txtActueelWachtwoord";
            this.txtActueelWachtwoord.PasswordChar = '*';
            this.txtActueelWachtwoord.Size = new System.Drawing.Size(135, 20);
            this.txtActueelWachtwoord.TabIndex = 5;
            // 
            // lblActueelWachtwoord
            // 
            this.lblActueelWachtwoord.AutoSize = true;
            this.lblActueelWachtwoord.Location = new System.Drawing.Point(13, 32);
            this.lblActueelWachtwoord.Name = "lblActueelWachtwoord";
            this.lblActueelWachtwoord.Size = new System.Drawing.Size(110, 13);
            this.lblActueelWachtwoord.TabIndex = 7;
            this.lblActueelWachtwoord.Text = "Actueel Wachtwoord:";
            // 
            // lblNieuwWachtwoord
            // 
            this.lblNieuwWachtwoord.AutoSize = true;
            this.lblNieuwWachtwoord.Location = new System.Drawing.Point(13, 58);
            this.lblNieuwWachtwoord.Name = "lblNieuwWachtwoord";
            this.lblNieuwWachtwoord.Size = new System.Drawing.Size(104, 13);
            this.lblNieuwWachtwoord.TabIndex = 9;
            this.lblNieuwWachtwoord.Text = "Nieuw Wachtwoord:";
            // 
            // txtNieuwWachtwoord
            // 
            this.txtNieuwWachtwoord.Location = new System.Drawing.Point(135, 58);
            this.txtNieuwWachtwoord.Name = "txtNieuwWachtwoord";
            this.txtNieuwWachtwoord.PasswordChar = '*';
            this.txtNieuwWachtwoord.Size = new System.Drawing.Size(135, 20);
            this.txtNieuwWachtwoord.TabIndex = 8;
            // 
            // lblHerhaalWachtwoord
            // 
            this.lblHerhaalWachtwoord.AutoSize = true;
            this.lblHerhaalWachtwoord.Location = new System.Drawing.Point(13, 84);
            this.lblHerhaalWachtwoord.Name = "lblHerhaalWachtwoord";
            this.lblHerhaalWachtwoord.Size = new System.Drawing.Size(111, 13);
            this.lblHerhaalWachtwoord.TabIndex = 11;
            this.lblHerhaalWachtwoord.Text = "Herhaal Wachtwoord:";
            // 
            // txtHerhaalWachtwoord
            // 
            this.txtHerhaalWachtwoord.Location = new System.Drawing.Point(135, 84);
            this.txtHerhaalWachtwoord.Name = "txtHerhaalWachtwoord";
            this.txtHerhaalWachtwoord.PasswordChar = '*';
            this.txtHerhaalWachtwoord.Size = new System.Drawing.Size(135, 20);
            this.txtHerhaalWachtwoord.TabIndex = 10;
            // 
            // gbWijzigWachtwoord
            // 
            this.gbWijzigWachtwoord.Controls.Add(this.txtActueelWachtwoord);
            this.gbWijzigWachtwoord.Controls.Add(this.lblHerhaalWachtwoord);
            this.gbWijzigWachtwoord.Controls.Add(this.lblActueelWachtwoord);
            this.gbWijzigWachtwoord.Controls.Add(this.txtHerhaalWachtwoord);
            this.gbWijzigWachtwoord.Controls.Add(this.txtNieuwWachtwoord);
            this.gbWijzigWachtwoord.Controls.Add(this.lblNieuwWachtwoord);
            this.gbWijzigWachtwoord.Location = new System.Drawing.Point(511, 356);
            this.gbWijzigWachtwoord.Name = "gbWijzigWachtwoord";
            this.gbWijzigWachtwoord.Size = new System.Drawing.Size(286, 118);
            this.gbWijzigWachtwoord.TabIndex = 12;
            this.gbWijzigWachtwoord.TabStop = false;
            this.gbWijzigWachtwoord.Text = "Wijzig Wachtwoord:";
            // 
            // btnWachtwoordOpslaan
            // 
            this.btnWachtwoordOpslaan.Location = new System.Drawing.Point(12, 357);
            this.btnWachtwoordOpslaan.Name = "btnWachtwoordOpslaan";
            this.btnWachtwoordOpslaan.Size = new System.Drawing.Size(119, 51);
            this.btnWachtwoordOpslaan.TabIndex = 13;
            this.btnWachtwoordOpslaan.Text = "Wachtwoord Opslaan";
            this.btnWachtwoordOpslaan.UseVisualStyleBackColor = true;
            // 
            // ProfielForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 486);
            this.Controls.Add(this.btnWachtwoordOpslaan);
            this.Controls.Add(this.gbWijzigWachtwoord);
            this.Controls.Add(this.lblOverJezelf);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.pbProfielFoto);
            this.Name = "ProfielForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfielForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbProfielFoto)).EndInit();
            this.gbWijzigWachtwoord.ResumeLayout(false);
            this.gbWijzigWachtwoord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProfielFoto;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Label lblOverJezelf;
        private System.Windows.Forms.TextBox txtActueelWachtwoord;
        private System.Windows.Forms.Label lblActueelWachtwoord;
        private System.Windows.Forms.Label lblNieuwWachtwoord;
        private System.Windows.Forms.TextBox txtNieuwWachtwoord;
        private System.Windows.Forms.Label lblHerhaalWachtwoord;
        private System.Windows.Forms.TextBox txtHerhaalWachtwoord;
        private System.Windows.Forms.GroupBox gbWijzigWachtwoord;
        private System.Windows.Forms.Button btnWachtwoordOpslaan;
    }
}