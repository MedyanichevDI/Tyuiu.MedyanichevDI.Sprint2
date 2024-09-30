using System;
using Tyuiu.MedyanichevDI.Sprint2.Task7.V2.Lib;

namespace Tyuiu.MedyanichevDI.Sprint2.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Медяничев Д.И. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор swich                                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Дано целое число k (1 <= k <= 365). Определить, каким днем недели        *");
            Console.WriteLine("*(понедельником, вторником, …, субботой или воскресеньем) является k-й    *");
            Console.WriteLine("* день не високосного года, в котором 1 января понедельник.               *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");

            //string k;

            Console.WriteLine("Введите значение предложение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение предложение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.CheckDotInShadedArea(x,y));
            Console.ReadKey();
        }
    }
}
