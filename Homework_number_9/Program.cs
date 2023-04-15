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
            const string StopCommand = "Exit";
            bool isExit = false;
            string inputText;

            Console.WriteLine($"Для остановки ведите команду : {StopCommand}");

            while (isExit == false)
            {
                Console.Write("Укажите текст: ");
                inputText = Console.ReadLine();

                if (inputText == StopCommand)
                {
                    isExit = true;
                }

                Console.Clear();
                Console.WriteLine($"Вы вели: {inputText}");
            }
        }
    }
}
