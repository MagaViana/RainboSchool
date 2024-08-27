namespace RainbowSchool
{
    public class Student
    {
        public string Name { get; set; }
        public string ClassSection { get; set; }

        public Student(string name, string classSection)
        {
            Name = name;
            ClassSection = classSection;
        }

        public override string ToString()
        {
            return $"Student: {Name}, Class & Section: {ClassSection}";
        }

    }
}
