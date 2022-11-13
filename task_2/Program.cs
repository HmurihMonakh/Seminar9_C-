
/*Задача 67: Напишите программу, которая будет 
принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
int SumNum(int n)
{
    if (n == 0) return 0;
    else return n % 10 + SumNum(n / 10);

}
Console.WriteLine(SumNum(456));







