using Tyuiu.MedyanichevDI.Sprint2.Task4.V4.Lib;

namespace Tyuiu.MedyanichevDI.Sprint2.Task4.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Медяничев Д.И. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая вычисляет требуемое значение с использованием*");
            Console.WriteLine("*тернарного оператора, где пользователь вводит значение переменных x,y,z  *");
            Console.WriteLine("*c клавиатуры                                                             *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*x+2<y, то z = sin(x)+2y, иначе cos(y)+2xy                                *");
            Console.WriteLine("***************************************************************************");

            //string k;

            Console.WriteLine("Введите значение предложение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение предложение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x,y));





            Console.ReadKey();
        }
    }
}
