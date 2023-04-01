// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


// string checkparalindrome(int number)
// {
//     if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10);
// }


int N = Read(); // присваиваем введеное число переменной

// Вводим число
int Read()
{
    System.Console.WriteLine("Введите пятизначное число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

 void CheckParalindrome()
 {
    if (Check(N))
    {
        System.Console.WriteLine("Да");
         if(CheckParal(N))
         {
              System.Console.WriteLine("Да, это число является паралиндромом!");
         }
         else 
         {
             System.Console.WriteLine("Нет, число не является паралиндромом!");
         }
    }
    else
    {
        System.Console.WriteLine("Ну это же не пятизначное число:)");
    }
}

bool Check(int N)
{
    return 9999 < N && N < 100000;
}

bool CheckParal(int N)
{
    return ((N / 10000 == N % 10) && (N / 1000 % 10 == N % 100 / 10));
}
CheckParalindrome();