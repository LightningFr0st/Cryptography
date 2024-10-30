using System.Text;

namespace lab4
{
    public partial class lab4 : Form
    {
        private bool USEALPHABET = false;

        private string start_string;
        private byte[] bytes;
        List<long> prime = new List<long>();

        private int? Q = null;
        private int? P = null;
        private int? R = null;
        private int? PHI_R = null;
        private int? E = null;
        private int? D = null;
        private bool fileSelected = false;
        private bool valuesInitialized = false;

        private string file_name;
        private string init_dir = @"D:\uni\4 sem\labs\it\lab4\test files\";
        private bool sign_action = true;

        public lab4()
        {
            InitializeComponent();
        }

        private void lab4_Load(object sender, EventArgs e)
        {
            Eratosthenes();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (sign_action)
            {
                long H, S;
                if (USEALPHABET)
                {
                    (H, S) = Signature.AlphSign(start_string, (int)D, (int)R);
                }
                else
                {
                    (H, S) = Signature.Sign(bytes, (int)D, (int)R);
                    
                }

                hash_label.Text = "hash = " + Convert.ToString(H);
                orig_hash_lable.Text = "original hash = ";
                sign_label.Text = "sign = " + Convert.ToString(S);
                string output = start_string + ":" + Convert.ToString(S);
                File.WriteAllText(init_dir + "signed_" + file_name, output);
            }
            else
            {
                long? hash_orig, hash_new;
                //(hash_new,hash_orig) = Signature.AlphCheck(start_string + ":206", (int)E, (int)R);
                if (USEALPHABET)
                {
                    (hash_new, hash_orig) = Signature.AlphCheck(start_string, (int)E, (int)R);
                    if (hash_orig == null)
                    {
                        MessageBox.Show("File doesn't contain signature", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else 
                    {
                        hash_label.Text = "hash = " + Convert.ToString(hash_new);
                        orig_hash_lable.Text = "original hash = " + Convert.ToString(hash_orig);
                        sign_label.Text = "sign = ";
                        if (hash_orig == hash_new)
                        {
                            result_label.Text = $"Result: Signature is correct ({hash_new}=={hash_orig})";
                        }
                        else
                        {
                            result_label.Text = $"Result: Signature is not correct ({hash_new}!={hash_orig})";
                        }
                    }
                }
                else
                {
                    (hash_new, hash_orig) = Signature.Check(bytes, (int)E, (int)R);
                    if (hash_orig == null)
                    {
                        MessageBox.Show("File doesn't contain signature", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        hash_label.Text = "hash = " + Convert.ToString(hash_new);
                        orig_hash_lable.Text = "original hash = " + Convert.ToString(hash_orig);
                        sign_label.Text = "sign = ";
                        if (hash_orig == hash_new)
                        {
                            result_label.Text = $"Result: Signature is correct ({hash_new}=={hash_orig})";
                        }
                        else
                        {
                            result_label.Text = $"Result: Signature is not correct ({hash_new}!={hash_orig})";
                        }
                    }
                }
                
            }
        }
        private bool IsDigitsOnly(string str)
        {
            if (str.Length == 0) return false;

            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select a file";
            fDialog.InitialDirectory = init_dir;
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                file_name = fDialog.SafeFileName;
                fileSelected = true;
                bytes = File.ReadAllBytes(fDialog.FileName);
                bytes = Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding(1251), bytes);
                start_string = Encoding.GetEncoding(1251).GetString(bytes);
                file_txt.Text = start_string;

                if (valuesInitialized)
                {
                    start_btn.Enabled = true;
                }
            }
        }

        private void prime_box1_SelectedIndexChanged(object sender, EventArgs e)
        {
            P = Convert.ToInt32(prime_box1.Text);
            if (Q != null)
            {
                R = P * Q;
                PHI_R = (P - 1) * (Q - 1);
                r_label.Text = "r = " + Convert.ToString(R);
                phi_r_label.Text = "φ(r) = " + Convert.ToString(PHI_R);
                d_txt.ReadOnly = false;
            }
        }

        private void prime_box2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Q = Convert.ToInt32(prime_box2.Text);
            if (P != null)
            {
                R = P * Q;
                PHI_R = (P - 1) * (Q - 1);
                r_label.Text = "r = " + Convert.ToString(R);
                phi_r_label.Text = "φ(r) = " + Convert.ToString(PHI_R);
                d_txt.ReadOnly = false;
            }
        }

        private readonly int MAXN = 1000;

        private void Eratosthenes()
        {
            bool[] check = Enumerable.Repeat(true, MAXN + 1).ToArray();
            check[0] = false;
            check[1] = false;
            for (int i = 2; i * i <= MAXN; i++)
            {
                if (check[i])
                {
                    for (int j = i * i; j <= MAXN; j += i)
                    {
                        check[j] = false;
                    }
                }
            }
            for (int i = 0; i <= MAXN; i++)
            {
                if (check[i])
                {
                    prime.Add(i);
                    prime_box1.Items.Add(i);
                    prime_box2.Items.Add(i);
                }
            }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                a %= b;
                (a, b) = (b, a);
            }
            return a;
        }

        private int ExtGCD(int a, int b, ref int x, ref int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            int x1 = 0, y1 = 0;
            int d = ExtGCD(b % a, a, ref x1, ref y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        private void sign_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            sign_action = true;
        }

        private void check_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            sign_action = false;
        }

        private void init_btn_Click(object sender, EventArgs e)
        {
            bool result = CheckInput();
            if (result && R != null)
            {
                int x = 0, y = 0;
                ExtGCD((int)PHI_R, (int)D, ref x, ref y);
                E = y;
                if (E < 0)
                {
                    E += PHI_R;
                }
                e_label.Text = "e = " + Convert.ToString(E);
                valuesInitialized = true;
                if (fileSelected)
                {
                    start_btn.Enabled = true;
                }
            }
        }
        private bool CheckInput()
        {
            bool is_d_valid = IsDigitsOnly(d_txt.Text);
            if (is_d_valid)
            {
                D = Convert.ToInt32(d_txt.Text);
                is_d_valid = (D > 1) && (D < PHI_R) && (GCD((int)D, (int)PHI_R) == 1);
                if (is_d_valid)
                {
                    return true;
                }
                else
                {
                    D = null;
                    MessageBox.Show("Incorrect value of D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            }
            else
            {
                MessageBox.Show("D must contain only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                D = null;
                return false;
            }
        }
    }

}
