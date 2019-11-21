using BrightenTheBrainApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Example2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExampleLogInPage : ContentPage
    {
        public ExampleLogInPage()
        {
            InitializeComponent();
        }

        void OnButtonPressedLog(object sender, EventArgs args)
        {
            LogInButton.BackgroundColor = Color.Black;
        }

        void OnButtonReleased(object sender, EventArgs args)
        {
            LogInButton.BackgroundColor = Color.FromHex("#2b2b2b");
            DisplayAlert("Alert Header", "Name Input Is: " + NameEntry.Text + " - Email Input Is:" + EmailEntry.Text, "OK Text", "Cancel Text");
            DirectoryPage help = new DirectoryPage();
            Navigation.PushModalAsync(help);
            //ExampleLogInPage LogIn = new ExampleLogInPage();
           // Navigation.PushModalAsync(LogIn);
        }


    }
}