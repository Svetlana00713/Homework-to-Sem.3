// Задача 19
//Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string aTxt = Convert.ToString(a);
char[] ar = aTxt.ToCharArray();
Array.Reverse(ar);
aTxt = new String(ar);
int b = Convert.ToInt32(aTxt);
if(a - b == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
};