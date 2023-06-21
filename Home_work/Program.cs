// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Reserve(string str){
    char[] chars = str.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}

int Numbers = Convert.ToInt32(Console.ReadLine());
string tmp = Convert.ToString(Numbers);
int Numbers1 = Convert.ToInt32(Reserve(tmp));

if(Numbers == Numbers1){
    System.Console.Write($"число {Numbers} палидром");
}
else{
    System.Console.Write($"число {Numbers} НЕ палидром");
}



