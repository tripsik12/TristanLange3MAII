namespace ForLoop3MAI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i); 
               
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); 
                }
            }
        }
    }
}