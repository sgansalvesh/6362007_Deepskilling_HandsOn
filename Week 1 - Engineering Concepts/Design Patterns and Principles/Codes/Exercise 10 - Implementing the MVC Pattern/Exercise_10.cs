using System;

namespace MVCPatternExample
{
    public class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Grade { get; set; }
    }

    public class StudentView
    {
        public void DisplayStudentDetails(string name, string id, string grade)
        {
            Console.WriteLine($"Student Details:\nName: {name}\nID: {id}\nGrade: {grade}");
        }
    }

    public class StudentController
    {
        private Student _student;
        private StudentView _view;

        public StudentController(Student student, StudentView view)
        {
            _student = student;
            _view = view;
        }

        public void SetStudentName(string name) => _student.Name = name;
        public void SetStudentId(string id) => _student.Id = id;
        public void SetStudentGrade(string grade) => _student.Grade = grade;

        public void UpdateView()
        {
            _view.DisplayStudentDetails(_student.Name, _student.Id, _student.Grade);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { Name = "Alice", Id = "S101", Grade = "A" };
            StudentView view = new StudentView();
            StudentController controller = new StudentController(student, view);

            controller.UpdateView();

            controller.SetStudentName("Bob");
            controller.SetStudentGrade("B+");
            controller.UpdateView();
        }
    }
}
