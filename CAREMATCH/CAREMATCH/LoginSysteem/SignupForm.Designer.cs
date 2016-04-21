namespace CAREMATCH.LoginSysteem
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
            this.lblSterkWW = new System.Windows.Forms.Label();
            this.lblZwakWW = new System.Windows.Forms.Label();
            this.tbHerhWachtwoord = new System.Windows.Forms.TextBox();
            this.lblWachtwoord2 = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.tbGebruikersnaam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblVOG = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPasFotoPath = new System.Windows.Forms.Label();
            this.lblVOGPath = new System.Windows.Forms.Label();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.cbGeslacht = new System.Windows.Forms.ComboBox();
            this.dtpGeboortedatum = new System.Windows.Forms.DateTimePicker();
            this.btnPasfotoToevoegen = new System.Windows.Forms.Button();
            this.btnUploadVOG = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.lblRFIDUitleg = new System.Windows.Forms.Label();
            this.lblRFIDAttached = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSterkWW
            // 
            this.lblSterkWW.AutoSize = true;
            this.lblSterkWW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSterkWW.ForeColor = System.Drawing.Color.Green;
            this.lblSterkWW.Location = new System.Drawing.Point(856, 209);
            this.lblSterkWW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSterkWW.Name = "lblSterkWW";
            this.lblSterkWW.Size = new System.Drawing.Size(183, 25);
            this.lblSterkWW.TabIndex = 18;
            this.lblSterkWW.Text = "Sterk wachtwoord";
            // 
            // lblZwakWW
            // 
            this.lblZwakWW.AutoSize = true;
            this.lblZwakWW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZwakWW.ForeColor = System.Drawing.Color.Red;
            this.lblZwakWW.Location = new System.Drawing.Point(856, 171);
            this.lblZwakWW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZwakWW.Name = "lblZwakWW";
            this.lblZwakWW.Size = new System.Drawing.Size(183, 25);
            this.lblZwakWW.TabIndex = 17;
            this.lblZwakWW.Text = "Zwak wachtwoord";
            // 
            // tbHerhWachtwoord
            // 
            this.tbHerhWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHerhWachtwoord.Location = new System.Drawing.Point(607, 203);
            this.tbHerhWachtwoord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHerhWachtwoord.Name = "tbHerhWachtwoord";
            this.tbHerhWachtwoord.PasswordChar = '*';
            this.tbHerhWachtwoord.Size = new System.Drawing.Size(223, 26);
            this.tbHerhWachtwoord.TabIndex = 4;
            // 
            // lblWachtwoord2
            // 
            this.lblWachtwoord2.AutoSize = true;
            this.lblWachtwoord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWachtwoord2.Location = new System.Drawing.Point(313, 203);
            this.lblWachtwoord2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWachtwoord2.Name = "lblWachtwoord2";
            this.lblWachtwoord2.Size = new System.Drawing.Size(270, 31);
            this.lblWachtwoord2.TabIndex = 16;
            this.lblWachtwoord2.Text = "Herhaal wachtwoord:";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWachtwoord.Location = new System.Drawing.Point(313, 149);
            this.lblWachtwoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(173, 31);
            this.lblWachtwoord.TabIndex = 15;
            this.lblWachtwoord.Text = "Wachtwoord:";
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruikersnaam.Location = new System.Drawing.Point(313, 102);
            this.lblGebruikersnaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(222, 31);
            this.lblGebruikersnaam.TabIndex = 12;
            this.lblGebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWachtwoord.Location = new System.Drawing.Point(607, 149);
            this.tbWachtwoord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.PasswordChar = '*';
            this.tbWachtwoord.Size = new System.Drawing.Size(223, 26);
            this.tbWachtwoord.TabIndex = 3;
            this.tbWachtwoord.TextChanged += new System.EventHandler(this.txtHerhWachtwoord_TextChanged);
            // 
            // tbGebruikersnaam
            // 
            this.tbGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGebruikersnaam.Location = new System.Drawing.Point(607, 102);
            this.tbGebruikersnaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGebruikersnaam.Name = "tbGebruikersnaam";
            this.tbGebruikersnaam.Size = new System.Drawing.Size(223, 26);
            this.tbGebruikersnaam.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 31);
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
            this.cbRol.Location = new System.Drawing.Point(605, 34);
            this.cbRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(224, 28);
            this.cbRol.TabIndex = 1;
            this.cbRol.SelectedIndexChanged += new System.EventHandler(this.cbRol_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(313, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "Voornaam:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 324);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 31);
            this.label8.TabIndex = 21;
            this.label8.Text = "Achternaam:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(313, 372);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 31);
            this.label9.TabIndex = 22;
            this.label9.Text = "Geslacht:";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(313, 495);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(279, 31);
            this.lblFoto.TabIndex = 23;
            this.lblFoto.Text = "Voeg een pasfoto toe:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(313, 425);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 31);
            this.label11.TabIndex = 24;
            this.label11.Text = "Geboortedatum:";
            // 
            // lblVOG
            // 
            this.lblVOG.AutoSize = true;
            this.lblVOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVOG.Location = new System.Drawing.Point(315, 585);
            this.lblVOG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVOG.Name = "lblVOG";
            this.lblVOG.Size = new System.Drawing.Size(208, 31);
            this.lblVOG.TabIndex = 25;
            this.lblVOG.Text = "Voeg VOG* toe:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(822, 618);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(235, 24);
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
            this.lblPasFotoPath.Location = new System.Drawing.Point(748, 503);
            this.lblPasFotoPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasFotoPath.Name = "lblPasFotoPath";
            this.lblPasFotoPath.Size = new System.Drawing.Size(0, 25);
            this.lblPasFotoPath.TabIndex = 28;
            // 
            // lblVOGPath
            // 
            this.lblVOGPath.AutoSize = true;
            this.lblVOGPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVOGPath.Location = new System.Drawing.Point(753, 588);
            this.lblVOGPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVOGPath.Name = "lblVOGPath";
            this.lblVOGPath.Size = new System.Drawing.Size(0, 25);
            this.lblVOGPath.TabIndex = 29;
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVoornaam.Location = new System.Drawing.Point(607, 278);
            this.tbVoornaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(223, 26);
            this.tbVoornaam.TabIndex = 30;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAchternaam.Location = new System.Drawing.Point(607, 327);
            this.tbAchternaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(223, 26);
            this.tbAchternaam.TabIndex = 31;
            // 
            // cbGeslacht
            // 
            this.cbGeslacht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGeslacht.FormattingEnabled = true;
            this.cbGeslacht.Items.AddRange(new object[] {
            "Man",
            "Vrouw"});
            this.cbGeslacht.Location = new System.Drawing.Point(605, 372);
            this.cbGeslacht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGeslacht.Name = "cbGeslacht";
            this.cbGeslacht.Size = new System.Drawing.Size(224, 28);
            this.cbGeslacht.TabIndex = 32;
            // 
            // dtpGeboortedatum
            // 
            this.dtpGeboortedatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGeboortedatum.Location = new System.Drawing.Point(605, 431);
            this.dtpGeboortedatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpGeboortedatum.Name = "dtpGeboortedatum";
            this.dtpGeboortedatum.Size = new System.Drawing.Size(284, 26);
            this.dtpGeboortedatum.TabIndex = 33;
            // 
            // btnPasfotoToevoegen
            // 
            this.btnPasfotoToevoegen.BackColor = System.Drawing.Color.Transparent;
            this.btnPasfotoToevoegen.BackgroundImage = global::CAREMATCH.Properties.Resources.up_arrow;
            this.btnPasfotoToevoegen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPasfotoToevoegen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPasfotoToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPasfotoToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasfotoToevoegen.Location = new System.Drawing.Point(644, 469);
            this.btnPasfotoToevoegen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasfotoToevoegen.Name = "btnPasfotoToevoegen";
            this.btnPasfotoToevoegen.Size = new System.Drawing.Size(75, 59);
            this.btnPasfotoToevoegen.TabIndex = 26;
            this.btnPasfotoToevoegen.UseVisualStyleBackColor = false;
            this.btnPasfotoToevoegen.Click += new System.EventHandler(this.btnPasfotoToevoegen_Click);
            // 
            // btnUploadVOG
            // 
            this.btnUploadVOG.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadVOG.BackgroundImage = global::CAREMATCH.Properties.Resources.up_arrow;
            this.btnUploadVOG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUploadVOG.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUploadVOG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadVOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadVOG.Location = new System.Drawing.Point(644, 570);
            this.btnUploadVOG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUploadVOG.Name = "btnUploadVOG";
            this.btnUploadVOG.Size = new System.Drawing.Size(75, 59);
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
            this.btnTerug.Location = new System.Drawing.Point(57, 554);
            this.btnTerug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(100, 91);
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
            this.btnRegistreer.Location = new System.Drawing.Point(1188, 554);
            this.btnRegistreer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(100, 91);
            this.btnRegistreer.TabIndex = 7;
            this.btnRegistreer.UseVisualStyleBackColor = false;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // lblRFIDUitleg
            // 
            this.lblRFIDUitleg.AutoSize = true;
            this.lblRFIDUitleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFIDUitleg.Location = new System.Drawing.Point(274, 556);
            this.lblRFIDUitleg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRFIDUitleg.Name = "lblRFIDUitleg";
            this.lblRFIDUitleg.Size = new System.Drawing.Size(777, 87);
            this.lblRFIDUitleg.TabIndex = 34;
            this.lblRFIDUitleg.Text = "Als Hulpbehoevende kunt u ook uw TAG gebruiken om te registreren. \r\nLeg deze op d" +
    "e scanner, zodat u geen gebruikersnaam en wachtwoord \r\nmeer in hoeft te vullen.";
            // 
            // lblRFIDAttached
            // 
            this.lblRFIDAttached.AutoSize = true;
            this.lblRFIDAttached.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFIDAttached.Location = new System.Drawing.Point(315, 142);
            this.lblRFIDAttached.Name = "lblRFIDAttached";
            this.lblRFIDAttached.Size = new System.Drawing.Size(562, 64);
            this.lblRFIDAttached.TabIndex = 35;
            this.lblRFIDAttached.Text = "U wordt op dit moment aangemeld met een \r\nongebruikte RFID tag.\r\n";
            this.lblRFIDAttached.Visible = false;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1377, 660);
            this.Controls.Add(this.lblRFIDAttached);
            this.Controls.Add(this.lblRFIDUitleg);
            this.Controls.Add(this.dtpGeboortedatum);
            this.Controls.Add(this.cbGeslacht);
            this.Controls.Add(this.tbAchternaam);
            this.Controls.Add(this.tbVoornaam);
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
            this.Controls.Add(this.lblSterkWW);
            this.Controls.Add(this.lblZwakWW);
            this.Controls.Add(this.tbHerhWachtwoord);
            this.Controls.Add(this.lblWachtwoord2);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblGebruikersnaam);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.btnRegistreer);
            this.Controls.Add(this.tbGebruikersnaam);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignupForm";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label lblSterkWW;
        private System.Windows.Forms.Label lblZwakWW;
        private System.Windows.Forms.TextBox tbHerhWachtwoord;
        private System.Windows.Forms.Label lblWachtwoord2;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.TextBox tbGebruikersnaam;
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
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.ComboBox cbGeslacht;
        private System.Windows.Forms.DateTimePicker dtpGeboortedatum;
        private System.Windows.Forms.Label lblRFIDUitleg;
        private System.Windows.Forms.Label lblRFIDAttached;
    }
}