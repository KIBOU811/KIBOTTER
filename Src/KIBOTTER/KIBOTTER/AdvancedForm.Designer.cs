namespace KIBOTTER
{
    partial class AdvancedForm
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
            this.BlackThemeCheckBox = new System.Windows.Forms.CheckBox();
            this.CKTextBox = new System.Windows.Forms.TextBox();
            this.CSTextBox = new System.Windows.Forms.TextBox();
            this.ViaChangeButton = new System.Windows.Forms.Button();
            this.ViaCheckBox = new System.Windows.Forms.CheckBox();
            this.ViaNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BlackThemeCheckBox
            // 
            this.BlackThemeCheckBox.AutoSize = true;
            this.BlackThemeCheckBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.BlackThemeCheckBox.Location = new System.Drawing.Point(12, 162);
            this.BlackThemeCheckBox.Name = "BlackThemeCheckBox";
            this.BlackThemeCheckBox.Size = new System.Drawing.Size(111, 22);
            this.BlackThemeCheckBox.TabIndex = 1;
            this.BlackThemeCheckBox.Text = "ぶらっくてーま";
            this.BlackThemeCheckBox.UseVisualStyleBackColor = true;
            this.BlackThemeCheckBox.CheckedChanged += new System.EventHandler(this.BlackThemeCheckBox_CheckedChanged);
            // 
            // CKTextBox
            // 
            this.CKTextBox.Enabled = false;
            this.CKTextBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.CKTextBox.Location = new System.Drawing.Point(28, 71);
            this.CKTextBox.Name = "CKTextBox";
            this.CKTextBox.Size = new System.Drawing.Size(190, 25);
            this.CKTextBox.TabIndex = 3;
            this.CKTextBox.Text = "Consumer Key (API Key)";
            this.CKTextBox.Click += new System.EventHandler(this.CKTextBox_Click);
            this.CKTextBox.Enter += new System.EventHandler(this.CKTextBox_Enter);
            // 
            // CSTextBox
            // 
            this.CSTextBox.Enabled = false;
            this.CSTextBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.CSTextBox.Location = new System.Drawing.Point(28, 102);
            this.CSTextBox.Name = "CSTextBox";
            this.CSTextBox.Size = new System.Drawing.Size(190, 25);
            this.CSTextBox.TabIndex = 4;
            this.CSTextBox.Text = "Consumer Secret (API Secret)";
            this.CSTextBox.Click += new System.EventHandler(this.CSTextBox_Click);
            this.CSTextBox.Enter += new System.EventHandler(this.CSTextBox_Enter);
            // 
            // ViaChangeButton
            // 
            this.ViaChangeButton.Enabled = false;
            this.ViaChangeButton.Font = new System.Drawing.Font("メイリオ", 8F);
            this.ViaChangeButton.Location = new System.Drawing.Point(143, 133);
            this.ViaChangeButton.Name = "ViaChangeButton";
            this.ViaChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ViaChangeButton.TabIndex = 5;
            this.ViaChangeButton.Text = "ついか";
            this.ViaChangeButton.UseVisualStyleBackColor = true;
            this.ViaChangeButton.Click += new System.EventHandler(this.ViaChangeButton_Click);
            // 
            // ViaCheckBox
            // 
            this.ViaCheckBox.AutoSize = true;
            this.ViaCheckBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.ViaCheckBox.Location = new System.Drawing.Point(12, 12);
            this.ViaCheckBox.Name = "ViaCheckBox";
            this.ViaCheckBox.Size = new System.Drawing.Size(128, 22);
            this.ViaCheckBox.TabIndex = 0;
            this.ViaCheckBox.Text = "viaのかすたまいず";
            this.ViaCheckBox.UseVisualStyleBackColor = true;
            this.ViaCheckBox.CheckedChanged += new System.EventHandler(this.ViaCheckBox_CheckedChanged);
            // 
            // ViaNameTextBox
            // 
            this.ViaNameTextBox.Enabled = false;
            this.ViaNameTextBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.ViaNameTextBox.Location = new System.Drawing.Point(28, 40);
            this.ViaNameTextBox.Name = "ViaNameTextBox";
            this.ViaNameTextBox.Size = new System.Drawing.Size(190, 25);
            this.ViaNameTextBox.TabIndex = 2;
            this.ViaNameTextBox.Text = "Via Name";
            this.ViaNameTextBox.Click += new System.EventHandler(this.ViaNameTextBox_Click);
            this.ViaNameTextBox.Enter += new System.EventHandler(this.ViaNameTextBox_Enter);
            // 
            // AdvancedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 196);
            this.Controls.Add(this.ViaNameTextBox);
            this.Controls.Add(this.ViaCheckBox);
            this.Controls.Add(this.ViaChangeButton);
            this.Controls.Add(this.CSTextBox);
            this.Controls.Add(this.CKTextBox);
            this.Controls.Add(this.BlackThemeCheckBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancedForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "しょうさいせってい";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdvancedForm_FormClosing);
            this.Load += new System.EventHandler(this.AdvancedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox BlackThemeCheckBox;
        private System.Windows.Forms.TextBox CKTextBox;
        private System.Windows.Forms.TextBox CSTextBox;
        private System.Windows.Forms.Button ViaChangeButton;
        private System.Windows.Forms.CheckBox ViaCheckBox;
        private System.Windows.Forms.TextBox ViaNameTextBox;
    }
}