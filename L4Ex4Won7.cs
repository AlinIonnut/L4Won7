//Scrieti o functie care pentru un numar “n” primit ca parametru, va afisa urmatoarea piramida a numerelor:
//1
//2 2
//3 3 3
//4 4 4 4
//…
//n n n ….. n

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

PrintNumberPyramid(number);

void PrintNumberPyramid(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}