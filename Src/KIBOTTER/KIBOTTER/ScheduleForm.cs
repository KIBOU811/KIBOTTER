using System;
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
