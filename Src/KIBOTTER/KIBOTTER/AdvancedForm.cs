using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KIBOTTER
{
    public partial class AdvancedForm : Form
    {
        private int F1Height { get; }

        public AdvancedForm(int height)
        {
            F1Height = height;
            InitializeComponent();
        }

        private void AdvancedForm_Load(object sender, EventArgs e)
        {
            BlackThemeCheckBox.Checked = Properties.Settings.Default.IsBlackTheme;

            int left = Screen.PrimaryScreen.WorkingArea.Width - Width;
            int top = Screen.PrimaryScreen.WorkingArea.Height - Height - F1Height;
            DesktopBounds = new Rectangle(left, top, Width, Height);
            MaximumSize = Size;

            if (Properties.Settings.Default.IsBlackTheme)
                ChangeThemeToBlack();
        }

        private void ChangeThemeToBlack()
        {
            BackColor = Color.FromArgb(45, 45, 45);
            ViaCheckBox.ForeColor = Color.White;
            ViaCheckBox.FlatStyle = FlatStyle.Flat;
            ViaNameTextBox.BackColor = Color.FromArgb(62, 62, 62);
            ViaNameTextBox.ForeColor = Color.White;
            CKTextBox.BackColor = Color.FromArgb(62, 62, 62);
            CKTextBox.ForeColor = Color.White;
            CSTextBox.BackColor = Color.FromArgb(62, 62, 62);
            CSTextBox.ForeColor = Color.White;
            ViaChangeButton.BackColor = Color.FromArgb(45, 45, 45);
            ViaChangeButton.ForeColor = Color.White;
            ViaChangeButton.FlatStyle = FlatStyle.Flat;
            BlackThemeCheckBox.ForeColor = Color.White;
            BlackThemeCheckBox.FlatStyle = FlatStyle.Flat;
        }

        private void ChangeThemeToDefault()
        {
            BackColor = SystemColors.Control;
            ViaCheckBox.ForeColor = SystemColors.ControlText;
            ViaCheckBox.FlatStyle = FlatStyle.System;
            ViaNameTextBox.BackColor = SystemColors.Window;
            ViaNameTextBox.ForeColor = SystemColors.WindowText;
            CKTextBox.BackColor = SystemColors.Window;
            CKTextBox.ForeColor = SystemColors.WindowText;
            CSTextBox.BackColor = SystemColors.Window;
            CSTextBox.ForeColor = SystemColors.WindowText;
            ViaChangeButton.BackColor = SystemColors.Control;
            ViaChangeButton.ForeColor = SystemColors.ControlText;
            ViaChangeButton.FlatStyle = FlatStyle.System;
            BlackThemeCheckBox.ForeColor = SystemColors.ControlText;
            BlackThemeCheckBox.FlatStyle = FlatStyle.System;
        }

        private void ViaNameTextBox_Enter(object sender, EventArgs e)
        {
            ViaNameTextBox.SelectAll();
        }

        private void ViaNameTextBox_Click(object sender, EventArgs e)
        {
            ViaNameTextBox.SelectAll();
        }

        private void CKTextBox_Enter(object sender, EventArgs e)
        {
            CKTextBox.SelectAll();
        }

        private void CKTextBox_Click(object sender, EventArgs e)
        {
            CKTextBox.SelectAll();
        }

        private void CSTextBox_Enter(object sender, EventArgs e)
        {
            CSTextBox.SelectAll();
        }

        private void CSTextBox_Click(object sender, EventArgs e)
        {
            CSTextBox.SelectAll();
        }

        private void ViaChangeButton_Click(object sender, EventArgs e)
        {
            if (ViaNameTextBox.Text == string.Empty
                || CKTextBox.Text == string.Empty
                || CSTextBox.Text == string.Empty)
            {
                MessageBox.Show(
                    @"どれかが入力されていません(X3)",
                    @"えらー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (ViaNameTextBox.Text == @"KIBOTTER")
                ViaNameTextBox.Text += @"(informal)";

            string folder = AppDomain.CurrentDomain.BaseDirectory + "Setting";
            Directory.CreateDirectory(folder);
            string fileName = folder + "\\Via" + ".cfg";
            fileName = Path.GetFullPath(fileName);

            if (!File.Exists(fileName))
            {
                using (FileStream fs = File.Create(fileName))
                {
                    if (fs != null)
                        fs.Close();
                }
            }

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                string toAdd = $"{ViaNameTextBox.Text}|{CKTextBox.Text}|{CSTextBox.Text}";
                sw.WriteLine(toAdd);
            }

            ViaNameTextBox.Text = string.Empty;
            CKTextBox.Text = string.Empty;
            CSTextBox.Text = string.Empty;
        }

        private void BlackThemeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BlackThemeCheckBox.Checked)
                ChangeThemeToBlack();
            else
                ChangeThemeToDefault();
        }

        private void AdvancedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.IsBlackTheme = BlackThemeCheckBox.Checked;
        }
    }
}
