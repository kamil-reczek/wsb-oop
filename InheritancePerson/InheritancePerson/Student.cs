using System;

namespace InheritancePerson
{
    public class Student : Person
    {
        private int _id;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public Student() : this(-1)
        {
            
        }

        public Student(int id)
        {
            this._id = id;
            Console.WriteLine("Student created");
        }

        override public void Breathe()
        {
            Console.WriteLine("Student is breathing");
        }
    }
}