using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriranjeZaporke
{
    class Class1
    {
        public static string GeneratePassword(bool prvi, bool drugi, bool treci, int passwordLength)
        {
            string lowers = "abcdefghijklmnopqrstuvwxyz";
            string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string number = "0123456789";
            string znakovi = "*$-+?_&=!%{}/";


            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789*$-+?_&=!%{}/";

            char[] chars = new char[passwordLength];

            Random rd = new Random();



            for (int i = 0; i < passwordLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }


            if (prvi && drugi && treci)
            {
                chars[0] = lowers[rd.Next(0, lowers.Length)];
                chars[1] = uppers[rd.Next(0, lowers.Length)];
                chars[2] = number[rd.Next(0, number.Length)];
                chars[3] = znakovi[rd.Next(0, znakovi.Length)];

                return new string(chars);
            }

            else if (prvi && drugi)
            {
                chars[0] = lowers[rd.Next(0, lowers.Length)];
                chars[1] = uppers[rd.Next(0, lowers.Length)];
                chars[2] = number[rd.Next(0, number.Length)];

                return new string(chars);
            }

            else if (prvi && treci)
            {
                chars[0] = lowers[rd.Next(0, lowers.Length)];
                chars[1] = uppers[rd.Next(0, lowers.Length)];
                chars[2] = znakovi[rd.Next(0, znakovi.Length)];

                return new string(chars);
            }

            else if (prvi)
            {
                chars[0] = lowers[rd.Next(0, lowers.Length)];
                chars[1] = uppers[rd.Next(0, lowers.Length)];
                return new string(chars);
            }
            else if (drugi)
            {
                chars[0] = number[rd.Next(0, number.Length)];
                return new string(chars);
            }

            else
            {
                chars[0] = znakovi[rd.Next(0, znakovi.Length)];
                return new string(chars);
            }
        }

    }
    }

