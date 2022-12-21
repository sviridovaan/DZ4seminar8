//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
void ShowArray(int [,,] array)
{
    for (int i = 0; i <array.GetLength(0) ; i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
           for (int k = 0; k <array.GetLength(2); k++)
           {
            Console.Write($"{array[i, j ,k]} ({i}, {j}, {k})");
           }
        }
        Console.WriteLine();
    }
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int x = EnterNumber("Введите значение x: ");
int y = EnterNumber("Введите значение y: ");
int z = EnterNumber("Введите значение z: ");

int [,,] array3D = new int [x,y,z];
void CreateRandomArray(int [,,] array3D)
{
    int count = 0;
    int number;
    int [] array = new int [array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10,19);
        number = array[i];
        if (i >=1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10, 19);
                    j = 0;
                    number = array[i];
                }
                number = array[i];
            }
        }
    }
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y< array3D.GetLength(1); y++)
        {
            for (int z = 0; z<array3D.GetLength(2); z++)
            {
                array3D[x,y,z] = array[count];
                count++;
            }
        }
    }
}

CreateRandomArray(array3D);
ShowArray(array3D);


