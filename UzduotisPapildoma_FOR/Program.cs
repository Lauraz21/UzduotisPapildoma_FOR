namespace UzduotisPapildoma_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            int mult = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    mult = i * j;
                    Console.WriteLine($" {i} x {j} = {mult}");
                }
            }

        }
    }
}