namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tree> trees = new List<Tree>();
            Random random = new Random();
            Berry berry = new Berry(random);
            List<IBush> bushes = new List<IBush>();
            
            Forest forest = new Forest(trees, bushes);
            //forest.CountTrees();
            while (true)
            {
                forest.ShowTrees();
                forest.ShowBushes();
                Console.WriteLine();
                forest.PlantTree();
                Console.WriteLine();
                //forest.ChopTree();
                forest.PlantBush();

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

