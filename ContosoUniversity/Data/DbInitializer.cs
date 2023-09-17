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
                new Student() {FirstMidName="Palmi",LastName="Lahe",EnrollmentDate=DateTime.Parse("2021-09-01")},
                new Student() {FirstMidName="Kommi",LastName="Onu",EnrollmentDate=DateTime.Parse("2021-09-01")},
                new Student() {FirstMidName="Risto",LastName="Koort",EnrollmentDate=DateTime.Parse("2021-09-01")},
                new Student() {FirstMidName="Kregor",LastName="Latt",EnrollmentDate=DateTime.Parse("2021-09-01")},
                new Student() {FirstMidName="Joonas",LastName="Õispuu",EnrollmentDate=DateTime.Parse("2021-09-01")}
            };
            //context.Students.AddRange(students);
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var instructors = new Instructor[]
            {
                new Instructor {FirstMidName = "Jõulu", LastName = "Vana", HireDate = DateTime.Parse("1995-03-11")},
                new Instructor {FirstMidName = "Rootsi", LastName = "Kuningas", HireDate = DateTime.Parse("1995-03-11")},
                new Instructor {FirstMidName = "Balta", LastName = "Parm", HireDate = DateTime.Parse("1995-03-11")},
                new Instructor {FirstMidName = "Kinder", LastName = "Suprise", HireDate = DateTime.Parse("1995-03-11")},
            };
            foreach (Instructor i in instructors)
            {
                context.Instructors.Add(i);
            }
            context.SaveChanges();

            var departments = new Department[]
            {
                new Department
                {
                    Name = "Infotechnology",
                    Budget = 0,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = instructors.Single(i => i.LastName == "Parm").ID
                },
                new Department
                {
                    Name = "Joomarlus",
                    Budget = 0,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = instructors.Single(i => i.LastName == "Vana").ID
                },
                new Department
                {
                    Name = "Internet Trolling & Tiktok 101",
                    Budget = 0,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = instructors.Single(i => i.LastName == "Kuningas").ID
                },
                new Department
                {
                    Name = "Kokandus",
                    Budget = 0,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = instructors.Single(i => i.LastName == "Suprise").ID
                },
            };
            foreach (Department d in departments)
            {
                context.Departments.Add(d);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course() {CourseID=1050,Title="Programmeerimine",Credits=160},
                new Course() {CourseID=6900,Title="Keemia",Credits=160},
                new Course() {CourseID=1420,Title="Matemaatika",Credits=160},
                new Course() {CourseID=6666,Title="Testimine",Credits=160},
                new Course() {CourseID=1234,Title="Riigikaitse",Credits=160}
            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var officeAssignments = new OfficeAssignment[]
            {
                new OfficeAssignment()
                {
                    InstructorID = instructors.Single(i => i.LastName == "Vana").ID,
                    Location = "A236",
                },
                new OfficeAssignment()
                {
                    InstructorID = instructors.Single(i => i.LastName == "Parm").ID,
                    Location = "Balta turu värav",
                },
                new OfficeAssignment()
                {
                    InstructorID = instructors.Single(i => i.LastName == "Suprise").ID,
                    Location = "Kaubik kooli ees",
                }
            };
            foreach (OfficeAssignment o in officeAssignments)
            {
                context.OfficeAssignments.Add(o);
            }
            context.SaveChanges();

            var courseInstructors = new CourseAssignment[]
            {
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Keemia").CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Parm").ID
                },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Riigikaitse").CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Parm").ID
                },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Matemaatika").CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Parm").ID
                },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Keemia").CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Vana").ID
                },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Programmeerimine").CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Vana").ID
                },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Matemaatika").CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Suprise").ID
                },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Riigikaitse").CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Suprise").ID
                },
            };
            foreach (CourseAssignment ci in courseInstructors)
            {
                context.CourseAssignments.Add(ci);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=6900,Grade=Grade.B},
                new Enrollment{StudentID=1,CourseID=1420,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=2,CourseID=1050,Grade=Grade.C},
                new Enrollment{StudentID=2,CourseID=6900,Grade=Grade.D},
                new Enrollment{StudentID=3,CourseID=1420,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=3,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=3,CourseID=6900,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1420,Grade=Grade.A},
                new Enrollment{StudentID=4,CourseID=1050,Grade=Grade.D},
                new Enrollment{StudentID=5,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=5,CourseID=6900,Grade=Grade.A},
                new Enrollment{StudentID=5,CourseID=1420,Grade=Grade.F},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();


        }
    }
}