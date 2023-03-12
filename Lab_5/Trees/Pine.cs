namespace Lab_5;

class Pine : Tree
{

    public override string Type
    {
        get => "Pine";
    }
    public override double Height { get; set; }
    public override int Age { get; set; }
    public Pine(int height, int age) : base(height, age)
    {
            
    }
}