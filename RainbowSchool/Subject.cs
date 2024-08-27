using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchool
{
    public class Subject
    {
        public string Name { get; set; }
        public string SubjectCode { get; set; }

        public Subject(string name, string subjectCode)
        {
            Name = name;
            SubjectCode = subjectCode;
        }

        public override string ToString()
        {
            return $"Subject: {Name}, Code: {SubjectCode}";
        }
    }
}
