//Verilmish arrayda hem tek eded olan hemde 3-e bolunen ededlerin sayini cixaran algorithm
int[] arr = new int [10];
Console.WriteLine("Arrayi Daxil Edin:");
for (int i = 0; i < 10; i++)
    arr[i] = int.Parse(Console.ReadLine());
int say = 0;
for (int i = 0; i < 10; i++)
    if (arr[i] % 3 == 0 && arr[i] % 2 == 1)
        say++;
Console.WriteLine("Say: " + say);