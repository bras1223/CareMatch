namespace CAREMATCH
{
    partial class ChatForm
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
            this.tbBericht = new System.Windows.Forms.TextBox();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.btnVerzenden = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 25;
            this.lbChat.Location = new System.Drawing.Point(213, 136);
            this.lbChat.Margin = new System.Windows.Forms.Padding(6);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(965, 404);
            this.lbChat.TabIndex = 2;
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
            this.btnVerzenden.Click += new System.EventHandler(this.btnVerzenden_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CAREMATCH.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(213, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gebruikersnaam";
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
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 641);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVerzenden);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.tbBericht);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBericht;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.Button btnVerzenden;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTerug;
    }
}