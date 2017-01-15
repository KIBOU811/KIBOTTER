using System;
using System.Drawing;
using System.Windows.Forms;

namespace KIBOTTER
{
    public partial class AddDraftForm : Form
    {
        private DraftForm Df { get; }
        private int _count;

        public AddDraftForm(DraftForm d)
        {
            Df = d;
            InitializeComponent();
        }

        private void AddDraftForm_Load(object sender, EventArgs e)
        {
            int left = Df.Left - Width;
            int top = Screen.PrimaryScreen.WorkingArea.Height - Height;
            DesktopBounds = new Rectangle(left, top, Width, Height);
            MaximumSize = Size;

            if (Properties.Settings.Default.IsBlackTheme)
                ChangeThemeToBlack();

            ContentTextBox.Focus();
        }

        private void ChangeThemeToBlack()
        {
            BackColor = Color.FromArgb(45, 45, 45);
            ContentTextBox.BackColor = Color.FromArgb(62, 62, 62);
            ContentTextBox.ForeColor = Color.White;
            ResultLabel.ForeColor = Color.White;
            AddButton.BackColor = Color.FromArgb(45, 45, 45);
            AddButton.ForeColor = Color.White;
            AddButton.FlatStyle = FlatStyle.Flat;
        }

        private void ContentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' && ModifierKeys == Keys.Control)
            {
                AddButton.PerformClick();
                e.Handled = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Df.DataGridView.Rows.Add(ContentTextBox.Text);
            ResultLabel.Text = $@"ついかしました({++_count}こめ)";
            ContentTextBox.Text = string.Empty;
        }
    }
}
