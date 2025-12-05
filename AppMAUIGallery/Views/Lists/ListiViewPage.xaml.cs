using AppMAUIGallery.Views.Lists.Models;
using Microsoft.Maui.Controls;

namespace AppMAUIGallery.Views.Lists;

public partial class ListiViewPage : ContentPage
{
	public ListiViewPage()
	{
		InitializeComponent();

		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		ListViewControl.ItemsSource = MovieList.GetGroupList().Take(2);
    }

    private void ListViewControl_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var movie = (Movie)e.SelectedItem;
        App.Current.MainPage.DisplayAlert("Filme Selecionado!", $"O filme selecionado e:  {movie.Id} -  {movie.Name}", "OK");
    }

    private async void ListViewControl_Refreshing(object sender, EventArgs e)
    {
        ListViewControl.IsRefreshing = true;
        await Task.Delay(3000);
        ListViewControl.ItemsSource = MovieList.GetGroupList();
        ListViewControl.IsRefreshing = false;
    }
}