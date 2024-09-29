using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MedyanichevDI.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            float ost = 0;
            float z = (k % 7.0f);
            
            string vi = "";

            switch(z)
            {
                case 1:
                    vi = "Понедельник";
                    break;
                case 2:
                    vi = "Вторник";
                    break;
                case 3:
                    vi = "Среда";
                    break;
                case 4:
                    vi = "Четверг";
                    break;
                case 5:
                    vi = "Пятниц";
                    break;
                case 6:
                    vi = "Суббота";
                    break;
                case 0:
                    vi = "Воскресенье";
                    break;
                default:
                    throw new ArgumentException($"День должен быть от 1 до 365. Значение {k}");
            }
            return vi;
        }
    }
}
