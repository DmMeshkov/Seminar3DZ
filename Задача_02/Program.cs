// Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N

void sqrtN (int N)
{
    int Count = 1;
    while (Count <= N)
    {
        int sqrt = Count*Count;
        Console.WriteLine(sqrt);//ecли WriteLine, то Console.WriteLine(sqrt+ "")
        Count++;
    }
}
Console.Write("Input Digit: ");
int n = Convert.ToInt32(Console.ReadLine());
sqrtN(n);