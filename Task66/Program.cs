// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 - 120
// M = 4; N = 8. - 30

int InputInt(string letter){

    Console.Write($"Введите {letter}: ");
    return int.Parse(Console.ReadLine());
}

void PrintMN (int m, int n){

    Console.Write($"{m} ");
    if(m < n) {
        m++;
        PrintMN(m,n);
    }
}

int SummMN (int m, int n){

    int sum = m;
    if(m < n) {
        m++;
        sum += SummMN(m,n);
    }
    return sum;
}

Console.Clear();
int m = InputInt("M");
int n = InputInt("N");

PrintMN(m,n);
Console.WriteLine();
Console.WriteLine($"Сумма: {SummMN(m,n)}");
