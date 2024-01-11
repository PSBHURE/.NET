namespace ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            Console.WriteLine("enter size of array");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            //Console.WriteLine(size);
            for(int i = 0; i < size;i++)
            {
                Console.WriteLine($"enter {i+1} element in array:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0;i < size;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
