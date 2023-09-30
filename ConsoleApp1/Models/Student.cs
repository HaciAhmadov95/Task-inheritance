using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Student:BaseEntity
    {
        public string name;
        public string surname;
        public string email;
        public DateTime birthday;
    }
}
