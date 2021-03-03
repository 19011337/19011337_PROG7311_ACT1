namespace _19011337_PROG7311_ACT1
{
    partial class MainForm
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
            this.TextLbl = new System.Windows.Forms.Label();
            this.EnterTxtBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextLbl
            // 
            this.TextLbl.AutoSize = true;
            this.TextLbl.Location = new System.Drawing.Point(180, 43);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(63, 13);
            this.TextLbl.TabIndex = 0;
            this.TextLbl.Text = "Text Here...";
            // 
            // EnterTxtBtn
            // 
            this.EnterTxtBtn.Location = new System.Drawing.Point(175, 154);
            this.EnterTxtBtn.Name = "EnterTxtBtn";
            this.EnterTxtBtn.Size = new System.Drawing.Size(75, 23);
            this.EnterTxtBtn.TabIndex = 1;
            this.EnterTxtBtn.Text = "Enter Text";
            this.EnterTxtBtn.UseVisualStyleBackColor = true;
            this.EnterTxtBtn.Click += new System.EventHandler(this.EnterTxtBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 212);
            this.Controls.Add(this.EnterTxtBtn);
            this.Controls.Add(this.TextLbl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.Button EnterTxtBtn;
    }
}

