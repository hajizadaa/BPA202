//Verilmiş n ədədinin aylara qarşılığı əsasında fəsli müəyyən edin.
System.Console.WriteLine("n - i daxil edin:");
int n = int.Parse(System.Console.ReadLine());
switch (n)
{
    case 1:
        System.Console.WriteLine("Yanvar ayindayiq ve Qis Feslidir.");
        break;
    case 2:
        System.Console.WriteLine("Fevral ayindayiq ve Qis Feslidir.");
        break;
    case 3:
        System.Console.WriteLine("Mart ayindayiq ve Yaz Feslidir.");
        break;
    case 4:
        System.Console.WriteLine("Aprel ayindayiq ve Yaz Feslidir.");
        break;
    case 5:
        System.Console.WriteLine("May ayindayiq ve Yaz Feslidir.");
        break;
    case 6:
        System.Console.WriteLine("Iyun ayindayiq ve Yay Feslidir.");
        break;
    case 7:
        System.Console.WriteLine("Iyul ayindayiq ve Yay Feslidir.");
        break;
    case 8:
        System.Console.WriteLine("Avqust ayindayiq ve Yay Feslidir.");
        break;
    case 9:
        System.Console.WriteLine("Sentyabr ayindayiq ve Payiz Feslidir.");
        break;
    case 10:
        System.Console.WriteLine("Oktyabr ayindayiq ve Payiz Feslidir.");
        break;
    case 11:
        System.Console.WriteLine("Noyabr ayindayiq ve Payiz Feslidir.");
        break;
    case 12:
        System.Console.WriteLine("Dekabr ayindayiq ve Qis Feslidir.");
        break;
    default:
        System.Console.WriteLine("Bele Bir Ay Nomresi Yoxdur.");
        break;
}