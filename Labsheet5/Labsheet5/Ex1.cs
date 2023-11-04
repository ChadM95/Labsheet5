namespace Labsheet5;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Chad","Computing", 3.0);

        s1.AdjustGPA(.1);

        Console.WriteLine(s1);

        Console.ReadLine();
    }
}

