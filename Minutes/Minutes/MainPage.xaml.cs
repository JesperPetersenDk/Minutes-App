using Minutes.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Minutes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            entries.ItemTapped += OnItemTapped;
        }

        //Fejl her havde TASK i stedet for VOID xD
        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            NoteEntry item = e.Item as NoteEntry;
            await Navigation.PushAsync(new NoteEntryEditPage(item));
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            entries.ItemsSource = await App.Entries.GetAllAsync();
        }

    }
}
