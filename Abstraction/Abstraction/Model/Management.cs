using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Model
{
    class Management : Faculty
    {
        public string ManageFormLearn;

        public Management(string manageFormLearn,string name,string dekanat) : base(name,dekanat)
        {
            ManageFormLearn = manageFormLearn;
        }

        public override void Groups()
        {
            Console.WriteLine("Groups in faculty:\n2319a1\n2319a2\n2319a3\n2319a4\n2319r\n99a1\n99a2\n99a3\n99a4\n99r\n");
        }

        public override int NumberSpecialitiesinFaculty(int count)
        {
            Console.WriteLine($"Number specialities in faculty: {count}");
            return count;
        }

        public override int NumStudentGrant(int grant)
        {
            Console.WriteLine($"Number student which receive grant: {grant}");
            return grant;
        }

        public override void Speciality()
        {
            Console.WriteLine("Speciality Subject:\nEconomics\nManagementn\nDesign\nSystem Control");
        }

        public override void Syllabus()
        {
            Console.WriteLine("Lectures continues 45 hours,Practice 30 hours");
        }
        public override string ToString()
        {
            return $"Technology Learn: {ManageFormLearn}\nName Faculty: {Name}\nDekan Faculty: {Dekanat}";
        }
    }
}
