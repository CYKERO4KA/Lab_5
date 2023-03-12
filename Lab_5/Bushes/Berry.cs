namespace Lab_5;

public class Berry
{
    public int Count { get; set; }

    public Berry(Random random)
    {
        Count = random.Next(0, 180);
    }
}