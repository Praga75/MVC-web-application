
namespace StudentDatabase.Entity
{
    public class Student
    {
        public int studentID;
        public string studentName;
        public string department;
        public string institutionName;
        public double studentPercentage;

        public Student(int studentId,string studentName,string department,string institutionName,double studentPercentage)
        {
            this.studentID = studentId;
            this.studentName = studentName;
            this.department = department;
            this.institutionName = institutionName;
            this.studentPercentage = studentPercentage;
        }

    }
}
