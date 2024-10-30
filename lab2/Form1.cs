using System.Collections;
using System.Text;

namespace lab2
{
    public partial class Stream_cipher : Form
    {
        public Stream_cipher()
        {
            InitializeComponent();
            Cryptography.myForm = this;
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select a file";
            fDialog.InitialDirectory = @"D:\uni\4 sem\labs\it\lab2\test files";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                Cryptography.selectFile(fDialog.FileName);
            }
        }

        private void Encryption_Click(object sender, EventArgs e)
        {
            Cryptography.encrypting = true;
        }

        private void Decryption_CheckedChanged(object sender, EventArgs e)
        {
            Cryptography.encrypting = false;
        }

        public static string ToBitString(BitArray bits, int amnt)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < int.Min(bits.Count, amnt); i++)
            {
                char c = bits[i] ? '1' : '0';
                sb.Append(c);
            }

            return sb.ToString();
        }

        public void output_1(BitArray file, BitArray key)
        {
            file_l.Text = ToBitString(file, 56);
            key_l.Text = ToBitString(key, 56);
        }

        public void output_2(BitArray enc_file)
        {
            enc_l.Text = ToBitString(enc_file, 56);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Cryptography.file_selected == false)
            {
                MessageBox.Show("You have not selected a file");
                return;
            }
            string input = key_input.Text;
            if (input.Length != Cryptography.lfsr_length)
            {
                MessageBox.Show("Invalid key length");
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '0' && input[i] != '1')
                {
                    MessageBox.Show("The key must contain only zeros and ones");
                    return;
                }
            }
            Cryptography.start(input);
            if (Cryptography.encrypting == true)
            {
                Result.Text = "Result: encryption comleted";
            }
            else
            {
                Result.Text = "Result: decryption comleted";
            }
        }

    }
}
