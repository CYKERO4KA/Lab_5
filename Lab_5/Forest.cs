namespace Lab_5;

class Forest
{
    private int _basket;
    public List<Tree> Trees;
    public List<IBush> Bushes;

    public Forest(List<Tree> trees, List<IBush> bushes)
    {
        Trees = trees;
        Bushes = bushes;
    }

    public void GoToForest()
    {
        while (true)
        {
            Console.WriteLine("Choose action:\n1. Plant tree\n2. Chop tree\n3. Show trees\n4. Plant bush\n5. Show bushes\n6. Collect berries");
            char index = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (index)
            {
                case '1':
                    PlantTree();
                    break;
                case '2':
                    ChopTree();
                    break;
                case '3':
                    ShowTrees();
                    break;
                case '4':
                    PlantBush();
                    break;
                case '5':
                    ShowBushes();
                    break;
                case '6':
                    CollectBerries();
                    break;
                default:
                    Console.WriteLine("Incorrect index!");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }

    private void ShowCountTrees()
    {
        Console.WriteLine($"Trees: " + Trees.Count);
    }

    private void ShowTrees()
    {
        int i = 1;
        Random random = new Random();
        foreach (var tree in Trees)
        {
            Console.WriteLine($"{i++}. {tree.Type}, height - {tree.Height}, age - {tree.Age ++}");
            tree.Height += random.Next(0, 10);
        }
        ShowCountTrees();
    }

    private void PlantTree()
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

    private void ChopTree()
    {
        int index;
        if (Trees.Count <= 0)
        {
            Console.WriteLine("There is no trees to chop!");
        }
        else
        {
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
    }

    private void ShowBushes()
    {
        int i = 1;
        Random random = new Random();
        Berry berry = new Berry(random);
        foreach (var bush in Bushes)
        {
            bush.CountOfBerries += berry.Count;
            Console.WriteLine($"{i++}. {bush.Name} -- {bush.CountOfBerries}");
        }
    }

    private void PlantBush()
    {
        char index;
        Console.WriteLine("Plant:\n1.Blueberry\n2.Raspberry");
        index = Convert.ToChar(Console.ReadLine());
        Random random = new Random();

        Berry berry = new Berry(random);

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

    private void CollectBerries()
    {
        int index;
        if (Bushes.Count <= 0)
        {
            Console.WriteLine("There is no bushes!");
        }
        else
        {
            ShowBushes();
            index = Convert.ToInt32(Console.ReadLine());

            try
            {
                _basket += Bushes[index-1].CountOfBerries;
                Console.WriteLine($"You have {_basket} berries in your basket");
                Bushes[index-1].CountOfBerries = 0;
            }
            catch
            {
                Console.WriteLine("Incorrect index!");
            }
        }
    }
}