namespace StringCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個英文敘述字串：");
            string input = Console.ReadLine();
            

            var counts = input
            //大寫轉小寫
            .ToLower()
            //移除空字串
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .GroupBy(word => word)
            //key檢查字串,count檢查次數
            .ToDictionary(group => group.Key, group => group.Count());


            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        

        }
    }
}
