string x = "Southville International School and Colleges";
string[] y = x.Split(' ');

for (int i = 0; i < y.Length; i++)
{
    for (int j = 0; j < y[i].Length; j++)
    {
        Console.WriteLine(y[i][j]);
    }
    Console.ReadKey();
}
