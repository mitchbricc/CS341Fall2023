namespace RunningApp.ContentPages;
/// <summary>
/// Author:Mitchell Bricco
/// </summary>
public partial class SocialFeed : ContentPage
{
	public SocialFeed()
	{
		InitializeComponent();
	}

    private async void Compare_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RunComparison());
    }
}