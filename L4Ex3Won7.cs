//Ex 3: Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n m, 
//respectiv m, n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la tastaura. 
//Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati matricea rezultata

Console.WriteLine("Enter the values for the matrix elements: ");

var matrix = ReadArray();
ShowArray(matrix);

int[,] ReadArray()
{
    int m = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());

    int[,] firstMatrix = new int[m, n];
    int[,] secondMatrix = new int[n, m];

    Console.WriteLine("Enter the values for the first matrix: ");

    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            firstMatrix[i, j] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
    }

    Console.WriteLine("Enter the values for the second matrix: ");

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            secondMatrix[i, j] = int.Parse(Console.ReadLine());
        }
    }

    Console.WriteLine("The sum of the matrix is: ");

    return MultiplyMatrices(firstMatrix, secondMatrix);

}

void ShowArray(int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);

    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    int n = firstMatrix.GetLength(0);
    int m = secondMatrix.GetLength(1);
    int[,] result = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }

    return result;
}