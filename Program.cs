
int n=Convert.ToInt32(Console.ReadLine());

bool easy = false;

for(int i = n-1; i > 1; i--)
{
    if (n % i == 0)
    {
        easy = true;
    }
}
if (!easy)
{
    Console.WriteLine($"Число уже простое");
    return;
}

while (n > 1)
{
    int sum = 0;
    for (int i = n; i > 0; i--)
    {
        if (n % i == 0)
        {
            sum += i;
        }
    }
    if (sum == 0)
    {
        break;
    }
    n -= sum;
    if (n <= 0)
    {
        Console.WriteLine("Цикл бесконечный");
        return;
    }
}

Console.WriteLine($"Простое число которое получилось это {n}");

