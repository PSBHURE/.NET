namespace MultiCastDelegate
{
    public delegate int DEL(int a,int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c1= new Class1();
            Console.WriteLine(c1.PassFuncationAsParameter(c1.Add, 10, 5));
           Console.WriteLine(c1.PassFuncationAsParameter(Class1.Sub,10,5));
           // Console.WriteLine(c1.PassFuncationAsParameter(c1.Mul,10,5));
           // Console.WriteLine(c1.PassFuncationAsParameter(c1.Div,10,2));
        }
    }
    public class Class1
    {
        public  int PassFuncationAsParameter(DEL d,int a,int b)
        {
            return d(a, b);
        }
        /*
         static int CallFunctionPassedAsAParameter(DelAdd objDelAdd,int a, int b)  //objDelAdd = Add
        { 
            return objDelAdd(a,b);
        }
         */
        public int Add(int a,int b)
        {
            return a+b;
        }
        public static int Sub(int a,int b)
        {
            return a - b;
        }
        public int Mul(int a, int b) { return a * b; }
        public int Div(int a, int b) { return a / b; }
    }
}
