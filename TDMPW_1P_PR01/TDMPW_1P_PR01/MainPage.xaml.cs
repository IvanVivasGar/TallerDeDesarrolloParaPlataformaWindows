namespace TDMPW_1P_PR01;

public partial class MainPage : ContentPage
{
	double celsius;
	double fahrenheit;

	public MainPage()
	{
		InitializeComponent();
	}

	private void ClickedFahrenheit(object sender, EventArgs s)
	{
		fahrenheit = double.Parse(this.entradaDatos.Text);
		fahrenheit = (fahrenheit * 9 / 5) + 32;
		this.lblResultadoFarenheit.Text = fahrenheit.ToString();
	}

	private void ClickedCelsius(object sender, EventArgs s)
	{
		celsius = double.Parse(this.entradaDatos.Text);
		celsius = (celsius - 32) * 5 / 9;
		this.lblResultadoCelsius.Text = this.celsius.ToString();
	}
}

