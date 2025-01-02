namespace ornekkk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "elma;armut,çilek;muz";
            string[] parcalar = str.Concat;

            foreach (string parca in parcalar)
            {
                Console.WriteLine(parca);
            }
        }
    }
}