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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OngepasteBerichtenForm));
            this.lvOngepasteBerichten = new System.Windows.Forms.ListView();
            this.btnLaatZien = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteSelection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnLaatZien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLaatZien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaatZien.Location = new System.Drawing.Point(13, 428);
            this.btnLaatZien.Name = "btnLaatZien";
            this.btnLaatZien.Size = new System.Drawing.Size(188, 36);
            this.btnLaatZien.TabIndex = 1;
            this.btnLaatZien.Text = "laat zien";
            this.btnLaatZien.UseVisualStyleBackColor = true;
            this.btnLaatZien.Click += new System.EventHandler(this.btnLaatZien_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(622, 428);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 82);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteSelection
            // 
            this.btnDeleteSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelection.Location = new System.Drawing.Point(13, 470);
            this.btnDeleteSelection.Name = "btnDeleteSelection";
            this.btnDeleteSelection.Size = new System.Drawing.Size(188, 40);
            this.btnDeleteSelection.TabIndex = 4;
            this.btnDeleteSelection.Text = "verwijder selectie";
            this.btnDeleteSelection.UseVisualStyleBackColor = true;
            this.btnDeleteSelection.Click += new System.EventHandler(this.btnDeleteSelection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Geen hulpvragen om te laten zien";
            this.label1.Visible = false;
            // 
            // OngepasteBerichtenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteSelection);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLaatZien);
            this.Controls.Add(this.lvOngepasteBerichten);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OngepasteBerichtenForm";
            this.Text = "Ongepaste Berichten - CareMatch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OngepasteBerichtenForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOngepasteBerichten;
        private System.Windows.Forms.Button btnLaatZien;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteSelection;
        private System.Windows.Forms.Label label1;
    }
}