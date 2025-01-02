namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] invalidChars = { '#', '$', '%' };

            foreach (char c in invalidChars)
            {
                if (password.Contains(c))
                {
                    Console.WriteLine("Invalid");
                    break;
                }dd
            }


        }
    }
}