namespace NavigationCambio2320559;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}
    private void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        if (!string.IsNullOrEmpty(pesoEntry.Text) && !string.IsNullOrEmpty(alturaEntry.Text))
        {
            string nombre = nombreEntry.Text;
            double pesoKg, alturaM;
            pesoKg = Convert.ToDouble(pesoEntry.Text);
            alturaM = Convert.ToDouble(alturaEntry.Text);
            double pesoLb = pesoKg * 2.20462;
            double alturaCM = alturaM * 100;
            ConertirEntry.Text = $"{nombre}; El peso en Kg en libras es:{pesoLb}Lb; La altura en M en Cm es:{alturaCM}Cm";
        }
        else
        {
            ConertirEntry.Text = "Porfavor introduce valores validos";
        }
    }
}