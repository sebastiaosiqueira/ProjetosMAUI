using AppTask.Models;
using AppTask.Repositories;

namespace AppTask.Views;

public partial class StartPage : ContentPage
{
	private ITaskModelRepository _repository;
	public StartPage()
	{
		InitializeComponent();

		//ponto de melhoria implementar usando D.I
		_repository = new TaskModelRepository();
		LoadData();
	}

	private void OnBorderClickedToFocusEntry(object sender, EventArgs e)
	{
		Entry_Search.Focus();
	}

	private async  void OnImageClickedToDelete(object sender, TappedEventArgs e)
	{
        var task = (TaskModel)e.Parameter;
        var confirm = await DisplayAlert("Confirme a Exclusão", $"Tem certeza de que seja excluir essa tarefa: {task.Name}?", "Sim", "Não")

		

		if (confirm) {
			_repository.Delete(task);
			LoadData();
		}
		
	}

	private void OnCheckBoxClickedToComplete(object sender, TappedEventArgs e)
	{
		var task = (TaskModel)e.Parameter;
		task.IsCompleted = ((CheckBox)sender).IsChecked;
		_repository.Update(task);
	}


    private void LoadData()
	{
		var tasks = _repository.GetAll();
        CollectionViewTasks.ItemsSource = tasks;
		LblEmptyText.IsVisible = tasks.Count <= 0;
	}

    private void OnButton_ClickedToAdd(object sender, EventArgs e)
    {
		LoadData();
		//Navigation.PushModalAsync(new AddEditTaskPage());
    }
}