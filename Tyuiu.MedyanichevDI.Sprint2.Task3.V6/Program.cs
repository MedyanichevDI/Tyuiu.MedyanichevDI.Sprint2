using Tyuiu.MedyanichevDI.Sprint2.Task3.V6.Lib;

namespace Tyuiu.MedyanichevDI.Sprint2.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Медяничев Д.И. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая вычисляет требуемое значение функции Y       *");
            Console.WriteLine("*с использованием вложенных оператор if-else, где пользователь вводит     *");
            Console.WriteLine("*значение переменной X с клавиатуры. Округлить полученное значение        *");
            Console.WriteLine("*до трех знаков после запятой;                                            *");
          
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                      *");
            Console.WriteLine("***************************************************************************");

            //string k;

            Console.WriteLine("Введите значение предложение X: ");
            double x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
           Console.WriteLine(ds.Calculate(x));





            Console.ReadKey();
        }
    }
}
