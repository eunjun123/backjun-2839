class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int x = int.Parse(input);

        int a = 0;
        int b = 0;

        while (x > 0)
        {
            if (x % 5 == 0)
            {
                a = x / 5;
                break;
            }

            x -= 3;
            b++;
        }

        if (x >= 0)
            Console.Write(a + b);
        else
            Console.Write(-1);
    }
}