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
            new Course() {CourseId=1050, Title="Programmeerimine",Credits=160},
            new Course() {CourseId=6900, Title="Keemia",Credits=160},
            new Course() {CourseId=1420, Title="Matemaatika",Credits=160},
            new Course() {CourseId=6666, Title="Testimine",Credits=160},
            new Course() {CourseId=1234, Title="Riigikaitse",Credits=160}
        };
        foreach (Course c in courses)
        {
            context.Courses.Add(c);
        }
        context.SaveChanges();

        var enrollments = new Enrollment[]
        {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=6900,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=1420,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=6666,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=1234,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.F},
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.D},
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A}
        };
        foreach (Enrollment c in enrollments)
        {
            context.Enrollmetns.Add(c);
        }
        context.SaveChanges();
    }
}
