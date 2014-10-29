﻿namespace QA.TelerikAcademy.Core.Pages.AdminPage.Teamwork.TeamMemberSuggestions
{
    using System.Windows.Forms;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;

    public class TeamMemberSuggestionsPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Teamwork/TeamMemberSuggestions";

        public TeamMemberSuggestionsPageMap Map
        {
            get
            {
                return new TeamMemberSuggestionsPageMap();
            }
        }

        public TeamMemberSuggestionsPageValidator Validator
        {
            get
            {
                return new TeamMemberSuggestionsPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        //public void AddTeamworkType(string teamworkType)
        //{
        //    this.Map.Add.Click();
        //    InsertText(teamworkType);

        //}

        //public void EditTeamworkType(string newteamworkType)
        //{
        //    this.Map.Edit.Click();
        //    this.Map.TypeText.Text = "";
        //    InsertText(newteamworkType);
        //}

        //public void UndoEdit()
        //{
        //    this.Map.UndoEdit.Click();
        //    this.Map.TypeText.Text = "";
        //    InsertText("Apples");
        //}

        //public void Delete()
        //{
        //    AlertDialog dialog = AlertDialog.CreateAlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
        //    Manager.Current.DialogMonitor.AddDialog(dialog);
        //    Manager.Current.DialogMonitor.Start();

        //    this.Map.Delete.Click();

        //    Manager.Current.DialogMonitor.RemoveDialog(dialog);
        //    Manager.Current.DialogMonitor.Stop();
        //}

        //private void InsertText(string teamworkType)
        //{
        //    this.Map.TypeText.MouseClick();
        //    Manager.Current.Desktop.KeyBoard.TypeText(teamworkType);
        //    this.Map.Update.MouseClick();
        //}

        //public void ValidateAddedType(string type)
        //{
        //    this.Validator.ConfirmType(type);
        //}
    }
}