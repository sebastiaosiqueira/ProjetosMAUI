namespace AppMAUIGallery.Views.Components.Forms;

public partial class SwichPage : ContentPage
{
	public SwichPage()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        Lblswich.Text = $"Marcado: {e.Value}";
    }
}