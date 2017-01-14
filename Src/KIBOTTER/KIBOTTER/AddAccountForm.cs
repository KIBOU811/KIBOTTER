using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CoreTweet;
using KIBOTTER.Properties;

namespace KIBOTTER
{
    public partial class AddAccountForm : Form
    {
        public MainForm Form1Obj;
        private OAuth.OAuthSession Session { get; set; }

        private string FileName { get; set; } = string.Empty;

        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void AddAcountForm_Load(object sender, EventArgs e)
        {
            ViaComboBox.Items.Add("KIBOTTER");
            ViaComboBox.SelectedIndex = 0;

            string folder = AppDomain.CurrentDomain.BaseDirectory + "Setting";
            Directory.CreateDirectory(folder);
            FileName = folder + "\\Via" + ".cfg";
            FileName = Path.GetFullPath(FileName);

            if (!File.Exists(FileName))
                return;

            using (StreamReader sr = new StreamReader(FileName))
            {
                while (sr.Peek() >= 1)
                {
                    var readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        string[] token = readLine.Split('|');
                        ViaComboBox.Items.Add(token[0]);
                    }
                }
            }

            int left = Screen.PrimaryScreen.WorkingArea.Width - Width;// - Form1Obj.Width;
            int top = Screen.PrimaryScreen.WorkingArea.Height - Height;// - Form1Obj.Height;
            DesktopBounds = new Rectangle(left, top, Width, Height);
            MaximumSize = Size;

            if (Settings.Default.IsBlackTheme)
                ChangeThemeToBlack();
        }

        private void ChangeThemeToBlack()
        {
            BackColor = Color.FromArgb(45, 45, 45);
            Label.ForeColor = Color.White;
            ViaComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            ViaComboBox.BackColor = Color.FromArgb(45, 45, 45);
            ViaComboBox.ForeColor = Color.White;
            ViaComboBox.FlatStyle = FlatStyle.Flat;
            ViaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ViaButton.BackColor = Color.FromArgb(45, 45, 45);
            ViaButton.ForeColor = Color.White;
            ViaButton.FlatStyle = FlatStyle.Flat;
            PinTextBox.BackColor = Color.FromArgb(62, 62, 62);
            PinTextBox.ForeColor = Color.White;
            AuthButton.BackColor = Color.FromArgb(45, 45, 45);
            AuthButton.ForeColor = Color.White;
            AuthButton.FlatStyle = FlatStyle.Flat;
        }

        private void ViaButton_Click(object sender, EventArgs e)
        {
            if (ViaComboBox.Text == @"KIBOTTER")
            {
                Session = OAuth.Authorize(Settings.Default.ConsumerKey, Settings.Default.ConsumerSecret);
                Process.Start(Session.AuthorizeUri.AbsoluteUri);
            }
            else
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    while (sr.Peek() >= 1)
                    {
                        var readLine = sr.ReadLine();
                        if (readLine != null)
                        {
                            string[] via = readLine.Split('|');
                            if (ViaComboBox.Text == via[0])
                            {
                                Session = OAuth.Authorize(via[1], via[2]);
                                Process.Start(Session.AuthorizeUri.AbsoluteUri);
                                break;
                            }
                        }
                    }
                }
            }

            ViaComboBox.Visible = false;
            ViaButton.Visible = false;
            PinTextBox.Visible = true;
            AuthButton.Visible = true;
            Label.Text = @"Pin";
            PinTextBox.Focus();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string pin = PinTextBox.Text;
            try
            {
                Tokens tokens = Session.GetTokens(pin);

                string folder = AppDomain.CurrentDomain.BaseDirectory + "Setting";
                Directory.CreateDirectory(folder);
                FileName = folder + "\\Account" + ".cfg";
                FileName = Path.GetFullPath(FileName);

                if (!File.Exists(FileName))
                {
                    using (FileStream fs = File.Create(FileName))
                    {
                        fs.Close();
                    }
                }

                if (ViaComboBox.Text == @"KIBOTTER")
                {
                    using (StreamWriter sw = new StreamWriter(FileName, true))
                    {
                        string toAdd = $"{tokens.ScreenName}|{ViaComboBox.Text}|KIBOTTER|KIBOTTER|{tokens.AccessToken}|{tokens.AccessTokenSecret}";
                        sw.WriteLine(toAdd);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(FileName, true))
                    {
                        string toAdd = $"{tokens.ScreenName}|{ViaComboBox.Text}|{tokens.ConsumerKey}|{tokens.ConsumerSecret}|{tokens.AccessToken}|{tokens.AccessTokenSecret}";
                        sw.WriteLine(toAdd);
                    }
                }

                Form1Obj.AccountComboBox.Items.Add($"{tokens.ScreenName}({ViaComboBox.Text})");
            }
            catch
            {
                Debug.WriteLine(6);
                MessageBox.Show(
                    @"にんしょーしっぱい(X3)",
                    @"えらー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                PinTextBox.Text = string.Empty;
                PinTextBox.Visible = false;
                AuthButton.Visible = false;
                ViaComboBox.Visible = true;
                ViaButton.Visible = true;
                Label.Text = @"Via";
            }
        }
    }
}
