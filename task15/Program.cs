// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 | dayNumber == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Рабочий день");
}