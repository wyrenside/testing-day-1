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

//#region
//int a = int.Parse(Console.ReadLine());

//while (a % 2 == 0)
//{
//    a /= 2;
//}

//if (a == 1)
//{
//    Console.WriteLine("the given number is power of 2");
//}
//else
//{
//    Console.WriteLine("The given number is not power of 2");
//}
//#endregion

//int[] numbers = new int[10];
//int compositeCount = 0;
//int count = 0;

//Console.WriteLine("Insert Array:");

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < numbers.Length; i++)
//{
//    int num = numbers[i];
//    int divider = 0;

//    if (num > 1)
//    {
//        for (int j = 2; j < num; j++)
//        {
//            if (num % j == 0)
//            {
//                divider++;
//            }
//        }
//        if (divider > 0)
//        {
//            count++;
//        }
//    }
//}
//Console.WriteLine("The number of composite numbers:" + (count));

int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < numbers.Length; i++)
{
    if ((numbers[i] % 2 != 0) && (numbers[i] % 3 == 0))
    {
        Console.WriteLine(numbers[i]);
    }
}
