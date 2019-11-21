using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Example2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            String User = TXTUser.Text;

            UserLabel.Text = "hello " + User;
        }

        void OnButtonPressed(object sender, EventArgs args)
        {
            PressHoldButton.BackgroundColor = Color.Blue;
        }

        void OnButtonReleased(object sender, EventArgs args)
        {
            PressHoldButton.BackgroundColor = Color.Red;
            DisplayAlert("Alert Header", "This is the alert body", "OK Text", "Cancel Text");
            NewPage newpage = new NewPage();
            Navigation.PushModalAsync(newpage);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }

        void OnEditorTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        void OnEditorCompleted(object sender, EventArgs e)
        {
            string text = ((Editor)sender).Text;
        }

    }
}
