// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число");
string numText = Console.ReadLine();
int count = 0;
while(count < numText.Length)
{
    if(numText[count] == numText[numText.Length - count - 1])
    {
        count++;
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
        return;
    }
}
Console.WriteLine("Число является палиндромом");