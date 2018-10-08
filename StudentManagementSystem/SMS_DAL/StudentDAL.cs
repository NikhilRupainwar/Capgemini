using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntity;
using SMSException;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SMS_DAL
{
    /// <summary>
    /// To create the methods for performing operations on StudentEntity
    /// Author:CG
    /// DOC:23rd Jan 2017
    /// </summary>
    public class StudentDAL
    {
      static List<Student> studentList = new List<Student>();
        /// <summary>
        /// Function for inserting data into the list
        /// </summary>
        /// <param name="newstudent"></param>
        /// <returns></returns>
      public bool AddStudentDAL(Student newstudent)
      {
          bool isStudentAdded = false;
          try
          {
              studentList.Add(newstudent);
              isStudentAdded = true;
          }

          catch (StudentException)
          {
              throw;
          }
          return isStudentAdded ;
      }
        /// <summary>
        /// Function for displaying the data from the student List
        /// </summary>
        /// <returns></returns>
      public List<Student> DisplayStudentDAL()
      {
       // if(studentList.Count <=0)

          return studentList;
      
      }

      public void SerializeStudent()
      {
          FileStream fs = new FileStream("Emp.txt", FileMode.Create);
          BinaryFormatter formatter = new BinaryFormatter();
          formatter.Serialize(fs, studentList);
          fs.Close();
            
      }
      public List<Student> DeserializeStudent()
      {
          FileStream fs = new FileStream("Emp.txt", FileMode.Open);
          BinaryFormatter formatter = new BinaryFormatter();
          List<Student> deserializedList = new List<Student>();
          deserializedList = (List<Student>)formatter.Deserialize(fs);
          return deserializedList;

      }
    }
}
