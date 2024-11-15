namespace ConsoleApp1;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public string Mail { get; set; }

    public void Print()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Email: {Mail}");
    }

    public string GetData()
    {
        return $"Id: {Id}, Name: {Name}";
    }

    public void SetMail(string newMail)
    {
        IsActive = false;

        Mail = newMail;
    }
}