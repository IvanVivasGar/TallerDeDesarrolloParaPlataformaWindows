using MauiApp1;

namespace TDMPW_1P_PR02;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	/*
	private void Longitud_Clicked(object sender, EventArgs e){
		await Navigation.PushAsync(new CalcularLongitudView());
	}
	*/

	private async void Volumen_Clicked(object sender, EventArgs e){
		await Navigation.PushAsync(new CalcularVolumenView());
	}
}

