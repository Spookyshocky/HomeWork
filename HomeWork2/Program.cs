Console.WriteLine("Введите первое число: ");
 int num1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите второе число: ");
 int num2 = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите третье число: ");
 int num3 = int.Parse(Console.ReadLine());
 
int max = num1;
Console.Write("Максимально число равно: ");
if (max>num2)
{
 
}
else 
{
   max = num2;
}
if (max<num3)
{
    max = num3;
}
Console.WriteLine(max);
