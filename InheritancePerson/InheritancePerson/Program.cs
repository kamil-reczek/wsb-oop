using System;
using System.Collections.Generic;

namespace InheritancePerson
{
    class Program
    {
        static void Main(string[] args)
        {
//            Person person = new Person();
//            Student student = new Student();
//            Console.WriteLine(student.Name);
//            student.Breathe();
            
            Person employer = new Employer();
            Person student = new Student();
// employer.Breathe();

            List<Person> persons = new List<Person>();
            persons.Add(employer);
            persons.Add(student);
            foreach (Person person in persons)
            {
                person.Breathe();
            }
            
             
        }
    }
}