namespace AppMAUIGallery.Views.Components.Forms;

public partial class PickerPage : ContentPage
{
	public PickerPage()
	{
		InitializeComponent();
	}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		var component = ((Picker)sender);
		String brandname = (String) component.SelectedItem;
		int brandidex = (int) component.SelectedIndex;
		lblvalue.Text = brandname;
        lblindex.Text = brandidex.ToString();
    }
}