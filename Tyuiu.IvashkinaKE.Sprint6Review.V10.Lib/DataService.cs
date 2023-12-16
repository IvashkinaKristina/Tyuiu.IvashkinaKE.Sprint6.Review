using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tyuiu.IvashkinaKE.Sprint6Review.V10.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int c, int k, int l)
        {
            int min = int.MaxValue; for (int i = k - 1; i <= l - 1; i++)
            {
                if (i % 2 == 0)
                {
                    if (array[i, c - 1] < min)
                    {
                        min = array[i, c - 1];
                    }
                }
            }
            return min;
        }
    }
}

