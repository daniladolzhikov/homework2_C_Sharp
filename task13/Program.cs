// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. Через строку решать нельзя.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (num < 100)
    Console.WriteLine("Третья цифра отсутствует");

else
{
    while (num > 999)
    {
        num = num / 10;
    }
    result = num % 10;
    Console.WriteLine(result);
}
