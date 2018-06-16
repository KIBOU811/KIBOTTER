namespace KIBOTTER
{
    partial class UpdateForm
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
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.TextLabel = new System.Windows.Forms.Label();
            this.DontShowAgainCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // YesButton
            // 
            this.YesButton.Font = new System.Drawing.Font("メイリオ", 8F);
            this.YesButton.Location = new System.Drawing.Point(84, 109);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 0;
            this.YesButton.Text = "はい";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Font = new System.Drawing.Font("メイリオ", 8F);
            this.NoButton.Location = new System.Drawing.Point(171, 109);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "いいえ";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("メイリオ", 9F);
            this.TextLabel.Location = new System.Drawing.Point(32, 20);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(200, 36);
            this.TextLabel.TabIndex = 2;
            this.TextLabel.Text = "さいしんのあっぷでーとがあります\r\nうぇぶぺーじをひらきますか？";
            // 
            // DontShowAgainCheckBox
            // 
            this.DontShowAgainCheckBox.AutoSize = true;
            this.DontShowAgainCheckBox.Font = new System.Drawing.Font("メイリオ", 8F);
            this.DontShowAgainCheckBox.Location = new System.Drawing.Point(12, 82);
            this.DontShowAgainCheckBox.Name = "DontShowAgainCheckBox";
            this.DontShowAgainCheckBox.Size = new System.Drawing.Size(137, 21);
            this.DontShowAgainCheckBox.TabIndex = 3;
            this.DontShowAgainCheckBox.Text = "こんごひょうじしない";
            this.DontShowAgainCheckBox.UseVisualStyleBackColor = true;
            this.DontShowAgainCheckBox.CheckedChanged += new System.EventHandler(this.DontShowAgainCheckBox_CheckedChanged);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 142);
            this.Controls.Add(this.DontShowAgainCheckBox);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Name = "UpdateForm";
            this.Text = "あっぷでーと？";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.CheckBox DontShowAgainCheckBox;
    }
}