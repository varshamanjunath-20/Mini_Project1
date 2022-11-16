using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Casestudy1
{
    public abstract class Case_study3
    {
        public void showFirstScreen()
        {
            try
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Welcome to Student Management System");
                Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin\n3. Exit");
                Console.WriteLine("Enter your choice ( 1 or 2 or 3) : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        showAdminScreen();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Your Choice is invalid...", op);
                        showFirstScreen();
                        break;
                }
            }
            catch (SystemException)
            {
                Console.WriteLine("error");
                showFirstScreen();
            }
        }
        public void showStudentScreen()
        {
        StartScreen:
            try
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Enter your choice....");
                Console.WriteLine("   ");
                Console.WriteLine("1. To see all the student list ");
                Console.WriteLine("2. To see all the Course list ");
                Console.WriteLine("3. student register screen");
                Console.WriteLine("4. Go back to first screen");
                Console.WriteLine("5. exit");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        showAllStudentsScreen();
                        goto StartScreen;
                    case 2:
                        showAllCoursesScreen();
                        goto StartScreen;
                    case 3:
                        showStudentRegistrationScreen();
                        goto StartScreen;
                    case 4:
                        showFirstScreen();
                        break;
                    case 5:
                        Console.WriteLine("Are You sure, you want to exit ??");
                        Console.WriteLine("enter y or n");
                        string type = Console.ReadLine();
                        if (type == "Y" || type == "y")
                        {
                            break;
                        }
                        else
                        {
                            goto StartScreen;
                        }
                    default:
                        Console.WriteLine("Please enter the valid option", op);
                        showStudentScreen();
                        break;
                }
            }
            catch (SystemException)
            {
                Console.WriteLine("error");
                showStudentScreen();
            }
        }
        public void showAdminScreen()
        {
        StartFirstScreen:
            try
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Welcome back Admin..!!!");
                Console.WriteLine("Enter your Choice...");
                Console.WriteLine(" ");
                Console.WriteLine("1. To see all students list");
                Console.WriteLine("2. Add Enrollments");
                Console.WriteLine("3. To see the enrollments");
                Console.WriteLine("4. To delete Enrollments");
                Console.WriteLine("5. introduce new courses");
                Console.WriteLine("6. To see all the courses");
                Console.WriteLine("7. Delete Course");
                Console.WriteLine("8. Update Student details");
                Console.WriteLine("9. Delete Student");
                Console.WriteLine("10. Go back to first screen");
                Console.WriteLine("11. Exit");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        showAllStudentsScreen();
                        goto StartFirstScreen;
                    case 2:
                        Enrollments();
                        break;
                    case 3:
                        Display_enroll();
                        goto StartFirstScreen;
                    case 4:
                        Delete_Enrollments();
                        goto StartFirstScreen;
                    case 5:
                        introduceNewCourseScreen();
                        goto StartFirstScreen;
                    case 6:
                        showAllCoursesScreen();
                        goto StartFirstScreen;
                    case 7:
                        DeleteCourse();
                        goto StartFirstScreen;
                    case 8:
                        UpdateStudent();
                        goto StartFirstScreen;
                    case 9:
                        DeleteStudent();
                        goto StartFirstScreen;
                    case 10:
                        showFirstScreen();
                        break;
                    case 11:
                        Console.WriteLine("Are You sure, you want to exit ??");
                        Console.WriteLine("enter y or n");
                        string type = Console.ReadLine();
                        if (type == "Y" || type == "y")
                        {
                            break;
                        }
                        else
                        {
                            goto StartFirstScreen;
                        }
                    default:
                        Console.WriteLine("Please enter the valid option", op);
                        showAdminScreen();
                        break;
                }
            }
            catch (SystemException)
            {
                Console.WriteLine("Error..........Please enter the vaild number");
                showAdminScreen();
            }
        }
        public void showAllStudentsScreen()
        {
            Register.Selectdata();
        }

        public void showStudentRegistrationScreen()
        {
            Register.register1();
            showAllStudentsScreen();
        }
        public void introduceNewCourseScreen()
        {
            Register.Introduce1();
            showAllCoursesScreen();
        }
        public void showAllCoursesScreen()
        {
            Register.Select();
        }
        public void DeleteCourse()
        {
            Register.DeleteCourse();
            showAllCoursesScreen();
        }
        public void DeleteStudent()
        {
            Register.DeleteStudent();
            showAllStudentsScreen();
            
        }
        public void UpdateStudent()
        {
            Register.Update();
            showAllStudentsScreen();
        }
        public void Enrollments()
        {
            Register.Student_enroll();
            Register.Display_enroll();
            showAdminScreen();
        }
        public void Delete_Enrollments()
        {
            Register.DeleteEnroll();
            Register.Display_enroll();
        }
        public void Display_enroll()
        {
            Register.Display_enroll();
            
        }

    }
}

