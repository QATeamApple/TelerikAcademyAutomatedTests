namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.StudentsRecords
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class StudentsRecordsPageMap : BaseElementMap
    {
        public HtmlAnchor Add
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Добавяне на файл");
            }
        }

        public HtmlInputText TeamworkName
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Name");
            }
        }

        public HtmlAnchor ExportToExcel
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("export");
            }
        }
    }
}