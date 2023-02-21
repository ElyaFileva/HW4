Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел из числа {number} = {SumOfNumbersFromNumber(number)}");

int SumOfNumbersFromNumber(int num)
{
  int sum = 0;
  while (num != 0)
  {
    sum += num % 10;
    num /= 10;
  }
  return sum;
}