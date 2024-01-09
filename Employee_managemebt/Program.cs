namespace Inheritance_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager e = new Manager("PRATIK", 2, 110000,"PUNE");
            Console.WriteLine(e);
            GeneralManager g=new GeneralManager("VIRU",10,200000,"Mumbai","Automention tester");
            Console.WriteLine(g);
            CEO c = new CEO("VIRU", 10, 200000, "Capjemini");
            Console.WriteLine(c);
            Console.WriteLine(e.CalNetSalary());
            Console.WriteLine(g.CalNetSalary());
            Console.WriteLine(c.CalNetSalary());
        }
    }
}
