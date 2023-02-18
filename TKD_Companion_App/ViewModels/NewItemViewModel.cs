using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;
using TKD_Companion_App.Models;
using Xamarin.Forms;

namespace TKD_Companion_App.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string text;
        public string grade;

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(grade);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Grade
        {
            get => grade;
            set => SetProperty(ref grade, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Student newItem = new Student()
            {
                Id = Guid.NewGuid().ToString(),
                Text = Text,
                Grade = Grade
            };

            await DataStore.AddItemAsync(newItem);

            Application.Current.Properties["id"] = newItem.Id; 
            Application.Current.Properties["Name"] = newItem.Text; 
            Application.Current.Properties["Grade"] = newItem.Grade; 


            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        
    }

    public static class StringExtensions
    {
        public static string SplitCamelCase(this string str)
        {
            return Regex.Replace(
                Regex.Replace(
                    str,
                    @"(\P{Ll})(\P{Ll}\p{Ll})",
                    "$1 $2"
                ),
                @"(\p{Ll})(\P{Ll})",
                "$1 $2"
            );
        }
    }
}
