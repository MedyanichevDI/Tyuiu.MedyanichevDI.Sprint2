using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MedyanichevDI.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a<c)|(b>+d);
            res[1] = (a>d)&(c!=b);
            res[2] = (a<c)||(b!=c);
            res[3] = (a==b)&&(c!=d);
            res[4] = !(b<d);
            res[5] = (a>d)^(c>b);
            return res;
        }
    }
}
