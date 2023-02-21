Console.Clear();
Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {a} в степени {b} = {DegreeBofNumberA(a, b)}");

int DegreeBofNumberA(int number, int degree)
{
  int result = 1;
  for (int i = 1; i <= degree; i++)
  {
    result = result * number;
  }
  return result;
}