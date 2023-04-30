// Напишите программу, которая выводи случайное число из отрезка
// [10,99] и показывет наибольшую цифру числа  10, 99+1
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit)
// {
//                       Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// }
// else
// {
//                       Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");
// }



// int maxDigit =firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit1 = MaxDigit(58);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit1}");



int MaxDigit(int num)
{
                      int firstDigit = num / 10;
                      int secondDigit = num % 10;
                      int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
                      return maxDigit;
}

