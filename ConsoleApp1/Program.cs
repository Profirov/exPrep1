namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string Line = "";
            int wins = 0;

            while ((Line = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(Line);

                if (distance > initialEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {initialEnergy} energy");
                    return;
                }

                initialEnergy -= distance;
                wins++;
                if (wins % 3 == 0)
                {
                    initialEnergy += wins;
                }
                
            }
            Console.WriteLine($"Won battles: {wins}. Energy left: {initialEnergy}");
        }
    }
}
