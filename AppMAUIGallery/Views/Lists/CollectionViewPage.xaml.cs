using AppMAUIGallery.Views.Lists.Models;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Text;

namespace AppMAUIGallery.Views.Lists;

public partial class CollectionViewPage : ContentPage
{
    ObservableCollection<Movie> movies = new ObservableCollection<Movie>();
	public CollectionViewPage()
	{
		InitializeComponent();

        CollectionViewControl.ItemsSource = MovieList.GetGroupList();   
    }

    private async void RefreshView_Refreshing(object sender, EventArgs e)
    {
		((RefreshView)sender).IsRefreshing = true;
		await Task.Delay(3000);
		CollectionViewControl.ItemsSource = MovieList.GetGroupList();
        ((RefreshView)sender).IsRefreshing = false;

    }

    private void CollectionViewControl_RemainingItemsThresholdReached(object sender, EventArgs e)
    {
        CollectionViewControl.ItemsSource = null;
        CollectionViewControl.ItemsSource = MovieList.GetGroupList();

    }

    private void CollectionViewControl_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        if (DeviceInfo.Platform != DevicePlatform.WinUI)
            return;

        if(sender is CollectionView cv)
        {
           var lastvisibleitem = e.LastVisibleItemIndex;

            var Remainitems = cv.RemainingItemsThreshold;

            var TotalItems = ((IEnumerable<object>)cv.ItemsSource).Count();
            if(lastvisibleitem > (TotalItems - Remainitems))
            {
                CollectionViewControl.ItemsSource = MovieList.GetGroupList();
            }
        }
    }

    private void CollectionViewControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        foreach( Movie movie in e.CurrentSelection)
        {
            sb.Append(movie.Name + " - ");
        }
        lblSelectedMovies.Text = sb.ToString();

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var group = (List<GroupMovie>)CollectionViewControl.ItemsSource;
        var item = group[2][0];
        CollectionViewControl.ScrollTo(item, position: ScrollToPosition.Start);
       // CollectionViewControl.ScrollTo(4, position: ScrollToPosition.Start);
    }

    private void CollectionViewControl_ScrolledNovo(object sender, ItemsViewScrolledEventArgs e)
    {
        LblScrollStatus.Text = $"Posicionamento: {e.VerticalOffset} - Espacamento: {e.VerticalDelta} ";

    }

}