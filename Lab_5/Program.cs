namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tree> trees = new List<Tree>();
            List<IBush> bushes = new List<IBush>();
            
            Forest forest = new Forest(trees, bushes);
            
            forest.GoToForest();
        }
    }
}