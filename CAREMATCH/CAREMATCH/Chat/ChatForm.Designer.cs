namespace CAREMATCH
{
    partial class ChatForm
    {
        // <summary>
        // Required designer variable.
        // </summary>
        private System.ComponentModel.IContainer components = null;

        // <summary>
        // Clean up any resources being used.
        // </summary>
        // <param name = "disposing" > true if managed resources should be disposed; otherwise, false.</param>
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
            this.tbBericht = new System.Windows.Forms.TextBox();
            this.btnVerzenden = new System.Windows.Forms.Button();
            this.pbProfielFoto = new System.Windows.Forms.PictureBox();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.lbGebruikerLijst = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfielFoto)).BeginInit();
            // 
            // tbBericht
            // 
            this.tbBericht.Location = new System.Drawing.Point(213, 552);
            this.tbBericht.Margin = new System.Windows.Forms.Padding(6);
            this.tbBericht.Multiline = true;
            this.tbBericht.Name = "tbBericht";
            this.tbBericht.Size = new System.Drawing.Size(825, 74);
            this.tbBericht.TabIndex = 0;
            // 
            // btnVerzenden
            // 
            this.btnVerzenden.Location = new System.Drawing.Point(1050, 552);
            this.btnVerzenden.Margin = new System.Windows.Forms.Padding(6);
            this.btnVerzenden.Name = "btnVerzenden";
            this.btnVerzenden.Size = new System.Drawing.Size(128, 74);
            this.btnVerzenden.TabIndex = 3;
            this.btnVerzenden.Text = "Verzenden";
            this.btnVerzenden.UseVisualStyleBackColor = true;
            // 
            // pbProfielFoto
            // 
            this.pbProfielFoto.Location = new System.Drawing.Point(213, 15);
            this.pbProfielFoto.Margin = new System.Windows.Forms.Padding(6);
            this.pbProfielFoto.Name = "pbProfielFoto";
            this.pbProfielFoto.Size = new System.Drawing.Size(98, 96);
            this.pbProfielFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfielFoto.TabIndex = 4;
            this.pbProfielFoto.TabStop = false;
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Location = new System.Drawing.Point(343, 25);
            this.lblGebruikersnaam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(173, 26);
            this.lblGebruikersnaam.TabIndex = 5;
            this.lblGebruikersnaam.Text = "Gebruikersnaam";
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(15, 15);
            this.btnTerug.Margin = new System.Windows.Forms.Padding(6);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(112, 45);
            this.btnTerug.TabIndex = 6;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 25;
            this.lbChat.Location = new System.Drawing.Point(213, 139);
            this.lbChat.Name = "lbChat";
            this.lbChat.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbChat.Size = new System.Drawing.Size(965, 404);
            this.lbChat.TabIndex = 7;
            // 
            // lbGebruikerLijst
            // 
            this.lbGebruikerLijst.FormattingEnabled = true;
            this.lbGebruikerLijst.ItemHeight = 25;
            this.lbGebruikerLijst.Location = new System.Drawing.Point(12, 139);
            this.lbGebruikerLijst.Name = "lbGebruikerLijst";
            this.lbGebruikerLijst.Size = new System.Drawing.Size(192, 479);
            this.lbGebruikerLijst.TabIndex = 8;
            // 
            // ChatForm

        }

        #endregion

        private System.Windows.Forms.TextBox tbBericht;
        private System.Windows.Forms.Button btnVerzenden;
        private System.Windows.Forms.PictureBox pbProfielFoto;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.ListBox lbGebruikerLijst;
    }
}