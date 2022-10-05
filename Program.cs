Console.WriteLine("Введите число. ");
int num = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= num; i = i + 1)

if (i % 2 == 0)

{
    Console.Write($" {i} ");
}
