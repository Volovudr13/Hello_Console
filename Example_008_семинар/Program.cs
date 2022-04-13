/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine("Result is " + result);
*/
// Задача 1

/*
Console.Write ("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input second intege number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;  // Можно записать и так - (num1 == num2 * num2) Не создавая переменную!
if (num1 ==quad)
{
    Console.WriteLine("First number is quad of second number"); // Команды занимающие одну строку можно не обрамлять скобками -{} !
}
else 
{
   Consolen.WriteLine("First number is not quad of second number"); 
}
*/ 
// Задача 2 

/*
Console.Write("Input number of d: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 7 || day <1)
{
    Console.WriteLine("Incorrect number of day!");
}
else
{
    if (day == 1)
        Console.WriteLine("It is Monday");
    if (day ==2)
        Console.WriteLine("It is Tuesday");



}
*/

// Задача 3


/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current;

if (num < 0)
{
    current = num;
    num = num * (-1);  //  Можно записать - int current = -1 *num; перед блоком if
}
else 
{
    current = -1 *num;
}

while(current <=num)
{
    Console.Write(current + " "); // Добавление пробела 
    current++; // Можно записать как current = current +1;

}
*/  
// Задача 4

/*
Console.Write ("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 < 100 || num1 > 999)
    Console.WriteLine("Go to sleep!");
else
{
    int a = num1 % 10;
    Console.WriteLine("Result is " + a);
}
*/
// Задача 5
