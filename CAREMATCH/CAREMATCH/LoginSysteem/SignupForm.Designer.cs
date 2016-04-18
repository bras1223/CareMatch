﻿namespace Login
{
    partial class SignupForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHerhWachtwoord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.btnUploadVOG = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblVOG = new System.Windows.Forms.Label();
            this.btnPasfotoToevoegen = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPasFotoPath = new System.Windows.Forms.Label();
            this.lblVOGPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(642, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sterk wachtwoord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(642, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Zwak wachtwoord";
            // 
            // txtHerhWachtwoord
            // 
            this.txtHerhWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerhWachtwoord.Location = new System.Drawing.Point(455, 165);
            this.txtHerhWachtwoord.Name = "txtHerhWachtwoord";
            this.txtHerhWachtwoord.PasswordChar = '*';
            this.txtHerhWachtwoord.Size = new System.Drawing.Size(168, 23);
            this.txtHerhWachtwoord.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Herhaal wachtwoord:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Wachtwoord:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gebruikersnaam:";
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWachtwoord.Location = new System.Drawing.Point(455, 121);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.PasswordChar = '*';
            this.txtWachtwoord.Size = new System.Drawing.Size(168, 23);
            this.txtWachtwoord.TabIndex = 3;
            this.txtWachtwoord.TextChanged += new System.EventHandler(this.txtHerhWachtwoord_TextChanged);
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGebruikersnaam.Location = new System.Drawing.Point(455, 83);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(168, 23);
            this.txtGebruikersnaam.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "U bent een:";
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Hulpbehoevende",
            "Vrijwilliger"});
            this.cbRol.Location = new System.Drawing.Point(454, 28);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(169, 24);
            this.cbRol.TabIndex = 1;
            this.cbRol.SelectedIndexChanged += new System.EventHandler(this.cbRol_SelectedIndexChanged);
            // 
            // btnUploadVOG
            // 
            this.btnUploadVOG.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadVOG.BackgroundImage = global::CAREMATCH.Properties.Resources.up_arrow;
            this.btnUploadVOG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUploadVOG.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUploadVOG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadVOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadVOG.Location = new System.Drawing.Point(485, 393);
            this.btnUploadVOG.Name = "btnUploadVOG";
            this.btnUploadVOG.Size = new System.Drawing.Size(56, 48);
            this.btnUploadVOG.TabIndex = 6;
            this.btnUploadVOG.UseVisualStyleBackColor = false;
            this.btnUploadVOG.Visible = false;
            this.btnUploadVOG.Click += new System.EventHandler(this.btnUploadVOG_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.BackColor = System.Drawing.Color.Transparent;
            this.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Image = global::CAREMATCH.Properties.Resources.circle_1_;
            this.btnTerug.Location = new System.Drawing.Point(43, 450);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 74);
            this.btnTerug.TabIndex = 8;
            this.btnTerug.UseVisualStyleBackColor = false;
            this.btnTerug.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistreer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistreer.Image = global::CAREMATCH.Properties.Resources._interface;
            this.btnRegistreer.Location = new System.Drawing.Point(891, 450);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(75, 74);
            this.btnRegistreer.TabIndex = 7;
            this.btnRegistreer.UseVisualStyleBackColor = false;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Voornaam:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Achternaam:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(235, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Geslacht:";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(235, 402);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(223, 25);
            this.lblFoto.TabIndex = 23;
            this.lblFoto.Text = "Voeg een pasfoto toe:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(235, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Geboortedatum:";
            // 
            // lblVOG
            // 
            this.lblVOG.AutoSize = true;
            this.lblVOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVOG.Location = new System.Drawing.Point(236, 475);
            this.lblVOG.Name = "lblVOG";
            this.lblVOG.Size = new System.Drawing.Size(164, 25);
            this.lblVOG.TabIndex = 25;
            this.lblVOG.Text = "Voeg VOG* toe:";
            // 
            // btnPasfotoToevoegen
            // 
            this.btnPasfotoToevoegen.BackColor = System.Drawing.Color.Transparent;
            this.btnPasfotoToevoegen.BackgroundImage = global::CAREMATCH.Properties.Resources.up_arrow;
            this.btnPasfotoToevoegen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPasfotoToevoegen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPasfotoToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPasfotoToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasfotoToevoegen.Location = new System.Drawing.Point(485, 463);
            this.btnPasfotoToevoegen.Name = "btnPasfotoToevoegen";
            this.btnPasfotoToevoegen.Size = new System.Drawing.Size(56, 48);
            this.btnPasfotoToevoegen.TabIndex = 26;
            this.btnPasfotoToevoegen.UseVisualStyleBackColor = false;
            this.btnPasfotoToevoegen.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(702, 509);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 18);
            this.label13.TabIndex = 27;
            this.label13.Text = "*Verklaring omtrent gedrag";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyPictures;
            // 
            // lblPasFotoPath
            // 
            this.lblPasFotoPath.AutoSize = true;
            this.lblPasFotoPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasFotoPath.Location = new System.Drawing.Point(561, 409);
            this.lblPasFotoPath.Name = "lblPasFotoPath";
            this.lblPasFotoPath.Size = new System.Drawing.Size(0, 20);
            this.lblPasFotoPath.TabIndex = 28;
            // 
            // lblVOGPath
            // 
            this.lblVOGPath.AutoSize = true;
            this.lblVOGPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVOGPath.Location = new System.Drawing.Point(565, 478);
            this.lblVOGPath.Name = "lblVOGPath";
            this.lblVOGPath.Size = new System.Drawing.Size(0, 20);
            this.lblVOGPath.TabIndex = 29;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1033, 536);
            this.Controls.Add(this.lblVOGPath);
            this.Controls.Add(this.lblPasFotoPath);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnPasfotoToevoegen);
            this.Controls.Add(this.lblVOG);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUploadVOG);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHerhWachtwoord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.btnRegistreer);
            this.Controls.Add(this.txtGebruikersnaam);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignupForm";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHerhWachtwoord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Button btnUploadVOG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblVOG;
        private System.Windows.Forms.Button btnPasfotoToevoegen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblPasFotoPath;
        private System.Windows.Forms.Label lblVOGPath;
    }
}