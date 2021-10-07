using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    class Tutorial2
    {
        static void Main(string[] args)
        {
            Tutorial2 t2 = new Tutorial2();
            Student student = new Student();
            student.Name = "Dirk";
            student.LastName = "Strauss";
            student.CourseCodes = new List<int> { 203, 202, 101 };

            t2.OutputInformation(student);

            // creating a professor
            Professor prof = new Professor();
            prof.Name = "Reinhardt";
            prof.LastName = "Botha";
            prof.TeachesSubjects = new List<string> { "Mobile Development", "Cryptography" };

            t2.OutputInformation(prof);

            t2.OutputInformation(null);     // someone else may find it difficult to understand what's happening

            Student student2 = null;
            t2.OutputInformation(student2);

            t2.OutputInformation(t2);
        }

        /// <summary>
        /// This is a super function
        /// </summary>
        /// <param name="person">This is required to be a professor or a student</param>
        public void OutputInformation(object person)
        {
            //if (person is Student student)
            //{
            //    Console.WriteLine($"Student {student.Name} {student.LastName} is enrolled for courses {String.Join<int>(", ", student.CourseCodes)}");
            //}
            //else if (person is Professor prof)
            //{
            //    Console.WriteLine($"Professor {prof.Name} {prof.LastName} teaches { String.Join<string>(",", prof.TeachesSubjects)}");
            //}
            //else if (person is null)
            //{
            //    Console.WriteLine($"Object {nameof(person)} is null");
            //    // It is good practice to use the nameof keyword here. If the variable name person ever has to change, the corresponding output will be changed also.
            //}
            //else
            //{
            //    Console.WriteLine($"Invalid object passed for parameter {nameof(person)}");
            //}

            switch (person)
            {
                case Student student when (student.CourseCodes.Contains(203)):
                    Console.WriteLine($"Student {student.Name} {student.LastName}is enrolled for course 203.");
                    break;
                case Student student:
                    Console.WriteLine($"Student {student.Name} {student.LastName} is enrolled for courses {String.Join<int>(", ", student.CourseCodes)}");
                    break;
                case Professor prof:
                    Console.WriteLine($"Professor {prof.Name} {prof.LastName} teaches {String.Join<string>(",", prof.TeachesSubjects)}");
                    break;
                case null:
                    Console.WriteLine($"Object {nameof(person)} is null");
                    break;
                default:
                    Console.WriteLine("Unknown object detected");
                    break;
            }
        }
    }
}
