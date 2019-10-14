using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NoteKeeper.Models;
using NoteKeeper.ViewModels;
using System.Collections.Generic;
using NoteKeeper.Services;

namespace NoteKeeper.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        public IList<String> CourseList { get; set; }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();

            this.viewModel = viewModel;
            BindingContext = this.viewModel;
            NoteCourse.BindingContext = this;
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            InitializeData();

            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
            NoteCourse.BindingContext = this;
        }

        async void InitializeData()
        {
            var pluralsightDataStore = new MockPluralsightDataStore();
            CourseList = await pluralsightDataStore.GetCoursesAsync();

        }

        public void Cancel_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Cancel options", "Cancel was selected", "Button 2", "Button 1");
        }

        public void Save_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Save options", "Save was clicked", "Button 2", "Button 1");
        }
    }

}