//Verilmiş n ədədinin bölənlərini tapın.
System.Console.WriteLine("n - i daxil edin:");
int n = int.Parse(System.Console.ReadLine());
for (int i = 1; i <= n / 2; i++)
    if (n % i == 0)
        System.Console.WriteLine(i);