using ArtOfTest.WebAii.Core;
using QA.UI.TestingFramework.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.TelerikAcademy.Core.Pages.UI.Exams
{
    public class ExamPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/PracticalExams/UploadForm/4";

        public ExamPageMap Map
        {
            get
            {
                return new ExamPageMap();
            }
        }

        public ExamPageValidator Validator
        {
            get
            {
                return new ExamPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void UploadExam()
        {
            this.Map.SelectFile.Upload(@"C:\TestFiles\Exam.zip", 1000);
            this.Map.Upload.Click();
        }

        public void UploadExamWithNoFile()
        {
            this.Map.Upload.Click();
        }

        public void UploadExamWithUnsupportedFormat()
        {
            this.Map.SelectFile.Upload(@"C:\TestFiles\Exam.pdf", 1000);
            this.Map.Upload.Click();
        }

        public void UploadExamkWithBigSize()
        {
            this.Map.SelectFile.Upload(@"C:\TestFiles\ExamBig.zip", 1000);
            this.Map.Upload.Click();
        }
    }
}
