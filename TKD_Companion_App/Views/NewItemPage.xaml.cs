using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using TKD_Companion_App.Models;
using TKD_Companion_App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TKD_Companion_App.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Student Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();

            var gradeList = Enum.GetNames(typeof(AllGrades)).Select(b => b.SplitCamelCase()).ToList();

            gradePicker.ItemsSource = gradeList;
        }

        private void gradePicker_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //Item.Grade = NewItemViewModel.instance.Grade;
            Debug.WriteLine(gradePicker.SelectedItem);
        }


    }
}