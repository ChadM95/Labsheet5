namespace Ex3;

class Program
{
    static void Main(string[] args)
    {
        Rectangle R1 = new Rectangle(50, 25);
        Rectangle R2 = new Rectangle(50, 60);

        int r1Perimeter = R1.CalcPerimeter();
        int r2Perimeter = R2.CalcPerimeter();

        int r1Area = R1.CalcArea();
        int r2Area = R2.CalcArea();

        if (r1Perimeter > r2Perimeter)
        {
            Console.WriteLine($"Area of Rectangle 1 is {r1Area}");
        }

        else if (r1Perimeter < r2Perimeter)
        {
            Console.WriteLine($"Area of Rectangle 2 is {r2Area}");
        }

        else
        {
            Console.WriteLine("Something went wrong");
        }


        Console.ReadLine();
    }
}

