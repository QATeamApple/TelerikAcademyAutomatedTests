namespace QA.TelerikAcademy.Core.Pages.AdminPages.EvaluationModulesPages.ExportResults
{
    public class Course
    {
        public Course(int courseId = 0, int studentsId = 0, bool isLive = false)
        {
            this.CourseId = courseId;
            this.StudentsId = studentsId;
            this.IsLive = isLive;
        }

        public int CourseId { get; set; }

        public int StudentsId { get; set; }

        public bool IsLive { get; set; }
    }
}
