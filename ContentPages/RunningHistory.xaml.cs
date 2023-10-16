namespace RunningApp.ContentPages;
/// <summary>
/// Author:Mitchell Bricco
/// </summary>
public partial class RunningHistory : ContentPage
{
	public RunningHistory()
	{
		InitializeComponent();
	}

    private async void Details_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RunDetails());
    }
}