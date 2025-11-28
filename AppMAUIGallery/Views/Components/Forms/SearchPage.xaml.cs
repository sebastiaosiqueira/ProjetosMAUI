namespace AppMAUIGallery.Views.Components.Forms;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
	}
	private void SearchBusca(object sender, EventArgs e)
	{
		var value = ((SearchBar)sender).Text;

		lblvalue.Text = value;
	}
}