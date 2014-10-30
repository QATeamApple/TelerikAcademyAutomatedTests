﻿namespace QA.TelerikAcademy.Core.Pages.AdminUIPages.EvaluationModulesPages.AddStudentsForTestExam
{
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class AddStudentsForTestPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/CourseTestExams/AddStudents";

        public AddStudentsForTestPageMap Map
        {
            get
            {
                return new AddStudentsForTestPageMap();
            }
        }

        public AddStudentsForTestPageValidator Validator
        {
            get
            {
                return new AddStudentsForTestPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void SelectExam(string courseName)
        {
            this.Map.SelectExam(courseName);
        }

        public void SelectCriteria(string criteriaName)
        {
            this.Map.SelectCriteria(criteriaName);
        }
        public void SelectColumn(string columnName)
        {
            this.Map.SelectColumn(columnName);
        }

        public void UploadStudentsListFile(string filePath)
        {
            this.Map.SelectFile.Upload(filePath, 1000);
            this.Map.SignUpStudents.Click();
        }

        public void SignUpStudents()
        {
            this.Map.SignUpStudents.Click();
        }

        public void StudentsAddedToExamsSuccessConfirmationMessage()
        {
            this.Validator.StudentsAddedToExamsSuccessConfirmationMessage();
        }

        public void ValidateCourseErrorMessage()
        {
            this.Validator.CourseErrorMessage();
        }

        public void ValidateInvalidCourseErrorMessage()
        {
            this.Validator.InvalidCourseErrorMessage();
        }

        public void PleaseChooseColumnMessage()
        {
            this.Validator.PleaseChooseColumnMessage();
        }

        public void PleaseChooseFileMessage()
        {
            this.Validator.PleaseChooseFileMessage();
        }

        public void PleaseChooseCriteriaMessage()
        {
            this.Validator.PleaseChooseCriteriaMessage();
        }

        public void PleaseChooseExamMessage()
        {
            this.Validator.PleaseChooseExamMessage();
        }

        public void InvalidFileNameErrorMessage()
        {
            this.Validator.InvalidFileNameErrorMessage();
        }

        public void InvalidSuccessMessage()
        {
            this.Validator.InvalidSuccessMessage();
        }

        public void InvalidDataFormatErrorMessage()
        {
            this.Validator.InvalidDataFormatErrorMessage();
        }
    }
}