using System.Collections;

public abstract class Worker : IEnumerable<Worker>
{
    private string name;
    private string surname;

    public Worker(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }

    public virtual void Show()
    {
        Console.WriteLine($"{name} {surname} is worker.");
    }

    public IEnumerator<Worker> GetEnumerator()
    {
        yield return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}