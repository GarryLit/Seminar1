/*
Задача 2: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
*/

Console.Write("Введите первое число  ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число  ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число  ");
int numberC = Convert.ToInt32(Console.ReadLine());

// Классический алгоритм

if(numberA > numberB)
    if(numberA > numberC)
        Console.Write(numberA); 
    else
        if(numberB > numberC)
            Console.Write(numberC);
        else    
            Console.Write(numberC);
else
    if(numberB > numberC)
        Console.Write(numberB);    
    else    
        Console.Write(numberC);

//C  третьей переменной
/*
int max = numberA;
if(numberB > max)
    max = numberB;
if(numberC > max)
    max = numberC;

Console.Write(max); 
*/