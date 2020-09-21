using System;
using System.Text;

namespace Xay_dung_class_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "N. Hoa", "Đông Hà", 30);

            Student student2 = new Student();
            student2.SetId(2);
            student2.SetName("Th. Minh Nhật");
            student2.SetAddress("Huế");
            student2.SetAge(25);

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.Read();
        }
    }
}