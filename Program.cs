using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2._7_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            string fullName = "Сухачев Денис Владимирович";
            int age = 32;
            string email = "detrov@mail.ru";
            double progScore = 68.44;
            double mathScore = 75.32;
            double physScore = 54.27;
            string pattern = "ФИО: {0} \nВозраст: {1} \nЭлектронная почта: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";
            Console.WriteLine(pattern,
                fullName,
                age,
                email,
                progScore,
                mathScore,
                physScore);
            Console.ReadKey();

            //Задание 2
            double sum_score;
            sum_score = progScore + mathScore + physScore;
            double avg_score;
            avg_score = (progScore + mathScore + physScore) / 3;
            Console.WriteLine($"Сумма баллов: {sum_score}");
            Console.ReadKey();
            Console.WriteLine($"Среднее арифметическое баллов: {avg_score}");
            Console.ReadKey();
        }
    }
}
