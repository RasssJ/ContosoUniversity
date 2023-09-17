namespace ContosoUniversity.Models
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Course { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}