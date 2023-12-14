// Задача 3: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.



using System;



class Program

{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int minRowIndex = 0;
        int minRowSum = int.MaxValue;

        for (int i = 0; i < array.GetLength(0); i++)

        {
       
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {

                rowSum += array[i, j];

            }

            if (rowSum < minRowSum)
            {
                minRowSum = rowSum;
                minRowIndex = i;
            }

        }
        Console.WriteLine("Строка с наименьшей суммой элементов: " + minRowIndex);
        Console.Write("Элементы строки: ");

        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[minRowIndex, j] + " ");
        
        }
        Console.ReadKey();

    }

}




      








       

           













        





      



            




            






