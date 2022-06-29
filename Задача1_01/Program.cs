//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
void FindCoord(int N)
{
    if (N==1) Console.WriteLine("X>0,Y>0");
    if (N==2) Console.WriteLine("X<0,Y>0");
    if (N==3) Console.WriteLine("X<0,Y<0");
    if (N==4) Console.WriteLine("X>0,Y<0");
    if (N<1 || N>4) Console.WriteLine("Такой четверти не существует");
}
Console.WriteLine("Введите номер четверти ");
int n = Convert.ToInt32(Console.ReadLine());
FindCoord(n);