using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntity;
using SMSException;
using SMS_DAL;
using System.IO;
using System.Text.RegularExpressions;
namespace SMS_BLL
{
    /// <summary>
    /// To create the Validation method and to invoke the operations from DAL
    /// </summary>
    public class StudentBLL
    {
        static List<Student> sList = new List<Student>();
        private static bool ValidateStudent( Student student)
        {

            bool validstudent = true;
            StringBuilder message = new StringBuilder();
            if ((student.StudentId <= 0) || (student.StudentId.ToString() == string.Empty))
            {
                validstudent = false;
                message.Append(Environment.NewLine + "student ID Required and cannot be 0");
            }
            //Validating the student ID for matching excatly with 6 digits
            if (!(Regex.IsMatch(student.StudentId.ToString(), @"^[0-9]{6}$")))
            {
                validstudent = false;
                message.Append(Environment.NewLine + "student ID must contain 6 digits only");
            }
            //Validating the student Name for containing only Alphabets
            if (!(Regex.IsMatch(student.StudentName, @"^[A-Z][a-z]+$")))
            {
                validstudent = false;
                message.Append(Environment.NewLine + "Student Name must contain Alphabets only");
            }

            //Validating the student Course Name for being empty, then assign Course = Computer
            if (student.CourseName.Equals(string.Empty))
            {
                student.CourseName = "Computer";
                //student  student1 = new student();
                //student.studentName = student1.studentName ;
            }
            else 
            {
                { validstudent = true; }
            }

            // validating for grades to be only A,B,C,F
            if (Student.Grade != 'A' && Student.Grade != 'B' && Student.Grade != 'C' && Student.Grade != 'F')
            {
                message.Append("Grade should either be A or B or C or F\n");
                validstudent = false;
            }

            if (validstudent == false)
            {
                throw new StudentException(message.ToString());
            }
            return validstudent;
        }

        public bool AddStudentBL(Student student)
        {
            StudentDAL studentOperations = new StudentDAL();

            bool isAdded = false;
            try
            {
                isAdded = studentOperations.AddStudentDAL(student);
                if (isAdded == false)
                {
                    throw new StudentException("Student Details not Added");
                }

            }
            catch (StudentException e)
            {
                throw e;
            }

            return isAdded;

        
        }

        public List<Student> DisplayStudentBL()
        { 
            StudentDAL studentOperations = new StudentDAL();
            try
            {
                sList = studentOperations.DisplayStudentDAL();
                if (sList.Count <= 0)
                {
                    throw new StudentException("No Records Found!!!");

                }
            }
            catch (StudentException e)
            {
                throw e;
            }

            return sList;
        }

        public void SaveToFile()
        {
            try
            {
                StudentDAL dalobj = new StudentDAL();
                dalobj.SerializeStudent();
            }

            catch (StudentException e)
            { throw e; }

            catch (IOException e)
            { throw e; }
        }

        public List<Student> DisplayFromFile()
        {
            List<Student> sList = new List<Student>();
            try
            {
                StudentDAL dalobj = new StudentDAL();
                
                sList = dalobj.DeserializeStudent();
                if (sList.Count <= 0) throw new StudentException("No Records Found in File");
            }

            catch (StudentException e)
            { throw e; }

            catch (IOException e)
            { throw e; }
          return sList;
        }


    }
}
