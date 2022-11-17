using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Infinite_Casestudy1
{
    public class Register
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection GetConnection()
        {
            con = new SqlConnection("data source=ICS-LAP-6624;initial catalog=MINI_PROJECT;" +
                "Integrated Security=True");
            con.Open();
            return con;
        }
        public static void register1()
        {
            con = GetConnection();
            try
            {
                Console.WriteLine("Enter the student name, date of birth");
                string name = Console.ReadLine();
                DateTime DOB = Convert.ToDateTime(Console.ReadLine());
                cmd = new SqlCommand("insert into Student values(@name,@dob)", con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dob", DOB);
                int v = cmd.ExecuteNonQuery();

                if (v > 0)
                {
                    Console.WriteLine("Registered successfully....");
                }
                else
                {
                    Console.WriteLine("something went wrong");
                }
            }
            catch(SystemException)
            {
                Console.WriteLine("Error in the database...");
            }
        }
        public static void Selectdata()
        {
            con = GetConnection();
            cmd = new SqlCommand("select * from student", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }
        }
        public static void Introduce1()
        {
            con = GetConnection();
            try
            {
                Console.WriteLine("Enter the course id, name, duration and fees : ");
                int Course_id = Convert.ToInt32(Console.ReadLine());
                string Course_name = Console.ReadLine();
                float Duration = float.Parse(Console.ReadLine());
                float Fees = float.Parse(Console.ReadLine());
                cmd = new SqlCommand("insert into course values(@id,@name,@duration,@fees)", con);
                cmd.Parameters.AddWithValue("@id", Course_id);
                cmd.Parameters.AddWithValue("@name", Course_name);
                cmd.Parameters.AddWithValue("@duration", Duration);
                cmd.Parameters.AddWithValue("@fees", Fees);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    Console.WriteLine("Course Added successfully....");
                    Console.WriteLine("Completed.....");
                }
                else
                {
                    Console.WriteLine("something went wrong");
                }
            }
            catch (SystemException)
            {
                Console.WriteLine("Error in database..");
            }
        }
        public static void Select()
        {
            con = GetConnection();
            cmd = new SqlCommand("select * from course", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
                Console.WriteLine(dr[2] +" "+"months"); 
                Console.WriteLine(dr[3]);
            }
        }
        public static void Update()
        {
            con = GetConnection();
            Console.WriteLine("Enter the student id to update: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you want to update your name, Enter the new one:");
            string Name = Console.ReadLine();
            Console.WriteLine("If you wanna update DOB, Enter the updated one:");
            DateTime DOB = Convert.ToDateTime(Console.ReadLine());
            cmd = new SqlCommand("update student set Name=@Name,DOB=@dateofbirth where Id=@id", con);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@dateofbirth", DOB);
            int records = cmd.ExecuteNonQuery();
            if (records > 0)
            {
                Console.WriteLine("updated successfull....");
            }
            else
            {
                Console.WriteLine("something went wrong");
            }
        }
        public static void DeleteStudent()
        {
            con = GetConnection();
            Console.WriteLine("Enter the Student Id:");
            int Id = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from student where Id=@id", con);
            cmd1.Parameters.AddWithValue("@id",Id );
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you Sure to delete this Student info? Y/N :");
            string status = Console.ReadLine();
            if (status == "y" || status == "Y")
            {
                cmd = new SqlCommand("delete from student where Id=@id", con);
                cmd.Parameters.AddWithValue("@id", Id);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Student Information Deleted Successfully...");
                }
                else
                    Console.WriteLine("Contact DBA..");
            }
            else
            {
                Console.WriteLine("You Opted not to delete the Student info");
            }
        }
        public static void DeleteCourse()
        {
            con = GetConnection();
            Console.WriteLine("Enter the Course to delete:");
            int Course_id = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from Course where Course_id=@id", con);
            cmd1.Parameters.AddWithValue("@id",Course_id);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you Sure to delete this Course? Y/N :");
            string status = Console.ReadLine();
            if (status == "y" || status == "Y")
            {
                cmd = new SqlCommand("delete from Course where Course_id=@id", con);
                cmd.Parameters.AddWithValue("@id", Course_id);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Course Deleted Successfully...");
                }
                else
                    Console.WriteLine("Contact DBA..");
            }
            else
            {
                Console.WriteLine("You Opted not to delete the Course");
            }
        }
        public static void Student_enroll()
        {
            con = GetConnection();
            try
            {
                Console.WriteLine("You can only enroll the existing student and course details :");
                Console.WriteLine("Enter the student id and course id : ");
                int Id = Convert.ToInt32(Console.ReadLine());
                int Course_id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("insert into student_enroll values(@id,@cid)", con);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@cid", Course_id);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    Console.WriteLine("Enrollment is successfull....");
                    Console.WriteLine("Thank You");
                }
                else
                {
                    Console.WriteLine("something went wrong");
                }
            }
            catch (SystemException)
            {
                Console.WriteLine("Error in the database...");
            }
        }
        public static void Display_enroll()
        {
            con = GetConnection();
            cmd = new SqlCommand("SELECT E.EID, S.*,C.* FROM STUDENT_ENROLL E JOIN STUDENT S ON E.ID = S.ID JOIN COURSE C ON E.COURSE_ID =C.COURSE_ID", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0]+ " " + dr[1] + " " + dr[2] + " " +dr[3] + " " +dr[4] + " " + dr[5] + " " + dr[6] + " " + dr[7]);
            }
        }
        public static void DeleteEnroll()
        {
            con = GetConnection();
            Console.WriteLine("Enter the Enroll Id:");
            int EId = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from student_enroll where Id=@id", con);
            cmd1.Parameters.AddWithValue("@id", EId);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you Sure to delete this Enrollment? Y/N :");
            string status = Console.ReadLine();
            if (status == "y" || status == "Y")
            {
                cmd = new SqlCommand("delete from student_enroll where Id=@id", con);
                cmd.Parameters.AddWithValue("@id", EId);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Enrollment Information Deleted Successfully...");
                }
                else
                    Console.WriteLine("Contact DBA..");
            }
            else
            {
                Console.WriteLine("You Opted not to delete the enrollment details");
            }
        }
    }
}
