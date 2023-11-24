// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число n");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m");
int numberM = Convert.ToInt32(Console.ReadLine());

int Akerman(int numberN, int numberM) {
if (numberN == 0) return numberM + 1; 
 

  else
  {
      if((numberN != 0) && (numberM == 0)) return Akerman(numberN - 1, 1);
      

      else
      {
          return Akerman(numberN - 1, Akerman(numberN, numberM - 1));
          
      }
}
}
int resalt = Akerman(numberN, numberM);
Console.WriteLine(resalt);
