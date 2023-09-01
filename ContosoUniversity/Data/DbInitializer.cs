using ContosoUniversity.Models;

namespace ContosoUniversity.Data;

public static class DbInitializer
{
    public static void Initialize(SchoolContext context)
    {
        if (context.Students.Any())
        {
            return;  
        }
        var students = new Student[]
        {
            new Student() {FirstName="Pop",LastName="Smoke",EnrollmentDate=DateTime.Parse("2019")},
            new Student() {FirstName="50",LastName="Cent",EnrollmentDate=DateTime.Parse("2019")},
            new Student() {FirstName="King",LastName="Von",EnrollmentDate=DateTime.Parse("2019")},
            new Student() {FirstName="DJ",LastName="Khaled",EnrollmentDate=DateTime.Parse("2019")}
        };
        context.Students.AddRange(students);
        foreach (Student s in students) 
        { 
            context.Students.Add(s);
        }
        context.SaveChanges();
        var courses = new Course[]
        {

        };
    }
}
