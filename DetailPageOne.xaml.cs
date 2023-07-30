namespace MauiBug_ShellNav_SamePage;

[QueryProperty("PlayerId", "playerId")]
public partial class DetailPageOne : ContentPage
{

    public int PlayerId { get; set; }

    public DetailPageOne()
	{
		InitializeComponent();

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        PageLabel.Text = $"Player ID: {PlayerId}";
    }

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//mainpage/detailpageone?playerId=2");
    }
}