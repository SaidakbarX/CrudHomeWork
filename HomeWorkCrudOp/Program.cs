using HomeWorkCrudOp.moduls;
using HomeWorkCrudOp.study;
using System.Net.Cache;

namespace HomeWorkCrudOp
{
    internal class Program
    {
        public static object studentServices;

        static void Main(string[] args)
        {
            RunFrontEnd();
        }
        public static void RunFrontEnd()
        {
            var students = new StudentServices();
            while (true)
            {
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Delete Student");
                Console.WriteLine("3.Update Student");
                Console.WriteLine("4.Get All Student");
                Console.WriteLine("5.Get By Id Student");
                Console.Write("Enter: ");
                var alternative = Console.ReadLine();
                if (alternative == "1")
                {
                    var student = new Student();
                    Console.Write("Enter name: ");
                    student.Name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    student.Age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Location : ");
                    student.Location = Console.ReadLine();
                    Console.Write("Enter Reyting : ");
                    student.Reyting = int.Parse(Console.ReadLine());
                    Console.Write("Enter  CameAndWent : ");
                    student.CameAndWent = Console.ReadLine();
                    Console.Write("Enter Charakter : ");
                    student.Character = Console.ReadLine();
                    student.Willingly = DateTime.Now;
                    students.AddStudent(student);
                }
                else if (alternative == "2")
                {
                    Console.Write("Enter of to delete");
                    var Id = Guid.Parse(Console.ReadLine());
                    var resFromFunc = students.DeleteStudent(Id);
                    Console.WriteLine(resFromFunc);


                }
                else if (alternative == "3")
                {
                    var student = new Student();
                    Console.Write("Enter of id updayted  ");
                    student.Id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter Name ");
                    student.Name = Console.ReadLine();
                    Console.Write("Enter Age ");
                    student.Age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Location");
                    student.Location = Console.ReadLine();
                    Console.Write("Enter of Reyting ");
                    student.Reyting = int.Parse(Console.ReadLine());
                    Console.Write("Enter of came end wend");
                    student.CameAndWent = Console.ReadLine();
                    Console.Write("Enter of character student ");
                    student.Character = Console.ReadLine();
                    Console.Write("Enter Data Time ");
                    student.Willingly = DateTime.Parse(Console.ReadLine());

                    students.UpdeteStudent(student);
                }
                else if (alternative == "4")
                {
                    var student = students.GetAllStudent();
                    foreach (var studentr in student)
                    {
                        string info = $"Id : {studentr.Id},Name : {studentr.Name},Age : {studentr.Age}," +
                            $"Location : {studentr.Location},Reyting : {studentr.Reyting}," +
                            $"Cam and went  : {studentr.CameAndWent},Character : {studentr.Character}" +
                            $"Date time : {studentr.Willingly}";
                        Console.WriteLine(info);
                    }
                }
                else if (alternative == "5")
                {
                    Console.WriteLine("Enter id to get ");
                    var Id = Guid.Parse(Console.ReadLine());
                  var student = students.Getby(Id);
                    string info = $"Id : {student.Id},Name : {student.Name},Age : {student.Age}" +
                        $"Location : {student.Location},Reting : {student.Reyting}," +
                        $"Cam and went : {student.CameAndWent},Character : {student.Character}" +
                        $"Date time : {student.Willingly}";
                    Console.WriteLine(info);

                }
                Console.ReadKey();
                Console.Clear();

            }

        }
    }
}
