using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    internal static class RotatingGrid
    {
        public static char[,] cypher_text;
        public static string original;
        public static int[,] grid;
        // = { { 1, 0, 0, 0 }, { 0, 0, 0, 2 }, { 0, 0, 3, 0 }, { 0, 4, 0, 0 } }

        private static (int, int)[] nextRep;
        // = { (0, 0), (1, 3), (2, 2), (3, 1) }

        private static int N;

        public static void InitializeGrid(int p_N, int[] arr)
        {
            N = p_N;

            cypher_text = new char[N, N];
            grid = new int[N, N];
            nextRep = new (int, int)[N];

            for (int i = 0; i < N; i++)
            {
                int ind = arr[i] - 1;
                grid[i, ind] = i + 1;
                nextRep[i] = (i, ind);
            }
        }

        public static void rotateGrid()
        {
            for (int i = 0; i < N / 2; i++)
            {
                for (int j = i; j < N - i - 1; j++)
                {
                    int temp = grid[i, j];
                    grid[i, j] = grid[N - 1 - j, i];
                    grid[N - 1 - j, i] = grid[N - 1 - i, N - 1 - j];
                    grid[N - 1 - i, N - 1 - j] = grid[j, N - 1 - i];
                    grid[j, N - 1 - i] = temp;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (grid[i, j] != 0)
                    {
                        nextRep[i] = (i, j);
                    }
                }
            }
        }

        private static string en_alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string EN_alphabet = "abcdefghijklmnopqrstuvwxyz";
        private static string RU_alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private static string ru_alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        private static int plainLenght;


        public static string? encrypt(string MAIN)
        {
            string substr = MAIN;
            original = MAIN;
            Regex rgx = new Regex("[^a-zA-Z]");
            substr = rgx.Replace(substr, "");
            if (substr == "")
            {
                return null;
            }
            
            plainLenght = substr.Length;
            int mainind = 0;
            StringBuilder sb = new StringBuilder();
            while (mainind < plainLenght)
            {
                string plain = substr.Substring(mainind, Math.Min(plainLenght - mainind, N * N));
                mainind += N * N;
                int ind = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        cypher_text[nextRep[j].Item1, nextRep[j].Item2] = plain[ind];
                        ind++;
                        if (ind >= plain.Length)
                        {
                            plain = EN_alphabet;
                            ind = 0;
                        }
                    }
                    rotateGrid();
                }

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        sb.Append(cypher_text[i, j]);
                    }
                }
            }

            string res = sb.ToString();
            string add = "";
            if (res.Length > plainLenght)
            {
                add = res.Substring(plainLenght, res.Length - plainLenght);
            }
            sb.Clear();
            mainind = 0;
            for (int i = 0; i < MAIN.Length; i++)
            {
                if ((MAIN[i] >= 'a' && MAIN[i] <= 'z') || (MAIN[i] >= 'A' && MAIN[i] <= 'Z'))
                {
                    sb.Append(res[mainind++]);
                }
                else
                {
                    sb.Append(MAIN[i]);
                }
            }
            if (add != "")
            {
                sb.Append(add);
            }
            return sb.ToString();
        }

        private static void InitArray(string str)
        {
            Array.Clear(cypher_text);
            int ind = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    cypher_text[i, j] = str[ind++];
                }
            }

        }

        public static string? decrypt(string plain)
        {
            
            string substr = plain;
            Regex rgx = new Regex("[^a-zA-Z]");
            substr = rgx.Replace(substr, "");
            if (substr == "")
            {
                return null;
            }

            plainLenght = substr.Length;
            int mainind = 0;
            StringBuilder sb = new StringBuilder();
            while (mainind < plainLenght)
            {
                string temp = substr.Substring(mainind, Math.Min(plainLenght - mainind, N * N));
                mainind += N * N;
                InitArray(temp);

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        sb.Append(cypher_text[nextRep[j].Item1, nextRep[j].Item2]);
                    }
                    rotateGrid();
                }
            }

            string res = sb.ToString();
            sb.Clear();
            mainind = 0;
            for (int i = 0; i < plain.Length; i++)
            {
                if ((plain[i] >= 'a' && plain[i] <= 'z') || (plain[i] >= 'A' && plain[i] <= 'Z'))
                {
                    sb.Append(res[mainind++]);
                }
                else
                {
                    sb.Append(plain[i]);
                }
            }
            return sb.ToString();
        }
    }
}
