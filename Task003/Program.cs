// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


int N = Read();

int Read()
{
    System.Console.WriteLine("Введите число: ");
    return int.Parse(Console.ReadLine());
}

void Print()
{
    for(int i =1; i <=N; i++)
    {
        System.Console.WriteLine(i*i*i);
    }
}
Print();