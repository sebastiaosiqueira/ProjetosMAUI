using AppTask.Models;
using AppTask.Repositories;

namespace AppTask.Views;

public partial class StartPage : ContentPage
{
	private ITaskModelRepository _repository;
	private IList<TaskModel> _tasks;
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
		var confirm = await DisplayAlert("Confirme a Exclusão", $"Tem certeza de que seja excluir essa tarefa: {task.Name}?", "Sim", "Não");

		

		if (confirm) {
			_repository.Delete(task);
			LoadData();
		}
		
	}

	private void OnCheckBoxClickedToComplete(object sender, TappedEventArgs e)
	{
		var checkbox = ((CheckBox)sender);
		var task = (TaskModel)e.Parameter;

		if(DeviceInfo.Platform!=DevicePlatform.WinUI)
		checkbox.IsChecked = !checkbox.IsChecked;
		task.IsCompleted = ((CheckBox)sender).IsChecked;
		_repository.Update(task);
	}


    private void LoadData()
	{
		_tasks = _repository.GetAll();
        CollectionViewTasks.ItemsSource = _tasks;
        LblEmptyText.IsVisible = _tasks.Count <= 0;
	}

    private void OnButton_ClickedToAdd(object sender, EventArgs e)
    {
		LoadData();
		//Navigation.PushModalAsync(new AddEditTaskPage());
    }

	private void OnTextChagend_FilterList(object sender, TextChangedEventArgs e)
	{
		var word = e.NewTextValue;
	 CollectionViewTasks.ItemsSource=_tasks.Where(a => a.Name.ToLower().Contains(word.ToLower())).ToList();
	}
}