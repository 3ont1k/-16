using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace раюота_16
{

    internal class Shareholding
    {
        public Shareholding()
        {
            Console.WriteLine("Введите сколько хотите инвестировать(целое число)");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Будете инвестировать еще в какие-либо акции?\n[да/нет]");
            string answer = Console.ReadLine();
            int i = 1;
            if (answer =="да")
            {
                Console.WriteLine("куда будете инвестировать?");
                string investment = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите сколько хотите инвестировать(целое число)");
                double sum[i]= Convert.ToDouble(Console.ReadLine());
                i++;
            }
            Random rnd = new Random();
            int eventnumber = rnd.Next(1, 5);
            if(eventnumber == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Ваши Акции упали в цене на 10%");
                Console.ForegroundColor = ConsoleColor.Black;
                sum = sum * 0.9;
            }
            if (eventnumber == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Ваши Акции упали в цене на 30%");
                Console.ForegroundColor = ConsoleColor.Black;
                sum = sum * 0.7;
            }
            if (eventnumber == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Ваши Акции поднялись в цене на 20%");
                sum = sum * 1.2;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            if(eventnumber == 4) 
            {
                Console.Write("Спустя месяц ваши акции ваши акции не изменились в цене");
            }
            Console.WriteLine($"\nВаш портфель = {sum}руб");
            }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Title = "пр/р 16";
            Console.Clear();
            Console.WriteLine("Добрый день!\nхотите инвестировать свои деньги в акции?\n[да/нет]");
            string answer = Convert.ToString(Console.ReadLine());
            answer = answer.ToLower();
            while (answer == "да")
            {
                Console.WriteLine("куда будете инвестировать?");
                string investment = Convert.ToString(Console.ReadLine());
                Shareholding shareholding = new Shareholding();
                break;
            }
        }
    }
}
