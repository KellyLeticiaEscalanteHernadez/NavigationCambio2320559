namespace NavigationCambio2320559;

public partial class Superficie : ContentPage
{
	public Superficie()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(basEntry.Text) && !string.IsNullOrEmpty(alturaEntry.Text))
        {
            double altura, bas, superficie;
            altura = Convert.ToDouble(alturaEntry.Text);
            bas = Convert.ToDouble(basEntry.Text);
            superficie = (bas * altura) / 2;
            superficiEntry.Text = superficie.ToString($"la superficie es:{superficie}");
        }

    }
}