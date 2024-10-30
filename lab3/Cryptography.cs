using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab3
{
    static class Cryptography
    {
        static private uint p, g, x, y, k;

        static private List<uint> coPrimeK;

        static public bool CheckPrime(uint p)
        {
            if (p == 1)
                return false;
            if (p % 2 == 0)
                return p == 2;
            int d = 3;
            while (d * d <= p && p % d != 0)
                d += 2;
            return d * d > p;
        }

        static public bool CheckCoPrime(uint a, uint b)
        {
            while (a != 0 && b != 0)
            {
                if (b > a)
                    b %= a;
                else
                    a %= b;
            }
            return (a + b) == 1;
        }

        static public uint FastExponent(uint a, uint n, uint m)
        {
            uint res = 1;
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

        static private List<uint> GetPrimeDivisors(uint n)
        {
            List<uint> primeDivisors = new List<uint>();
            double border = Math.Sqrt(n);

            while (n % 2 == 0)
            {
                n /= 2;
                primeDivisors.Add(2);
            }

            for (uint i = 3; i < border; i += 2)
            {
                while (n % i == 0)
                {
                    n /= i;
                    primeDivisors.Add(i);
                }
            }
            if (n > 2)
            {
                primeDivisors.Add(n);
            }
            return primeDivisors;
        }

        static private bool CheckPrimitiveRoot(uint value, List<uint> primeDivisors)
        {
            for (int i = 0; i < primeDivisors.Count; i++)
                if (FastExponent(value, (p - 1) / primeDivisors[i], p) == 1)
                    return false;
            return true;
        }

        static public List<uint> GetPrimitiveRoots()
        {
            List<uint> divisors = GetPrimeDivisors(p - 1);
            List<uint> result = new List<uint>();
            for (uint i = 2; i < p; i++)
                if (CheckPrimitiveRoot(i, divisors))
                    result.Add(i);
            return result;
        }

        static List<uint> MakeKList(uint border, uint p)
        {
            List<uint> list = new List<uint>();
            for (uint i = 2; i < border; i++)
                if (CheckCoPrime(i, p - 1))
                    list.Add(i);
            return list;
        }

        static string? fileName;
        static string? fileExt;
        public static string encrPath = @"D:\uni\4 sem\labs\it\lab3\test files\encrypted\";
        public static string decrPath = @"D:\uni\4 sem\labs\it\lab3\test files\decrypted\";
        public static string orignalPath = @"D:\uni\4 sem\labs\it\lab3\test files\";
        public delegate void ProcessFILE();
        static public ProcessFILE? Process;

        static public void SetP(uint p_p)
        {
            p = p_p;
        }

        static public void Init(string p_fileName, bool p_enc, uint p_g, uint p_x, uint p_k)
        {
            if (p_enc)
            {
                fileName = p_fileName.Split('.')[0];
                fileExt = p_fileName.Split('.')[1];

                g = p_g;
                x = p_x;
                y = FastExponent(g, x, p);
                k = p_k;

                coPrimeK = MakeKList(p - 1, p);
                Process = Encrypt;
            }
            else
            {
                Process = Decrypt;
            }
        }

        static public void Encrypt()
        {
            byte[] buff = File.ReadAllBytes(orignalPath + fileName + "." + fileExt);
            ushort[] cipherText = new ushort[buff.Length * 2];
            Random random = new Random();
            for (int i = 0; i < buff.Length; i++)
            {
                byte m = buff[i];
                uint a = FastExponent(g, k, p);
                uint b = FastExponent(y, k, p);
                b = (b * (m % p)) % p;
                cipherText[i * 2] = (ushort)a;
                cipherText[i * 2 + 1] = (ushort)b;
                k = coPrimeK[random.Next(0, coPrimeK.Count)];
            }
            byte[] outputBytes = new byte[cipherText.Length * 2];
            Buffer.BlockCopy(cipherText, 0, outputBytes, 0, outputBytes.Length);
            File.WriteAllBytes(encrPath + fileName, outputBytes);
        }

        static public void Decrypt()
        {
            byte[] buff = File.ReadAllBytes(encrPath + fileName);
            ushort[] inputBytes = new ushort[buff.Length / 2];
            Buffer.BlockCopy(buff, 0, inputBytes, 0, buff.Length);
            byte[] plainText = new byte[inputBytes.Length / 2];
            for (int i = 0; i < inputBytes.Length / 2; i++)
            {
                ushort a = inputBytes[i * 2];
                ushort b = inputBytes[i * 2 + 1];
                uint m = ((FastExponent(a, x * (p - 2), p) * (b % p)) % p);
                plainText[i] = (byte)m;
            }
            File.WriteAllBytes(decrPath + fileName + "." + fileExt, plainText);
        }
    }
}
/*
p = 431
g = 7
x = 429
k = 41
*/ 