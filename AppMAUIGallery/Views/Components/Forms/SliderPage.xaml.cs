namespace AppMAUIGallery.Views.Components.Forms;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
	}

    private void Slider_DragStarted(object sender, EventArgs e)
    {
        LblStatus.Text = "Inicou o arrasto!";
    }

    private void Slider_DragCompleted(object sender, EventArgs e)
    {
        LblStatus.Text = "Terminou o arrasto!";
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Lblvalue.Text = "Valor : " + e.NewValue;
    }
}