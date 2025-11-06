namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	private void OnGenerateLuckNumbers(object sender, EventArgs e)
	{
		NameApp.IsVisible = false;
		ContainerLuckNumbers.IsVisible = true;

		var set = GenerateLuckNumbers();
		luckNumber01.Text = set.ElementAt(0).ToString("D2");
        luckNumber02.Text = set.ElementAt(1).ToString("D2");
        luckNumber03.Text = set.ElementAt(2).ToString("D2");
        luckNumber04.Text = set.ElementAt(3).ToString("D2");
        luckNumber05.Text = set.ElementAt(4).ToString("D2");
        luckNumber06.Text = set.ElementAt(5).ToString("D2");
    }

	private SortedSet<int> GenerateLuckNumbers()
	{
		var set = new SortedSet<int>();
			while (set.Count<6) {
			var random = new Random();
			var lucknumber = random.Next(1, 60);
			set.Add(lucknumber);
		}
		return set;
	}

}