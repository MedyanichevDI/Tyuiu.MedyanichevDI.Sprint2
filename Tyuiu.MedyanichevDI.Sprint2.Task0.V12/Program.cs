using Tyuiu.MedyanichevDI.Sprint2.Task0.V12.Lib;

namespace Tyuiu.MedyanichevDI.Sprint2.Task0.V12
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=,          *");
            Console.WriteLine("*последовательность операций не должна нарушаться)                        *");
            Console.WriteLine("* и арифметических выражений, которая вернет                              *");
            Console.WriteLine("*логическую последовательность(массив):                                   *");
            Console.WriteLine("*(True, False, True, False, True, False)                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* x = 1095, y = 47                                                        *");
            Console.WriteLine("***************************************************************************");

            //string k;

            //Console.WriteLine("Введите значение предложение:");
            //k = Convert.ToString(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int x = 1095;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            for (int i =0; i<6; i++) {
                Console.WriteLine(res[i]);

            }
           
           
               
           

            Console.ReadKey();
        }
    }
}
