namespace QA.TelerikAcademy.Tests.AdminTests.EvaluationModulesTests
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.AdminPages.TeamworkModulesPages.TeamMemberSuggestions;
    using QA.TelerikAcademy.Core.Pages.UIPages.MainPage;
    using QA.UI.TestingFramework.Core;
    using QA.TelerikAcademy.Core.Pages.AdminPages.EvaluationModulesPages.ExportResults;

    [TestClass]
    public class ExportResultsTests : BaseTest
    {
        public ExportResultsPage ExportResultsPage { get; set; }

        public List<Course> Courses { get; set; }

        public override void TestInit()
        {
            this.ExportResultsPage = new ExportResultsPage();
            this.Courses = new List<Course>();

            base.TestInit();

            this.ExportResultsPage.Navigate();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResults()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false);
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResultsWithPoints()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, true, false, false, false, false);
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResultsWithHonors()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, false, true, false, false, false);
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResultsWithPracticalExamPoints()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, true, false, false);
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResultsWithTestExamPoints()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, true, false);
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResultsWithLiveParticipant()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, true);
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportEmptyResultsWithExtraColumns()
        {
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true);
            this.ExportResultsPage.ValidateExportedExcel();
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportOneCourseWithoutExtraColumns()
        {
            this.Courses.Add(new Course(33));
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportOneCourseWithExtraColumns()
        {
            this.Courses.Add(new Course(33));
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportStudentsInOneCourseWithoutExtraColumns()
        {
            this.Courses.Add(new Course(0, 33));
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportStudentsInOneCourseWithExtraColumns()
        {
            this.Courses.Add(new Course(0, 33));
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportLiveStudentsInOneCourseWithoutExtraColumns()
        {
            this.Courses.Add(new Course(0, 33, true));
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportLiveStudentsInOneCourseWithExtraColumns()
        {
            this.Courses.Add(new Course(0, 33, true));
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void Export100CoursesWithoutExtraColumns()
        {
            GenerateStudentCourses(100, true, false, false);
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void Export100CoursesWithExtraColumns()
        {
            GenerateStudentCourses(100, true, false, false);
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportStudentsIn100CoursesWithoutExtraColumns()
        {
            GenerateStudentCourses(100, false, true, false);
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportStudentsIn100CoursesWithExtraColumns()
        {
            GenerateStudentCourses(100, false, true, false);
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportLiveStudentsIn100CoursesWithoutExtraColumns()
        {
            GenerateStudentCourses(100, false, true, true);
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportLiveStudentsIn100CoursesWithExtraColumns()
        {
            GenerateStudentCourses(100, false, true, true);
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportAllWithoutExtraColumns()
        {
            GenerateStudentCourses(100, true, true, true);
            this.ExportResultsPage.ExportExcel(this.Courses, false, false, false, false, false);
            this.ExportResultsPage.ValidateExportedExcel(true);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ExportAllWithExtraColumns()
        {
            GenerateStudentCourses(100, true, true, true);
            this.ExportResultsPage.ExportExcel(this.Courses, true, true, true, true, true);
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