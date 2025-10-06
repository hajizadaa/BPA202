/*Sizə x və y  tam ədədləri verilir. Siz 0 ilə x arasında yerləşən və y-ə tam bölünən ən böyük ədədi
tapmalısınız. Əgər belə bir ədəd yoxdursa, ekranda -1 çap olunmalıdır.*/
int x, y;
System.Console.WriteLine("x - i daxil edin: ");
x = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("y - i daxil edin: ");
y = int.Parse(System.Console.ReadLine());
int max = 0;
for (int i = 0; i < x; i++)
{
    if (i % y == 0 && i > max)
        max = i;
}

if (max != 0)
    Console.WriteLine(max);
else
    Console.WriteLine(-1);