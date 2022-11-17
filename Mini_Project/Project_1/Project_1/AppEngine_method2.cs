using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Casestudy1
{
    class AppEngine_method2
    {
        public void introduce_2()
        {
            Register.Introduce1();
        }

        public void register_2()
        {
            Register.register1();
        }

        public void listOfStudents_2()
        {
            Register.Selectdata();
        }

        public void listOfCourses_2()
        {
            Register.Select();
        }

        public void enroll()
        {
            Console.Write("Enter the total number of students : ");
            int StdCount = Convert.ToInt32(Console.ReadLine());
            Student[] std = new Student[StdCount];
            for (int i = 0; i <= StdCount - 1; i++)
            {
                Register.register1();
                Register.Introduce1();
            }
        }

        public void listOfEnrollments_2()
        {
            Register.Selectdata();
            Register.Select();
        }
    }
}
