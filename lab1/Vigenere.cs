using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab1
{
    internal static class Vigenere
    {
        private static string EN_alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string en_alphabet = "abcdefghijklmnopqrstuvwxyz";

        private static string RU_alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private static string ru_alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        private static readonly int ruAlphLength = 33;
        private static readonly int enAlphLength = 26;

        private static string curAlphL;
        private static string curAlphU;
        private static int curAlphLength;


        private static string keyWord;

        private static List<int> replace = new List<int>();

        public static void SetAlph(bool isEn)
        {
            if (isEn)
            {
                curAlphL = en_alphabet;
                curAlphU = EN_alphabet;
                curAlphLength = enAlphLength;
            }
            else
            {
                curAlphL = ru_alphabet;
                curAlphU = RU_alphabet;
                curAlphLength = ruAlphLength;
            }
        }

        public static void Init(string keyWord)
        { 
            replace.Clear();
            keyWord = keyWord.ToUpper();
            Vigenere.keyWord = keyWord;
            for (int i = 0; i < keyWord.Length; i++)
            {
                replace.Add(curAlphU.IndexOf(keyWord[i]));
            }
        }

        public static string? encrypt(string plainText)
        {
            string temp = plainText;
            Regex rgx = new Regex(@"[^a-яА-ЯёЁ]");
            temp = rgx.Replace(temp, "");

            int i = 0;
            StringBuilder sb = new StringBuilder();
            foreach (char c in temp)
            {
                char rep = ' ';
                if (curAlphL.IndexOf(c) != -1 || curAlphU.IndexOf(c) != -1)
                {
                    if (char.IsLower(c))
                    {
                        rep = curAlphL[(replace[i] + curAlphL.IndexOf(c)) % curAlphLength];
                    }
                    else
                    {
                        rep = curAlphU[(replace[i] + curAlphU.IndexOf(c)) % curAlphLength];
                    }
                    i++;
                    if (i >= replace.Count)
                    {
                        replace.Add((replace[i - 1] + 1) % curAlphLength);
                        for (int j = i + 1; j < temp.Length; j++)
                        {
                            replace.Add((replace[j - 1] + 1) % curAlphLength);
                        }
                    }
                }
                sb.Append(rep);

            }

            string res = sb.ToString();
            sb.Clear();
            int mainind = 0;
            for (i = 0; i < plainText.Length; i++)
            {
                if ((plainText[i] >= 'А' && plainText[i] <= 'Я') || (plainText[i] >= 'а' && plainText[i] <= 'я') || (plainText[i] >= 'ё') || (plainText[i] >= 'Ё'))
                {
                    sb.Append(res[mainind++]);
                }
                else
                {
                    sb.Append(plainText[i]);
                }
            }
            return sb.ToString();
        }

        public static string decrypt(string cipherText)
        {
            //Init(keyWord);
            StringBuilder sb = new StringBuilder();
            string temp = cipherText;
            Regex rgx = new Regex(@"[^a-яА-ЯёЁ]");
            temp = rgx.Replace(temp, "");

            int i = 0;
            foreach (char c in temp)
            {
                char rep;
                if (c == ' ')
                {
                    rep = ' ';
                }
                else
                {
                    if (char.IsLower(c))
                    {
                        rep = curAlphL[(curAlphL.IndexOf(c) + curAlphLength - replace[i]) % curAlphLength];
                    }
                    else
                    {
                        rep = curAlphU[(curAlphU.IndexOf(c) + curAlphLength - replace[i]) % curAlphLength];
                    }
                    i++;
                }
                sb.Append(rep);
            }

            string res = sb.ToString();
            sb.Clear();
            int mainind = 0;
            for (i = 0; i < cipherText.Length; i++)
            {
                if ((cipherText[i] >= 'А' && cipherText[i] <= 'Я') || (cipherText[i] >= 'а' && cipherText[i] <= 'я') || (cipherText[i] >= 'ё') || (cipherText[i] >= 'Ё'))
                {
                    sb.Append(res[mainind++]);
                }
                else
                {
                    sb.Append(cipherText[i]);
                }
            }

            return sb.ToString();
        }
    }
}
