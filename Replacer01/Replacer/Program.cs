namespace Replacer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入大於90的數字: ");

            int max = int.Parse( Console.ReadLine());
            while(max < 90) {
                Console.WriteLine("請輸入大於90的數字: ");
                max = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Dann");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("School");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            Console.ReadLine();
            
        }
    }
}
 