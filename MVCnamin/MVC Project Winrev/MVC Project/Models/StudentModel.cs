
namespace MVC_Project.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MI { get; set; }
        public string LastName { get; set; }
        public string Hobbies { get; set; }
        public string BirthDate { get; set; }

        public string FullName
        {
            get { return FirstName + " " + MI + " " + LastName; }
        }
    }
}