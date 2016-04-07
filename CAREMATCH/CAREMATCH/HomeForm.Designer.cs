namespace CAREMATCH
{
    partial class HomeForm
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
            this.btnHulpvraagIndienen = new System.Windows.Forms.Button();
            this.btnMijnHulpvragen = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnBerichten = new System.Windows.Forms.Button();
            this.btnProfiel = new System.Windows.Forms.Button();
            this.btnUitloggen = new System.Windows.Forms.Button();
            this.btnHulpvraagAannemen = new System.Windows.Forms.Button();
            this.btnAangenomenHulpvragen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHulpvraagIndienen
            // 
            this.btnHulpvraagIndienen.Location = new System.Drawing.Point(51, 70);
            this.btnHulpvraagIndienen.Name = "btnHulpvraagIndienen";
            this.btnHulpvraagIndienen.Size = new System.Drawing.Size(129, 110);
            this.btnHulpvraagIndienen.TabIndex = 0;
            this.btnHulpvraagIndienen.Text = "Hulpvraag Indienen";
            this.btnHulpvraagIndienen.UseVisualStyleBackColor = true;
            this.btnHulpvraagIndienen.Click += new System.EventHandler(this.btnHulpvraagIndienen_Click);
            // 
            // btnMijnHulpvragen
            // 
            this.btnMijnHulpvragen.Location = new System.Drawing.Point(228, 70);
            this.btnMijnHulpvragen.Name = "btnMijnHulpvragen";
            this.btnMijnHulpvragen.Size = new System.Drawing.Size(129, 110);
            this.btnMijnHulpvragen.TabIndex = 1;
            this.btnMijnHulpvragen.Text = "Mijn Hulpvragen";
            this.btnMijnHulpvragen.UseVisualStyleBackColor = true;
            this.btnMijnHulpvragen.Click += new System.EventHandler(this.btnMijnHulpvragen_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Location = new System.Drawing.Point(404, 70);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(129, 110);
            this.btnAgenda.TabIndex = 2;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnBerichten
            // 
            this.btnBerichten.Location = new System.Drawing.Point(562, 70);
            this.btnBerichten.Name = "btnBerichten";
            this.btnBerichten.Size = new System.Drawing.Size(129, 110);
            this.btnBerichten.TabIndex = 3;
            this.btnBerichten.Text = "Berichten";
            this.btnBerichten.UseVisualStyleBackColor = true;
            this.btnBerichten.Click += new System.EventHandler(this.btnBerichten_Click);
            // 
            // btnProfiel
            // 
            this.btnProfiel.Location = new System.Drawing.Point(228, 248);
            this.btnProfiel.Name = "btnProfiel";
            this.btnProfiel.Size = new System.Drawing.Size(129, 110);
            this.btnProfiel.TabIndex = 4;
            this.btnProfiel.Text = "Profiel";
            this.btnProfiel.UseVisualStyleBackColor = true;
            this.btnProfiel.Click += new System.EventHandler(this.btnProfiel_Click);
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.Location = new System.Drawing.Point(404, 248);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(129, 110);
            this.btnUitloggen.TabIndex = 5;
            this.btnUitloggen.Text = "Uitloggen";
            this.btnUitloggen.UseVisualStyleBackColor = true;
            this.btnUitloggen.Click += new System.EventHandler(this.btnUitloggen_Click);
            // 
            // btnHulpvraagAannemen
            // 
            this.btnHulpvraagAannemen.Location = new System.Drawing.Point(51, 70);
            this.btnHulpvraagAannemen.Name = "btnHulpvraagAannemen";
            this.btnHulpvraagAannemen.Size = new System.Drawing.Size(129, 110);
            this.btnHulpvraagAannemen.TabIndex = 6;
            this.btnHulpvraagAannemen.Text = "Hulpvraag Aannemen";
            this.btnHulpvraagAannemen.UseVisualStyleBackColor = true;
            this.btnHulpvraagAannemen.Click += new System.EventHandler(this.btnHulpvraagAannemen_Click);
            // 
            // btnAangenomenHulpvragen
            // 
            this.btnAangenomenHulpvragen.Location = new System.Drawing.Point(228, 70);
            this.btnAangenomenHulpvragen.Name = "btnAangenomenHulpvragen";
            this.btnAangenomenHulpvragen.Size = new System.Drawing.Size(129, 110);
            this.btnAangenomenHulpvragen.TabIndex = 7;
            this.btnAangenomenHulpvragen.Text = "Aangenomen Hulpvragen";
            this.btnAangenomenHulpvragen.UseVisualStyleBackColor = true;
            this.btnAangenomenHulpvragen.Click += new System.EventHandler(this.btnAangenomenHulpvragen_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 397);
            this.Controls.Add(this.btnAangenomenHulpvragen);
            this.Controls.Add(this.btnHulpvraagAannemen);
            this.Controls.Add(this.btnUitloggen);
            this.Controls.Add(this.btnProfiel);
            this.Controls.Add(this.btnBerichten);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnMijnHulpvragen);
            this.Controls.Add(this.btnHulpvraagIndienen);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHulpvraagIndienen;
        private System.Windows.Forms.Button btnMijnHulpvragen;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnBerichten;
        private System.Windows.Forms.Button btnProfiel;
        private System.Windows.Forms.Button btnUitloggen;
        private System.Windows.Forms.Button btnHulpvraagAannemen;
        private System.Windows.Forms.Button btnAangenomenHulpvragen;
    }
}