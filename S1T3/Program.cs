/*
Задача 3: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
*/

Console.Write("Введите число  ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;
if(result != 0) 
    Console.Write("Не четное");
else
    Console.Write("Четное");    

