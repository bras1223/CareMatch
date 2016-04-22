namespace CAREMATCH
{
    partial class OngepasteBerichtenForm
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
            this.lvOngepasteBerichten = new System.Windows.Forms.ListView();
            this.btnLaatZien = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbKiesBerichten = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvOngepasteBerichten
            // 
            this.lvOngepasteBerichten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOngepasteBerichten.Location = new System.Drawing.Point(12, 12);
            this.lvOngepasteBerichten.Name = "lvOngepasteBerichten";
            this.lvOngepasteBerichten.Size = new System.Drawing.Size(758, 410);
            this.lvOngepasteBerichten.TabIndex = 0;
            this.lvOngepasteBerichten.UseCompatibleStateImageBehavior = false;
            // 
            // btnLaatZien
            // 
            this.btnLaatZien.Location = new System.Drawing.Point(13, 428);
            this.btnLaatZien.Name = "btnLaatZien";
            this.btnLaatZien.Size = new System.Drawing.Size(148, 82);
            this.btnLaatZien.TabIndex = 1;
            this.btnLaatZien.Text = "laat zien";
            this.btnLaatZien.UseVisualStyleBackColor = true;
            this.btnLaatZien.Click += new System.EventHandler(this.btnLaatZien_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(622, 428);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 82);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbKiesBerichten
            // 
            this.cmbKiesBerichten.FormattingEnabled = true;
            this.cmbKiesBerichten.Location = new System.Drawing.Point(168, 429);
            this.cmbKiesBerichten.Name = "cmbKiesBerichten";
            this.cmbKiesBerichten.Size = new System.Drawing.Size(121, 21);
            this.cmbKiesBerichten.TabIndex = 3;
            this.cmbKiesBerichten.SelectedValueChanged += new System.EventHandler(this.cmbKiesBerichten_SelectedValueChanged);
            // 
            // OngepasteBerichtenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 516);
            this.Controls.Add(this.cmbKiesBerichten);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLaatZien);
            this.Controls.Add(this.lvOngepasteBerichten);
            this.Name = "OngepasteBerichtenForm";
            this.Text = "OngepasteBerichtenForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvOngepasteBerichten;
        private System.Windows.Forms.Button btnLaatZien;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbKiesBerichten;
    }
}