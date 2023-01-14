namespace Deliverable1_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution (1): Hello, World!");
            Console.WriteLine(" ");

            string stg = "Hello, World!";
            Console.WriteLine("Solution (2): " + stg);
            Console.WriteLine(" ");

            Console.WriteLine("Enter user's name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("The user's name is: " + userName);
            Console.WriteLine(" ");

            Console.WriteLine("Enter user's name: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("The user's age is: " + age);
        }
    }
}