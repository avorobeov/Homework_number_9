using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_9
{
    class Program
    {
        static void Main(string[] args)
        {
            const string STOP_COMMAND = "Exit";
            bool isExit = false;
            string imputText;

            Console.WriteLine($"Для остановки ведите команду : {STOP_COMMAND}");

            while (isExit == false)
            {
                Console.Write("Укажите текст: ");
                imputText = Console.ReadLine();

                if (imputText == STOP_COMMAND)
                {
                    isExit = true;
                }

                Console.Clear();
                Console.WriteLine($"Вы вели: {imputText}");
            }
        }
    }
}
