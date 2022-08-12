// Напишите метод, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Enter(string n) {
   Console.Write($"Введите число {n}:");
   return Convert.ToInt32(Console.ReadLine());
}

int SumNumb (int numN) {
int sum = 0;
while (numN > 0)
{
int a = numN % 10;
numN = numN / 10;
sum = sum + a;
}
return sum;
}

int a = Enter("Введите число: ");
Console.WriteLine ($"Сумма цифр в числе : {SumNumb (a)}");