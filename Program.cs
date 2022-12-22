//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*Console.Write("input a first number:" );
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("input a seond number:" );
int num2=Convert.ToInt32(Console.ReadLine());
int max=num1;
int min=num1;
if(num1<num2)
{Console.WriteLine("максимальное число "+num2 );
Console.WriteLine("минимальное число "+num1 );
}
    else
{Console.WriteLine("максимальное число "+num1 );
Console.WriteLine("минимальное число "+num2 );
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*Console.Write("input a first number:" );
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number:" );
int num2=Convert.ToInt32(Console.ReadLine());
Console.Write("input a third number:" );
int num3=Convert.ToInt32(Console.ReadLine());
int max=num1;
if(num1>max) max=num1;
if(num2>max) max=num2;
if(num3>max) max=num3;
Console.Write("max=");
Console.WriteLine(max);*/

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*Console.Write("input a number:" );
int num=Convert.ToInt32(Console.ReadLine());
int result=num%2;
if(result==1)
{
Console.WriteLine("нечетное");
}
else
{Console.WriteLine("четное");}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*Console.Write("input a number:" );
int num=Convert.ToInt32(Console.ReadLine());
int current=2;
while(current<=num)
{
    Console.Write(current+" ");
    current=current+2;
    }
*/