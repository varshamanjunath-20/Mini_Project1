using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Casestudy1
{
    class Student
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime DOB { get; set; }
    }
    class Course
    {
        public int Course_id { get; set; }
        public string Course_name { get; set; }
        public float Duration { get; set; }
        public float Fees { get; set; }
    }
    class Info
    {
        public void Display(Student student)
        {

            Console.WriteLine("student id :{0}", student.Id);
            Console.WriteLine("student name :{0} ", student.name);
            Console.WriteLine("student dob :{0} ", student.DOB.ToShortDateString());

        }
        public void Display(Course course)
        {
            Console.WriteLine("course id {0} : ", course.Course_id);
            Console.WriteLine("course name {0}: ", course.Course_name);
            Console.WriteLine("course duration{0} : ", course.Duration + "years");
            Console.WriteLine("Fees {0}: ", course.Fees + "lakhs");
        }
        public void Display(Enroll enroll)
        {
            Console.WriteLine("student :{0}", enroll.student);
            Console.WriteLine("Course :{0} ", enroll.course);
            Console.WriteLine("enrollment date :{0} ", enroll.enrollmentDate);
        }
    }
    class App : Case_study3
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.showFirstScreen();
            Console.Read();
        }
        public void Scenario1()
        {
            Student s1 = new Student();
            Info i1 = new Info();
            s1.Id = 1;
            s1.name = "anupa";
            s1.DOB = new DateTime(2017, 10, 05);
            i1.Display(s1);

            Student s2 = new Student();
            s2.Id = 2;
            s2.name = "ramya";
            s2.DOB = new DateTime(2015, 04, 04);
            i1.Display(s2);

            Student s3 = new Student();
            s3.Id = 3;
            s3.name = "varsha";
            s3.DOB = new DateTime(2018, 06, 05);
            i1.Display(s3);

            Console.WriteLine("  ");

            Course c1 = new Course();
            Info i2 = new Info();
            c1.Course_id = 1001;
            c1.Course_name = "DSA";
            c1.Duration = 2;
            c1.Fees = 2;
            i2.Display(c1);

            Course c2 = new Course();
            c2.Course_id = 1002;
            c2.Course_name = "computer science";
            c2.Duration = 3;
            c2.Fees = 4;
            i2.Display(c2);

            Course c3 = new Course();
            c3.Course_id = 1003;
            c3.Course_name = "Data Science";
            c3.Duration = 1;
            c3.Fees = 2;
            i2.Display(c3);
        }
        public void Scenario2()
        {

            Student[] std = new Student[4];
            Info ii = new Info();
            std[0] = new Student();
            std[1] = new Student();
            std[2] = new Student();
            std[3] = new Student();

            std[0].Id = 4;
            std[0].name = "ramya";
            std[0].DOB = new DateTime(2001, 10, 10);

            std[1].Id = 5;
            std[1].name = "varsha";
            std[1].DOB = new DateTime(2010, 09, 09);

            std[2].Id = 6;
            std[2].name = "Bhanu";
            std[2].DOB = new DateTime(2013, 05, 20);

            std[3].Id = 7;
            std[3].name = "Bhavish";
            std[3].DOB = new DateTime(2014, 06, 05);

            foreach (var v in std)
            {
                ii.Display(v);
            }
        }
        public void Scenario3()
        {
            Console.Write("Enter the total number of students : ");
            int StdCount = Convert.ToInt32(Console.ReadLine());
            Student[] std = new Student[StdCount];
            for (int i = 0; i <= StdCount - 1; i++)
            {
                std[i] = new Student();
                Console.Write("Enter the id of student {0} : ", i + 1);
                int Id = Convert.ToInt32(Console.ReadLine());
                std[i].Id = Id;
                Console.Write("Enter the Name of student {0} : ", i + 1);
                string name = Console.ReadLine();
                std[i].name = name;
                Console.Write("Enter the DOB of Student {0} : ", i + 1);
                DateTime DOB = Convert.ToDateTime(Console.ReadLine());
                std[i].DOB = DOB;
                Info i3 = new Info();
                i3.Display(std[i]);
            }
        }
        public void scenario4()       //Additional it is connected with database 
        {
            Console.Write("Enter the total number of students : ");
            int StdCount = Convert.ToInt32(Console.ReadLine());
            Student[] std = new Student[StdCount];
            for (int i = 0; i <= StdCount - 1; i++)
            {
                Register.register1();
                Register.Selectdata();

            }

        }
    }
}