﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriranjeZaporke
{
    class Class1
    {
        public static string GeneratePassword(int lowercase, int uppercase, int numerics, int znak)
        {
            string lowers = "abcdefghijklmnopqrstuvwxyz";
            string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string number = "0123456789";
            string znakovi = "*$-+?_&=!%{}/";

            Random random = new Random();
          
            string generated = "!";
            
            for (int i = 1; i <= lowercase; i++)
                generated = generated.Insert(
                    random.Next(generated.Length),
                    lowers[random.Next(lowers.Length - 1)].ToString()
                );

            for (int i = 1; i <= uppercase; i++)
                generated = generated.Insert(
                    random.Next(generated.Length),
                    uppers[random.Next(uppers.Length - 1)].ToString()
                );

            for (int i = 1; i <= numerics; i++)
                generated = generated.Insert(
                    random.Next(generated.Length),
                    number[random.Next(number.Length - 1)].ToString()
                );
            for (int i = 1; i <= znak; i++)
                generated = generated.Insert(
                    random.Next(generated.Length),
                    znakovi[random.Next(znakovi.Length - 1)].ToString()
                );

            return generated.Replace("!", string.Empty);

        }
    }
}
