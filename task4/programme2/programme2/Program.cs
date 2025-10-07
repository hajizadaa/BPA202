//Verilmish ededin 2 quvveti olub olmadigini tapan alqoritm
Console.WriteLine("Ededi Daxil Edin:");
int n = int.Parse(Console.ReadLine());
int i = 1;
while (n > i)
    i *= 2;
Console.WriteLine(i);
if (n == i && i!= 1)
    Console.WriteLine($"{n} 2 - nin quvvetidir.");
else
    Console.WriteLine($"{n} 2 - nin quvveti deyildir.");    