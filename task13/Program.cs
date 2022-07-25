// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int[] getNewArray(int lenghtArr)
{
int[] array = new int[lenghtArr];

for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 10);
}


return array;
}


foreach (int item in getNewArray(8))
{
Console.Write(item + " ");
}