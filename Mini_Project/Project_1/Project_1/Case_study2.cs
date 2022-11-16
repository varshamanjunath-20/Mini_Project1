using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Casestudy1
{
    class Enroll
    {
        public Student student { get; set; }
        public Course course { get; set; }
        public DateTime enrollmentDate { get; set; }
    }
    class AppEngine
    {
        Course[] cour = new Course[1];
        Student[] stud = new Student[1];
        Enroll[] e = new Enroll[1];
        public void Introduce(Course course)
        {

            for (int i = 0; i < cour.Length; i++)
            {
                Console.WriteLine("Enter Corseid, CorseName,Duration,Fees");
                int cid = Convert.ToInt32(Console.ReadLine());
                string cname = Console.ReadLine();
                float Dur = float.Parse(Console.ReadLine());
                float Fee = float.Parse(Console.ReadLine());
                cour[i] = new Course()
                {

                    Course_id = cid,
                    Course_name = cname,
                    Duration = Dur,
                    Fees = Fee
                };
            }
        }
        public void Register(Student student)
        {

            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine("Enter Stdid, Stdname,Dateofbirth");
                int sid = Convert.ToInt32(Console.ReadLine());
                string sname = Console.ReadLine();
                DateTime DOB = Convert.ToDateTime(Console.ReadLine());
                stud[i] = new Student()
                {
                    Id = sid,
                    name = sname,
                    DOB = Convert.ToDateTime(DOB),
                };
            }
        }
        public Student[] listOfStudents()
        {
            Student[] std = new Student[3];
            for (int i = 0; i < stud.Length; i++)
            {
                std[i] = new Student()
                {
                    Id = stud[i].Id,
                    name = stud[i].name,
                    DOB = stud[i].DOB,
                };
            }
            return std;

        }
        public Course[] listOfCourses()
        {
            Course[] cour = new Course[4];
            for (int i = 0; i <= cour.Length; i++)
            {
                cour[i] = new Course()
                {
                    Course_id = cour[i].Course_id,
                    Course_name = cour[i].Course_name,
                    Duration = cour[i].Duration,
                    Fees = cour[i].Fees,
                };
            }
            return cour;
        }
        public void enroll()
        {
            Student[] slist = new Student[1];
            Course[] clist = new Course[1];

            Student stud = new Student();
            Register(stud);
            Course c1 = new Course();
            Introduce(c1);
            slist = listOfStudents();
            clist = listOfCourses();

            for (int i = 0; i < slist.Length; i++)
            {
                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t{4}\t{5}\t{6}", slist[i].Id, slist[i].name, slist[i].DOB, clist[i].Course_id,
                    clist[i].Course_name, clist[i].Duration, clist[i].Fees);
                int ids = slist[i].Id;
                string snm = slist[i].name;
                DateTime DOB = slist[i].DOB;
                int id = clist[i].Course_id;
                string nm = clist[i].Course_name;
                float Dur = Convert.ToInt32(clist[i].Duration);
                double Fees = clist[i].Fees;

                e[i] = new Enroll();
                {
                    int CourseId = ids;
                    string CourseName = snm;
                    float Duration = Dur;
                    double fees = Fees;
                    int Id = ids;
                    string Name = snm;
                    DateTime dateofbirth = DOB;
                };
            }
        }
        public Enroll[] listOfEnrollments()
        {

            Enroll[] e1 = new Enroll[1];
            for (int i = 0; i < e1.Length; i++)
            {
                e1[i] = new Enroll()
                {
                    course = e1[i].course,
                    student = e1[i].student,
                    enrollmentDate = e1[i].enrollmentDate,
                };
            }
            return e1;
        }
    }
}