namespace AppMAUIGallery.Views.Components.Mains;

public partial class ButtonPage : ContentPage
{
	public ButtonPage()
	{
		InitializeComponent();
	}
    private void Buttonclicked(System.Object sender, System.EventArgs e)
    {
        lblLog.Text += $"\n Clicado: {DateTime.Now}";
    }
    private void Button_Pressed(System.Object sender, System.EventArgs e)
    {
        lblLog.Text += $"\n Pressionado: {DateTime.Now}";

    }

    private void Button_Released(System.Object sender, System.EventArgs e)
    {
        lblLog.Text += $"\n Liberado: {DateTime.Now}";
    }
}