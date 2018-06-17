using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using CoreTweet;
using Newtonsoft.Json;

namespace KIBOTTER
{
    public partial class MainForm : Form
    {
        private Tokens Tokens { get; set; }
        private DraftForm DraftObj { get; set; }
        private AdvancedForm AdvancedObj { get; set; }
        private MorseCodeConversionTool McctObj { get; set; }

        private string FirstMediaPath { get; set; }
        private string SecondMediaPath { get; set; }
        private string ThirdMediaPath { get; set; }
        private string FourthMediaPath { get; set; }

        private System.Timers.Timer _tweetTimer;

        private bool _isClosing;

        public List<ScheduledTweetClass> ScheduledTweetList;

        private KIBOTTERSettingClass _kibotterSetting = new KIBOTTERSettingClass();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RepliedPokerToolStripMenuItem.Checked = Properties.Settings.Default.IsRepliedPokerChecked;
            string folder = AppDomain.CurrentDomain.BaseDirectory + "Setting";
            Directory.CreateDirectory(folder);
            string fileName = $@"{folder}\Account.cfg";
            fileName = Path.GetFullPath(fileName);

            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (sr.Peek() >= 1)
                    {
                        var readLine = sr.ReadLine();
                        if (readLine != null)
                        {
                            string[] token = readLine.Split('|');
                            AccountComboBox.Items.Add($"{token[0]}({token[1]})");
                        }
                    }
                }
            }
            else
            {
                AccountComboBox.Items.Add("あかうんとせんたく");
            }
            AccountComboBox.SelectedIndex = 0;

            fileName = $@"{folder}\ScheduledTweets.json";
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName, Encoding.UTF8))
                {
                    string text = sr.ReadToEnd();
                    ScheduledTweetList = JsonConvert.DeserializeObject<List<ScheduledTweetClass>>(text);
                }
                using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    sw.Write("");
                }
            }

            if (ScheduledTweetList == null)
                ScheduledTweetList = new List<ScheduledTweetClass>();

            fileName = $@"{folder}\Settings.json";
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName, Encoding.UTF8))
                {
                    string text = sr.ReadToEnd();
                    _kibotterSetting = JsonConvert.DeserializeObject<KIBOTTERSettingClass>(text);
                }
                Properties.Settings.Default.IsBlackTheme = _kibotterSetting.IsBlackTheme;
                if (_kibotterSetting.IsBlackTheme)
                    ChangeThemeToBlack();
            }

            int left = Screen.PrimaryScreen.WorkingArea.Width - Width;
            int top = Screen.PrimaryScreen.WorkingArea.Height - Height;
            DesktopBounds = new Rectangle(left, top, Width, Height);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = Size;

            NewTimer();
            StartTimer();

            TweetTextBox.Focus();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void ChangeThemeToBlack()
        {
            BackColor = Color.FromArgb(45, 45, 45);
            AccountComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            AccountComboBox.BackColor = Color.FromArgb(45, 45, 45);
            AccountComboBox.ForeColor = Color.White;
            AccountComboBox.FlatStyle = FlatStyle.Flat;
            AccountComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TweetTextBox.BackColor = Color.FromArgb(62, 62, 62);
            TweetTextBox.ForeColor = Color.White;
            TextLengthLabel.ForeColor = Color.White;
            TweetButton.BackColor = Color.FromArgb(45, 45, 45);
            TweetButton.ForeColor = Color.White;
            TweetButton.FlatStyle = FlatStyle.Flat;
            DraftButton.BackColor = Color.FromArgb(45, 45, 45);
            DraftButton.ForeColor = Color.White;
            DraftButton.FlatStyle = FlatStyle.Flat;
            MediaButton.BackColor = Color.FromArgb(45, 45, 45);
            MediaButton.ForeColor = Color.White;
            MediaButton.FlatStyle = FlatStyle.Flat;
            toolStripMenuItem1.Visible = false;
            toolStripMenuItem2.Visible = false;
            toolStripMenuItem3.Visible = false;
            toolStripMenuItem4.Visible = false;
            MenuStrip.BackColor = Color.FromArgb(45, 45, 45);
            MenuToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            SettingToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            AboutToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            HelpToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            AddAccountToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            ScheduleToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            MorseConToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            CloseToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            MorseToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            SushiModeToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            RepliedPokerToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            AdvancedToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            MenuToolStripMenuItem.ForeColor = Color.White;
            SettingToolStripMenuItem.ForeColor = Color.White;
            AboutToolStripMenuItem.ForeColor = Color.White;
            HelpToolStripMenuItem.ForeColor = Color.White;
            AddAccountToolStripMenuItem.ForeColor = Color.White;
            ScheduleToolStripMenuItem.ForeColor = Color.White;
            MorseConToolStripMenuItem.ForeColor = Color.White;
            CloseToolStripMenuItem.ForeColor = Color.White;
            MorseToolStripMenuItem.ForeColor = Color.White;
            SushiModeToolStripMenuItem.ForeColor = Color.White;
            RepliedPokerToolStripMenuItem.ForeColor = Color.White;
            AdvancedToolStripMenuItem.ForeColor = Color.White;
            StatusStrip.BackColor = Color.FromArgb(43, 123, 185);
            StatusStrip.ForeColor = Color.White;
        }

        private void ChangeThemeToDefault()
        {
            BackColor = SystemColors.Control;
            AccountComboBox.BackColor = SystemColors.Window;
            AccountComboBox.ForeColor = SystemColors.WindowText;
            AccountComboBox.FlatStyle = FlatStyle.System;
            TweetTextBox.BackColor = SystemColors.Window;
            TweetTextBox.ForeColor = SystemColors.WindowText;
            TextLengthLabel.ForeColor = SystemColors.ControlText;
            TweetButton.BackColor = SystemColors.Control;
            TweetButton.ForeColor = SystemColors.ControlText;
            TweetButton.FlatStyle = FlatStyle.System;
            DraftButton.BackColor = SystemColors.Control;
            DraftButton.ForeColor = SystemColors.ControlText;
            DraftButton.FlatStyle = FlatStyle.System;
            MediaButton.BackColor = SystemColors.Control;
            MediaButton.ForeColor = SystemColors.ControlText;
            MediaButton.FlatStyle = FlatStyle.System;
            toolStripMenuItem1.Visible = true;
            toolStripMenuItem2.Visible = true;
            toolStripMenuItem3.Visible = true;
            toolStripMenuItem4.Visible = true;
            MenuStrip.BackColor = SystemColors.Control;
            MenuToolStripMenuItem.BackColor = SystemColors.Control;
            SettingToolStripMenuItem.BackColor = SystemColors.Control;
            AboutToolStripMenuItem.BackColor = SystemColors.Control;
            HelpToolStripMenuItem.BackColor = SystemColors.Control;
            AddAccountToolStripMenuItem.BackColor = SystemColors.Control;
            ScheduleToolStripMenuItem.BackColor = SystemColors.Control;
            MorseConToolStripMenuItem.BackColor = SystemColors.Control;
            CloseToolStripMenuItem.BackColor = SystemColors.Control;
            MorseToolStripMenuItem.BackColor = SystemColors.Control;
            SushiModeToolStripMenuItem.BackColor = SystemColors.Control;
            RepliedPokerToolStripMenuItem.BackColor = SystemColors.Control;
            AdvancedToolStripMenuItem.BackColor = SystemColors.Control;
            MenuToolStripMenuItem.ForeColor = SystemColors.ControlText;
            SettingToolStripMenuItem.ForeColor = SystemColors.ControlText;
            AboutToolStripMenuItem.ForeColor = SystemColors.ControlText;
            HelpToolStripMenuItem.ForeColor = SystemColors.ControlText;
            AddAccountToolStripMenuItem.ForeColor = SystemColors.ControlText;
            ScheduleToolStripMenuItem.ForeColor = SystemColors.ControlText;
            MorseConToolStripMenuItem.ForeColor = SystemColors.ControlText;
            CloseToolStripMenuItem.ForeColor = SystemColors.ControlText;
            MorseToolStripMenuItem.ForeColor = SystemColors.ControlText;
            SushiModeToolStripMenuItem.ForeColor = SystemColors.ControlText;
            RepliedPokerToolStripMenuItem.ForeColor = SystemColors.ControlText;
            AdvancedToolStripMenuItem.ForeColor = SystemColors.ControlText;
            StatusStrip.BackColor = SystemColors.Control;
            StatusStrip.ForeColor = SystemColors.ControlText;
        }

        private void AccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AccountComboBox.Text == @"あかうんとせんたく")
                return;

            Auth();
        }

        private void Auth()
        {
            string folder = AppDomain.CurrentDomain.BaseDirectory + "Setting";
            string fileName = $@"{folder}\Account.cfg";
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (sr.Peek() >= 1)
                {
                    var readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        string[] token = readLine.Split('|');
                        if ($@"{token[0]}({token[1]})" == AccountComboBox.Text)
                        {
                            if (token[2] == "KIBOTTER")
                            {
                                Tokens = Tokens.Create(
                                    Properties.Settings.Default.ConsumerKey,
                                    Properties.Settings.Default.ConsumerSecret,
                                    token[4],
                                    token[5]);
                            }
                            else
                            {
                                Tokens = Tokens.Create(
                                    token[2],
                                    token[3],
                                    token[4],
                                    token[5]);
                            }
                            break;
                        }
                    }
                }
            }

            if (Tokens == null)
            {
                MessageBox.Show(
                    @"認証に失敗しました(X3)",
                    @"えらー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            ToolStripStatusLabel.Text = @"ろぐいんしました(:3)";
        }

        private void TweetTextBox_TextChanged(object sender, EventArgs e)
        {
            int length = 140 - TweetTextBox.TextLength;
            int linage = TweetTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;
            length += linage - 1;

            if (length < 0)
                TextLengthLabel.ForeColor = Color.Red;
            else
            {
                TextLengthLabel.ForeColor = Color.Black;
                if (Properties.Settings.Default.IsBlackTheme) TextLengthLabel.ForeColor = Color.White;
            }

            TextLengthLabel.Text = length.ToString();
        }

        private async void TweetButton_Click(object sender, EventArgs e)
        {
            if (Tokens == null)
            {
                ToolStripStatusLabel.Text = @"まだにんしょうしていません(X3)";
                return;
            }
            string text = TweetTextBox.Text;
            TweetTextBox.Clear();
            TweetTextBox.Focus();
            
            await ApplyCommandAndTweet(text);
        }

        private string CommandPoker()
        {
            Poker poker = new Poker();
            string[] text = new string[10];
            int[] cards = poker.HandOutCards();
            string result = poker.Judge(cards);
            string tweetContent = "Enjoy Poker!!\r\n";

            for (int i = 0; i < 5; i++)
            {
                text[2 * i] = Convert.ToString(cards[i] % 4);

                if (text[2 * i] == "0") text[2 * i] = "♠";
                else if (text[2 * i] == "1") text[2 * i] = "♥";
                else if (text[2 * i] == "2") text[2 * i] = "♦";
                else if (text[2 * i] == "3") text[2 * i] = "♣";

                text[2 * i + 1] = Convert.ToString((cards[i] - cards[i] % 4) / 4 + 1);

                if (text[2 * i + 1] == "1") text[2 * i + 1] = "A";
                else if (text[2 * i + 1] == "11") text[2 * i + 1] = "J";
                else if (text[2 * i + 1] == "12") text[2 * i + 1] = "Q";
                else if (text[2 * i + 1] == "13") text[2 * i + 1] = "K";

                tweetContent += text[2 * i] + text[2 * i + 1];
            }

            return tweetContent + $"\r\n{result}";
        }

        private async Task ApplyCommandAndTweet(string text)
        {
            text = text.TrimEnd('\r', '\n');

            if (string.IsNullOrEmpty(text))
            {
                ToolStripStatusLabel.Text = @"しっぱいしました(X3)";
                return;
            }

            if (SushiModeToolStripMenuItem.Checked)
            {
                var sushiText = string.Empty;

                for (int i = 0; i < text.Length; i++)
                    sushiText += "🍣";

                text = sushiText;
            }
            else if (MorseToolStripMenuItem.Checked)
            {
                MorseCode mc = new MorseCode();
                text = mc.ConvertToMorse(text);
                if (text == "error")
                {
                    ToolStripStatusLabel.Text = @"もーるすしんごうにできませんでした(X3)";
                    return;
                }
            }
            
            if (text == "!poker")
            {
                text = string.Empty;

                if (RepliedPokerToolStripMenuItem.Checked)
                    text = "@KIBOUDIED \r\n";

                text += CommandPoker();
            }
            else if (text == "!bill")
            {
                Random rnd = new Random(int.Parse(DateTime.Now.ToString("yyyyMMdd")));
                int bill = rnd.Next();
                text = $"本日のTwitter利用料 {bill:#,0}円";
            }

            int startIndex;
            if (0 <= (startIndex = text.IndexOf("!now", StringComparison.Ordinal)))
                text = text.Remove(startIndex, 4).Insert(startIndex, DateTime.Now.ToString(CultureInfo.CurrentCulture));

            if (FirstMediaPath != null)
            {
                await TweetWithMedia(text);
                return;
            }

            await Tweet(text, 1);
        }

        private async Task Tweet(string text, int count)
        {
            const string completeText = "ついーとしました(:3)";
            const string failureText = "しっぱいしました(X3)";

            string textWithCount = text;
            try
            {
                if (count != 1)
                {
                    textWithCount += $"({count}回目)";

                    if (textWithCount.Length > 140)
                    {
                        ToolStripStatusLabel.Text = failureText;
                        return;
                    }
                }

                await Tokens.Statuses.UpdateAsync(status => textWithCount);
                var resultText = completeText;

                if (count != 1)
                    resultText += $"({count}回目)";

                ToolStripStatusLabel.Text = resultText;
            }
            catch
            {
                count++;
                await Tweet(text, count);
            }
        }

        private async Task TweetWithMedia(string text)
        {
            try
            {
                List<long> mediaIds = new List<long>();

                if (FirstMediaPath != null)
                {
                    string f = FirstMediaPath;
                    FirstMediaPath = null;
                    var first = await Tokens.Media.UploadAsync(media => new FileInfo(f));
                    mediaIds.Add(first.MediaId);
                }
                if (SecondMediaPath != null)
                {
                    string s = SecondMediaPath;
                    SecondMediaPath = null;
                    var second = await Tokens.Media.UploadAsync(media => new FileInfo(s));
                    mediaIds.Add(second.MediaId);
                }
                if (ThirdMediaPath != null)
                {
                    string t = ThirdMediaPath;
                    ThirdMediaPath = null;
                    var third = await Tokens.Media.UploadAsync(media => new FileInfo(t));
                    mediaIds.Add(third.MediaId);
                }
                if (FourthMediaPath != null)
                {
                    string f = FourthMediaPath;
                    FourthMediaPath = null;
                    var fourth = await Tokens.Media.UploadAsync(media => new FileInfo(f));
                    mediaIds.Add(fourth.MediaId);
                }

                await Tokens.Statuses.UpdateAsync(status:text, media_ids:mediaIds);
                ToolStripStatusLabel.Text = @"がぞうつきでとうこうしました(:3)";
            }
            catch
            {
                FirstMediaPath = null;
                SecondMediaPath = null;
                ThirdMediaPath = null;
                FourthMediaPath = null;
                ToolStripStatusLabel.Text = @"がぞうのあっぷろーどにしっぱい(X3)";
            }
        }

        private void MediaButton_Click(object sender, EventArgs e)
        {
            if (FourthMediaPath != null)
            {
                MessageBox.Show(
                    @"これいじょうついかできません(X3)",
                    @"えらー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Filter = @"すべてのふぁいる(*.*)|*.*|じぇいぺぐ(*.jpeg;*.jpg)|*.jpeg;*.jpg|ぴんぐ(*.png)|*.png|じふ(*.gif)|*.gif",
                FilterIndex = 1,
                Title = @"ふぁいるのあっぷろーど"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (FirstMediaPath == null)
                {
                    FirstMediaPath = ofd.FileName;
                    ToolStripStatusLabel.Text = @"1まいめをついかしました(:3)";
                }
                else if (SecondMediaPath == null)
                {
                    SecondMediaPath = ofd.FileName;
                    ToolStripStatusLabel.Text = @"2まいめをついかしました(:3)";
                }
                else if (ThirdMediaPath == null)
                {
                    ThirdMediaPath = ofd.FileName;
                    ToolStripStatusLabel.Text = @"3まいめをついかしました(:3)";
                }
                else if (FourthMediaPath == null)
                {
                    FourthMediaPath = ofd.FileName;
                    ToolStripStatusLabel.Text = @"4まいめをついかしました(:3)";
                }
                else
                {
                    MessageBox.Show(
                        @"これいじょうついかできません(X3)",
                        @"えらー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void DraftButton_Click(object sender, EventArgs e)
        {
            if (DraftObj == null || DraftObj.IsDisposed)
            {
                DraftObj = new DraftForm(this);
                DraftObj.Show();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $@"まだありません(X3){Environment.NewLine}しつもんはこちらまで{Environment.NewLine}@KIBOU811",
                @"えらー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $@"まだありません(X3){Environment.NewLine}しつもんはこちらまで{Environment.NewLine}@KIBOU811",
                @"えらー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void AddAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccountObj = new AddAccountForm
            {
                ShowInTaskbar = false,
                Form1Obj = this
            };
            addAccountObj.ShowDialog();
        }

        private void ScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleFormObj = new ScheduleForm
            {
                ShowInTaskbar = false,
                Form1Obj = this
            };
            scheduleFormObj.ShowDialog();
        }

        private void MorseConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (McctObj == null || McctObj.IsDisposed)
            {
                McctObj = new MorseCodeConversionTool();
                McctObj.Show();
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdvancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvancedObj = new AdvancedForm(Height) {ShowInTaskbar = false};
            AdvancedObj.ShowDialog();

            if (Properties.Settings.Default.IsBlackTheme)
                ChangeThemeToBlack();
            else
                ChangeThemeToDefault();

            if (DraftObj != null && !DraftObj.IsDisposed)
            {
                if (Properties.Settings.Default.IsBlackTheme)
                    DraftObj.ChangeThemeToBlack();
                else
                    DraftObj.ChangeThemeToDefault();
            }
        }

        private void TweetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' && ModifierKeys == Keys.Control)
            {
                TweetButton.PerformClick();
                e.Handled = true;
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if(_isClosing)
                return;
            
            Opacity = 0.7;
        }

        private void MenuItemMouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsBlackTheme)
            {
                var control = (ToolStripMenuItem)sender;
                control.ForeColor = Color.Black;
            }
        }

        private void MenuItemMouseLeave(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.IsBlackTheme)
            {
                var control = (ToolStripMenuItem)sender;
                control.ForeColor = Color.White;
            }
        }

        private void NewTimer()
        {
            _tweetTimer = new System.Timers.Timer
            {
                AutoReset = true,
                Interval = 30000
            };

            _tweetTimer.Elapsed += OnTimerEvent;
        }

        private async void OnTimerEvent(object source, ElapsedEventArgs e)
        {
            List<ScheduledTweetClass> alternateList = new List<ScheduledTweetClass>(ScheduledTweetList);

            foreach (var al in alternateList)
            {
                DateTime tweetTime = DateTime.FromBinary(al.TweetDateTime);
                if (tweetTime.Date == DateTime.Now.Date
                    && tweetTime.Hour == DateTime.Now.Hour
                    && tweetTime.Minute == DateTime.Now.Minute)
                {
                    Tokens scheduleTokensTokens = new Tokens();

                    
                    string folder = AppDomain.CurrentDomain.BaseDirectory + "Setting";
                    string fileName = $@"{folder}\ScheduledTweets.json";

                        using (StreamReader sr = new StreamReader(fileName))
                    {
                        while (sr.Peek() >= 1)
                        {
                            var readLine = sr.ReadLine();
                            if (readLine != null)
                            {
                                string[] token = readLine.Split('|');
                                if ($@"{token[0]}({token[1]})" == al.ScreenAndViaName)
                                {
                                    if (token[2] == "KIBOTTER")
                                    {
                                        scheduleTokensTokens = Tokens.Create(
                                            Properties.Settings.Default.ConsumerKey,
                                            Properties.Settings.Default.ConsumerSecret,
                                            token[4],
                                            token[5]);
                                    }
                                    else
                                    {
                                        scheduleTokensTokens = Tokens.Create(
                                            token[2],
                                            token[3],
                                            token[4],
                                            token[5]);
                                    }
                                    break;
                                }
                            }
                        }
                    }

                    if (scheduleTokensTokens == null)
                    {
                        MessageBox.Show(
                            @"予約投稿に失敗しました(X3)",
                            @"えらー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    await Tweet(al.Content, 1);

                    ScheduledTweetList.Remove(al);
                    ToolStripStatusLabel.Text = @"よやくついーとしました(:3)";
                }
            }
        }

        private void StartTimer()
        {
            _tweetTimer.Start();
        }

        private void StopTimer()
        {
            _tweetTimer.Stop();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopTimer();
            _isClosing = true;

            string fileName;
            if (ScheduledTweetList != null && ScheduledTweetList.Count != 0)
            {
                string folder = AppDomain.CurrentDomain.BaseDirectory + "Setting";
                fileName = $@"{folder}\ScheduledTweets.json";
                if (!File.Exists(fileName))
                {
                    using (FileStream fs = File.Create(fileName))
                    {
                        fs.Close();
                    }
                }
                using (StreamWriter sw = new StreamWriter(fileName, true, Encoding.UTF8))
                {
                    string json = JsonConvert.SerializeObject(ScheduledTweetList, Formatting.Indented);
                    sw.Write(json);
                }
            }
            _kibotterSetting.IsBlackTheme = Properties.Settings.Default.IsBlackTheme;

            fileName = $@"{AppDomain.CurrentDomain.BaseDirectory}Setting\Settings.json";
            if (!File.Exists(fileName))
            {
                using (FileStream fs = File.Create(fileName))
                {
                    fs.Close();
                }
            }
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                string json = JsonConvert.SerializeObject(_kibotterSetting, Formatting.Indented);
                sw.Write(json);
            }

            Properties.Settings.Default.IsRepliedPokerChecked = RepliedPokerToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
