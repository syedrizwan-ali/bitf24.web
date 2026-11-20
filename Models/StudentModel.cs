using FCIT.BITF24A.Web.OrmModels;

namespace FCIT.BITF24A.Web.Models
{
    public class StudentModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public DateTime CreateOn { get; set; }

        public StudentModel()
        {
            
        }

        public StudentModel(Student student)
        {
            ID = student.Id;
            Name = student.Name;
            RollNumber = student.RollNumber;
            CreateOn = student.CreatedOn;
        }
    }
}
