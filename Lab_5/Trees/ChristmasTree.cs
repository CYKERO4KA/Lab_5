namespace Lab_5;

class ChristmasTree : Tree
{
    public override string Type
    {
        get => "ChristmasTree";
    }

    public override double Height { get; set; }
    public override int Age { get; set; }

    public ChristmasTree(int height, int age) : base(height, age)
    {
            
    }
}