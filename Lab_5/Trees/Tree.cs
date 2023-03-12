namespace Lab_5;

abstract class Tree
{
    public abstract string Type { get; }
    public abstract double Height { get; set; }
    public abstract int Age { get; set; }

    public Tree(int height, int age)
    {
        Height = height;
        Age = age;
    }
}