namespace Lab_5;

class Blueberries : IBush
{
    public string Name
    {
        get => "Blueberries";
    }
    public int CountOfBerries { get; set; }

    public Blueberries(int countOfBerries)
    {
        CountOfBerries = countOfBerries;
    }
}