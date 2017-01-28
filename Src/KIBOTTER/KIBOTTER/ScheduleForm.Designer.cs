namespace KIBOTTER
{
    partial class ScheduleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.TweetAccountComboBox = new System.Windows.Forms.ComboBox();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.MinuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.HourLabel = new System.Windows.Forms.Label();
            this.HourUpDown = new System.Windows.Forms.NumericUpDown();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.AccountColumn,
            this.ContentColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.Location = new System.Drawing.Point(12, 12);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 21;
            this.DataGridView.Size = new System.Drawing.Size(560, 172);
            this.DataGridView.TabIndex = 0;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("メイリオ", 8F);
            this.DateTimePicker.Location = new System.Drawing.Point(6, 24);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(127, 23);
            this.DateTimePicker.TabIndex = 1;
            this.DateTimePicker.Value = new System.DateTime(2017, 1, 20, 0, 0, 0, 0);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.TweetAccountComboBox);
            this.GroupBox.Controls.Add(this.ScheduleButton);
            this.GroupBox.Controls.Add(this.MinuteLabel);
            this.GroupBox.Controls.Add(this.MinuteUpDown);
            this.GroupBox.Controls.Add(this.HourLabel);
            this.GroupBox.Controls.Add(this.HourUpDown);
            this.GroupBox.Controls.Add(this.ContentTextBox);
            this.GroupBox.Controls.Add(this.DateTimePicker);
            this.GroupBox.Font = new System.Drawing.Font("メイリオ", 9F);
            this.GroupBox.Location = new System.Drawing.Point(12, 190);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(560, 207);
            this.GroupBox.TabIndex = 2;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "よやくするついーと";
            // 
            // TweetAccountComboBox
            // 
            this.TweetAccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TweetAccountComboBox.Font = new System.Drawing.Font("メイリオ", 8F);
            this.TweetAccountComboBox.FormattingEnabled = true;
            this.TweetAccountComboBox.Location = new System.Drawing.Point(273, 23);
            this.TweetAccountComboBox.Name = "TweetAccountComboBox";
            this.TweetAccountComboBox.Size = new System.Drawing.Size(230, 25);
            this.TweetAccountComboBox.TabIndex = 8;
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Font = new System.Drawing.Font("メイリオ", 8F);
            this.ScheduleButton.Location = new System.Drawing.Point(479, 178);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.ScheduleButton.TabIndex = 7;
            this.ScheduleButton.Text = "よやく";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Font = new System.Drawing.Font("メイリオ", 9F);
            this.MinuteLabel.Location = new System.Drawing.Point(247, 28);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(20, 18);
            this.MinuteLabel.TabIndex = 6;
            this.MinuteLabel.Text = "分";
            // 
            // MinuteUpDown
            // 
            this.MinuteUpDown.Font = new System.Drawing.Font("メイリオ", 8F);
            this.MinuteUpDown.Location = new System.Drawing.Point(206, 24);
            this.MinuteUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinuteUpDown.Name = "MinuteUpDown";
            this.MinuteUpDown.Size = new System.Drawing.Size(35, 23);
            this.MinuteUpDown.TabIndex = 5;
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Font = new System.Drawing.Font("メイリオ", 9F);
            this.HourLabel.Location = new System.Drawing.Point(180, 28);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(20, 18);
            this.HourLabel.TabIndex = 4;
            this.HourLabel.Text = "時";
            // 
            // HourUpDown
            // 
            this.HourUpDown.Font = new System.Drawing.Font("メイリオ", 8F);
            this.HourUpDown.Location = new System.Drawing.Point(139, 24);
            this.HourUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HourUpDown.Name = "HourUpDown";
            this.HourUpDown.Size = new System.Drawing.Size(35, 23);
            this.HourUpDown.TabIndex = 3;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(6, 53);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentTextBox.Size = new System.Drawing.Size(548, 119);
            this.ContentTextBox.TabIndex = 2;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "にちじ";
            this.DateColumn.Name = "DateColumn";
            // 
            // AccountColumn
            // 
            this.AccountColumn.HeaderText = "あかうんと";
            this.AccountColumn.Name = "AccountColumn";
            // 
            // ContentColumn
            // 
            this.ContentColumn.HeaderText = "ついーとないよう";
            this.ContentColumn.Name = "ContentColumn";
            this.ContentColumn.Width = 300;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.DataGridView);
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.NumericUpDown HourUpDown;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.NumericUpDown MinuteUpDown;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.ComboBox TweetAccountComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentColumn;
    }
}