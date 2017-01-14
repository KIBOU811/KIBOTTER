namespace KIBOTTER
{
    partial class AddAccountForm
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
            this.Label = new System.Windows.Forms.Label();
            this.ViaButton = new System.Windows.Forms.Button();
            this.PinTextBox = new System.Windows.Forms.TextBox();
            this.AuthButton = new System.Windows.Forms.Button();
            this.ViaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("メイリオ", 9F);
            this.Label.Location = new System.Drawing.Point(12, 14);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(30, 15);
            this.Label.TabIndex = 0;
            this.Label.Text = "Via";
            // 
            // ViaButton
            // 
            this.ViaButton.Font = new System.Drawing.Font("メイリオ", 8F);
            this.ViaButton.Location = new System.Drawing.Point(97, 47);
            this.ViaButton.Name = "ViaButton";
            this.ViaButton.Size = new System.Drawing.Size(75, 23);
            this.ViaButton.TabIndex = 2;
            this.ViaButton.Text = "これにする";
            this.ViaButton.UseVisualStyleBackColor = true;
            this.ViaButton.Click += new System.EventHandler(this.ViaButton_Click);
            // 
            // PinTextBox
            // 
            this.PinTextBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.PinTextBox.Location = new System.Drawing.Point(41, 12);
            this.PinTextBox.Name = "PinTextBox";
            this.PinTextBox.Size = new System.Drawing.Size(131, 25);
            this.PinTextBox.TabIndex = 3;
            this.PinTextBox.Visible = false;
            // 
            // AuthButton
            // 
            this.AuthButton.Font = new System.Drawing.Font("メイリオ", 8F);
            this.AuthButton.Location = new System.Drawing.Point(97, 47);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(75, 23);
            this.AuthButton.TabIndex = 4;
            this.AuthButton.Text = "にんしょー";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Visible = false;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // ViaComboBox
            // 
            this.ViaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViaComboBox.Font = new System.Drawing.Font("メイリオ", 8F);
            this.ViaComboBox.FormattingEnabled = true;
            this.ViaComboBox.Location = new System.Drawing.Point(41, 12);
            this.ViaComboBox.MaxDropDownItems = 100;
            this.ViaComboBox.Name = "ViaComboBox";
            this.ViaComboBox.Size = new System.Drawing.Size(131, 25);
            this.ViaComboBox.TabIndex = 1;
            // 
            // AddAcountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 82);
            this.Controls.Add(this.ViaComboBox);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.PinTextBox);
            this.Controls.Add(this.ViaButton);
            this.Controls.Add(this.Label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAcountForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ついか";
            this.Load += new System.EventHandler(this.AddAcountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button ViaButton;
        private System.Windows.Forms.TextBox PinTextBox;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.ComboBox ViaComboBox;
    }
}