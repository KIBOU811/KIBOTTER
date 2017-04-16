namespace KIBOTTER
{
    partial class MorseCodeConversionTool
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
            this.OriginalTextBox = new System.Windows.Forms.TextBox();
            this.ConvertedTextBox = new System.Windows.Forms.TextBox();
            this.DotTextBox = new System.Windows.Forms.TextBox();
            this.DashTextBox = new System.Windows.Forms.TextBox();
            this.SpaceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OriginalTextBox
            // 
            this.OriginalTextBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.OriginalTextBox.Location = new System.Drawing.Point(12, 61);
            this.OriginalTextBox.Multiline = true;
            this.OriginalTextBox.Name = "OriginalTextBox";
            this.OriginalTextBox.Size = new System.Drawing.Size(440, 78);
            this.OriginalTextBox.TabIndex = 0;
            this.OriginalTextBox.TextChanged += new System.EventHandler(this.OriginalTextBox_TextChanged);
            // 
            // ConvertedTextBox
            // 
            this.ConvertedTextBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.ConvertedTextBox.Location = new System.Drawing.Point(12, 172);
            this.ConvertedTextBox.Multiline = true;
            this.ConvertedTextBox.Name = "ConvertedTextBox";
            this.ConvertedTextBox.Size = new System.Drawing.Size(440, 78);
            this.ConvertedTextBox.TabIndex = 1;
            // 
            // DotTextBox
            // 
            this.DotTextBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.DotTextBox.Location = new System.Drawing.Point(67, 12);
            this.DotTextBox.Name = "DotTextBox";
            this.DotTextBox.Size = new System.Drawing.Size(70, 25);
            this.DotTextBox.TabIndex = 2;
            this.DotTextBox.Text = "・";
            // 
            // DashTextBox
            // 
            this.DashTextBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.DashTextBox.Location = new System.Drawing.Point(198, 12);
            this.DashTextBox.Name = "DashTextBox";
            this.DashTextBox.Size = new System.Drawing.Size(70, 25);
            this.DashTextBox.TabIndex = 3;
            this.DashTextBox.Text = "－";
            // 
            // SpaceTextBox
            // 
            this.SpaceTextBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.SpaceTextBox.Location = new System.Drawing.Point(377, 12);
            this.SpaceTextBox.Name = "SpaceTextBox";
            this.SpaceTextBox.Size = new System.Drawing.Size(75, 25);
            this.SpaceTextBox.TabIndex = 4;
            this.SpaceTextBox.Text = "　";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "【・】:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F);
            this.label2.Location = new System.Drawing.Point(143, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "【－】:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F);
            this.label3.Location = new System.Drawing.Point(274, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "【くぎりもじ】:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F);
            this.label4.Location = new System.Drawing.Point(9, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "もじれつかもーるすしんごうをいれてください↓";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F);
            this.label5.Location = new System.Drawing.Point(186, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "↓　　↓　　↓";
            // 
            // MorseCodeConversionTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpaceTextBox);
            this.Controls.Add(this.DashTextBox);
            this.Controls.Add(this.DotTextBox);
            this.Controls.Add(this.ConvertedTextBox);
            this.Controls.Add(this.OriginalTextBox);
            this.Name = "MorseCodeConversionTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "もーるすしんごうへんかんつーる";
            this.Activated += new System.EventHandler(this.MorseCodeConversionTool_Activated);
            this.Load += new System.EventHandler(this.MorseCodeConversionTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OriginalTextBox;
        private System.Windows.Forms.TextBox ConvertedTextBox;
        private System.Windows.Forms.TextBox DotTextBox;
        private System.Windows.Forms.TextBox DashTextBox;
        private System.Windows.Forms.TextBox SpaceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}