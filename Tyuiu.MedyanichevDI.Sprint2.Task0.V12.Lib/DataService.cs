using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MedyanichevDI.Sprint2.Task0.V12.Lib
{
    public class DataService : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            
            bool[] arr = new bool[6];
            arr[0] = x != y;
            arr[1] = x == y;
            arr[2] = x > y;
            arr[3] = x < y;
            arr[4] = x >= y;
            arr[5] = x <=y;
            return arr;
        }
    }
}
