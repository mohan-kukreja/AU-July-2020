using System;
using System.Data;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace NET_Delegates
{

    class SQLConnect
    {
        SqlConnection conn;
        string connectionString;
        SqlDataAdapter ad;
        DataSet ds;


        
        public SQLConnect()
        {
            string connetionString = null;
            MySqlConnection conn;
            connetionString = "server=localhost;database=dbone;uid=root;";
            conn = new MySqlConnection(connetionString);
            conn.Open();
            ds = new DataSet();
        }
        public void Display_Employee()
        {
            Console.WriteLine("Employee table \n");
            ad = new SqlDataAdapter("Select * from Employee", conn);
            ds = new DataSet();
            ad.Fill(ds);
            if (ds != null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    Console.WriteLine("Employee ID: " + ds.Tables[0].Rows[i]["EmpID"] + " Employee Name:" + ds.Tables[0].Rows[i]["EmpName"] + "Department ID: " + ds.Tables[0].Rows[i]["DeptID"]);
                }
            }
        }
       
        public void Display_Department()
        {
            Console.WriteLine("Displaying department\n");
            ad = new SqlDataAdapter("Select * from dept", conn);
            ds = new DataSet();
            ad.Fill(ds);
            if (ds != null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    Console.WriteLine("Department ID: " + ds.Tables[0].Rows[i]["DeptID"] + " Department Name:" + ds.Tables[0].Rows[i]["DeptName"]);
                }


            }
            
        }
       
        public void Insert_Into_Department()
        {
          
            Console.WriteLine("Enter Department ID ");
            string deptid = Console.ReadLine();
            Console.WriteLine("Enter Department Name ");
            string deptname = Console.ReadLine();
            string sqlQuery = "execute Insert_Dept " + "'" + deptid + "'" + "," + "'" + deptname + "'" + ";";
           
            SqlCommand command = new SqlCommand(sqlQuery, conn);
            Console.WriteLine("Data Successfully Inserted\n");
        }

        public void Delete_From_Employee()
        {
            string empid;
            Console.WriteLine("Enter Employee ID of the record to be deleted");
            empid = Console.ReadLine();

            string sqlQuery = "execute delete_from_employee " + "'" + empid + "'" + ";";
            int rowAffected = 0;
            SqlCommand command = new SqlCommand(sqlQuery, conn);
            rowAffected = command.ExecuteNonQuery();
            Console.WriteLine("Data Deleted Successfully");

        }


        
        public void Department_of_Employees()
    {
        string sqlQuery = "execute department_of_employees;";
        ad = new SqlDataAdapter(sqlQuery, conn);
        ds = new DataSet();
        ad.Fill(ds);
        if (ds != null)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine("Employee ID: " + ds.Tables[0].Rows[i]["EmpID"] + " Employee Name:" + ds.Tables[0].Rows[i]["EmpName"] + "Department Name: " + ds.Tables[0].Rows[i]["DeptName"]);
            }
        }
    }




}
    class Program
    {
        static void Main(string[] args)
        {
            SQLConnect sq = new SQLConnect();
            sq.Insert_Into_Department();
            sq.Display_Department();

            sq.Display_Employee();
            sq.Delete_From_Employee();
            sq.Display_Employee();
            


        }
    }
    


   
}
