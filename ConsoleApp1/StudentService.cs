using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StudentService
    {
        private Student[] GetAllStudents()
        {
            Student student1 = new Student()
            {
                id = 1,
                name = "Haci",
                surname = "Ahmadov",
                email = "haci@gmail.com",
                birthday = new DateTime(07, 01, 1995)
            };

            Student student2 = new Student()
            {
                id = 2,
                name = "Hac2i",
                surname = "Ah2madov",
                email = "haci@gm2ail.com",
                birthday = new DateTime(02, 01, 1995)
            };


            Student student3 = new Student()
            {
                id = 3,
                name = "Ha3c2i",
                surname = "A3h2madov",
                email = "haci3@gm2ail.com",
                birthday = new DateTime(02, 05, 1995)
            };


            Student[] students = new Student[] { student1, student2, student3 };
            return students;
        }



        public Student[] GetFilteredAge (DateTime startDate, DateTime endDate)
        {
            Student[] students = GetAllStudents();

            var result = students.Where(m => m.birthday > startDate && m.birthday < endDate).ToArray();
            return result;
        }
    }
}



