using System;
using System.Collections.Generic;

namespace BLL.Entities
{
    public class Group
    {
        private readonly List<Student> _students;

        public Group(int number)
        {
            _students = new List<Student>();
            Number = number;
        }

        public Group(int number, List<Student> students)
        {
            Number = number;
            _students = students;
        }

        public int Number { get; }

        public void Add(Student student)
        {
            if (ReferenceEquals(student, null))
            {
                throw new ArgumentNullException($"{nameof(student)} can not be null");
            }

            _students.Add(student);
        }

        public void Remove(Student student)
        {
            if (!_students.Contains(student))
            {
                throw new ArgumentException($"{nameof(student)} is not exist");
            }

            _students.Remove(student);
        }

        public List<Student> GetStudents() => _students;

        public Student GetStudent(Student student)
        {
            if (ReferenceEquals(student, null))
            {
                throw new ArgumentNullException($"{nameof(student)} can not be null");
            }

            return _students.Find(x => x.Equals(student));
        }
    }
}
