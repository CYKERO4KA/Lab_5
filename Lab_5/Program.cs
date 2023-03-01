namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    abstract class Forest
    {
        public List<string> Trees;
        public List<string> Bushes;
    }

    class Tree : Forest
    {
        public string Type;
        public double Heigh;
        public int Age;
    }

    class Bush : Forest
    {
        public bool IsBerries;
    }

    class Berry : Bush
    {
        
    }
    
    class ChristmasTree : Tree
    {
        
    }


    class BlueBerries : Berry
    {
        
    }

    class Pine : Tree
    {
        
    }

    class Birch : Tree
    {
        
    }
    
}

