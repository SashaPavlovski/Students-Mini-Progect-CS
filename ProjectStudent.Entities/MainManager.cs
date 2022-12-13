using ProjectStudent.Entities;
using ProjectStudent.Model;
using System.Collections;

namespace ProjectStudent.Entities
{
    public class MainManager
    {
        Hashtable studentHash = null;
        private MainManager() { }

        private readonly static MainManager _INSTANCE = new MainManager();
        public static MainManager INSTANCE { get { return _INSTANCE; } }

        Students students = new Students();

        public void Init()
        {
            studentHash = students.AddStudentHashtable();
        }
        public void Push(string id, string address, string name, string age)
        {
            studentHash = students.AddStudentHashtable();

            if (!(studentHash[int.Parse(id)] is Student))
            {
                int StudentId = int.Parse(id);
                string StudentAddress = address;
                string StudentName = name;
                int StudentAge = int.Parse(age);
                students.AddStudentData(StudentId, StudentAddress, StudentName, StudentAge);
            }
            studentHash.Clear();

        }
        public string ShowStudent(int id)
        {
            string studentData = null;
            if (studentHash[id] is Student)
            {
                Student student = (Student)studentHash[id];
                string nameStudent = student.name;
                string addressStudent = student.Address;
                int ageStudent = student.Age;
                int idStudent = student.id;

                studentData = $"{nameStudent} {addressStudent} {ageStudent} {idStudent}";

            }

            return studentData;
        }

    }
 
}