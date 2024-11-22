using HomeWorkCrudOp.moduls;
using System.Net.Cache;

namespace HomeWorkCrudOp.study;

public class StudentServices
{
    private List<Student>students;
    public StudentServices()
    
    {
        students = new List<Student>();
        DataSeed();
    }

    public Student AddStudent(Student student)
    {
        student.Id = Guid.NewGuid();
        students.Add(student);
        return student;
    }
    public bool DeleteStudent(Guid studentId)
    {
        var exist = false;
        foreach (var student in students)
        {
            if (student.Id == studentId)
            {
                students.Remove(student);
                exist = true;
                break;
            }
        }
        return exist;
    }
    public bool UpdeteStudent(Student updateStudent)
    {
        for (var i = 0; i < students.Count; i++)
        {
            if (students[i].Id == updateStudent.Id)
            {
                students[i] = updateStudent;
                return true;
            }
        }
        return false;

    }
    public Student Getby(Guid studentId)
    {
        foreach (var student in students)
        {
            if (studentId == student.Id)
            {
                return student;
            }
        }
        return null;
    }
    public List<Student> GetAllStudent()
    {
        return students;
    }
    private void DataSeed()
    {
        var firstStudent = new Student()
        {
            Id = Guid.NewGuid(),
            Name = "Islom",
            Age = 18,
            Location = "PDP akademiyasini oldida ",
            Reyting = 4,
            CameAndWent = "kegan",
            Character = "ogirbosiq",
       
        };
        var secondStudent = new Student()
        {
            Id = Guid.NewGuid(),
            Name = "Boymurod",
            Age = 24,
            Location = "Medgaradok",
            Reyting = 3,
            CameAndWent = "kelgan",
            Character = "hech narsani tushunmaydi"
        };
        students.Add(firstStudent);
        students.Add(secondStudent);


    }


}

