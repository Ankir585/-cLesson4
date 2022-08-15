// Напишите метод(ы), которай задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string EnterString(string n) 
{
   Console.Write(n);
   return Console.ReadLine()!;
}
void PrintArray (int [] array)
{
   int size = array.Length;
   Console.Write("[");
   for (int i = 0; i < size-1; i++)
   {
      Console.Write($"{array[i]}, ");
   }
   
   Console.Write($"{array [array.Length-1]}]");
}

int IndexArray (string s, char c)
{
    int j = s.Length;
    
    for (int i=0; i<j; i++)
    {
      if (s[i]== c) return i; 
    }
      return -1;
}
int Count (string s, char c)
   {
      int count = 0;
      int j = s.Length;
      
      for (int i=0; i<j; i++)
      {
         if (s[i]== c) count++;
      }
      return count;
   }
string ArrayStr (string s, int c)
{
   string res = String.Empty;
   int size = s.Length;
   for (int i = c; i < size; i++)
   {
      res +=$"{s[i]}";
   }
   return res;
}
string ArrayStrL (string s, int c, int l)
{
   string res = String.Empty;
   int size = s.Length;
   for (int i = c; i < c+l; i++)
   {
      res +=$"{s[i]}";
   }
   return res;
}
int [] CommArray (string a)
{
   int [] result = new int [Count(a, ',') + 1];
   a += ",";
   int i = 0;

   while (a.Length != 0)
   {
      int pos = IndexArray(a, ',');
      string need = ArrayStrL(a, 0, pos);
      string os= ArrayStr(a, pos +1);
      a = os;

      result[i] = Convert.ToInt32(need);
      i++;
   }
   return result;
}


string str = EnterString("Введите числа через запятую: ");
int [] array = CommArray(str);
PrintArray(array);
