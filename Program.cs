using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace felhantering1
{
    class Program
    {

        static void Main(string[] args)
        {
            int resultat;
            if (!TryParse(Console.ReadLine(), out resultat))
                Console.WriteLine("Skriva in ett tal");
        }

        public static bool TryParse(string s, out int result)
        {
            try
            {
                result = int.Parse(s);
                return  true;
            }

            catch
            {
                result = 0;
                return  false;
            }
        }
    }
}
