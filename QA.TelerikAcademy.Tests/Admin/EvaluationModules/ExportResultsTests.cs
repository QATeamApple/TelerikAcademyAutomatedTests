namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using System;
    using System.Collections.Generic;

    using ArtOfTest.WebAii.TestTemplates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.ExportResults;
    using QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberSuggestions;
    using QA.TelerikAcademy.Core.Pages.Front.MainPage;
    using QA.UI.TestingFramework.Core;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    [TestClass]
    public class ExportResultsTests : AcademyBaseTest
    {

        public ExportResultsPage ExportResultsPage { get; set; }

        public List<Course> Courses { get; set; }

        public TestContext TestContext { get; set; }

        public override void TestInit()
        {
            this.ExportResultsPage = new ExportResultsPage();
            this.Courses = new List<Course>();

            base.TestInit();

            this.ExportResultsPage.Navigate();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResults()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false, this.DesktopFolder + @"\" + "Export1.xls");
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResultsWithPoints()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, true, false, false, false, false, this.DesktopFolder + @"\" + "Export2.xls");
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResultsWithHonors()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, false, true, false, false, false, this.DesktopFolder + @"\" + "Export3.xls");
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResultsWithPracticalExamPoints()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, true, false, false, this.DesktopFolder + @"\" + "Export4.xls");
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResultsWithTestExamPoints()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, true, false, this.DesktopFolder + @"\" + "Export5.xls");
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResultsWithLiveParticipant()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, true, this.DesktopFolder + @"\" + "Export6.xls");
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResultsWithExtraColumns()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true, this.DesktopFolder + @"\" + "Export7.xls");
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportOneCourseWithoutExtraColumns()
        {
            this.Courses.Add(new Course(33));
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false, this.DesktopFolder + @"\" + "Export8.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportOneCourseWithExtraColumns()
        {
            this.Courses.Add(new Course(33));
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true, this.DesktopFolder + @"\" + "Export9.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportStudentsInOneCourseWithoutExtraColumns()
        {
            this.Courses.Add(new Course(0, 33));
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false, this.DesktopFolder + @"\" + "Export10.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportStudentsInOneCourseWithExtraColumns()
        {
            this.Courses.Add(new Course(0, 33));
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true, this.DesktopFolder + @"\" + "Export11.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportLiveStudentsInOneCourseWithoutExtraColumns()
        {
            this.Courses.Add(new Course(0, 33, true));
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false, this.DesktopFolder + @"\" + "Export12.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportLiveStudentsInOneCourseWithExtraColumns()
        {
            this.Courses.Add(new Course(0, 33, true));
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true, this.DesktopFolder + @"\" + "Export13.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void Export100CoursesWithoutExtraColumns()
        {
            this.GenerateStudentCourses(100, true, false, false);
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false, this.DesktopFolder + @"\" + "Export14.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void Export100CoursesWithExtraColumns()
        {
            this.GenerateStudentCourses(100, true, false, false);
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true, this.DesktopFolder + @"\" + "Export15.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportStudentsIn100CoursesWithoutExtraColumns()
        {
            this.GenerateStudentCourses(100, false, true, false);
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false, this.DesktopFolder + @"\" + "Export16.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportStudentsIn100CoursesWithExtraColumns()
        {
            this.GenerateStudentCourses(100, false, true, false);
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true, this.DesktopFolder + @"\" + "Export17.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportLiveStudentsIn100CoursesWithoutExtraColumns()
        {
            this.GenerateStudentCourses(100, false, true, true);
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false, this.DesktopFolder + @"\" + "Export18.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportLiveStudentsIn100CoursesWithExtraColumns()
        {
            this.GenerateStudentCourses(100, false, true, true);
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true, this.DesktopFolder + @"\" + "Export19.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportAllLiveWithoutExtraColumns()
        {
            this.GenerateStudentCourses(100, true, true, true);
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false, this.DesktopFolder + @"\" + "Export20.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportAllLiveWithExtraColumns()
        {
            this.GenerateStudentCourses(100, true, true, true);
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true, this.DesktopFolder + @"\" + "Export21.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportAllWithoutExtraColumns()
        {
            this.GenerateStudentCourses(100, true, true, false);
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false, this.DesktopFolder + @"\" + "Export22.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportAllWithExtraColumns()
        {
            this.GenerateStudentCourses(100, true, true, false);
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true, this.DesktopFolder + @"\" + "Export23.xls");
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        private void GenerateStudentCourses(int count, bool courses, bool students, bool isLive)
        {
            for (int id = 1; id <= count; id++)
            {
                this.Courses.Add(new Course(courses ? id : 0, students ? id : 0, isLive));
            }
        }
    }
}