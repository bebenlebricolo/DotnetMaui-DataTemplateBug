namespace DataTemplateBug;

public partial class MainPage : ContentPage
{
	public MainPage(CustomViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

