using System;
using System.Diagnostics;
using System.Threading.Tasks;
using TKD_Companion_App.Models;
using Xamarin.Forms;

namespace TKD_Companion_App.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        public ItemDetailViewModel()
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

        private string itemId;
        private string text;
        private string grade;
        public string Id { get; set; }

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

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                Id = Application.Current.Properties["id"] as string;
                Text = Application.Current.Properties["Name"] as string;
                Grade = Application.Current.Properties["Grade"] as string;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
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
            var newItem = await DataStore.GetItemAsync(itemId);
            newItem.Id = Id;
            newItem.Text = Text;
            newItem.Grade= Grade;

            await DataStore.UpdateItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
