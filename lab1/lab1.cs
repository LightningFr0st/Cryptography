using System.Text.RegularExpressions;

namespace lab1
{
    public partial class lab1 : Form
    {

        public delegate string ProcessFile(string text);
        static public ProcessFile? ENCODE = RotatingGrid.encrypt;
        static public ProcessFile? DECODE = RotatingGrid.decrypt;
        static public ProcessFile? PROC = ENCODE;


        static public bool isEncode = true;
        static public bool isGrid = true;

        public string? fileName;
        private bool fileSelected = false;

        public lab1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ENCODE = RotatingGrid.encrypt;
            DECODE = RotatingGrid.decrypt;
            isGrid = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ENCODE = Vigenere.encrypt;
            DECODE = Vigenere.decrypt;
            isGrid = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            PROC = ENCODE;
            isEncode = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            PROC = DECODE;
            isEncode = false;
        }

        private static string? allContent;

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select a file";
            fDialog.InitialDirectory = @"D:\uni\4 sem\labs\it\lab1\test files";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fDialog.SafeFileName;
            }
            fileSelected = true;
            allContent = File.ReadAllText(fDialog.FileName);

            if (isEncode)
            {
                PlainText.Text = allContent;
            }
            else
            {
                EncText.Text = allContent;
            }
        }

        public static string encrPath = @"D:\uni\4 sem\labs\it\lab1\test files\encrypted\";
        public static string decrPath = @"D:\uni\4 sem\labs\it\lab1\test files\decrypted\";
        public static string orignalPath = @"D:\uni\4 sem\labs\it\lab1\test files\";

        private void start_Click(object sender, EventArgs e)
        {
            string res = PROC(allContent);
            if (res == null) {
                MessageBox.Show("Wrong input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isEncode) {
                EncText.Text = res;
                File.WriteAllText(encrPath + fileName, res);
            }
            else
            {
                File.WriteAllText(decrPath + fileName, res);
            }
            
        }

        private void InitBTN_Click(object sender, EventArgs e)
        {
            if (isGrid && Regex.IsMatch(Key.Text, @"^[0-9 ]+$"))
            {
                string[] tokens = Key.Text.Split(' ');
                if (tokens.Length < 4) {
                    MessageBox.Show("Wrong input! Not enough numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                RotatingGrid.InitializeGrid(4 ,tokens.Select(n => Convert.ToInt32(n)).ToArray());
                return;
            }
            else if (!isGrid && Regex.IsMatch(Key.Text, @"^[à-ÿÀ-ÿ¸¨]+$"))
            {
                Vigenere.SetAlph(false);
                Vigenere.Init(Key.Text);
                return;
            }

            MessageBox.Show("Wrong input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
