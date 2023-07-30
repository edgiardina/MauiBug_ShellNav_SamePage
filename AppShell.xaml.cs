namespace MauiBug_ShellNav_SamePage;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("detailpageone", typeof(DetailPageOne));
    }
}
