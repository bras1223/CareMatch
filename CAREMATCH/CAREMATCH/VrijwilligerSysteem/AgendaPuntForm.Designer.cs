namespace CAREMATCH.VrijwilligerSysteem
{
    partial class AgendaPuntForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rtxtBeschrijving = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDatumAfspraak = new System.Windows.Forms.Label();
            this.lblAfspraakBeschrijving = new System.Windows.Forms.Label();
            this.lblVrijwilliger = new System.Windows.Forms.Label();
            this.lblAfspraakMet = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.txtHulpbehoevende = new System.Windows.Forms.TextBox();
            this.lblHulpbehoevende = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 33);
            this.textBox1.TabIndex = 1;
            // 
            // rtxtBeschrijving
            // 
            this.rtxtBeschrijving.Location = new System.Drawing.Point(303, 116);
            this.rtxtBeschrijving.Name = "rtxtBeschrijving";
            this.rtxtBeschrijving.Size = new System.Drawing.Size(414, 184);
            this.rtxtBeschrijving.TabIndex = 2;
            this.rtxtBeschrijving.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(303, 66);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 33);
            this.textBox2.TabIndex = 3;
            // 
            // lblDatumAfspraak
            // 
            this.lblDatumAfspraak.AutoSize = true;
            this.lblDatumAfspraak.Location = new System.Drawing.Point(12, 9);
            this.lblDatumAfspraak.Name = "lblDatumAfspraak";
            this.lblDatumAfspraak.Size = new System.Drawing.Size(89, 13);
            this.lblDatumAfspraak.TabIndex = 4;
            this.lblDatumAfspraak.Text = "Datum Afspraak: ";
            // 
            // lblAfspraakBeschrijving
            // 
            this.lblAfspraakBeschrijving.AutoSize = true;
            this.lblAfspraakBeschrijving.Location = new System.Drawing.Point(196, 116);
            this.lblAfspraakBeschrijving.Name = "lblAfspraakBeschrijving";
            this.lblAfspraakBeschrijving.Size = new System.Drawing.Size(67, 13);
            this.lblAfspraakBeschrijving.TabIndex = 5;
            this.lblAfspraakBeschrijving.Text = "Beschrijving:";
            // 
            // lblVrijwilliger
            // 
            this.lblVrijwilliger.AutoSize = true;
            this.lblVrijwilliger.Location = new System.Drawing.Point(196, 69);
            this.lblVrijwilliger.Name = "lblVrijwilliger";
            this.lblVrijwilliger.Size = new System.Drawing.Size(55, 13);
            this.lblVrijwilliger.TabIndex = 6;
            this.lblVrijwilliger.Text = "Vrijwilliger:";
            // 
            // lblAfspraakMet
            // 
            this.lblAfspraakMet.AutoSize = true;
            this.lblAfspraakMet.Location = new System.Drawing.Point(196, 18);
            this.lblAfspraakMet.Name = "lblAfspraakMet";
            this.lblAfspraakMet.Size = new System.Drawing.Size(101, 13);
            this.lblAfspraakMet.TabIndex = 7;
            this.lblAfspraakMet.Text = "Korte Omschrijving: ";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(12, 251);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(127, 49);
            this.btnOpslaan.TabIndex = 8;
            this.btnOpslaan.Text = "Afspraak Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // txtHulpbehoevende
            // 
            this.txtHulpbehoevende.Location = new System.Drawing.Point(576, 66);
            this.txtHulpbehoevende.Multiline = true;
            this.txtHulpbehoevende.Name = "txtHulpbehoevende";
            this.txtHulpbehoevende.Size = new System.Drawing.Size(141, 33);
            this.txtHulpbehoevende.TabIndex = 9;
            // 
            // lblHulpbehoevende
            // 
            this.lblHulpbehoevende.AutoSize = true;
            this.lblHulpbehoevende.Location = new System.Drawing.Point(463, 66);
            this.lblHulpbehoevende.Name = "lblHulpbehoevende";
            this.lblHulpbehoevende.Size = new System.Drawing.Size(92, 13);
            this.lblHulpbehoevende.TabIndex = 10;
            this.lblHulpbehoevende.Text = "Hulpbehoevende:";
            // 
            // NieuwAgendaPuntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 321);
            this.Controls.Add(this.lblHulpbehoevende);
            this.Controls.Add(this.txtHulpbehoevende);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.lblAfspraakMet);
            this.Controls.Add(this.lblVrijwilliger);
            this.Controls.Add(this.lblAfspraakBeschrijving);
            this.Controls.Add(this.lblDatumAfspraak);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rtxtBeschrijving);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "NieuwAgendaPuntForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NieuwAgendaPuntForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox rtxtBeschrijving;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDatumAfspraak;
        private System.Windows.Forms.Label lblAfspraakBeschrijving;
        private System.Windows.Forms.Label lblVrijwilliger;
        private System.Windows.Forms.Label lblAfspraakMet;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.TextBox txtHulpbehoevende;
        private System.Windows.Forms.Label lblHulpbehoevende;
    }
}