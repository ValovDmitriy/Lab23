// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число для факториала");
int factorialLenght = Convert.ToInt32(Console.ReadLine());
  FactorialAsync(factorialLenght);
Console.ReadKey();

static async void FactorialAsync(int factorialLenght)
{
    int res = await Task.Run(() => Factorial(factorialLenght));
    Console.WriteLine("Факториал числа {0} равен {1}", factorialLenght,res);
}

static int Factorial(int factorialLenght)
{
    int result = 1;
    for (int i = 1; i <= factorialLenght; i++)
    {
        result *= i;
    }
    return result;
}

