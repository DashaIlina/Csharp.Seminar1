using System;
    Console.WriteLine("Введите 2 числа: ");
    Console.Write("Ведите 1 число ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ведите 2 число ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    if (num1 == num2 * num2)
    {
        Console.WriteLine(num1 + " является квадратом " + num2);
    }   
    else 
    {
        Console.WriteLine(num1 + " не является квадратом " + num2);
    }
    

