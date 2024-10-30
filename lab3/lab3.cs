using System.Diagnostics;

namespace lab3
{
    public partial class lab3 : Form
    {
        public string? fileName;
        private bool fileSelected = false;
        private bool encrypt = true;

        public lab3()
        {
            InitializeComponent();
        }

        private void PChanged(object sender, EventArgs e)
        {
            string input = ((TextBox)sender).Text;
            SelectG.Items.Clear();
            if (input != "" && input.All(char.IsDigit))
            {
                uint cur = UInt32.Parse(input);
                if (cur > 255 && cur < 500 && Cryptography.CheckPrime(cur))
                {
                    Cryptography.SetP(cur);
                    var primitiveRoots = Cryptography.GetPrimitiveRoots();
                    foreach (uint root in primitiveRoots)
                    {
                        SelectG.Items.Add(root);
                    }
                    SelectG.SelectedIndex = 0;
                    counter.Text = primitiveRoots.Count.ToString();
                }
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select a file";
            fDialog.InitialDirectory = @"D:\uni\4 sem\labs\it\lab3\test files";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fDialog.SafeFileName;
            }
            fileSelected = true;
            FileStream fs = new FileStream(fDialog.FileName, FileMode.Open, FileAccess.Read);
            var buffer = new byte[40];
            fs.Read(buffer, 0, 20);

            if (encrypt)
            {
                PlainFile.Text = string.Join(' ', buffer);
            }
            else
            {
                ushort[] output = new ushort[buffer.Length / 2];
                Buffer.BlockCopy(buffer, 0, output, 0, buffer.Length);
                EncFile.Text = string.Join(' ', output);
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (inputP.Text == "" || !inputP.Text.All(char.IsDigit))
            {
                MessageBox.Show("Incorrect input of P", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (inputX.Text == "" || !inputX.Text.All(char.IsDigit))
            {
                MessageBox.Show("Incorrect input of X", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (inputK.Text == "" || !inputK.Text.All(char.IsDigit))
            {
                MessageBox.Show("Incorrect input of K", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!fileSelected)
            {
                MessageBox.Show("You haven't selected a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            stats.Text = "Status: In process";
            Cryptography.Init(fileName, encrypt, UInt32.Parse(SelectG.Text), UInt32.Parse(inputX.Text), UInt32.Parse(inputK.Text));
            Cryptography.Process();
            stats.Text = "Status: Done";
        }

        private void enableEncryption_CheckedChanged(object sender, EventArgs e)
        {
            encrypt = true;
            fileSelected = false;
        }

        private void enableDecryption_CheckedChanged(object sender, EventArgs e)
        {
            encrypt = false;
            fileSelected = false;
        }

    }
}
