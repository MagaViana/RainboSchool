using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchool
{
    public class Teacher
    {
        public string Name { get; set; }
        public string ClassSection { get; set; }

        public Teacher(string name, string classSection)
        {
            Name = name;
            ClassSection = classSection;
        }

        public override string ToString()
        {
            return $"Teacher: {Name}, Class & Section: {ClassSection}";
        }
    }
}
