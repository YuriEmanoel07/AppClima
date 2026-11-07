using AppClima.Models;
using AppClima.ViewModels;

namespace AppClima.Views;

public partial class ClimaView : ContentPage
{
	public ClimaView()
	{
		InitializeComponent();
        BindingContext = new ClimaViewModels();


    }
}