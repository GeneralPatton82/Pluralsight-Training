using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NoteKeeper.Models;
using NoteKeeper.ViewModels;
using System.Collections.Generic;
using NoteKeeper.Services;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        public Note Note { get; set; }
        public IList<String> CourseList { get; set; }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();

            BindingContext = Note;
            NoteCourse.BindingContext = this;
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            InitializeData();
                          
            BindingContext = Note;
            NoteCourse.BindingContext = this;
        }

        async void InitializeData()
        {
            var pluralsightDataStore = new MockPluralsightDataStore();
            CourseList = await pluralsightDataStore.GetCoursesAsync();

            Note = new Note
            {
                Heading = "Test note",
                Text = "Text for a test note",
                Course = CourseList[0]
            };
        }

        public void Cancel_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Cancel option", "Cancel was selected", "Button 2", "Button 1");
        }

        public void Save_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Save option", "Save was clicked", "Button 2", "Button 1");
        }

    }
}