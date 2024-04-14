using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public  class Classroom
    {
        private static int _id;
        public string Name { get; set; }  
        public int Id { get; set; }
        public Core.Type Type { get; set; }
        Student[] students = new Student[0];
        public Classroom()
        {
            _id++;
            _id = Id;
        }
        public void AddStudent(Student student)
        {
            if (students.Length < (Type == Type.BackEnd ? 20 : 15))
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Classroom doludur!!");
            }
        }
        public void FindId(int id)
        {
            try
            {
                Student[] newstudents = new Student[0];
                for (int i = 0; i < newstudents.Length; i++)
                {
                    if (newstudents[i].Id == id)
                    {
                        Array.Resize(ref newstudents, newstudents.Length + 1);
                        newstudents[newstudents.Length - 1] = newstudents[i];
                    }
                }
                newstudents = students;
            }
            catch (Exception)
            {
                Console.WriteLine(" StudentNotFoundException");
            }
        }
        public void Delete(int id)
        {
            try
            {
                Student[] newstudents2 = new Student[0];
                for (int i = 0; i < newstudents2.Length; i++)
                    if (students[i].Id != id)
                    {
                        Array.Resize(ref newstudents2, newstudents2.Length + 1);
                        newstudents2[newstudents2.Length - 1] = newstudents2[i];
                    }
                newstudents2 = students;
            }
            catch (Exception)
            {
                Console.WriteLine(" StudentNotFoundException");
            }
             
        }
      
    }
}
