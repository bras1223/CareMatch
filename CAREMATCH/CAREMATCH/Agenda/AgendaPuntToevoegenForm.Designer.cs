namespace CAREMATCH.Agenda
{
    partial class AgendaPuntToevoegenForm
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
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.txtBeschrijving = new System.Windows.Forms.RichTextBox();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVrijwilliger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHulpbehoevende = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEindTijd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartTijd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(12, 337);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(115, 55);
            this.btnOpslaan.TabIndex = 0;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // txtBeschrijving
            // 
            this.txtBeschrijving.Location = new System.Drawing.Point(209, 175);
            this.txtBeschrijving.Name = "txtBeschrijving";
            this.txtBeschrijving.Size = new System.Drawing.Size(566, 217);
            this.txtBeschrijving.TabIndex = 1;
            this.txtBeschrijving.Text = "";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(310, 9);
            this.txtTitel.Multiline = true;
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(465, 35);
            this.txtTitel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Korte Omschrijving:";
            // 
            // txtVrijwilliger
            // 
            this.txtVrijwilliger.Location = new System.Drawing.Point(310, 63);
            this.txtVrijwilliger.Multiline = true;
            this.txtVrijwilliger.Name = "txtVrijwilliger";
            this.txtVrijwilliger.Size = new System.Drawing.Size(166, 35);
            this.txtVrijwilliger.TabIndex = 5;
            this.txtVrijwilliger.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hulpbehoevende:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vrijwilliger:";
            // 
            // txtHulpbehoevende
            // 
            this.txtHulpbehoevende.Location = new System.Drawing.Point(609, 60);
            this.txtHulpbehoevende.Multiline = true;
            this.txtHulpbehoevende.Name = "txtHulpbehoevende";
            this.txtHulpbehoevende.Size = new System.Drawing.Size(166, 35);
            this.txtHulpbehoevende.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // txtEindTijd
            // 
            this.txtEindTijd.Location = new System.Drawing.Point(609, 119);
            this.txtEindTijd.Multiline = true;
            this.txtEindTijd.Name = "txtEindTijd";
            this.txtEindTijd.Size = new System.Drawing.Size(166, 35);
            this.txtEindTijd.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Start Tijd:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Eind Tijd:";
            // 
            // txtStartTijd
            // 
            this.txtStartTijd.Location = new System.Drawing.Point(310, 122);
            this.txtStartTijd.Multiline = true;
            this.txtStartTijd.Name = "txtStartTijd";
            this.txtStartTijd.Size = new System.Drawing.Size(166, 35);
            this.txtStartTijd.TabIndex = 10;
            // 
            // AgendaPuntToevoegenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 410);
            this.Controls.Add(this.txtEindTijd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStartTijd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtHulpbehoevende);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVrijwilliger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.txtBeschrijving);
            this.Controls.Add(this.btnOpslaan);
            this.Name = "AgendaPuntToevoegenForm";
            this.Text = "AgendaPuntToevoegenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.RichTextBox txtBeschrijving;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVrijwilliger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHulpbehoevende;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEindTijd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStartTijd;
    }
}