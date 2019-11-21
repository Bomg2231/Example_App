using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PresentationPage : ContentPage
    {
        public PresentationPage()
        {
            InitializeComponent();
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            //Will search database for entry
            // DisplayAlert("Working", "it's working:" + SearchEntry.Text, "ok");
        }

        private void GoogCalButton_Pressed(object sender, EventArgs e)
        {
            GoogCalButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void GoogCalButton_Released(object sender, EventArgs e)
        {
            GoogCalButton.BackgroundColor = Color.WhiteSmoke;
            //Goes to Google Calendar / Opens Link To Google Calendar
        }

        private void OnPresButton_Pressed(object sender, EventArgs e)
        {
            OnPresButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void OnPresButton_Released(object sender, EventArgs e)
        {
            OnPresButton.BackgroundColor = Color.WhiteSmoke;
            //Opens Google Doc PDF. 
        }

        private void ResultsButton_Pressed(object sender, EventArgs e)
        {
            ResultsButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void ResultsButton_Released(object sender, EventArgs e)
        {
            ResultsButton.BackgroundColor = Color.WhiteSmoke;
            //Opens Google Doc PDF. 
        }

        private void TemplateEmailButton_Pressed(object sender, EventArgs e)
        {
            TemplateEmailButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void TemplateEmailButton_Released(object sender, EventArgs e)
        {
            TemplateEmailButton.BackgroundColor = Color.WhiteSmoke;
            //Opens Google Doc PDF. 
        }

        private void PitchButton_Pressed(object sender, EventArgs e)
        {
            PitchButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void PitchButton_Released(object sender, EventArgs e)
        {
            PitchButton.BackgroundColor = Color.WhiteSmoke;
            //PitchPage pitch = new PitchPage();
          //  Navigation.PushModalAsync(pitch);
        }

        void OnButtonPressedBack(object sender, EventArgs args)
        {
            BackButton.BackgroundColor = Color.Black;
        }

        void OnButtonReleasedBack(object sender, EventArgs args)
        {
            BackButton.BackgroundColor = Color.FromHex("#2b2b2b");
           // AppointmentPage appoint = new AppointmentPage(); //Creates an instance of the AppointmentPage form called "appoint"
          //  Navigation.PushModalAsync(appoint); //Opens new AppointmentPage using the name "appoint"
        }
    }
}