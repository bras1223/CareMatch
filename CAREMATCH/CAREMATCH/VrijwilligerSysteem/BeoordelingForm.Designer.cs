namespace CAREMATCH.VrijwilligerSysteem
{
    partial class BeoordelingForm
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
            this.txtBeoordeling = new System.Windows.Forms.RichTextBox();
            this.lblUitleg = new System.Windows.Forms.Label();
            this.btnSlaOP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBeoordeling
            // 
            this.txtBeoordeling.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeoordeling.Location = new System.Drawing.Point(12, 67);
            this.txtBeoordeling.Name = "txtBeoordeling";
            this.txtBeoordeling.Size = new System.Drawing.Size(600, 198);
            this.txtBeoordeling.TabIndex = 0;
            this.txtBeoordeling.Text = "";
            // 
            // lblUitleg
            // 
            this.lblUitleg.AutoSize = true;
            this.lblUitleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitleg.Location = new System.Drawing.Point(7, 9);
            this.lblUitleg.Name = "lblUitleg";
            this.lblUitleg.Size = new System.Drawing.Size(308, 26);
            this.lblUitleg.TabIndex = 1;
            this.lblUitleg.Text = "Text wordt geplaatst in runtime";
            // 
            // btnSlaOP
            // 
            this.btnSlaOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlaOP.Location = new System.Drawing.Point(12, 271);
            this.btnSlaOP.Name = "btnSlaOP";
            this.btnSlaOP.Size = new System.Drawing.Size(168, 69);
            this.btnSlaOP.TabIndex = 2;
            this.btnSlaOP.Text = "Sa beoordeling op";
            this.btnSlaOP.UseVisualStyleBackColor = true;
            this.btnSlaOP.Click += new System.EventHandler(this.btnSlaOp);
            // 
            // BeoordelingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 350);
            this.Controls.Add(this.btnSlaOP);
            this.Controls.Add(this.lblUitleg);
            this.Controls.Add(this.txtBeoordeling);
            this.Name = "BeoordelingForm";
            this.Text = "BeoordelingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBeoordeling;
        private System.Windows.Forms.Label lblUitleg;
        private System.Windows.Forms.Button btnSlaOP;
    }
}