using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1;

public class DataRepository
{
    private readonly string _fileName = "student.json";
    public void SaveAppData(List<Student> students)
    {
        string jsonString = JsonSerializer.Serialize(students);
        File.WriteAllText(_fileName, jsonString);
    }

    public List<Student> LoadAppData()
    {
        string jsonString = File.ReadAllText(_fileName);
        List<Student> students = JsonSerializer.Deserialize<List<Student>>(jsonString);
        return students;
    }
}