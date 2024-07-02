namespace NavigationCambio2320559;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}
    private void CalcularCambio_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(costoEntry.Text) && !string.IsNullOrEmpty(entregadoEntry.Text))
        {
            double cambio, entregado, costo;
            cambioLabel.Text = "Ingrese el costo del articulo.";
            costo = Convert.ToDouble(costoEntry.Text);
            cambioLabel.Text = "Ingrese valores numéricos válidos.";
            entregado = Convert.ToDouble(entregadoEntry.Text);
            cambio = entregado - costo;
            cambioLabel.Text = $"Cambio a entregar: {cambio}";
        }
    }
}