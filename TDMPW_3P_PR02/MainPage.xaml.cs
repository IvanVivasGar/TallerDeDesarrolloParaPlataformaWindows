namespace TDMPW_3P_PR02;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void ShippingAmount(){
		if (this.quantityEntry.Text != null && int.TryParse(this.quantityEntry.Text, out int quantity)){
			if (quantity <= 100){
				this.shippingLbl.Text = "$ 200.0";
			}else if (quantity <= 300){
				this.shippingLbl.Text = "$ 100.0";
			}else{
				this.shippingLbl.Text = "$ 0.0";
			}
		}
	}

	private void TaxesAmount(){
		if (this.quantityEntry.Text != null && int.TryParse(this.quantityEntry.Text, out int quantity2)){
			if (sldr.Value == 11){
				this.taxesLbl.Text = "$ " + (quantity2 * 0.11);
			}else if (sldr.Value == 16){
				this.taxesLbl.Text = "$ " + (quantity2 * 0.16);
			}else {
				this.taxesLbl.Text = "$ 0.00";
			}
		}
	}

	private void OnQuantityChanged(object sender, EventArgs e){
		this.quantityMain.Text = "$ " + this.quantityEntry.Text;

		ShippingAmount();
		TaxesAmount();
	}

	private void OnCounterClicked0(object sender, EventArgs e){
		this.sldr.Value = 0;
		TaxesAmount();
	}

	private void OnCounterClicked11(object sender, EventArgs e){
		this.sldr.Value = 11;
		TaxesAmount();
	}

	private void OnCounterClicked16(object sender, EventArgs e){
		this.sldr.Value = 16;
		TaxesAmount();
	}
}