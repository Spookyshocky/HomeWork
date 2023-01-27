Console.WriteLine("Введите число: ");

int num = int.Parse(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + " является: нечётным");
 
}          
else
{
    Console.WriteLine("Число " + num + "является: чётным");
}