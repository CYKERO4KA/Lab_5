namespace Lab_5;

class Forest
{
    public List<Tree> Trees;
    public List<IBush> Bushes;

    public Forest(List<Tree> trees, List<IBush> bushes)
    {
        Trees = trees;
        Bushes = bushes;
    }

    public void CountTrees()
    {
        Console.WriteLine(Trees.Count);
    }

    public void ShowTrees()
    {
        int i = 1;
        Random random = new Random();
        foreach (var tree in Trees)
        {
            Console.WriteLine($"{i++} {tree.Type}, height - {tree.Height ++}, age - {tree.Age ++}");
        }
    }

    public void PlantTree()
    {
        char index;
        Console.WriteLine("Plant:\n1.Birch\n2.Christmas tree\n3.Pine");
        index = Convert.ToChar(Console.ReadLine());
        Random random = new Random();
        int age = 1;

        switch (index)
        {
            case '1':
                Trees.Add(new Birch(random.Next(3, 7), age));
                break;
            case '2':
                Trees.Add(new ChristmasTree(random.Next(3, 7), age));
                break;
            case '3':
                Trees.Add(new Pine(random.Next(3, 7), age));
                break;
            default:
                Console.WriteLine("Incorrect action!");
                break;
        }
    }

    public void ChopTree()
    {
        int index;
        ShowTrees();
        index = Convert.ToInt32(Console.ReadLine());

        try
        {
            Trees.RemoveAt(index - 1);
        }
        catch
        {
            Console.WriteLine("Incorrect index!");
        }
    }

    public void ShowBushes()
    {
        int i = 1;
        Random random = new Random();
        foreach (var bush in Bushes)
        {
            Console.WriteLine($"{i++} {bush.Name} -- {bush.CountOfBerries}");
        }
    }
    public void PlantBush()
    {
        char index;
        Console.WriteLine("Plant:\n1.Blueberry\n2.Raspberry");
        index = Convert.ToChar(Console.ReadLine());
        Random random = new Random();

        Berry berry = new Berry(random);
        int age = 1;

        switch (index)
        {
            case '1':
                Bushes.Add(new Blueberries(berry.Count));
                break;
            case '2':
                Bushes.Add(new Raspberry(berry.Count));              
                break;
            default:
                Console.WriteLine("Incorrect action!");
                break;
        }
    }
}