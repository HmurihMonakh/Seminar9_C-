// int Factorial(int n)
// {
//     if (n==1) return 1;
//     {
//         return n* Factorial(n-1);//  4 * Factorial(3)
//     }
// }

// 4-> 1 *2 *3 *4
// 4 * 3 * 2 * Factorial(1)

//Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PrintNumber(1, N));

// string PrintNumber(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumber(start + 1, end));
// }

///////////////////////////////////
// **Задача 65:** Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

// Console.WriteLine("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PrintNumber(M, N));

// string PrintNumber(int start, int end)
// {
//     if (start == end) return start.ToString();
   
//     return (start + " " + PrintNumber(start + 1, end));
    
// }

// **Задача 67:** Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.

// 453 -> 12

// 45 -> 9

// Console.WriteLine("Введите число n:");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumNum(int n)
// {
//     if (n == 0) return 0;
//     else return n % 10 + SumNum(n / 10);

// }
// Console.WriteLine(SumNum(n));




// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8

// Console.WriteLine("Введите число A:");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B:");
// int B = Convert.ToInt32(Console.ReadLine());
// int PowerRec(int A, int B)
// { 
//     if (B == 0) return 1;
//     else return PowerRec(A, B - 1) * A;
// }
// Console.WriteLine(PowerRec(A,B));



// задача 68 Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}