using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student() {FirstMidName="Kaarel-Martin",LastName="Noole",EnrollmentDate=DateTime.Now},
                new Student() {FirstMidName="Marcus",LastName="Toman",EnrollmentDate=DateTime.Parse("2021-09-01")},
                new Student() {FirstMidName="Rasmus",LastName="Jalakas",EnrollmentDate=DateTime.Now},
                new Student() {FirstMidName="Karl Umberto",LastName="Kats",EnrollmentDate=DateTime.Now},
                new Student() {FirstMidName="Risto",LastName="Koort",EnrollmentDate=DateTime.Now},
            };

            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var course = new Course[]
            {
                new Course() {CourseID=1050,Title="Programmeerimine",Credits=160},
                new Course() {CourseID=6900,Title="Keemia",Credits=160},
                new Course() {CourseID=1420,Title="Matemaatika",Credits=160},
                new Course() {CourseID=6666,Title="Testimine",Credits=160},
                new Course() {CourseID=1234,Title="Riigikaitse",Credits=160},
            };

            foreach (Course c in course)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=6900,Grade=Grade.B},
                new Enrollment{StudentID=1,CourseID=1420,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=6666,Grade=Grade.A},
                new Enrollment{StudentID=2,CourseID=6666,Grade=Grade.C},
                new Enrollment{StudentID=2,CourseID=6666,Grade=Grade.A},
                new Enrollment{StudentID=2,CourseID=6666,Grade=Grade.B},
                new Enrollment{StudentID=3,CourseID=6666,Grade=Grade.B},
                new Enrollment{StudentID=3,CourseID=6666,Grade=Grade.A},
                new Enrollment{StudentID=3,CourseID=6666,Grade=Grade.F},
                new Enrollment{StudentID=4,CourseID=6666,Grade=Grade.A},
                new Enrollment{StudentID=4,CourseID=6666,Grade=Grade.C},
                new Enrollment{StudentID=5,CourseID=6666,Grade=Grade.D},
                new Enrollment{StudentID=5,CourseID=6666,Grade=Grade.B},
                new Enrollment{StudentID=6,CourseID=6666,Grade=Grade.A},
                new Enrollment{StudentID=7,CourseID=6666,Grade=Grade.B},
                new Enrollment{StudentID=7,CourseID=6666,Grade=Grade.C},
            };

            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}