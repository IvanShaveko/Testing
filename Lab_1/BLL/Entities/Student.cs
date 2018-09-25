using System.Collections.Generic;
using System.Linq;

namespace BLL.Entities
{
    public class Student
    {
        private readonly List<int> _marks;

        public Student(List<int> marks, string name)
        {
            _marks = marks;
            Name = name;
        }

        public string Name { get; }

        public List<int> GetMarks() => _marks;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(this, null) || ReferenceEquals(obj, null))
            {
                return false;
            }

            return Equals((Student)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((_marks != null ? _marks.GetHashCode() : 0) * 397) ^ (Name != null ? Name.GetHashCode() : 0);
            }
        }

        public bool Equals(Student student)
        {
            if (ReferenceEquals(student, this))
            {
                return true;
            }

            if (ReferenceEquals(this, null) || ReferenceEquals(student, null))
            {
                return false;
            }

            return student.Name == Name && student.GetMarks().SequenceEqual(GetMarks());
        }
    }
}
