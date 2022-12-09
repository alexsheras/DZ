Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int n = 0;
if (a<=99)
{
   Console.WriteLine("Нет третьего числа"); 
}
else
{
do a = a / 10; 
while (a > 999);
n = a%10;
Console.WriteLine(n);
}