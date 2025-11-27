

namespace AppMAUIGallery.Views.Components.Forms;

public partial class RadionbuttonPage : ContentPage
{
	public RadionbuttonPage()
	{
		InitializeComponent();
	}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value == true)
		{
            var value = ((RadioButton)sender).Content;
			LblResultAsk01.Text = $"Você escolheu: {value}";
		}

    }
}