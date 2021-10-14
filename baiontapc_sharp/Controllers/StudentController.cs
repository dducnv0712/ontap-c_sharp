using System;
using System.Collections.Generic;
using baiontapc_sharp.Models;
using baiontapc_sharp.Controllers;

namespace baiontapc_sharp.Controllers
{
    public class StudentController
    {
        public void PrintListStudent(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public Student CreateStudent()
        {
            //nhập thông tin sinh viên
           Console.WriteLine("Nhập Mã Sinh Viên");
           var maSv = Console.ReadLine();
           Console.WriteLine("Nhập Họ và Tên");
           var hoTen = Console.ReadLine();
           Console.WriteLine("Nhập Ngày Sinh");
           var ngaySinh = DateTime.Parse(Console.ReadLine());
           Console.WriteLine("Nhập SĐT");
           var phone = Console.ReadLine();
           Console.WriteLine("Nhập Email");
           var email = Console.ReadLine();
           Console.WriteLine("Trạng Thái");
           var trangThai = (StudentStatus) Int32.Parse( Console.ReadLine() ?? string.Empty);
           var student = new Student()
           {
               RollNumber = maSv,
               FullName = hoTen,
               Birthday = ngaySinh,
               Phone = phone,
               Email = email,
               Status = trangThai
           };
           return student;
        }

        
    }
}