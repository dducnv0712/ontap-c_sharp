using System;
using baiontapc_sharp.Controllers;
using baiontapc_sharp.Models;

namespace baiontapc_sharp
{
    public enum StudentStatus
    {
        Active = 1,
        Deactive = 0
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
          var studentController = new StudentController();

          var st = studentController.CreateStudent();
          
          Console.WriteLine(st.ToString());
        }
    }
}