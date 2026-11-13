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
        public Shareholding(string firstInvestment)
        {
            int size = 100;
            string[] names = new string[size];
            double[] sums = new double[size];
            int count = 0;

            names[count] = firstInvestment;

            Console.WriteLine("Введите, сколько хотите инвестировать (число):");
            sums[count] = Convert.ToDouble(Console.ReadLine());
            count++;

            Console.WriteLine("Будете инвестировать еще в какие-либо акции?\n[да/нет]");
            string answer = Console.ReadLine().ToLower();

            while (answer == "да")
            {
                Console.WriteLine("Куда будете инвестировать?");
                names[count] = Console.ReadLine();

                Console.WriteLine("Введите, сколько хотите инвестировать (число):");
                sums[count] = Convert.ToDouble(Console.ReadLine());
                count++;

                Console.WriteLine("Будете инвестировать еще?\n[да/нет]");
                answer = Console.ReadLine().ToLower();
            }
            double startTotalSum = 0;
            for (int i = 0; i < count; i++)
            {
                startTotalSum += sums[i];
            }
            Console.WriteLine($"\nНачальная общая сумма вашего портфеля = {startTotalSum}руб\n");

            Random rnd = new Random();
            double totalSum = 0; 

            for (int i = 0; i < count; i++)
            {
                int eventnumber = rnd.Next(1, 5); 

                if (eventnumber == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($"Ваши акции «{names[i]}» упали в цене на 10%");
                    Console.ForegroundColor = ConsoleColor.Black;
                    sums[i] = sums[i] * 0.9;
                }
                if (eventnumber == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($"Ваши акции «{names[i]}» упали в цене на 30%");
                    Console.ForegroundColor = ConsoleColor.Black;
                    sums[i] = sums[i] * 0.7;
                }
                if (eventnumber == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write($"Ваши акции «{names[i]}» поднялись в цене на 20%");
                    sums[i] = sums[i] * 1.2;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                if (eventnumber == 4)
                {
                    Console.Write($"Спустя месяц ваши акции «{names[i]}» не изменились в цене");
                }
                Console.WriteLine($"\nВаш портфель ({names[i]}) = {sums[i]}руб");

                totalSum += sums[i];
            }

            Console.WriteLine($"\nОбщая сумма вашего портфеля = {totalSum}руб");
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
                    Shareholding shareholding = new Shareholding(investment);
                    Console.WriteLine("\nхотите еще раз запустить программу и инвестировать свои деньги в акции?\n[да/нет]");
                    answer = Convert.ToString(Console.ReadLine()).ToLower();
                }
            }
        }
    }
}
