using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    static internal class Signature
    {
        public enum RESPONSE
        {
            OK,
            NO_SIGN,
            WRONG
        }

        private static string EN_alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string en_alphabet = "abcdefghijklmnopqrstuvwxyz";

        private static string RU_alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private static string ru_alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public static long AlphHashFunction(string str, long n)
        {
            long H = 100;
            foreach (char c in str)
            {
                int num = RU_alphabet.IndexOf(c) + 1;
                H = FastExponent(H + num, 2, n);
            }
            return H;
        }
        public static (long, long) AlphSign(string str, int D, int R)
        {
            long M = AlphHashFunction(str, R);
            long S = FastExponent(M, D, R);
            return (M, S);
        }
        public static (long?, long?) AlphCheck(string str, int E, int R)
        {
            int pos = str.IndexOf(':');
            if (pos != -1)
            {
                string message = str.Substring(0, pos);
                int sign = Convert.ToInt32(str.Substring(pos + 1, str.Length - pos - 1));
                long? hash_orig = FastExponent(sign, E, R);
                long? hash_new = AlphHashFunction(message, R);
                return (hash_new, hash_orig);
            }
            else
            {
                return (null, null);
            }

        }


        public static long HashFunction(byte[] arr, long n)
        {
            long H = 100;
            foreach (byte b in arr)
            {
                H = FastExponent(H + b, 2, n);
            }
            return H;
        }
        public static (long, long) Sign(byte[] arr, int D, int R)
        {
            long M = HashFunction(arr, R);
            long S = FastExponent(M, D, R);
            return (M, S);
        }
        public static (long?, long?) Check(byte[] arr, int E, int R)
        {
            int pos = Array.FindIndex(arr, x => x == ':');
            if (pos != -1)
            {
                byte[] messageb = new byte[pos];
                byte[] signb = new byte[arr.Length - pos];
                Array.Copy(arr, 0, messageb, 0, pos);
                Array.Copy(arr, pos + 1, signb, 0, arr.Length - pos - 1);
                int sign = Convert.ToInt32(Encoding.ASCII.GetString(signb));
                long? hash_orig = FastExponent(sign, E, R);
                long? hash_new = HashFunction(messageb, R);
                return (hash_new, hash_orig);
            }
            else
            {
                return (null, null);
            }
        }


        private static long FastExponent(long a, long n, long m)
        {
            long res = 1;
            while (n != 0)
            {
                while (n % 2 == 0)
                {
                    n /= 2;
                    a = (a * a) % m;
                }
                n--;
                res = (res * a) % m;
            }
            return res;
        }
    }
}
