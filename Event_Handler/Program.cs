namespace Event_Handler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.InvalidateBasic += InvalidateBasic;
            e1.Basic = 1000;
        }
        static void InvalidateBasic()
        {
            Console.WriteLine("my event handling code called");
        }
    }
}
