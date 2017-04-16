using System;
using System.Drawing;
using System.Windows.Forms;

namespace KIBOTTER
{
    public partial class MorseCodeConversionTool : Form
    {
        public MorseCodeConversionTool()
        {
            InitializeComponent();
        }

        private void MorseCodeConversionTool_Load(object sender, EventArgs e)
        {
            ConvertedTextBox.ReadOnly = true;
            ConvertedTextBox.Text = @"ここにへんかんけっかがでます(:3)";
        }

        private void ChangeThemeToBlack()
        {
            BackColor = Color.FromArgb(45, 45, 45);
            label1.BackColor = Color.FromArgb(45, 45, 45);
            label1.ForeColor = Color.White;
            label2.BackColor = Color.FromArgb(45, 45, 45);
            label2.ForeColor = Color.White;
            label3.BackColor = Color.FromArgb(45, 45, 45);
            label3.ForeColor = Color.White;
            label4.BackColor = Color.FromArgb(45, 45, 45);
            label4.ForeColor = Color.White;
            label5.BackColor = Color.FromArgb(45, 45, 45);
            label5.ForeColor = Color.White;
            DotTextBox.BackColor = Color.FromArgb(62, 62, 62);
            DotTextBox.ForeColor = Color.White;
            DashTextBox.BackColor = Color.FromArgb(62, 62, 62);
            DashTextBox.ForeColor = Color.White;
            SpaceTextBox.BackColor = Color.FromArgb(62, 62, 62);
            SpaceTextBox.ForeColor = Color.White;
            OriginalTextBox.BackColor = Color.FromArgb(62, 62, 62);
            OriginalTextBox.ForeColor = Color.White;
            ConvertedTextBox.BackColor = Color.FromArgb(62, 62, 62);
            ConvertedTextBox.ForeColor = Color.White;
        }

        private void ChangeThemeToDefault()
        {
            BackColor = SystemColors.Control;
            label1.BackColor = SystemColors.Control;
            label1.ForeColor = SystemColors.ControlText;
            label2.BackColor = SystemColors.Control;
            label2.ForeColor = SystemColors.ControlText;
            label3.BackColor = SystemColors.Control;
            label3.ForeColor = SystemColors.ControlText;
            label4.BackColor = SystemColors.Control;
            label4.ForeColor = SystemColors.ControlText;
            label5.BackColor = SystemColors.Control;
            label5.ForeColor = SystemColors.ControlText;
            DotTextBox.BackColor = SystemColors.Window;
            DotTextBox.ForeColor = SystemColors.WindowText;
            DashTextBox.BackColor = SystemColors.Window;
            DashTextBox.ForeColor = SystemColors.WindowText;
            SpaceTextBox.BackColor = SystemColors.Window;
            SpaceTextBox.ForeColor = SystemColors.WindowText;
            OriginalTextBox.BackColor = SystemColors.Window;
            OriginalTextBox.ForeColor = SystemColors.WindowText;
            ConvertedTextBox.BackColor = SystemColors.Window;
            ConvertedTextBox.ForeColor = SystemColors.WindowText;
        }

        private void OriginalTextBox_TextChanged(object sender, EventArgs e)
        {
            MorseCode mc = new MorseCode();
            ConvertedTextBox.Text = mc.Convert(OriginalTextBox.Text, DotTextBox.Text, DashTextBox.Text, SpaceTextBox.Text);
        }

        private void MorseCodeConversionTool_Activated(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsBlackTheme)
                ChangeThemeToBlack();
            else
                ChangeThemeToDefault();
        }
    }
}
