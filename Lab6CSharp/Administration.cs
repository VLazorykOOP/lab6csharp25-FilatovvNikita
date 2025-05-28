using System.Collections;

public interface IAdminInfo
{
    decimal salary { get; }
}
public class Administration : Worker
{
    private string position;

    public decimal salary { get; }

    public Administration(string name, string surname, string position, decimal salary) : base(name, surname)
    {
        this.position = position;
        this.salary = salary;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"This worker is administrator {position}, salary ${salary:F2}");
    }
}