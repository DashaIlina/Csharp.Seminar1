public class task4 
{
public static void Main(string[] args) 
{
Console.WriteLine("Проверка числа на чётность.");
Console.WriteLine("___________________________");
Console.Write("Введите целое число: ");

int num = Convert.ToInt32(Console.ReadLine()); 

if (num % 2 == 0)
{
Console.Write("Число чётное. ");
}
else 
{
Console.Write("Число нечётное. ");
}

 
}
}
