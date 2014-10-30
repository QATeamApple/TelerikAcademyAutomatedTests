namespace QA.TelerikAcademy.Core.Pages.FrontEndUIPages.MainPage
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.TelerikAcademy.Core.Pages.AdminUIPages.EvaluationModulesPages.ExportResults;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Contracts;
    using System.Collections.Generic;

    public class ExportResultsPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/ExportResults";

        public ExportResultsPageMap Map
        {
            get
            {
                return new ExportResultsPageMap();
            }
        }

        public ExportResultsPageValidator Validator
        {
            get
            {
                return new ExportResultsPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void ExportExcel(List<Course> courses, bool points, bool honors, bool practicalExam, bool testExam, bool isLiveParticipant)
        {
            foreach (var course in courses)
            {
                if (course.StudentsId > 0)
                {
                    var studentsCheck = this.Map.StudentsCheckBox(course.StudentsId);
                    if (studentsCheck != null) studentsCheck.Check(true, false);

                    if (course.IsLive)
                    {
                        var isLive = this.Map.LiveCheckBox(course.StudentsId);
                        if (isLive != null) isLive.Check(true, false);
                    }
                }

                if (course.CourseId > 0)
                {
                    var courseCheck = this.Map.CoursesCheckBox(course.CourseId);
                    if (courseCheck != null) courseCheck.Check(true, false);
                }
            }

            this.Map.ExportPointsCheckBox.Check(points, false);
            this.Map.ExportHonorsCheckBox.Check(honors, false);
            this.Map.ExportPracticalExamCheckBox.Check(practicalExam, false);
            this.Map.ExportTestExamCheckBox.Check(testExam, false);
            this.Map.ExportIsLiveParticipantCheckBox.Check(isLiveParticipant, false);

            this.Map.Generate.Click();
        }

        public void ValidateExportedExcel(bool isEmpty = false)
        {
            this.Validator.CheckExportedExcel(isEmpty);
        }
    }
}
