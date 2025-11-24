namespace ProductosAppQ4;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ProductoView();
	}
}
