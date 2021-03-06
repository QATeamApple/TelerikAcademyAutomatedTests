﻿namespace QA.TelerikAcademy.Core.Pages.Front.Exams.ExamUploadPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class ExamUploadPageMap : BaseElementMap
    {
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
    }
}
