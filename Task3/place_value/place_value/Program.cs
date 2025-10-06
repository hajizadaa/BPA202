//Verilmiş n mərtəbəli ədədin ən yüksək mərtəbəsini tapın.
System.Console.WriteLine("n - i daxil edin:");
int n = int.Parse(System.Console.ReadLine());
int mertebe = 0;
int mertebeSayi = 0;
while (n != 0)
{
    mertebe = n % 10;
    n /= 10;
    mertebeSayi++;
}
System.Console.WriteLine("n - in en yuksek mertebesi:");
System.Console.WriteLine(mertebe);

// elave
System.Console.WriteLine("n nece mertebelidir:");
System.Console.WriteLine(mertebeSayi);
int power = mertebe;
for (int i = 0; i < mertebeSayi - 1; i++)
{
    power *= 10;
}
System.Console.WriteLine("n en yuksek mertebe deyeri:");
System.Console.WriteLine(power);