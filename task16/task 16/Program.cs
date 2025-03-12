#region
int a = int.Parse(Console.ReadLine());
int max = 0;
while (a > 0)
{
    if (max < a % 10)
    {
        max = a % 10;
    }
    a /= 10;
}
Console.WriteLine(max);
#endregion

