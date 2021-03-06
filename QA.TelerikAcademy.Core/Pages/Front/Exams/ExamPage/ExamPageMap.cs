﻿namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class ExamPageMap : BaseElementMap
    {
        public HtmlInputSubmit SignUp
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Запиши се за изпит");
            }
        }

        public HtmlInputSubmit SignUpForTest
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Запиши се за тест");
            }
        }

        public HtmlInputFile SelectFile
        {
            get
            {
                return this.Find.ById<HtmlInputFile>("examFile");
            }
        }

        public HtmlInputSubmit Upload
        {
            get
            {
                return this.Find.ById<HtmlInputSubmit>("SendButton");
            }
        }

        public HtmlDiv ValidationError
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("class=validation-summary-errors");
            }
        }

        public HtmlControl UploadSuccessConfirmationMessage
        {
            get
            {
                return this.Find.ByContent<HtmlDiv>("Файлът ви е изпратен успешно!");
            }
        }

        public HtmlDiv SignUpResult
        {
            get
            {
                var mainContent = this.Find.ById<HtmlControl>("MainContent");
                return mainContent.Find.ByAttributes<HtmlDiv>("class=importantMessageInfo");
            }
        }

        public HtmlDiv SignUpForTestResult
        {
            get
            {
                var mainContent = this.Find.ById<HtmlControl>("MainContent");
                return mainContent.Find.ByAttributes<HtmlDiv>("class=importantMessageInfo");
            }
        }

        public HtmlControl DownloadLatestExamClick
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Свали");
            }
        }
    }
}
