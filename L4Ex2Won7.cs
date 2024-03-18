//Ex 2: Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m k. 
//Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura. 
// Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i rezultatul. 
// Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i rezultatul.

using System;

var firstMatrix = ReadArray();
ShowArray(firstMatrix);
var secondMatrix = ReadArray();
ShowArray(secondMatrix);
var thirdMatrix = ReadArray();
ShowArray(thirdMatrix);
SumArray(firstMatrix, secondMatrix, thirdMatrix);
MaxValueOfMatrix(firstMatrix);

int[,,] ReadArray()
{
    Console.WriteLine("Enter the dimensions of the array, n, m and k: ");
    int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    int k = int.Parse(Console.ReadLine());

    int[,,] matrix = new int[n, m, k];

    Console.WriteLine("Enter the values inside the array: ");

    for (int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            for (int l = 0; l < k; l++)
            {
                matrix[i,j,l] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }
    return matrix;
}

void ShowArray(int[,,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    int k = matrix.GetLength(2);

    for (int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            for(int l = 0; l < k; l++)
            {
                Console.Write(matrix[i, j, l] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] SumArray(int[,,] firstMatrix, int[,,] secondMatrix, int[,,]thirdMatrix)
{
    int n = firstMatrix.GetLength(0);
    int m = firstMatrix.GetLength(1);
    int k = firstMatrix.GetLength(2);

    int[,,] result = new int[n, m, k];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for(int l = 0; l < k; l++)
            {
                result[i, j, l] = firstMatrix[i, j, l] + secondMatrix[i, j, l] + thirdMatrix[i,j,l];
            }
        }
    }
    Console.WriteLine("The sum is: ");
    ShowArray(result);

    return result;
}

int MaxValueOfMatrix(int[,,] matrix)
{
    int maxValue = int.MinValue;

    foreach(var element in matrix)
    {
        if(maxValue < element)
        {
            maxValue = element;
        }
    }
    Console.WriteLine("The biggest value is: " + maxValue);
    return maxValue;
}