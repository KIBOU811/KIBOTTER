namespace KIBOTTER
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MorseConToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MorseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SushiModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.RepliedPokerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.AdvancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountComboBox = new System.Windows.Forms.ComboBox();
            this.TweetTextBox = new System.Windows.Forms.TextBox();
            this.TweetButton = new System.Windows.Forms.Button();
            this.MediaButton = new System.Windows.Forms.Button();
            this.DraftButton = new System.Windows.Forms.Button();
            this.TextLengthLabel = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem,
            this.SettingToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(254, 26);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "menuStrip";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.AddAccountToolStripMenuItem,
            this.ScheduleToolStripMenuItem,
            this.MorseConToolStripMenuItem,
            this.toolStripMenuItem2,
            this.CloseToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.MenuToolStripMenuItem.Text = "めにゅー";
            this.MenuToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.MenuToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.AboutToolStripMenuItem.Text = "あばうと";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            this.AboutToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.AboutToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.HelpToolStripMenuItem.Text = "へるぷ";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            this.HelpToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.HelpToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // AddAccountToolStripMenuItem
            // 
            this.AddAccountToolStripMenuItem.Name = "AddAccountToolStripMenuItem";
            this.AddAccountToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.AddAccountToolStripMenuItem.Text = "あかうんとついか...";
            this.AddAccountToolStripMenuItem.Click += new System.EventHandler(this.AddAccountToolStripMenuItem_Click);
            this.AddAccountToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.AddAccountToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // ScheduleToolStripMenuItem
            // 
            this.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem";
            this.ScheduleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ScheduleToolStripMenuItem.Text = "ついーとよやく...";
            this.ScheduleToolStripMenuItem.Click += new System.EventHandler(this.ScheduleToolStripMenuItem_Click);
            this.ScheduleToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.ScheduleToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // MorseConToolStripMenuItem
            // 
            this.MorseConToolStripMenuItem.Name = "MorseConToolStripMenuItem";
            this.MorseConToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.MorseConToolStripMenuItem.Text = "もーるすしんごう...";
            this.MorseConToolStripMenuItem.Click += new System.EventHandler(this.MorseConToolStripMenuItem_Click);
            this.MorseConToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.MorseConToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.CloseToolStripMenuItem.Text = "しゅーりょー";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            this.CloseToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.CloseToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MorseToolStripMenuItem,
            this.SushiModeToolStripMenuItem,
            this.toolStripMenuItem3,
            this.RepliedPokerToolStripMenuItem,
            this.toolStripMenuItem4,
            this.AdvancedToolStripMenuItem});
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.SettingToolStripMenuItem.Text = "せってい";
            this.SettingToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.SettingToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // MorseToolStripMenuItem
            // 
            this.MorseToolStripMenuItem.CheckOnClick = true;
            this.MorseToolStripMenuItem.Name = "MorseToolStripMenuItem";
            this.MorseToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.MorseToolStripMenuItem.Text = "もーるすもーど";
            this.MorseToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.MorseToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // SushiModeToolStripMenuItem
            // 
            this.SushiModeToolStripMenuItem.CheckOnClick = true;
            this.SushiModeToolStripMenuItem.Name = "SushiModeToolStripMenuItem";
            this.SushiModeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.SushiModeToolStripMenuItem.Text = "すしもーど";
            this.SushiModeToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.SushiModeToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(197, 6);
            // 
            // RepliedPokerToolStripMenuItem
            // 
            this.RepliedPokerToolStripMenuItem.CheckOnClick = true;
            this.RepliedPokerToolStripMenuItem.Name = "RepliedPokerToolStripMenuItem";
            this.RepliedPokerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.RepliedPokerToolStripMenuItem.Text = "ぽーかーのりぷらいか";
            this.RepliedPokerToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.RepliedPokerToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(197, 6);
            // 
            // AdvancedToolStripMenuItem
            // 
            this.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem";
            this.AdvancedToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.AdvancedToolStripMenuItem.Text = "しょうさいせってい....";
            this.AdvancedToolStripMenuItem.Click += new System.EventHandler(this.AdvancedToolStripMenuItem_Click);
            this.AdvancedToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItemMouseEnter);
            this.AdvancedToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItemMouseLeave);
            // 
            // AccountComboBox
            // 
            this.AccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountComboBox.Font = new System.Drawing.Font("メイリオ", 8F);
            this.AccountComboBox.FormattingEnabled = true;
            this.AccountComboBox.Location = new System.Drawing.Point(12, 29);
            this.AccountComboBox.Name = "AccountComboBox";
            this.AccountComboBox.Size = new System.Drawing.Size(230, 25);
            this.AccountComboBox.TabIndex = 7;
            this.AccountComboBox.SelectedIndexChanged += new System.EventHandler(this.AccountComboBox_SelectedIndexChanged);
            // 
            // TweetTextBox
            // 
            this.TweetTextBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TweetTextBox.Location = new System.Drawing.Point(12, 60);
            this.TweetTextBox.Multiline = true;
            this.TweetTextBox.Name = "TweetTextBox";
            this.TweetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TweetTextBox.Size = new System.Drawing.Size(230, 117);
            this.TweetTextBox.TabIndex = 1;
            this.TweetTextBox.TextChanged += new System.EventHandler(this.TweetTextBox_TextChanged);
            this.TweetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TweetTextBox_KeyPress);
            // 
            // TweetButton
            // 
            this.TweetButton.Font = new System.Drawing.Font("メイリオ", 8F);
            this.TweetButton.Location = new System.Drawing.Point(167, 212);
            this.TweetButton.Name = "TweetButton";
            this.TweetButton.Size = new System.Drawing.Size(75, 23);
            this.TweetButton.TabIndex = 2;
            this.TweetButton.Text = "ついーと";
            this.TweetButton.UseVisualStyleBackColor = true;
            this.TweetButton.Click += new System.EventHandler(this.TweetButton_Click);
            // 
            // MediaButton
            // 
            this.MediaButton.Font = new System.Drawing.Font("メイリオ", 8F);
            this.MediaButton.Location = new System.Drawing.Point(12, 183);
            this.MediaButton.Name = "MediaButton";
            this.MediaButton.Size = new System.Drawing.Size(75, 23);
            this.MediaButton.TabIndex = 4;
            this.MediaButton.Text = "てんぷ";
            this.MediaButton.UseVisualStyleBackColor = true;
            this.MediaButton.Click += new System.EventHandler(this.MediaButton_Click);
            // 
            // DraftButton
            // 
            this.DraftButton.Font = new System.Drawing.Font("メイリオ", 8F);
            this.DraftButton.Location = new System.Drawing.Point(12, 212);
            this.DraftButton.Name = "DraftButton";
            this.DraftButton.Size = new System.Drawing.Size(75, 23);
            this.DraftButton.TabIndex = 3;
            this.DraftButton.Text = "したがき";
            this.DraftButton.UseVisualStyleBackColor = true;
            this.DraftButton.Click += new System.EventHandler(this.DraftButton_Click);
            // 
            // TextLengthLabel
            // 
            this.TextLengthLabel.Font = new System.Drawing.Font("メイリオ", 9F);
            this.TextLengthLabel.Location = new System.Drawing.Point(118, 212);
            this.TextLengthLabel.Name = "TextLengthLabel";
            this.TextLengthLabel.Size = new System.Drawing.Size(43, 23);
            this.TextLengthLabel.TabIndex = 6;
            this.TextLengthLabel.Text = "140";
            this.TextLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 240);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(254, 22);
            this.StatusStrip.TabIndex = 8;
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 262);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.TextLengthLabel);
            this.Controls.Add(this.DraftButton);
            this.Controls.Add(this.MediaButton);
            this.Controls.Add(this.TweetButton);
            this.Controls.Add(this.TweetTextBox);
            this.Controls.Add(this.AccountComboBox);
            this.Controls.Add(this.MenuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "めいんがめん";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MorseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SushiModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem RepliedPokerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem AdvancedToolStripMenuItem;
        public System.Windows.Forms.ComboBox AccountComboBox;
        private System.Windows.Forms.Button TweetButton;
        private System.Windows.Forms.Button MediaButton;
        private System.Windows.Forms.Button DraftButton;
        private System.Windows.Forms.Label TextLengthLabel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        public System.Windows.Forms.TextBox TweetTextBox;
        private System.Windows.Forms.ToolStripMenuItem ScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MorseConToolStripMenuItem;
    }
}

