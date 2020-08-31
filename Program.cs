using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "exit";
            string userInput;
            bool enterOrExit = true;

            while (enterOrExit)
            {
                Console.Write("Для выхода из программы введите exit : ");
                userInput = Console.ReadLine();

                if(exit == userInput)
                {
                    enterOrExit = false;                    
                }
                Console.WriteLine("Вы ввели другое слово или фразу.");
            }
        }
    }
}
