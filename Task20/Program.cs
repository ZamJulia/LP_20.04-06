// 20. Напишите программу, которая принимает
// на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве
// А (3,6), В (2,1)->5.09

Console.WriteLine("Введите координаты точки А");
Console.WriteLine("x = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("x = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xA, yA, xB, yB);

Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2);
{
                      int katet1 = x1 - x2;
                      int katet2 = y2 - y1;
                      double hypo = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
                      return hypo;
}



// double d = Math.Sqrt(5);

// double num = 5.099786232;
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
// Console.WriteLine(numRound);

// double pw Math.Pow(3, 6)