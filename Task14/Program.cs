// Напишите программу, которая принимает на вход два числа 
// и проверяет, кратно ли оно одновременно 7 и 23
// 14 -> Нет
// 161 -> да
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Multiplicity(number);
Console.WriteLine(result ? "Да" : "Нет");

bool Multiplicity(int num)
{
    return num % 7 == 0 && num % 23 == 0;                 
}