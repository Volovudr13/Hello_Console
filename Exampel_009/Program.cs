/*
int Shownumber(int n)
{
    
    int firstNum = n/10;
    int secondNum = n%10;

    Console.Write(n + " -> " );
    if (n/10 > n%10)
    {
        Console.Write(firstNum);
        return firstNum;
    }
    else
    {
        Console.Write(secondNum);
        return secondNum;
    }
    
}

int num = new Random(). Next (10,99);
int a = Shownumber(num);
Console.WriteLine (a);
*/

/*

// Task 1:

int ThreeNumb()
{
    int num = new Random().Next(100,999);
    Console.Write(num + " => ");
    int num1 = num / 100;
    int num2 = num % 10; 
    return num1*10+num2;
}

int q = ThreeNumb();
Console.Write(q);

*/

// Task 2:

/*

void taskTwo()
{
    Console.WriteLine("Input first number");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input second number");
    int b = Convert.ToInt32(Console.ReadLine());

    if(a % b ==0)
    {
        Console.Write(a + " Is multiple "  + b);
       
    }
    else
    {
       Console.Write(a + " Is not multiple "  + b); 
    }
}
taskTwo();
*/

// Task 3:
/*
void TwoNum()
{
    Console.WriteLine("Input your number");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 7 == 0 & num % 23 == 0)
    {
        Console.Write (num +  " Is multiple of 7 and 23!");
    }
    else
    {
        Console.Write (num +  " Is not multiple of 7 and 23!");
    }
}

TwoNum();
*/


// Task 4:

void Sqrd(int r, int g)
{
    if (r == g*g)
    {
        Console.WriteLine(r + " Is squer of  " + g);
    }
    else
    {
        Console.WriteLine(r + " Is not squer of  " + g);
    }
}
Console.WriteLine("Input first number ");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number ");
int g = Convert.ToInt32(Console.ReadLine());
Sqrd(r, g);