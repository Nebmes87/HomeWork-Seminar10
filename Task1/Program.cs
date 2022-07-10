// Есть монотонная последовательность, каждое число встречается 
// ровно то количество раз, какое значение этого числа: 
// 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
// Выведите ряд этой последовательности до N-го значения, 
// желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

Console.WriteLine("Введите число M");
int countM = Convert.ToInt32(Console.ReadLine());

Sequence(countM);

void Sequence(int count, int number = 0, int countnum = 0)
{
  if (count == 0)
  {
    return;
  }
  for (int i = 0; countnum < count; i++)
  {
    countnum = countnum + i;
    number = i;
  }
  Sequence(--count);
  Console.Write(number + " ");
}