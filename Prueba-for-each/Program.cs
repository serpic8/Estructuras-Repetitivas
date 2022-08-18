int[] valores;
valores = new int[9] { 3, 5, 6, 7, 8, 9, 1, 5, 5 };
string[] paises = new string[3] {"Nicaragua","Cuba","Venezuela"};

int total = 0;
foreach(int i in valores)
{
    total += i;
    Console.WriteLine(" {0} ", i);
}
Console.WriteLine("Total: " + total);

int[,] numeros = new int[2, 2] { { 5, 2 }, { 2, 3 } };
numeros[2, 1] = 10;

foreach(int i in numeros)
{
    Console.WriteLine(" {0} ",i);

}

Console.WriteLine(valores.Length);

int[][] matriz = new int [3][];







