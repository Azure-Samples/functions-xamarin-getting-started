using Xamarin.Forms;

namespace XamCalculator
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            AddButton.Clicked += async (s, e) =>
            {
                int number1 = 0, number2 = 0;

                var success = int.TryParse(Number1.Text, out number1)
                    && int.TryParse(Number2.Text, out number2);

                if (!success)
                {
                    await DisplayAlert(
                        "Error in inputs", 
                        "You must enter two integers", "OK");
                    return;
                }

                var result = number1 + number2;
                Result.Text = result + $" {result.GetType()}";
            };
		}
	}
}
