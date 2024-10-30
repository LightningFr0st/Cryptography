using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public static class Cryptography
    {
        static public Stream_cipher myForm;
        public readonly static int lfsr_length = 33;
        public readonly static int bits_length = 2;
        private static int key_length;
        private static bool key_created = false;

        private static int ind = 0;

        private static BitArray? LFSR;
        private static int[] bits = { 12, 32 };
        private static BitArray? key;
        private static string s_key = "";

        private static string file_name;
        private static string file_extension;
        private static string file_path;

        public static bool encrypting = true;
        public static bool file_selected = false;

        public static void start(string new_key)
        {
            if (new_key != s_key)
            {
                s_key = new_key;
                setKey();
            }
            if (encrypting == true)
            {
                encode();
            }
            else
            {
                decode();
            }
        }

        public static void selectFile(string filepath)
        {
            file_path = filepath;
            string[] tokens = filepath.Split('\\');
            string full_name = tokens[tokens.Length - 1];
            string[] arr_file_name = full_name.Split('.');
            if (arr_file_name.Length > 1)
            {
                file_name = arr_file_name[0];
                file_extension = arr_file_name[1];
            }
            else
            {
                file_name = arr_file_name[0];
            }
            file_selected = true;
            if (encrypting == true)
            {
                key_created = false;
            }
        }

        public static void setKey()
        {
            LFSR = new BitArray(lfsr_length, false);

            for (int i = 0; i < lfsr_length; i++)
            {
                LFSR[i] = Convert.ToBoolean((s_key[lfsr_length - i - 1] - '0'));
            }
        }

        public static void GenereteKey()
        {
            for (int k = 0; k < key_length; k++)
            {
                bool new_bit = LFSR[bits[0]];
                for (int i = 1; i < bits_length; i++)
                {
                    new_bit ^= LFSR[bits[i]];
                }
                key[ind] = LFSR[lfsr_length - 1];
                ind++;
                LFSR.LeftShift(1);
                LFSR[0] = new_bit;
            }
            key_created = true;
        }

        public static void encode()
        {
            byte[] fileArray = File.ReadAllBytes(file_path);
            BitArray plaintext = new BitArray(fileArray);

            if (!key_created)
            {
                key_length = plaintext.Length;
                ind = 0;
                key = new BitArray(key_length, false);
                GenereteKey();
            }

            myForm.output_1(plaintext, key);

            plaintext.Xor(key);

            byte[] ciphertext = new byte[key_length / 8];
            plaintext.CopyTo(ciphertext, 0);

            myForm.output_2(plaintext);

            FileStream output = new FileStream(@"D:\uni\4 sem\labs\it\lab2\test files\encrypted\" + file_name, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(output);

            bw.Write(ciphertext);
            bw.Close();
            output.Close();
        }

        public static void decode()
        {
            byte[] fileArray = File.ReadAllBytes(file_path);
            BitArray ciphertext = new BitArray(fileArray);

            //if (!key_created)
            //{
            //    key_length = ciphertext.Length;
            //    ind = key_length - 1;
            //    key = new BitArray(key_length, false);
            //    GenereteKey();
            //}

            ciphertext.Xor(key);

            byte[] plaintext = new byte[key_length / 8];
            ciphertext.CopyTo(plaintext, 0);

            FileStream output = new FileStream(@"D:\uni\4 sem\labs\it\lab2\test files\decrypted\" + file_name + '.' + file_extension, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(output);

            bw.Write(plaintext);
            bw.Close();
            output.Close();
        }

    }
}

// 111111111111111111111111111111111

// output - 1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡0󠀡󠀡0󠀡󠀡0󠀡󠀡0󠀡󠀡0󠀡󠀡0󠀡󠀡0󠀡󠀡0󠀡󠀡0󠀡󠀡0󠀡󠀡0󠀡󠀡0󠀡󠀡0󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡1󠀡󠀡