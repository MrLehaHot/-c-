using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Суть проекта (видео): Создать ввод пароля с ограниченным количеством попыток
            // Проект чуть усовершенствован, добавлен ввод пароля.
            // Я выключил видео и даже туда не смотрел. Думаю я сделал всё прекрасно!)
            // Коментарии поставлены для GitHub
            
            // Проект: Консольное приложение (.NET Framework)

            string userPassword; // Переменная для хранения пароля пользывателя

            bool loop1 = true, loop2 = false; // Переменные для хранения состояний выполнения цыкла, что-бы не перебрасывало на цыкл при выходе.

            while (loop1)
            {
                string password, passwordConfirm; // Пароль который ввёл польватель при создании его, подтверждение.
                Console.Write("Введите пароль который вы хотите: ");

                password = Console.ReadLine(); // Записываем первый пароль

                Console.Write("Подвердите введённый пароль, если хотите придумать новый, напишите здесь всё, что угодно: ");
                passwordConfirm = Console.ReadLine(); // Записываем подверждение

                if (password == passwordConfirm) // Сравниваем первый пароль и второй пароль
                {
                    Console.WriteLine("Мы запомнили ваш пароль! Что-бы продолжить нажмите любую клавишу:");
                    userPassword = password; // Пароль пользывателя
                    Console.WriteLine($"Если что ваш пароль: {userPassword}");
                    loop1 = false; // Выключаем первый цыкл
                    loop2 = true; // Включаем второй цыкл
                    Console.ReadKey();
                } else
                {
                    Console.WriteLine("Пароли не совпадают!");
            }

            userPassword = password;
            int attempts = 3; // Количество попыток
            
            while (loop2)
            {
                    string loginUserPassword; // Переменная для поля с вводом пароля
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Введите ваш пароль: ");
                    loginUserPassword = Console.ReadLine();

                    if (loginUserPassword == userPassword) { // Если введёный пароль равен паролу который создал пользыватель
                        Console.WriteLine("Проходите, пароль верен!");
                        Console.WriteLine("Что бы выйти из программы, нажмите любую клавишу:");
                        Console.ReadKey();
                        break;
                    } else {
                        attempts--; // Уменьшаем количество попыток
                        Console.WriteLine($"Пароль неверен. Осталось попыток: {attempts}");
                    }

                    if (attempts == 0) // Если не осталось попыток
                    {
                        Console.WriteLine("Попытки закончились( Приходите ещё.");
                        Console.WriteLine("Что-бы продолжить нажмите любую клавишу:");
                        Console.ReadKey();
                        break;
                    }
            }

            // Учусь по видео: Роман сакутин, Весь c# в одном ролике (https://www.youtube.com/watch?v=w8rRhAup4kg)
            // Практическая задача на тайм коде: 1:55:37
            // Делал не по видео, есть костыли и т.д )
            }
        }
    }
}
