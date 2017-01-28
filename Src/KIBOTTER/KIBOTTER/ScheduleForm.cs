using System;
using System.Drawing;
using System.Windows.Forms;

namespace KIBOTTER
{
    public partial class ScheduleForm : Form
    {
        public MainForm Form1Obj;

        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {

            if (Form1Obj.AccountComboBox.Items[0].ToString() == "あかうんとせんたく")
            {
                MessageBox.Show(
                    @"先に認証してください(X3)",
                    @"えらー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }

            DataGridView.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridView.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridView.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridView.ReadOnly = true;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.MultiSelect = false;

            foreach (var st in Form1Obj.ScheduledTweetList)
            {
                int idx = DataGridView.RowCount - 1;
                DataGridView.Rows[idx].Cells[0].Value = st.TweetDateTime;
                DataGridView.Rows[idx].Cells[1].Value = st.ScreenAndViaName;
                DataGridView.Rows[idx].Cells[2].Value = st.Content;
            }

            DateTimePicker.Value = DateTime.Today;
            HourUpDown.Value = DateTime.Now.Hour;
            MinuteUpDown.Value = DateTime.Now.Minute;

            for (int i = 0; i < Form1Obj.AccountComboBox.Items.Count; i++)
            {
                TweetAccountComboBox.Items.Add(Form1Obj.AccountComboBox.Items[i]);
            }
            TweetAccountComboBox.SelectedIndex = 0;

            if (Properties.Settings.Default.IsBlackTheme)
                ChangeThemeToBlack();
        }

        private void ChangeThemeToBlack()
        {
            BackColor = Color.FromArgb(45, 45, 45);
            DataGridView.EnableHeadersVisualStyles = false;
            DataGridView.BackgroundColor = Color.FromArgb(45, 45, 45);
            DataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridView.BorderStyle = BorderStyle.None;
            DateColumn.DefaultCellStyle.BackColor = Color.FromArgb(62, 62, 62);
            DateColumn.DefaultCellStyle.ForeColor = Color.White;
            AccountColumn.DefaultCellStyle.BackColor = Color.FromArgb(62, 62, 62);
            AccountColumn.DefaultCellStyle.ForeColor = Color.White;
            ContentColumn.DefaultCellStyle.BackColor = Color.FromArgb(62, 62, 62);
            ContentColumn.DefaultCellStyle.ForeColor = Color.White;
            GroupBox.BackColor = Color.FromArgb(45, 45, 45);
            GroupBox.ForeColor = Color.White;
            GroupBox.FlatStyle = FlatStyle.Flat;
            DateTimePicker.BackColor = Color.FromArgb(45, 45, 45);
            DateTimePicker.ForeColor = Color.White;
            DateTimePicker.CalendarForeColor = Color.White;
            DateTimePicker.CalendarMonthBackground = Color.FromArgb(45, 45, 45);
            DateTimePicker.CalendarTitleBackColor = Color.FromArgb(45, 45, 45);
            DateTimePicker.CalendarTitleForeColor = Color.White;
            DateTimePicker.CalendarTrailingForeColor = Color.FromArgb(100, 100, 100);
            HourUpDown.BackColor = Color.FromArgb(45, 45, 45);
            HourUpDown.ForeColor = Color.White;
            MinuteUpDown.BackColor = Color.FromArgb(45, 45, 45);
            MinuteUpDown.ForeColor = Color.White;
            TweetAccountComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            TweetAccountComboBox.BackColor = Color.FromArgb(45, 45, 45);
            TweetAccountComboBox.ForeColor = Color.White;
            TweetAccountComboBox.FlatStyle = FlatStyle.Flat;
            TweetAccountComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ContentTextBox.BackColor = Color.FromArgb(62, 62, 62);
            ContentTextBox.ForeColor = Color.White;
            ScheduleButton.BackColor = Color.FromArgb(45, 45, 45);
            ScheduleButton.ForeColor = Color.White;
            ScheduleButton.FlatStyle = FlatStyle.Flat;
        }

        private void ChangeThemeToDefault()
        {

        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            if (DateTime.Now > DateTime.Parse($"{DateTimePicker.Text} {HourUpDown.Text}:{MinuteUpDown.Text}:00"))
            {
                MessageBox.Show(
                    @"予約日時が過去のものです",
                    @"えらー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            ScheduledTweetClass stc = new ScheduledTweetClass
            {
                TweetDateTime = DateTime.Parse($"{DateTimePicker.Text} {HourUpDown.Text}:{MinuteUpDown.Text}:00"),
                ScreenAndViaName = TweetAccountComboBox.Text,
                Content = ContentTextBox.Text
            };

            Form1Obj.ScheduledTweetList.Add(stc);

            if (DataGridView.RowCount == 1 && DataGridView.Rows[0].Cells[0].Value != null
                || DataGridView.RowCount != 1)
                DataGridView.Rows.Add();
            
            int idx = DataGridView.RowCount - 1;
            
            DataGridView.Rows[idx].Cells[0].Value = stc.TweetDateTime;
            DataGridView.Rows[idx].Cells[1].Value = stc.ScreenAndViaName;
            DataGridView.Rows[idx].Cells[2].Value = stc.Content;
        }
    }
}
