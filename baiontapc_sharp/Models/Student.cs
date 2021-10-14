using System;

namespace baiontapc_sharp.Models
{
    public class Student
    {

        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public StudentStatus Status { get; set; }
        

        public bool IsNewStudent()
        {
            //
            return true;
        }


        public bool IsDeactive()
        {
            return false;
        }
        
        public override string ToString()
        {
            return $"{RollNumber}----------|----------{FullName}----------|----------{Birthday}----------|----------{Phone}----------|----------{Email}----------|----------{Status}";
        }
    }
    
}