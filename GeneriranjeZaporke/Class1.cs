using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriranjeZaporke
{
    class Class1
    {

        public static T[] Randomize<T>(T[] source)
        {
            List<T> randomized = new List<T>();
            List<T> original = new List<T>(source);
            Random r = new Random();
            for (int size = original.Count; size > 0; size--)
            {
                int index = r.Next(size);
                randomized.Add(original[index]);
                original[index] = original[size - 1];
            }
            return randomized.ToArray();
        }


        public static string GeneratePassword(bool first, bool second, bool third, int passwordLength)
        {
            string lowers = "abcdefghijklmnopqrstuvwxyz";
            string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string number = "0123456789";
            string sign = "*$-+?_&=!%{}/";


            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789*$-+?_&=!%{}/";

            char[] chars = new char[passwordLength];

            Random rd = new Random();
            
            for (int i = 0; i < passwordLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }


            if (first && second && third)
            {
                chars[0] = lowers[rd.Next(0, lowers.Length)];
                chars[1] = uppers[rd.Next(0, lowers.Length)];
                chars[2] = number[rd.Next(0, number.Length)];
                chars[3] = sign[rd.Next(0, sign.Length)];

                return new string(Randomize(chars));
            }

            else if (first && second)
            {
                chars[0] = lowers[rd.Next(0, lowers.Length)];
                chars[1] = uppers[rd.Next(0, lowers.Length)];
                chars[2] = number[rd.Next(0, number.Length)];

                return new string(Randomize(chars));
            }

            else if (first && third)
            {
                chars[0] = lowers[rd.Next(0, lowers.Length)];
                chars[1] = uppers[rd.Next(0, lowers.Length)];
                chars[2] = sign[rd.Next(0, sign.Length)];

                return new string(Randomize(chars));
            }

            else if (first)
            {
                chars[0] = lowers[rd.Next(0, lowers.Length)];
                chars[1] = uppers[rd.Next(0, lowers.Length)];

                return new string(Randomize(chars));
            }
            else if (second)
            {
                chars[0] = number[rd.Next(0, number.Length)];
                return new string(Randomize(chars));
            }

            else
            {
                chars[0] = sign[rd.Next(0, sign.Length)];
                return new string(Randomize(chars));
            }
        }

    }
    }

