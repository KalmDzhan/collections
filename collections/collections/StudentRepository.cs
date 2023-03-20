using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepos
{
    class StudentRepository
    {
        private List<Student> students = new();

        public List<Student> GetAll()
        {
            return students;
        }
        public Student GetById(int id)
        {
            return students[id];
        }
        public void Insert(Student student)
        {
            students.Add(student);
        }

        public void Delete(int id)
        {
            if (students[id] != null)
            {
                students.Remove(students[id]);
            }
        }

        public void Update(int id, Student student)
        {
            if (students[id] != null)
            {
                students[id].FirstName = student.FirstName;
                students[id].LastName = student.LastName;
                students[id].Group = student.Group;
            }
        }

        public List<Student> Find(char firstLetter)
        {
            List <Student> studentsByLetter = new();
            foreach (Student student in students)
            {
                if (firstLetter == char.ToLower(student.LastName[0]))
                {
                    studentsByLetter.Add(student);
                }
            }
            return studentsByLetter;
        }
    }
}