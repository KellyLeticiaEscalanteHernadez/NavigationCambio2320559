namespace NavigationCambio2320559;

public partial class Gas : ContentPage
{
	public Gas()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(GalonesEntry.Text) && !string.IsNullOrEmpty(litroEntry.Text))
        {
            double galones, precio, lit;
            galones = Convert.ToDouble(GalonesEntry.Text);
            lit = Convert.ToDouble(litroEntry.Text);

            precio = ((galones) * (lit * 3.78)) / 1;
            CobroEntry.Text = $"total a cobrar es:${precio}";
        }
        else
        {
            CobroEntry.Text = "Por favor complete todos los cuadros e ingrese valores validos";
        }
    }
}