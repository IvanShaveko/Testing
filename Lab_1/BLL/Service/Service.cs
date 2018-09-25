using System.Linq;
using BLL.Entities;

namespace BLL.Service
{
    public static class Service
    {
        public static double CalculateAvgOfGroup(Group group)
        {
            var students = group.GetStudents();
            double avg = 0;

            foreach (var student in students)
            {
                avg += student.GetMarks().Average();
            }

            return avg / students.Count;
        }

        public static double CalculateAvgOfSudent(Group group, Student student) =>
            group.GetStudent(student).GetMarks().Average();
    }
}
