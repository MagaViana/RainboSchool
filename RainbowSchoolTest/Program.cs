using RainbowSchool;

class Program
{
    static void Main(string[] args)
    {
        SchoolManager manager = new SchoolManager();

        manager.AddStudent(new Student("Alice", "10-A"));
        manager.AddTeacher(new Teacher("Mr. John", "10-A"));
        manager.AddSubject(new Subject("Mathematics", "MATH101"));

        string allData = manager.GetAllData();
        System.Console.WriteLine(allData);
    }
}