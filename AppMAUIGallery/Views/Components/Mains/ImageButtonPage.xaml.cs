namespace AppMAUIGallery.Views.Components.Mains;

public partial class ImageButtonPage : ContentPage
{
	bool buttonState = false;
	public ImageButtonPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(System.Object sender, System.EventArgs e)
    {
		buttonState = !buttonState;

		var poweroff = "powerooff.png";
		var poweorn = "powerorn.png";

		var button = (ImageButton)sender;

		button.Source = (buttonState == false ? ImageSource.FromFile(poweroff) : ImageSource.FromFile(poweorn));

            ;
    }
}