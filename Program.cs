
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ban hay nhap vao 1 so");
        int so = Convert.ToInt32(Console.ReadLine());

        if (0 < so && so < 5)
        {
            switch (so) // Changed 'Switch' to 'switch'
            {
                case 1:
                    Console.WriteLine("*");
                    Console.WriteLine("* *");
                    Console.WriteLine("* * *");
                    Console.WriteLine("* * * *");
                    Console.WriteLine("* * * * *");
                    Console.WriteLine("* * * * * *");
                    break;
                case 2:
                    Console.WriteLine("* * * * * * * * * *");
                    Console.WriteLine("* * * * * * * * * *");
                    Console.WriteLine("* * * * * * * * * *");
                    Console.WriteLine("* * * * * * * * * *");
                    break;
                case 3:
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * *");
                    Console.WriteLine("* * * *");
                    Console.WriteLine("* * *");
                    Console.WriteLine("* *");
                    Console.WriteLine("*");
                    break;
                default:
                    Console.WriteLine("Gia tri khong nam trong pham vi xu ly.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Gia tri nhap khong hop le. Vui long nhap so tu 1 den 4.");
        }
    }
}
