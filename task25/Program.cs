// // Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

int Enter(string n) {
   Console.WriteLine ($"Введите число {n}:");
   return Convert.ToInt32(Console.ReadLine());
}
int a = Enter("A");
int b = Enter("B");

int Decision (int num1, int num2) 
{
   int num3 = 1;
   int i = 0;
   while (i < num2)
   {
      num3 = num3 * num1;
      i++;
   }
   return num3;
}

Console.WriteLine(Decision (a, b));

