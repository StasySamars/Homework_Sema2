/*Напишите программу, которая будет принимать на вход два числа и выводить,
 является ли второе число кратным первому. 
 Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно*/

Console.Clear();

double number1 = new Random().Next(10, 100);
double number2 = new Random().Next(10, 100);

Console.WriteLine (number1);
Console.WriteLine(number2);

if (number2%number1 == 0)
{
    Console.WriteLine ("кратно");
}
else
{
    Console.WriteLine($"некратно, остаток: {number2%number1}");
}
    