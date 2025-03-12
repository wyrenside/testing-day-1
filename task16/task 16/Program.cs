//#region
//int a = int.Parse(Console.ReadLine());
//int max = 0;
//while (a > 0)
//{
//    if (max < a % 10)
//    {
//        max = a % 10;
//    }
//    a /= 10;
//}
//Console.WriteLine(max);
//#endregion

#region
int a = int.Parse(Console.ReadLine());

while (a % 2 == 0)
{
    a /= 2;
}

if (a == 1)
{
    Console.WriteLine("the given number is power of 2");
}
else
{
    Console.WriteLine("The given number is not power of 2");
}
#endregion
