using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMSException;
using StudentEntity;
using SMS_BLL;

namespace SMS_PL
{
    /// <summary>
    /// Console Application to Manage the Student Info
    /// Author: Nikhil Rupainwar
    /// DOC: 23- Jan -17
    /// </summary>
    class Program
    {

        public static void AddStudentPL()
        {
            try
            {
                Student objStudent = new Student();
                Console.WriteLine("Enter the Student ID :");
                bool chkid;
                int sid;
                //Use TryParse to chk if the entered value is parseable or not
                chkid = Int32.TryParse(Console.ReadLine(), out sid);
                //If the Parsing fails, throw the Exception
                if (!chkid) throw new StudentException("Invalid Entry");
                // If the Parsing is successful, store the StudentId into the Entity object
                else objStudent.StudentId = sid;
                Console.WriteLine("Enter Student Name:");
                objStudent.StudentName = Console.ReadLine();
                Console.WriteLine("Enter the Grade only in Uppercase:");
                char Grade =  Convert.ToChar(Console.ReadLine());

                StudentBLL bllobj = new StudentBLL();
                if (bllobj.AddStudentBL(objStudent) == false)
                {
                    throw new StudentException("Student Record could not be added");

                }

                else
                    Console.WriteLine("Student Details Added Successfully");
            }

            catch (StudentException e)
            {
                Console.WriteLine("Error occurred " + e.Message);
            }
        }
        public static void DisplayStudentPL()
        {
            try
            {
                SMS_BLL.StudentBLL bllobj = new StudentBLL();
                List<Student> sList = new List<Student>();
                sList = bllobj.DisplayStudentBL();
                Console.WriteLine("Student Details");
                Console.WriteLine("=================");
                foreach (Student s in sList)
                {
                    Console.WriteLine("Student Id :{0}\n Student Name :{1} \n Student Grade :{2}", s.StudentId, s.StudentName, Student.Grade);

                }

            }
            catch (StudentException e)
            {
                Console.WriteLine(e.Message);
            }
        
        }
        public static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("*****Student Management System*************");
            Console.WriteLine("1.  To Add Student Details  - Press 1,");
            Console.WriteLine("2.  To Display All Students - Press 2,");
            Console.WriteLine("3.  To Search a Student     - Press 3,");
           // Console.WriteLine("4.  To Serialize Data       - Press 3,");
          //  Console.WriteLine("5.  To Deserialize Data     - Press 4,");
            Console.WriteLine("4.  To Exit the Application - Press 5,");
            Console.WriteLine("*********************************************");
        }
        static void Main(string[] args)
        {
            int userchoice;
            bool chkchoice;
            do
            {
                PrintMenu();
                Console.WriteLine("Enter Your Choice from the Menu");
                chkchoice = Int32.TryParse(Console.ReadLine(), out userchoice);
                if (!chkchoice)
                    Console.WriteLine("Enter a Valid Choice from the Menu");
                else
                    switch (userchoice)
                    {
                        case 1: AddStudentPL();
                            break;
                        case 2: DisplayStudentPL();
                            break;
                        //case 3: SearchProduct();
                        //    break;
                        //case 4: SerializePL();
                        //    break;
                        //case 5: DeserializePL();
                        //    break;
                        case 4: break;
                        default: Console.WriteLine("Invalid Choice");
                            break;

                    }
            } while (userchoice != 4);


        }
    }
}
