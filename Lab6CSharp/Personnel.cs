using System.Collections;

public interface IPersonnelInfo
{
    int employees { get; }
}
public class Personnel : Worker, IPersonnelInfo, IComparable<Personnel>
{
    private string department;

    public int employees { get; }

    public Personnel(string name, string surname, string department, int employees) : base(name, surname)
    {
        this.department = department;
        this.employees = employees;

    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"This worker from {department}, employees {employees} workers.");
    }

    public int CompareTo(Personnel? other)
    {
        if (other == null) return 1;
        return this.employees.CompareTo(other.employees);
    }

    public new IEnumerator<Worker> GetEnumerator()
    {
        yield return this;
    }
}