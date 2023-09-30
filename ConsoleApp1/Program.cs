



using ConsoleApp1;
using ConsoleApp1.Models;

StudentService students = new StudentService();

DateTime startdate = new (07, 01, 1995);
DateTime enddate = new(07, 02, 1996);


Student[] student = students.GetFilteredAge (startdate, enddate);


foreach (var item in student)
{
    Console.WriteLine($"{ item.name} - { item.surname} - { item.id} - { item.birthday} - { item.email}");
}