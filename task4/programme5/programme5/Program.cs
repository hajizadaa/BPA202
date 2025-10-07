//Verilmish arrayda murekkeb ededlerin sayini cixaran algorithm
int[] arr = new int[10];
Console.WriteLine("Arrayi Daxil Edin: ");
for (int i = 0; i < 10; i++)
    arr[i] = int.Parse(Console.ReadLine());
int bolenSay = 0, murekkebSay = 0;;
for (int i = 0; i < 10; i++)
{
    bolenSay = 0;
    for (int x = 1; x <= arr[i]; x++)
    {
        if (arr[i] % x == 0)
            bolenSay++;
    }
    if (bolenSay > 2)
        murekkebSay++;
}
Console.WriteLine("Murekkeb Eded Sayi: " + murekkebSay);