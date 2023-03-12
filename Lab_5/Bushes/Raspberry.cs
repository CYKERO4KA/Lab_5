namespace Lab_5;

public class Raspberry : IBush
{
    public string Name
    {
        get => "Raspberry";
    }
    public int CountOfBerries { get; set; }

    public Raspberry(int countOfBerries)
    {
        CountOfBerries = countOfBerries;
    }
}