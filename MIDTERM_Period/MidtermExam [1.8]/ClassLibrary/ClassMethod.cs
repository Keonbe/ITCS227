using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClassMethod
    {

        static ArrayList studentID = new ArrayList();
        static ArrayList studentName = new ArrayList();
        static ArrayList courseYearSection = new ArrayList();
        static ArrayList password = new ArrayList();

        #region properties
        public static ArrayList StudentID { get => studentID; set => studentID = value; }
        public static ArrayList StudentName { get => studentName; set => studentName = value; }
        public static ArrayList CourseYearSection { get => courseYearSection; set => courseYearSection = value; }
        public static ArrayList Password { get => password; set => password = value; }
        #endregion

        public void SaveRecord(string studentID, string studentName, string courseYearSection, string password) { //STATIC 
            StudentID.Add(studentID); //PROPERTIES for gridview
            StudentName.Add(studentName);
            CourseYearSection.Add(courseYearSection);
            Password.Add(password);
        }
    }
}
