using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month =DateTime.Now.Month ;

            switch (month)//expression
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız");
                    break;            
                case 3:
                    Console.WriteLine("Mart ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("nisan ayındasınız");
                    break;
                case 5:
                    Console.WriteLine("mayıs ayındasınız");
                    break;
                case 6:
                    Console.WriteLine("haziran ayındasınız");
                    break;
                case 7:
                    Console.WriteLine("temmuz ayındasınız");
                    break;
                case 8:
                    Console.WriteLine("agustos ayındasınız");
                    break;
                case 9:
                    Console.WriteLine("eylul ayındasınız");
                    break;            
                case 10:
                    Console.WriteLine("ekim ayındasınız");
                    break;
                case 11:
                    Console.WriteLine("kasım ayındasınız");
                    break;
                case 12:
                    Console.WriteLine("aralık ayındasınız");
                    break;
                default://hicbir case e uymuyorsa yapılacak ifade
                    Console.WriteLine("Yanlış veri girişi");
                break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Ayındasınız!");
                    break;
                default:
                    Console.WriteLine("Kış Ayında değilsiniz!");
                    break;
            }
        }
    }
}
