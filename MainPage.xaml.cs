namespace MauiBug_ShellNav_SamePage;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//mainpage/detailpageone?playerId=1");
	}
}

