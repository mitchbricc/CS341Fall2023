﻿using RunningApp.ContentPages;

namespace RunningApp;

public partial class GenerateRoute : ContentPage
{

	public GenerateRoute()
	{
		InitializeComponent();
	}

    private void btnGenerateRoute_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new GenerateRouteSettings());
    }
}

