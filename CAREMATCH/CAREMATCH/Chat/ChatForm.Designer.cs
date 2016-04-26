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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.tbBericht = new System.Windows.Forms.TextBox();
            this.btnVerzenden = new System.Windows.Forms.Button();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.lbGebruikerLijst = new System.Windows.Forms.ListBox();
            this.tmrLaadberichten = new System.Windows.Forms.Timer(this.components);
            this.btnTerug = new System.Windows.Forms.Button();
            this.pbProfielFoto = new System.Windows.Forms.PictureBox();
            this.btnModus = new System.Windows.Forms.Button();
            this.lblParterStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfielFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBericht
            // 
            this.tbBericht.Location = new System.Drawing.Point(213, 552);
            this.tbBericht.Margin = new System.Windows.Forms.Padding(6);
            this.tbBericht.Multiline = true;
            this.tbBericht.Name = "tbBericht";
            this.tbBericht.Size = new System.Drawing.Size(825, 74);
            this.tbBericht.TabIndex = 0;
            this.tbBericht.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBericht_KeyDown);
            // 
            // btnVerzenden
            // 
            this.btnVerzenden.BackColor = System.Drawing.Color.Transparent;
            this.btnVerzenden.Image = global::CAREMATCH.Properties.Resources._interface;
            this.btnVerzenden.Location = new System.Drawing.Point(1050, 552);
            this.btnVerzenden.Margin = new System.Windows.Forms.Padding(6);
            this.btnVerzenden.Name = "btnVerzenden";
            this.btnVerzenden.Size = new System.Drawing.Size(128, 74);
            this.btnVerzenden.TabIndex = 3;
            this.btnVerzenden.UseVisualStyleBackColor = false;
            this.btnVerzenden.Click += new System.EventHandler(this.btnVerzenden_Click);
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Location = new System.Drawing.Point(343, 25);
            this.lblGebruikersnaam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(0, 26);
            this.lblGebruikersnaam.TabIndex = 5;
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 25;
            this.lbChat.Location = new System.Drawing.Point(213, 139);
            this.lbChat.Name = "lbChat";
            this.lbChat.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbChat.Size = new System.Drawing.Size(965, 354);
            this.lbChat.TabIndex = 7;
            this.lbChat.SelectedIndexChanged += new System.EventHandler(this.lbChat_SelectedIndexChanged);
            // 
            // lbGebruikerLijst
            // 
            this.lbGebruikerLijst.FormattingEnabled = true;
            this.lbGebruikerLijst.ItemHeight = 25;
            this.lbGebruikerLijst.Location = new System.Drawing.Point(12, 12);
            this.lbGebruikerLijst.Name = "lbGebruikerLijst";
            this.lbGebruikerLijst.Size = new System.Drawing.Size(192, 454);
            this.lbGebruikerLijst.TabIndex = 8;
            this.lbGebruikerLijst.SelectedIndexChanged += new System.EventHandler(this.lbGebruikerLijst_SelectedIndexChanged_1);
            // 
            // tmrLaadberichten
            // 
            this.tmrLaadberichten.Tick += new System.EventHandler(this.tmrLaadberichten_Tick);
            // 
            // btnTerug
            // 
            this.btnTerug.BackColor = System.Drawing.Color.Transparent;
            this.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerug.Image = global::CAREMATCH.Properties.Resources.buildings;
            this.btnTerug.Location = new System.Drawing.Point(58, 524);
            this.btnTerug.Margin = new System.Windows.Forms.Padding(6);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(91, 86);
            this.btnTerug.TabIndex = 6;
            this.btnTerug.UseVisualStyleBackColor = false;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click_1);
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
            // btnModus
            // 
            this.btnModus.Location = new System.Drawing.Point(1011, 28);
            this.btnModus.Name = "btnModus";
            this.btnModus.Size = new System.Drawing.Size(167, 76);
            this.btnModus.TabIndex = 9;
            this.btnModus.Text = "Nieuwe Chat";
            this.btnModus.UseVisualStyleBackColor = true;
            this.btnModus.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // lblParterStatus
            // 
            this.lblParterStatus.AutoSize = true;
            this.lblParterStatus.ForeColor = System.Drawing.Color.Red;
            this.lblParterStatus.Location = new System.Drawing.Point(343, 54);
            this.lblParterStatus.Name = "lblParterStatus";
            this.lblParterStatus.Size = new System.Drawing.Size(0, 26);
            this.lblParterStatus.TabIndex = 10;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 641);
            this.Controls.Add(this.lblParterStatus);
            this.Controls.Add(this.btnModus);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.lblGebruikersnaam);
            this.Controls.Add(this.pbProfielFoto);
            this.Controls.Add(this.btnVerzenden);
            this.Controls.Add(this.tbBericht);
            this.Controls.Add(this.lbGebruikerLijst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat - CareMatch";
            this.Load += new System.EventHandler(this.ChatForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfielFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBericht;
        private System.Windows.Forms.Button btnVerzenden;
        private System.Windows.Forms.PictureBox pbProfielFoto;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.ListBox lbGebruikerLijst;
        private System.Windows.Forms.Timer tmrLaadberichten;
        private System.Windows.Forms.Button btnModus;
        private System.Windows.Forms.Label lblParterStatus;
    }
}