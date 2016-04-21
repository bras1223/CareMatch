namespace CAREMATCH.VrijwilligerSysteem
{
    partial class HulpvraagForm
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lblHulpvrager = new System.Windows.Forms.Label();
            this.btnSluit = new System.Windows.Forms.Button();
            this.lblReactie = new System.Windows.Forms.Label();
            this.rtxtReactieInhoud = new System.Windows.Forms.RichTextBox();
            this.btnReactieOpslaan = new System.Windows.Forms.Button();
            this.rtxtHulpvraag = new System.Windows.Forms.RichTextBox();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.txtHulpvrager = new System.Windows.Forms.TextBox();
            this.lblDuur = new System.Windows.Forms.Label();
            this.txtDuur = new System.Windows.Forms.TextBox();
            this.txtFrequentie = new System.Windows.Forms.TextBox();
            this.lblFrequentie = new System.Windows.Forms.Label();
            this.cbUrgent = new System.Windows.Forms.CheckBox();
            this.lblUrgent = new System.Windows.Forms.Label();
            this.btnHulpvraagOpslaan = new System.Windows.Forms.Button();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAutoBenodigd = new System.Windows.Forms.CheckBox();
            this.pbHulpbehoevende = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAfspraakInAgenda = new System.Windows.Forms.Button();
            this.btnStartChat = new System.Windows.Forms.Button();
            this.txtVrijwilliger = new System.Windows.Forms.TextBox();
            this.lblVrijwilliger = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lbldatumtijd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHulpbehoevende)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(172, 438);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(251, 31);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Korte Omschrijving:";
            this.lblTitel.Click += new System.EventHandler(this.lblTitel_Click);
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmschrijving.Location = new System.Drawing.Point(469, 498);
            this.lblOmschrijving.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(179, 31);
            this.lblOmschrijving.TabIndex = 2;
            this.lblOmschrijving.Text = "Omschrijving:";
            // 
            // lblHulpvrager
            // 
            this.lblHulpvrager.AutoSize = true;
            this.lblHulpvrager.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHulpvrager.Location = new System.Drawing.Point(197, 22);
            this.lblHulpvrager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHulpvrager.Name = "lblHulpvrager";
            this.lblHulpvrager.Size = new System.Drawing.Size(226, 31);
            this.lblHulpvrager.TabIndex = 4;
            this.lblHulpvrager.Text = "Hulpvrager Naam";
            // 
            // btnSluit
            // 
            this.btnSluit.BackColor = System.Drawing.Color.Transparent;
            this.btnSluit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSluit.Image = global::CAREMATCH.Properties.Resources.circle_1_;
            this.btnSluit.Location = new System.Drawing.Point(48, 888);
            this.btnSluit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSluit.Name = "btnSluit";
            this.btnSluit.Size = new System.Drawing.Size(86, 79);
            this.btnSluit.TabIndex = 11;
            this.btnSluit.UseVisualStyleBackColor = false;
            this.btnSluit.Click += new System.EventHandler(this.btnSluit_Click);
            // 
            // lblReactie
            // 
            this.lblReactie.AutoSize = true;
            this.lblReactie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReactie.Location = new System.Drawing.Point(469, 718);
            this.lblReactie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReactie.Name = "lblReactie";
            this.lblReactie.Size = new System.Drawing.Size(115, 31);
            this.lblReactie.TabIndex = 4;
            this.lblReactie.Text = "Reactie:";
            // 
            // rtxtReactieInhoud
            // 
            this.rtxtReactieInhoud.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtReactieInhoud.Location = new System.Drawing.Point(476, 753);
            this.rtxtReactieInhoud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtReactieInhoud.Name = "rtxtReactieInhoud";
            this.rtxtReactieInhoud.Size = new System.Drawing.Size(845, 216);
            this.rtxtReactieInhoud.TabIndex = 8;
            this.rtxtReactieInhoud.Text = "";
            // 
            // btnReactieOpslaan
            // 
            this.btnReactieOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactieOpslaan.Image = global::CAREMATCH.Properties.Resources._interface;
            this.btnReactieOpslaan.Location = new System.Drawing.Point(48, 774);
            this.btnReactieOpslaan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReactieOpslaan.Name = "btnReactieOpslaan";
            this.btnReactieOpslaan.Size = new System.Drawing.Size(86, 79);
            this.btnReactieOpslaan.TabIndex = 10;
            this.btnReactieOpslaan.UseVisualStyleBackColor = true;
            this.btnReactieOpslaan.Click += new System.EventHandler(this.btnSlaOp_Click);
            // 
            // rtxtHulpvraag
            // 
            this.rtxtHulpvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtHulpvraag.Location = new System.Drawing.Point(476, 534);
            this.rtxtHulpvraag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtHulpvraag.Name = "rtxtHulpvraag";
            this.rtxtHulpvraag.Size = new System.Drawing.Size(845, 166);
            this.rtxtHulpvraag.TabIndex = 7;
            this.rtxtHulpvraag.Text = "";
            // 
            // txtTitel
            // 
            this.txtTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitel.Location = new System.Drawing.Point(476, 434);
            this.txtTitel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitel.Multiline = true;
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(729, 50);
            this.txtTitel.TabIndex = 1;
            this.txtTitel.TextChanged += new System.EventHandler(this.txtTitel_TextChanged);
            // 
            // txtHulpvrager
            // 
            this.txtHulpvrager.Enabled = false;
            this.txtHulpvrager.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHulpvrager.Location = new System.Drawing.Point(509, 22);
            this.txtHulpvrager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHulpvrager.Multiline = true;
            this.txtHulpvrager.Name = "txtHulpvrager";
            this.txtHulpvrager.Size = new System.Drawing.Size(729, 47);
            this.txtHulpvrager.TabIndex = 2;
            // 
            // lblDuur
            // 
            this.lblDuur.AutoSize = true;
            this.lblDuur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuur.Location = new System.Drawing.Point(935, 303);
            this.lblDuur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuur.Name = "lblDuur";
            this.lblDuur.Size = new System.Drawing.Size(196, 31);
            this.lblDuur.TabIndex = 15;
            this.lblDuur.Text = "Duur Afspraak:";
            // 
            // txtDuur
            // 
            this.txtDuur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuur.Location = new System.Drawing.Point(1177, 303);
            this.txtDuur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDuur.Multiline = true;
            this.txtDuur.Name = "txtDuur";
            this.txtDuur.Size = new System.Drawing.Size(141, 47);
            this.txtDuur.TabIndex = 3;
            // 
            // txtFrequentie
            // 
            this.txtFrequentie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrequentie.Location = new System.Drawing.Point(476, 282);
            this.txtFrequentie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFrequentie.Multiline = true;
            this.txtFrequentie.Name = "txtFrequentie";
            this.txtFrequentie.Size = new System.Drawing.Size(141, 47);
            this.txtFrequentie.TabIndex = 4;
            // 
            // lblFrequentie
            // 
            this.lblFrequentie.AutoSize = true;
            this.lblFrequentie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequentie.Location = new System.Drawing.Point(168, 282);
            this.lblFrequentie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrequentie.Name = "lblFrequentie";
            this.lblFrequentie.Size = new System.Drawing.Size(267, 31);
            this.lblFrequentie.TabIndex = 17;
            this.lblFrequentie.Text = "Frequentie Afspraak:";
            // 
            // cbUrgent
            // 
            this.cbUrgent.AutoSize = true;
            this.cbUrgent.Location = new System.Drawing.Point(1300, 247);
            this.cbUrgent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUrgent.Name = "cbUrgent";
            this.cbUrgent.Size = new System.Drawing.Size(18, 17);
            this.cbUrgent.TabIndex = 6;
            this.cbUrgent.UseVisualStyleBackColor = true;
            // 
            // lblUrgent
            // 
            this.lblUrgent.AutoSize = true;
            this.lblUrgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrgent.Location = new System.Drawing.Point(1161, 236);
            this.lblUrgent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrgent.Name = "lblUrgent";
            this.lblUrgent.Size = new System.Drawing.Size(104, 31);
            this.lblUrgent.TabIndex = 20;
            this.lblUrgent.Text = "Urgent:";
            // 
            // btnHulpvraagOpslaan
            // 
            this.btnHulpvraagOpslaan.BackColor = System.Drawing.Color.Transparent;
            this.btnHulpvraagOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHulpvraagOpslaan.Image = global::CAREMATCH.Properties.Resources._interface;
            this.btnHulpvraagOpslaan.Location = new System.Drawing.Point(48, 774);
            this.btnHulpvraagOpslaan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHulpvraagOpslaan.Name = "btnHulpvraagOpslaan";
            this.btnHulpvraagOpslaan.Size = new System.Drawing.Size(86, 79);
            this.btnHulpvraagOpslaan.TabIndex = 9;
            this.btnHulpvraagOpslaan.UseVisualStyleBackColor = false;
            this.btnHulpvraagOpslaan.Click += new System.EventHandler(this.btnHulpvraagOpslaan_Click);
            // 
            // txtLocatie
            // 
            this.txtLocatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocatie.Location = new System.Drawing.Point(476, 354);
            this.txtLocatie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocatie.Multiline = true;
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(267, 54);
            this.txtLocatie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Afspreek locatie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(780, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Vink aan als er een auto benodigd is:";
            // 
            // cbAutoBenodigd
            // 
            this.cbAutoBenodigd.AutoSize = true;
            this.cbAutoBenodigd.Location = new System.Drawing.Point(1300, 369);
            this.cbAutoBenodigd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAutoBenodigd.Name = "cbAutoBenodigd";
            this.cbAutoBenodigd.Size = new System.Drawing.Size(18, 17);
            this.cbAutoBenodigd.TabIndex = 23;
            this.cbAutoBenodigd.UseVisualStyleBackColor = true;
            // 
            // pbHulpbehoevende
            // 
            this.pbHulpbehoevende.Location = new System.Drawing.Point(9, 22);
            this.pbHulpbehoevende.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHulpbehoevende.Name = "pbHulpbehoevende";
            this.pbHulpbehoevende.Size = new System.Drawing.Size(159, 175);
            this.pbHulpbehoevende.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHulpbehoevende.TabIndex = 26;
            this.pbHulpbehoevende.TabStop = false;
            this.pbHulpbehoevende.Click += new System.EventHandler(this.pbHulpbehoevende_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1305, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAfspraakInAgenda
            // 
            this.btnAfspraakInAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfspraakInAgenda.Location = new System.Drawing.Point(189, 774);
            this.btnAfspraakInAgenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAfspraakInAgenda.Name = "btnAfspraakInAgenda";
            this.btnAfspraakInAgenda.Size = new System.Drawing.Size(188, 79);
            this.btnAfspraakInAgenda.TabIndex = 28;
            this.btnAfspraakInAgenda.Text = "Zet afspraak in Agenda";
            this.btnAfspraakInAgenda.UseVisualStyleBackColor = true;
            // 
            // btnStartChat
            // 
            this.btnStartChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartChat.Location = new System.Drawing.Point(189, 890);
            this.btnStartChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartChat.Name = "btnStartChat";
            this.btnStartChat.Size = new System.Drawing.Size(188, 79);
            this.btnStartChat.TabIndex = 29;
            this.btnStartChat.Text = "Start Chat";
            this.btnStartChat.UseVisualStyleBackColor = true;
            // 
            // txtVrijwilliger
            // 
            this.txtVrijwilliger.Enabled = false;
            this.txtVrijwilliger.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVrijwilliger.Location = new System.Drawing.Point(204, 128);
            this.txtVrijwilliger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVrijwilliger.Multiline = true;
            this.txtVrijwilliger.Name = "txtVrijwilliger";
            this.txtVrijwilliger.Size = new System.Drawing.Size(729, 47);
            this.txtVrijwilliger.TabIndex = 30;
            // 
            // lblVrijwilliger
            // 
            this.lblVrijwilliger.AutoSize = true;
            this.lblVrijwilliger.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijwilliger.Location = new System.Drawing.Point(1005, 128);
            this.lblVrijwilliger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVrijwilliger.Name = "lblVrijwilliger";
            this.lblVrijwilliger.Size = new System.Drawing.Size(215, 31);
            this.lblVrijwilliger.TabIndex = 31;
            this.lblVrijwilliger.Text = "Vrijwilliger Naam";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Location = new System.Drawing.Point(476, 223);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatum.MinDate = new System.DateTime(2016, 4, 21, 0, 0, 0, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(329, 38);
            this.dtpDatum.TabIndex = 32;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dtpDatum_ValueChanged);
            // 
            // lbldatumtijd
            // 
            this.lbldatumtijd.AutoSize = true;
            this.lbldatumtijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatumtijd.Location = new System.Drawing.Point(13, 223);
            this.lbldatumtijd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatumtijd.Name = "lbldatumtijd";
            this.lbldatumtijd.Size = new System.Drawing.Size(411, 31);
            this.lbldatumtijd.TabIndex = 33;
            this.lbldatumtijd.Text = "Datum && tijd van benodigde hulp:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtHulpvrager);
            this.groupBox1.Controls.Add(this.lblHulpvrager);
            this.groupBox1.Controls.Add(this.pbHulpbehoevende);
            this.groupBox1.Controls.Add(this.lblVrijwilliger);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtVrijwilliger);
            this.groupBox1.Location = new System.Drawing.Point(16, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1480, 212);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // HulpvraagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 980);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbldatumtijd);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnStartChat);
            this.Controls.Add(this.btnAfspraakInAgenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAutoBenodigd);
            this.Controls.Add(this.txtLocatie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHulpvraagOpslaan);
            this.Controls.Add(this.lblUrgent);
            this.Controls.Add(this.cbUrgent);
            this.Controls.Add(this.txtFrequentie);
            this.Controls.Add(this.lblFrequentie);
            this.Controls.Add(this.txtDuur);
            this.Controls.Add(this.lblDuur);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.rtxtHulpvraag);
            this.Controls.Add(this.btnReactieOpslaan);
            this.Controls.Add(this.rtxtReactieInhoud);
            this.Controls.Add(this.lblReactie);
            this.Controls.Add(this.btnSluit);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.lblTitel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HulpvraagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HulpvraagForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbHulpbehoevende)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Label lblHulpvrager;
        private System.Windows.Forms.Button btnSluit;
        private System.Windows.Forms.Label lblReactie;
        private System.Windows.Forms.RichTextBox rtxtReactieInhoud;
        private System.Windows.Forms.Button btnReactieOpslaan;
        private System.Windows.Forms.RichTextBox rtxtHulpvraag;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.TextBox txtHulpvrager;
        private System.Windows.Forms.Label lblDuur;
        private System.Windows.Forms.TextBox txtDuur;
        private System.Windows.Forms.TextBox txtFrequentie;
        private System.Windows.Forms.Label lblFrequentie;
        private System.Windows.Forms.CheckBox cbUrgent;
        private System.Windows.Forms.Label lblUrgent;
        private System.Windows.Forms.Button btnHulpvraagOpslaan;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAutoBenodigd;
        private System.Windows.Forms.PictureBox pbHulpbehoevende;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAfspraakInAgenda;
        private System.Windows.Forms.Button btnStartChat;
        private System.Windows.Forms.TextBox txtVrijwilliger;
        private System.Windows.Forms.Label lblVrijwilliger;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lbldatumtijd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}