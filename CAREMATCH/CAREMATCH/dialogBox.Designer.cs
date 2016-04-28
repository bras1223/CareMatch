namespace CAREMATCH
{
    partial class dialogBox
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
            this.btnOKE = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOKE
            // 
            this.btnOKE.Location = new System.Drawing.Point(180, 60);
            this.btnOKE.Name = "btnOKE";
            this.btnOKE.Size = new System.Drawing.Size(75, 23);
            this.btnOKE.TabIndex = 0;
            this.btnOKE.Text = "Ok";
            this.btnOKE.UseVisualStyleBackColor = true;
            this.btnOKE.Click += new System.EventHandler(this.btnOKE_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(13, 13);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "label1";
            // 
            // dialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 95);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOKE);
            this.Name = "dialogBox";
            this.Text = "Waarschuwing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dialogBox_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOKE;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMessage;
    }
}