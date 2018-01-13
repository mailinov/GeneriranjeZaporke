using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriranjeZaporke
{
    class Class1
    {
        public static string GeneratePassword(bool prvi, bool drugi, bool treci, object broj)
        {
            //int lowercase = 2;
            //int uppercase = 2;
            //int numerics = 2;
            //int znak = 2;    
            int m = Convert.ToInt32(broj);

            string lowers = "abcdefghijklmnopqrstuvwxyz";
            string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string number = "0123456789";
            string znakovi = "*$-+?_&=!%{}/";

            Random random = new Random();
          
            string generated = "";
            string generated2 = "";
            string generated3 = "";
            string generated4 = "";
            string generated5 = "";

            for (int i = 1; i <= m; i++)
                generated = generated.Insert(
                    random.Next(generated.Length),
                    lowers[random.Next(lowers.Length - 1)].ToString()
                );
            

            for (int i = 1; i <= m; i++)
                generated = generated.Insert(
                    random.Next(generated.Length),
                    uppers[random.Next(uppers.Length - 1)].ToString()
                );

            for (int i = 1; i <= m; i++)
                generated2 = generated2.Insert(
                    random.Next(generated2.Length),
                    number[random.Next(number.Length - 1)].ToString()
                );
            for (int i = 1; i <= m; i++)
                generated3 = generated3.Insert(
                    random.Next(generated3.Length),
                    znakovi[random.Next(znakovi.Length - 1)].ToString()
                );
            for (int i = 1; i < m; i++)
            {
                if (random.Next(1000) % 2 == 0)
                    generated5 += generated[i];
                else
                {

                    generated5 += generated2[i];
                }
            }
            //return generated;//.Replace("!", string.Empty);



            if (prvi && drugi)
            {
                return generated5;
            }
            else if (prvi)
            {
                return generated = generated.Substring(0, m);
            }
            else if (drugi)
            {
                return generated2;
            }
            else if (treci)
            {
                return generated3;
            }
            
            else
            return generated4 = (string.Concat(generated, generated2, generated3));
 
        }
    }
}
