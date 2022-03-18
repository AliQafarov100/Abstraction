using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Model
{
    class ITT : Faculty
    {
        public string TechnologyLearn;

        public ITT(string technologyLearn,string name,string dekanat) : base(name,dekanat)
        {
            TechnologyLearn = technologyLearn;
        }

        public override void Groups()
        {
            Console.WriteLine("Groups in faculty:\n319a1\n319a2\n319a3\n319a4\n319r\n659a1\n659a2\n659a3\n659a4\n659r\n");
        }

        public override int NumberSpecialitiesinFaculty(int count)
        {
            Console.WriteLine($"Number specialities in faculty: {count}");
            return count;
        }

        public override void Speciality()
        {
            Console.WriteLine("Speciality Subject:\nProgramming\nNetwork administrator\nSustem adminidtrator\nComputer Engineer\nComputer networks");
        }

        public override int NumStudentGrant(int grant)
        {
            Console.WriteLine($"Number student which receive grant: {grant}");
            return grant;
        }

        public override void Syllabus()
        {
            Console.WriteLine("Lectures continues 15 hours,Practice 45 hours");
        }
        public override string ToString()
        {
            return $"Technology Learn: {TechnologyLearn}\nName Faculty: {Name}\nDekan Faculty: {Dekanat}";
        }

    }
}
