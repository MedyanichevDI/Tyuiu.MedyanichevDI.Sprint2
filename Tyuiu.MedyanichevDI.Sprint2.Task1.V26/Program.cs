using Tyuiu.MedyanichevDI.Sprint2.Task1.V26.Lib;

namespace Tyuiu.MedyanichevDI.Sprint2.Task1.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Медяничев Д.И. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #12                                                              *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=,          *");
            Console.WriteLine("*последовательность можно чередовать, но использовать один раз в выражении)*");
            Console.WriteLine("*и логических операций (|, &, ||, &&, !, ^, последовательность            *");
            Console.WriteLine("*операций не должна нарушаться), а также арифметических выражений,        *");
            Console.WriteLine("*которая вернет логическую последовательность(массив):                    *");
            Console.WriteLine("* (True, True, True, False, True, False)                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* a = 654, b = 671, c = 874, d = 137                                                       *");
            Console.WriteLine("***************************************************************************");

            //string k;

            //Console.WriteLine("Введите значение предложение:");
            //k = Convert.ToString(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int a = 654;
            int b = 671;
            int c = 874;
            int d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);

            }





            Console.ReadKey();
        }
    }
}
