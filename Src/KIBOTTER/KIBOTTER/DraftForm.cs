using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace KIBOTTER
{
    public partial class DraftForm : Form
    {
        private MainForm F1 { get; }
        private AddDraftForm _addDraftDbj;

        private string FileName { get; set; } = string.Empty;

        public DraftForm(MainForm f)
        {
            F1 = f;
            InitializeComponent();
        }

        private void DraftForm_Load(object sender, EventArgs e)
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory + "Setting";
            Directory.CreateDirectory(folder);
            FileName = folder + "\\SavedTweets" + ".tweet";
            FileName = Path.GetFullPath(FileName);

            if (File.Exists(FileName))
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    int ch;
                    string draftedTweet = string.Empty;
                    while ((ch = sr.Read()) != -1)
                    {
                        if ((char)ch == '℧')
                        {
                            DataGridView.Rows.Add(draftedTweet);
                            draftedTweet = string.Empty;
                            continue;
                        }

                        draftedTweet += (char)ch;
                    }
                }
            }

            int left = Screen.PrimaryScreen.WorkingArea.Width - Width - F1.Width;
            int top = Screen.PrimaryScreen.WorkingArea.Height - Height;
            DesktopBounds = new Rectangle(left, top, Width, Height);
            MaximumSize = Size;

            DataGridView.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridView.ReadOnly = true;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.MultiSelect = false;

            if (Properties.Settings.Default.IsBlackTheme)
                ChangeThemeToBlack();
        }

        public void ChangeThemeToBlack()
        {
            BackColor = Color.FromArgb(45, 45, 45);
            DataGridView.EnableHeadersVisualStyles = false;
            DataGridView.BackgroundColor = Color.FromArgb(45, 45, 45);
            DataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridView.BorderStyle = BorderStyle.None;
            ContentColumn.DefaultCellStyle.BackColor = Color.FromArgb(62, 62, 62);
            ContentColumn.DefaultCellStyle.ForeColor = Color.White;
            AddButton.BackColor = Color.FromArgb(45, 45, 45);
            AddButton.ForeColor = Color.White;
            AddButton.FlatStyle = FlatStyle.Flat;
            UseButton.BackColor = Color.FromArgb(45, 45, 45);
            UseButton.ForeColor = Color.White;
            UseButton.FlatStyle = FlatStyle.Flat;
        }

        public void ChangeThemeToDefault()
        {
            BackColor = SystemColors.Control;
            DataGridView.EnableHeadersVisualStyles = true;
            DataGridView.BackgroundColor = SystemColors.AppWorkspace;
            DataGridView.BorderStyle = BorderStyle.FixedSingle;
            ContentColumn.DefaultCellStyle.BackColor = Color.White;
            ContentColumn.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            AddButton.BackColor = SystemColors.Control;
            AddButton.ForeColor = SystemColors.ControlText;
            AddButton.FlatStyle = FlatStyle.System;
            UseButton.BackColor = SystemColors.Control;
            UseButton.ForeColor = SystemColors.ControlText;
            UseButton.FlatStyle = FlatStyle.System;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_addDraftDbj != null && !_addDraftDbj.IsDisposed)
                return;

            _addDraftDbj = new AddDraftForm(this) {ShowInTaskbar = false};
            _addDraftDbj.ShowDialog();
            _addDraftDbj.Dispose();
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.CurrentRow != null)
                    F1.TweetTextBox.Text += (string)DataGridView.CurrentRow.Cells[0].Value;
            }
            catch
            {
                MessageBox.Show(
                    @"つかえませんでした(X3)",
                    @"えらー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DraftForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataGridView.MultiSelect = true;
            DataGridView.SelectAll();

            using (var sw = new StreamWriter(FileName, false))
            {
                for (int i = 0; i < DataGridView.SelectedCells.Count; i++)
                {
                    if (DataGridView.SelectedCells[i].Value == null)
                        break;

                    var toAdd = DataGridView.SelectedCells[i].Value.ToString();
                    sw.Write(toAdd + "℧");
                }
            }
        }
    }
}
