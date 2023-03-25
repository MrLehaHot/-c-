using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Суть проекта - создать без помощи видео игру "Угадай число"
            // Взял идею проекта с канала романа сакутина. (В прошлой практике есть ссылка на его видео)
            // Коментарии добавленны для GitHub

            Random NumberGenerator = new Random(); // Создаём новый генератор числ
            int RandomNumber = NumberGenerator.Next(0, 101); // Генерируем число от 0 до 100

            int UserNumber; // Для ввода числа

            int Attems = 0; // Количество попыток

            while (true)
            {
                Console.Write("Введи число от 0 до 100: ");
                UserNumber = Convert.ToInt32(Console.ReadLine());
                if (UserNumber == RandomNumber) 
                {
                    Console.WriteLine($"Прямо в точку!!! Вы угадали за {Attems} попыток.");
                    Console.WriteLine("Что-бы продолжить нажмите на любую клавишу: ");
                    Console.ReadKey();
                    break;
                } 
                else if (UserNumber > RandomNumber)
                {
                    Console.WriteLine("Это больше задоного числа");
                    Attems++;
                }
                else if (UserNumber < RandomNumber)
                {
                    Console.WriteLine("Это меньше задоного числа");
                    Attems++;
                }
            }

            // Добавленно: Мне кажется что у меня игра лучше чем в ролике)
        }
    }
}
