Console.Write("Введите номер дня недели ");

int numday = Convert.ToInt32(Console.ReadLine());

switch (numday)
{
    case 1:
        Console.Write(" Понедельник ");
        break;
    case 2:
        Console.Write(" Вторник ");
        break;
    case 3:
        Console.Write(" Среда ");
        break;
    case 4:
        Console.Write(" Четверг ");
        break;
    case 5:
        Console.Write(" Пятница ");
        break;
    case 6:
        Console.Write(" Суббота ");
        break;
    case 7:
        Console.Write(" Воскресенье ");
        break;
    default: 
        Console.Write(" Дня недели с таким номером нет ");
        break;
}