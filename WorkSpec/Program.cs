//Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x 
//и возвращает целую часть квадратного корня от введенного числа.

Console.Clear();

Console.WriteLine("Введите числа: ");
double num = int.Parse(Console.ReadLine()!);

double number = num;
double result = 0;

double a = 1;
while (a <= number)
{ 
    
    number -= a;
    a += 2;
    result+=1; 
}
Console.WriteLine($"Корень из числа {num} равен {result}");