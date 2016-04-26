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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfielForm));
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
            this.btnWijzig.BackColor = System.Drawing.Color.Transparent;
            this.btnWijzig.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzig.Image = global::CAREMATCH.Properties.Resources.UpArrow;
            this.btnWijzig.Location = new System.Drawing.Point(12, 160);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(119, 51);
            this.btnWijzig.TabIndex = 1;
            this.btnWijzig.UseVisualStyleBackColor = false;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // txtGebruikersInfo
            // 
            this.txtGebruikersInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGebruikersInfo.Location = new System.Drawing.Point(171, 52);
            this.txtGebruikersInfo.Name = "txtGebruikersInfo";
            this.txtGebruikersInfo.Size = new System.Drawing.Size(777, 207);
            this.txtGebruikersInfo.TabIndex = 2;
            this.txtGebruikersInfo.Text = "";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.BackColor = System.Drawing.Color.Transparent;
            this.btnOpslaan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpslaan.Image = global::CAREMATCH.Properties.Resources.Interface;
            this.btnOpslaan.Location = new System.Drawing.Point(31, 396);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(62, 60);
            this.btnOpslaan.TabIndex = 9;
            this.btnOpslaan.UseVisualStyleBackColor = false;
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
            this.txtActueelWachtwoord.Location = new System.Drawing.Point(235, 41);
            this.txtActueelWachtwoord.Name = "txtActueelWachtwoord";
            this.txtActueelWachtwoord.PasswordChar = '*';
            this.txtActueelWachtwoord.Size = new System.Drawing.Size(135, 32);
            this.txtActueelWachtwoord.TabIndex = 6;
            // 
            // lblActueelWachtwoord
            // 
            this.lblActueelWachtwoord.AutoSize = true;
            this.lblActueelWachtwoord.Location = new System.Drawing.Point(6, 41);
            this.lblActueelWachtwoord.Name = "lblActueelWachtwoord";
            this.lblActueelWachtwoord.Size = new System.Drawing.Size(218, 26);
            this.lblActueelWachtwoord.TabIndex = 7;
            this.lblActueelWachtwoord.Text = "Actueel Wachtwoord:";
            // 
            // lblNieuwWachtwoord
            // 
            this.lblNieuwWachtwoord.AutoSize = true;
            this.lblNieuwWachtwoord.Location = new System.Drawing.Point(6, 87);
            this.lblNieuwWachtwoord.Name = "lblNieuwWachtwoord";
            this.lblNieuwWachtwoord.Size = new System.Drawing.Size(206, 26);
            this.lblNieuwWachtwoord.TabIndex = 9;
            this.lblNieuwWachtwoord.Text = "Nieuw Wachtwoord:";
            // 
            // txtNieuwWachtwoord
            // 
            this.txtNieuwWachtwoord.Location = new System.Drawing.Point(235, 87);
            this.txtNieuwWachtwoord.Name = "txtNieuwWachtwoord";
            this.txtNieuwWachtwoord.PasswordChar = '*';
            this.txtNieuwWachtwoord.Size = new System.Drawing.Size(135, 32);
            this.txtNieuwWachtwoord.TabIndex = 7;
            // 
            // lblHerhaalWachtwoord
            // 
            this.lblHerhaalWachtwoord.AutoSize = true;
            this.lblHerhaalWachtwoord.Location = new System.Drawing.Point(6, 134);
            this.lblHerhaalWachtwoord.Name = "lblHerhaalWachtwoord";
            this.lblHerhaalWachtwoord.Size = new System.Drawing.Size(221, 26);
            this.lblHerhaalWachtwoord.TabIndex = 11;
            this.lblHerhaalWachtwoord.Text = "Herhaal Wachtwoord:";
            // 
            // txtHerhaalWachtwoord
            // 
            this.txtHerhaalWachtwoord.Location = new System.Drawing.Point(235, 134);
            this.txtHerhaalWachtwoord.Name = "txtHerhaalWachtwoord";
            this.txtHerhaalWachtwoord.PasswordChar = '*';
            this.txtHerhaalWachtwoord.Size = new System.Drawing.Size(135, 32);
            this.txtHerhaalWachtwoord.TabIndex = 8;
            // 
            // gbWijzigWachtwoord
            // 
            this.gbWijzigWachtwoord.Controls.Add(this.txtActueelWachtwoord);
            this.gbWijzigWachtwoord.Controls.Add(this.lblHerhaalWachtwoord);
            this.gbWijzigWachtwoord.Controls.Add(this.lblActueelWachtwoord);
            this.gbWijzigWachtwoord.Controls.Add(this.txtHerhaalWachtwoord);
            this.gbWijzigWachtwoord.Controls.Add(this.txtNieuwWachtwoord);
            this.gbWijzigWachtwoord.Controls.Add(this.lblNieuwWachtwoord);
            this.gbWijzigWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWijzigWachtwoord.Location = new System.Drawing.Point(559, 280);
            this.gbWijzigWachtwoord.Name = "gbWijzigWachtwoord";
            this.gbWijzigWachtwoord.Size = new System.Drawing.Size(389, 182);
            this.gbWijzigWachtwoord.TabIndex = 12;
            this.gbWijzigWachtwoord.TabStop = false;
            this.gbWijzigWachtwoord.Text = "Wijzig Wachtwoord:";
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuto.Location = new System.Drawing.Point(417, 288);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(15, 14);
            this.cbAuto.TabIndex = 3;
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuto.Location = new System.Drawing.Point(182, 280);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(222, 26);
            this.lblAuto.TabIndex = 15;
            this.lblAuto.Text = "In bezit van een Auto:";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchternaam.Location = new System.Drawing.Point(182, 376);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(136, 26);
            this.lblAchternaam.TabIndex = 15;
            this.lblAchternaam.Text = "Achternaam:";
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAchternaam.Location = new System.Drawing.Point(397, 376);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(135, 32);
            this.txtAchternaam.TabIndex = 5;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoornaam.Location = new System.Drawing.Point(397, 330);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(135, 32);
            this.txtVoornaam.TabIndex = 4;
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoornaam.Location = new System.Drawing.Point(182, 330);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(119, 26);
            this.lblVoornaam.TabIndex = 13;
            this.lblVoornaam.Text = "Voornaam:";
            // 
            // ProfielForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 474);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfielForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profiel - CareMatch";
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