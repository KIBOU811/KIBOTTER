namespace KIBOTTER
{
    partial class AddDraftForm
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
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.ContentTextBox.Location = new System.Drawing.Point(12, 12);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ContentTextBox.Size = new System.Drawing.Size(260, 209);
            this.ContentTextBox.TabIndex = 0;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("メイリオ", 9F);
            this.ResultLabel.Location = new System.Drawing.Point(12, 229);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(56, 18);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "りざると";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("メイリオ", 8F);
            this.AddButton.Location = new System.Drawing.Point(197, 227);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "ついか";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // AddDraftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ContentTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDraftForm";
            this.Text = "したがきついか";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button AddButton;
    }
}