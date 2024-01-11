namespace Array_Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            Console.WriteLine("enter size of array");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"enter {i + 1} element in array:");
                arr[i] = int.Parse(Console.ReadLine());
            }

        }
        public void ArrayCopy(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            for(int i = 0; i<arr.Length; i++)
            {
                arr1[i] = arr[i];
            }
            Console.WriteLine("element of 2nd array");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr1[i] + " ");
            }
        }
    }
}
