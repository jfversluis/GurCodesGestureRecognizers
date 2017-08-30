using Xamarin.Forms;

namespace GurCodesGestureRecognizers
{
    public partial class GurCodesGestureRecognizersPage : ContentPage
    {
        public GurCodesGestureRecognizersPage()
        {
            InitializeComponent();
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Hi!", "This is a message", "OK");
        }

        private void Handle_Tapped(object sender, System.EventArgs e)
        {
            DisplayAlert("Hi!", "This is a message", "OK");
        }

        void Handle_PinchUpdated(object sender, Xamarin.Forms.PinchGestureUpdatedEventArgs e)
        {
            if (e.Status == GestureStatus.Started)
                DisplayAlert("Hi!", "This is a message", "OK");
        }
    }
}