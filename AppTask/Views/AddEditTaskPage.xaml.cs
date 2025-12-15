namespace AppTask.Views;

public partial class AddEditTaskPage : ContentPage
{
	public AddEditTaskPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Navigation.PopModalAsync();

    }

    private void SaveData(System.Object sender, System.EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private async void AddStep(System.Object sender, System.EventArgs e)
    {
       var stepName =DisplayPromptAsync("Etapa", "Digite o nome da etapa(subtarefa", "Adicionar", "Cancelar");
    }
}