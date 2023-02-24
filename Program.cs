//Task 4; Программа, которая на вход принимает 3 числа и выдает максимальное из этих чисел
Console.WriteLine("//Task 4; Программа, которая на вход принимает 3 числа и выдает максимальное из этих чисел");
Console.Write("Введите первое число: "); 
int numA = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: "); 
int numB = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: "); 
int numC = Convert.ToInt32 (Console.ReadLine());

int maxNum = numA;

if (numA > maxNum)
{
    maxNum = numA;
}
if (numB >maxNum)
{
    maxNum = numB;
}
if (numC > maxNum)
{
    maxNum = numC;
}

     Console.WriteLine($"Максимальное число: {maxNum}");
