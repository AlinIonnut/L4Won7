// Cititi de la tastatura continutul unei matrici de intregi cu 2 dimensiuni avand lungimile m, n. 
//Lungimile celor doua dimensiuni ale matricii, m si n, vor fi citite de la tastaura. 
// Scrieti o functie care va afisa continutul unei astfel de matrici si apelati-o.
// Scrieti o functie care va aduna doua matrici, apelati-o si afisati rezultatul.


var firstMmatrix = ReadArray();
ShowArray(firstMmatrix);
var secondMmatrix = ReadArray();
ShowArray(secondMmatrix);
SumArray(firstMmatrix, secondMmatrix);


int[,] ReadArray()
{
    Console.WriteLine("Enter the dimensions of the array, n and m: ");
    int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());

    int[,] array = new int[n, m];

    Console.WriteLine("Enter the values inside the array: ");

    for (int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            array[i,j] = int.Parse(Console.ReadLine());
        }
    }
    return array;
}

void ShowArray(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);

    for(int i = 0; i < n; ++i)
    {
        for(int j = 0; j<m ; ++j)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SumArray(int[,] firstMatrix, int[,] secondMatrix)
{
    int n = firstMatrix.GetLength(0);
    int m = firstMatrix.GetLength(1);

    int[,] result = new int[n,m];

    for (int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            result[i,j] = firstMatrix[i,j] + secondMatrix[i,j];
        }
    }
    Console.WriteLine("The sum is: ");
    ShowArray(result);

    return result;
}
