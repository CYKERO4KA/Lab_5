namespace Lab_5;

class Birch : Tree
{

    public override string Type
    {
        get => "Birch";
    }

    public override double Height { get; set; }
    public override int Age { get; set; }
    public Birch(int height, int age) : base(height, age)
    {
            
    }
}