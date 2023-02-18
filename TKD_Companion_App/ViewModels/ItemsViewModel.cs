using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using TKD_Companion_App.Models;
using TKD_Companion_App.Views;
using Xamarin.Forms;

namespace TKD_Companion_App.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        private Student _selectedItem;

        public ObservableCollection<Student> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Student> ItemTapped { get; }

        public ItemsViewModel()
        {
            Title = "My TKD";
            Items = new ObservableCollection<Student>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<Student>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var student = new Student();
                student.Id = (string)Application.Current.Properties["id"];
                student.Text = (string)Application.Current.Properties["Name"];
                student.Grade = (string)Application.Current.Properties["Grade"];
                Items.Add(student);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public Student SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        async void OnItemSelected(Student item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }
}