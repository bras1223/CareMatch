namespace Login
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
            this.btnTerug = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHerhWachtwoord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 161);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(168, 28);
            this.btnTerug.TabIndex = 6;
            this.btnTerug.Text = "Terug naar login scherm";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(407, 113);
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
            this.label4.Location = new System.Drawing.Point(407, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Zwak wachtwoord";
            // 
            // txtHerhWachtwoord
            // 
            this.txtHerhWachtwoord.Location = new System.Drawing.Point(206, 113);
            this.txtHerhWachtwoord.Name = "txtHerhWachtwoord";
            this.txtHerhWachtwoord.PasswordChar = '*';
            this.txtHerhWachtwoord.Size = new System.Drawing.Size(168, 20);
            this.txtHerhWachtwoord.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Herhaal wachtwoord:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Wachtwoord:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gebruikersnaam:";
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(206, 82);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.PasswordChar = '*';
            this.txtWachtwoord.Size = new System.Drawing.Size(168, 20);
            this.txtWachtwoord.TabIndex = 3;
            this.txtWachtwoord.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Location = new System.Drawing.Point(425, 161);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(168, 28);
            this.btnRegistreer.TabIndex = 5;
            this.btnRegistreer.Text = "Registreer";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            this.btnRegistreer.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Location = new System.Drawing.Point(206, 40);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(168, 20);
            this.txtGebruikersnaam.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Rol:";
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Hulpbehoevende",
            "Vrijwilliger"});
            this.cbRol.Location = new System.Drawing.Point(204, 5);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(169, 21);
            this.cbRol.TabIndex = 1;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 201);
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
    }
}