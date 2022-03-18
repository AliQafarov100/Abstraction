using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Model
{
    abstract class Faculty
    {
        public string Name;
        public string Dekanat;

        public Faculty(string name,string dekanat)
        {
            Name = name;
            Dekanat = dekanat;
        }
        public abstract void Syllabus();
        public abstract int NumberSpecialitiesinFaculty(int count);
        public abstract void Speciality();
        public abstract void Groups();
        public abstract int NumStudentGrant(int grant);
        
    }
}
