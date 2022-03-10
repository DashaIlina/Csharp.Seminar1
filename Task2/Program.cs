
Console.WriteLine("Введите 2 числа: ");
Console.Write("Ведите 1 число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите 2 число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2)
{
    Console.WriteLine(num1 + " является меньше " + num2 );
}
else if (num1 == num2)
{
    Console.WriteLine(num1 + " равно " + num2);
}
else 
{
    Console.WriteLine(num1 + " является больше " + num2);
}
