using System.Collections;

public interface IEngineerInfo
{
    int experience { get; }
}
public class Engineer : Worker, IEngineerInfo, IComparable<Engineer>
{
    private string specialization;

    public int experience { get; }

    public Engineer(string name, string surname, string specialization, int experience) : base(name, surname)
    {
        this.specialization = specialization;
        this.experience = experience;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"This worker is engineer {specialization}, experience {experience} year.");
    }

    public int CompareTo(Engineer? other)
    {
        if (other == null) return 1;
        return this.experience.CompareTo(other.experience);
    }

    public new IEnumerator<Worker> GetEnumerator()
    {
        yield return this;
    }
}