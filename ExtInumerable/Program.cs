namespace ExtInumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            int addition = integers.Where(x => x <= number).Aggregate((x, y) => x + y);
            int result = addition / integers.Where(x => x <= number).Count();
            Console.WriteLine(result);
        }
    }
}
