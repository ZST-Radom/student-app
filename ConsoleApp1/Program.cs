// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Console.WriteLine("Hello, World!");


DataRepository dataRepository = new DataRepository();

List<Student> students = dataRepository.LoadAppData();

while (true)
{
    Console.WriteLine("Co chcesz zrobić, 1 - dodaje sutedna, 2 - wyświetla wszystkich, 3 - zmien email.");

    int options = int.Parse(Console.ReadLine());

    if(options == 1)
    {
        Console.WriteLine("Podaj id:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj name:");
        string name = Console.ReadLine();

        Console.WriteLine("Podaj mail:");
        string mail = Console.ReadLine();

        students.Add(new Student { Id = id, Name = name, IsActive = true, Mail = mail });
    }
    else if (options == 2)
    {
        foreach (var student in students)
        {
            student.Print();
        }
    }
    else if(options==3)
    {
        Console.WriteLine("Podaj id studenta:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj nowy mail:");
        string mail = Console.ReadLine();

        Student student = students.Find(x => x.Id == id);

        student.SetMail(mail);
    }
    else if (options == 4)
    {
        dataRepository.SaveAppData(students);
    }
    else
    {
        break;
    }
}
