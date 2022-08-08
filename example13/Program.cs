

string[,] table = new string[2, 5];
// String.Empty
//table [0,0]   [0,1]   [0,2]   [0,3]   [0,4] столбцы
//table [1,0]   [1,1]   [1,2]   [1,3]   [1,4] 
// строки


// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"--{table[rows, columns]}--");

//     }
// }



void PrintArray(int[,]  matr)
{

    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            Console.Write($"{matr[rows, i]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}


int[,] matrix = new int[4, 5];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
