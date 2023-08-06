using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Kullanıcıdan pozitif bir tamsayı girmesini isteyin 
            ve girilen sayıya kadar olan tek sayıları ekrana yazdırın 
            ve en sonda bu sayıların toplamını gösteren.
            */

            int input, last = 0;

            Console.Write("Pozitif Tam Sayı: ");
            input = int.Parse(Console.ReadLine());
            while (input >= 1)
            {
                for (int i = 1; i <= input; i++)
                {
                    Console.Write(i + " ");
                    last = last + i;
                    if (i == input)
                    {
                        Console.Write("= "+last);
                        Console.WriteLine();
                    }
                }
                break;
            }
            Console.Clear();
            Console.WriteLine("Unknow Command. \nPress any button for exit.");
            Console.ReadKey();
        }
    }
}
