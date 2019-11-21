using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.SqlTypes;
using System.Data.SqlClient;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace Example2
{
    public partial class NewPage : ContentPage
    {
        public NewPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        void OnButtonPressed(object sender, EventArgs args)
        {
            LogInButton.BackgroundColor = Color.Blue;
        }

        void OnButtonReleased(object sender, EventArgs args)
        {
            LogInButton.BackgroundColor = Color.Red;
            DisplayAlert("Alert Header", "Moving To Example Log In Page", "OK Text", "Cancel Text");
            ExampleLogInPage LogIn = new ExampleLogInPage();
            Navigation.PushModalAsync(LogIn);
        }

        private void ButtonExample5_Clicked(object sender, EventArgs e)
        {
            var Example = (Link)BindingContext;
            App.Database.SaveItemAsync(Example);
            string output = Convert.ToString(App.Database.GetItemAsync(1));


            DisplayAlert("header", output, "ok", "cancel");
            
            
        }
    }
}