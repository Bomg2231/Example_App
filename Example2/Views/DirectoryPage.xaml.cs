using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DirectoryPage : ContentPage
    {
        public DirectoryPage()
        {
            InitializeComponent();
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            //Will search database for entry
            // DisplayAlert("Working", "it's working:" + SearchEntry.Text, "ok");
        }

        private void AppointmentButton_Pressed(object sender, EventArgs e)
        {
            AppointmentButton.BackgroundColor = Color.LightGray;
        }

        private void AppointmentButton_Released(object sender, EventArgs e)
        {
            AppointmentButton.BackgroundColor = Color.FromHex("#E6E6E6");
            //AppointmentPage appoint = new AppointmentPage();
          //  Navigation.PushModalAsync(appoint);

        }

        private void ShareBEMERButton_Pressed(object sender, EventArgs e)
        {
            ShareBEMERButton.BackgroundColor = Color.LightGray;
        }

        private void ShareBEMERButton_Released(object sender, EventArgs e)
        {
            ShareBEMERButton.BackgroundColor = Color.FromHex("#E6E6E6");
          //  ShareBeemerPage beem = new ShareBeemerPage(); //Creates an instance of the ShareBeemerPage form called "beem"
          //  Navigation.PushModalAsync(beem); //Opens new ShareBeemerPage using the name "beem" 
        }

        private void SeniorButton_Pressed(object sender, EventArgs e)
        {
            SeniorButton.BackgroundColor = Color.LightGray;
        }

        private void SeniorButton_Released(object sender, EventArgs e)
        {
            SeniorButton.BackgroundColor = Color.FromHex("#E6E6E6");
          //  TeaPage senior = new TeaPage(); //Creates an instance of the TeaPage form called "senior"
          //  Navigation.PushModalAsync(senior); //Opens new TeaPage using the name "senior"
        }

        private void QSGButton_Pressed(object sender, EventArgs e)
        {
            QSGButton.BackgroundColor = Color.Black;
        }

        private void QSGButton_Released(object sender, EventArgs e)
        {
            QSGButton.BackgroundColor = Color.FromHex("#2b2b2b");
            //Goes to a Google Doc PDF. 
        }

        private void AddConButton_Pressed(object sender, EventArgs e)
        {
            AddConButton.BackgroundColor = Color.Black;
        }

        private void AddConButton_Released(object sender, EventArgs e)
        {
            AddConButton.BackgroundColor = Color.FromHex("#2b2b2b");
            //Will go to the Add Contact page. 
        }

        private void PresButton_Pressed(object sender, EventArgs e)
        {
            PresButton.BackgroundColor = Color.Black;
        }

        private void PresButton_Released(object sender, EventArgs e)
        {
            PresButton.BackgroundColor = Color.FromHex("#2b2b2b");
          //  PresentationPage pres = new PresentationPage(); //Creates an instance of the PresentationPage form called "pres"
          //  Navigation.PushModalAsync(pres); //Opens new PresentationPage using the name "pres"

        }

        private void FilesButton_Pressed(object sender, EventArgs e)
        {
            FilesButton.BackgroundColor = Color.Black;
        }

        private void FilesButton_Released(object sender, EventArgs e)
        {
            FilesButton.BackgroundColor = Color.FromHex("#2b2b2b");
            //Goes to the File Cabinet Form. 
        }
    }
}