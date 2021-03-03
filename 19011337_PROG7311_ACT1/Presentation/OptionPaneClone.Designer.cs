namespace _19011337_PROG7311_ACT1.Presentation
{
    partial class OptionPaneClone
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
            this.NewTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnterNewTxtBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewTxtBox
            // 
            this.NewTxtBox.Location = new System.Drawing.Point(55, 46);
            this.NewTxtBox.Name = "NewTxtBox";
            this.NewTxtBox.Size = new System.Drawing.Size(190, 20);
            this.NewTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your text below:";
            // 
            // EnterNewTxtBtn
            // 
            this.EnterNewTxtBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EnterNewTxtBtn.Location = new System.Drawing.Point(170, 74);
            this.EnterNewTxtBtn.Name = "EnterNewTxtBtn";
            this.EnterNewTxtBtn.Size = new System.Drawing.Size(75, 23);
            this.EnterNewTxtBtn.TabIndex = 2;
            this.EnterNewTxtBtn.Text = "Enter";
            this.EnterNewTxtBtn.UseVisualStyleBackColor = true;
            this.EnterNewTxtBtn.Click += new System.EventHandler(this.EnterNewTxtBtn_Click);
            // 
            // OptionPaneClone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 109);
            this.Controls.Add(this.EnterNewTxtBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewTxtBox);
            this.Name = "OptionPaneClone";
            this.Text = "Enter Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EnterNewTxtBtn;
        private System.Windows.Forms.TextBox NewTxtBox;
    }
}