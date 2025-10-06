//Fibonacci ardıcıllığını ekrana çıxaran alqoritm yazın
int fibo1 = 0, fibo2 = 1, fibo3 = 0;
int elementNum;
System.Console.WriteLine("Ardicilliqin Nece Elementi Yazdirilmalidir: ");
elementNum = int.Parse(System.Console.ReadLine());
Console.WriteLine(fibo1);
Console.WriteLine(fibo2);
for (int i = 2; i < elementNum; i++)
{
    fibo3 = fibo1 + fibo2;
    System.Console.WriteLine(fibo3);
    fibo1 = fibo2;
    fibo2 = fibo3;
}