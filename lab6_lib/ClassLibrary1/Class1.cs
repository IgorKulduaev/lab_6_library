using System.Net.Http.Headers;
using System.Numerics;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int bewbebe(int[,] mas)
        {
            int Product = 1;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] % 2 != 0)
                    {
                        Product *= mas[i, j];
                    }
                }
            }
            return Product;
        }
    }
}


