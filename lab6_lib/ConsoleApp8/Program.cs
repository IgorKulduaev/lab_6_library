using ClassLibrary1;
try
{
    int[,] myMas = new int[8, 3];
    Random rand=new Random();
    for (int i = 0;i<myMas.GetLength(0);i++)
    {
        for (int j = 0;j<myMas.GetLength(1);j++)
        {
            myMas[i, j] = rand.Next(1, 10);
            Console.Write(myMas[i,j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Произведение нечетных элементов матрицы:{ClassLibrary1.Class1.bewbebe(myMas)}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


