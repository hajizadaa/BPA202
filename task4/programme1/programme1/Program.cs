//Verilmish ededin mertebelerinin en boyuyunu tapan alqoritm
Console.WriteLine("Ededi Daxil Edin: ");
int n = int.Parse(Console.ReadLine());
int max = 0, r = 0;
while (n != 0)
{
    r = n % 10;
    if (r > max)
        max = r;
    n /= 10;
}
Console.WriteLine("En boyuk mertebe: " + max);
