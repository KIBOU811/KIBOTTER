using System;
using System.Drawing;
using System.Windows.Forms;

namespace KIBOTTER
{
    public partial class UpdateForm : Form
    {
        public MainForm MainFormObj { private get; set; }
        public string NewAppVer { private get; set; }

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            TextLabel.Text += $@"{Environment.NewLine}ばーしょん: {NewAppVer}";

            MaximizeBox = false;
            MinimizeBox = false;

            if (MainFormObj.KibotterSetting.IsBlackTheme)
                ChangeThemeToBlack();
            else
                ChangeThemeToDefault();
        }

        private void ChangeThemeToBlack()
        {
            BackColor = Color.FromArgb(45, 45, 45);
            YesButton.BackColor = Color.FromArgb(45, 45, 45);
            YesButton.ForeColor = Color.White;
            YesButton.FlatStyle = FlatStyle.Flat;
            NoButton.BackColor = Color.FromArgb(45, 45, 45);
            NoButton.ForeColor = Color.White;
            NoButton.FlatStyle = FlatStyle.Flat;
            DontShowAgainCheckBox.ForeColor = Color.White;
            DontShowAgainCheckBox.FlatStyle = FlatStyle.Flat;
            TextLabel.ForeColor = Color.White;
        }

        private void ChangeThemeToDefault()
        {
            BackColor = SystemColors.Control;
            YesButton.BackColor = SystemColors.Control;
            YesButton.ForeColor = SystemColors.ControlText;
            YesButton.FlatStyle = FlatStyle.System;
            NoButton.BackColor = SystemColors.Control;
            NoButton.ForeColor = SystemColors.ControlText;
            NoButton.FlatStyle = FlatStyle.System;
            DontShowAgainCheckBox.ForeColor = SystemColors.ControlText;
            DontShowAgainCheckBox.FlatStyle = FlatStyle.System;
            TextLabel.ForeColor = SystemColors.ControlText;
        }

        private void DontShowAgainCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MainFormObj.KibotterSetting.IsNotAlertUpdate = DontShowAgainCheckBox.Checked;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            MainFormObj.IsUpdateing = true;
            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            MainFormObj.IsUpdateing = false;
            Close();
        }
    }
}
