Console.WriteLine("Введите первое число: ");
 int num1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите второе число: ");
 int num2 = int.Parse(Console.ReadLine());
 
int max = num1;
Console.Write("Максимально число равно: ");
if (max>num2)
{
 Console.WriteLine(max);
}
else
{
    Console.WriteLine(num2);
}