// // Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] myArray = new int[8];
Random num = new Random();

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = num.Next(0, 99);
}

for (int i = 0; i <  myArray.Length; i++)
{
    Console.Write( myArray[i] +" ");
}

