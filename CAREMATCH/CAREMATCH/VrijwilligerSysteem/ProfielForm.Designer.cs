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
            this.txtGebruikersInfo = new System.Windows.Forms.RichTextBox();
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
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.lblAuto = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.lblVoornaam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfielFoto)).BeginInit();
            this.gbWijzigWachtwoord.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWijzig
            // 
            this.btnWijzig.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzig.Location = new System.Drawing.Point(12, 160);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(119, 33);
            this.btnWijzig.TabIndex = 1;
            this.btnWijzig.Text = "Wijzig Profielfoto";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // txtGebruikersInfo
            // 
            this.txtGebruikersInfo.Location = new System.Drawing.Point(171, 52);
            this.txtGebruikersInfo.Name = "txtGebruikersInfo";
            this.txtGebruikersInfo.Size = new System.Drawing.Size(626, 286);
            this.txtGebruikersInfo.TabIndex = 2;
            this.txtGebruikersInfo.Text = "";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpslaan.Location = new System.Drawing.Point(12, 414);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(149, 60);
            this.btnOpslaan.TabIndex = 3;
            this.btnOpslaan.Text = "Opslaan en Sluiten";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // lblOverJezelf
            // 
            this.lblOverJezelf.AutoSize = true;
            this.lblOverJezelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverJezelf.Location = new System.Drawing.Point(171, 13);
            this.lblOverJezelf.Name = "lblOverJezelf";
            this.lblOverJezelf.Size = new System.Drawing.Size(186, 26);
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
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(313, 387);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(15, 14);
            this.cbAuto.TabIndex = 14;
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Location = new System.Drawing.Point(191, 387);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(111, 13);
            this.lblAuto.TabIndex = 15;
            this.lblAuto.Text = "In bezit van een Auto:";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(191, 440);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(67, 13);
            this.lblAchternaam.TabIndex = 15;
            this.lblAchternaam.Text = "Achternaam:";
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(313, 440);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(135, 20);
            this.txtAchternaam.TabIndex = 14;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(313, 414);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(135, 20);
            this.txtVoornaam.TabIndex = 12;
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(191, 414);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(58, 13);
            this.lblVoornaam.TabIndex = 13;
            this.lblVoornaam.Text = "Voornaam:";
            // 
            // ProfielForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 486);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.cbAuto);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.gbWijzigWachtwoord);
            this.Controls.Add(this.lblOverJezelf);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.txtGebruikersInfo);
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
        private System.Windows.Forms.RichTextBox txtGebruikersInfo;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Label lblOverJezelf;
        private System.Windows.Forms.TextBox txtActueelWachtwoord;
        private System.Windows.Forms.Label lblActueelWachtwoord;
        private System.Windows.Forms.Label lblNieuwWachtwoord;
        private System.Windows.Forms.TextBox txtNieuwWachtwoord;
        private System.Windows.Forms.Label lblHerhaalWachtwoord;
        private System.Windows.Forms.TextBox txtHerhaalWachtwoord;
        private System.Windows.Forms.GroupBox gbWijzigWachtwoord;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label lblVoornaam;
    }
}