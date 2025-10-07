//Verilmish arrayda en kicik ve en boyuk ededlerin cemini cixaran alogirthm
Console.WriteLine("Arrayi Daxil Edin:");
int[] arr = new int[10];
for (int i = 0; i < 10; i++)
    arr[i] = int.Parse(Console.ReadLine());
int min = arr[0], max = arr[0];
for (int i = 0; i < 10; i++)
{
    if (arr[i] < min)
        min = arr[i];
    if (arr[i] > max)
        max = arr[i];
}
int sum = min + max;
Console.WriteLine("Sum: " + sum);