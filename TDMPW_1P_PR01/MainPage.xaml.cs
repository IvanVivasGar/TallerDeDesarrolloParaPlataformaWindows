namespace TDMPW_1P_PR01;

public partial class MainPage : ContentPage
{
	double celsius;
	double farenheit;

	public MainPage()
	{
		InitializeComponent();
	}

	private void ClickedFarenheit(object sender, EventArgs s)
	{
		farenheit = (double.Parse(this.entradaDatosFarenheit.Text) * 9 / 5) + 32;
		this.lblResultadoFarenheit.Text = "Los grados en Celsius son de: " + farenheit.ToString();
	}

	private void ClickedCelsius(object sender, EventArgs s)
	{
		celsius = (double.Parse(this.entradaDatosCelsius.Text) - 32) * 5 / 9;
		this.lblResultadoCelsius.Text = "Los grados en Farenheit son de: " + this.celsius.ToString();
	}
}

