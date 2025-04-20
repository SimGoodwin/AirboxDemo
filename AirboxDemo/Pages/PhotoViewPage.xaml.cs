using AirboxDemo.ViewModels;

namespace AirboxDemo.Pages;

public partial class PhotoViewPage : ContentPage
{

    private readonly PhotoViewViewModel viewModel;

    public PhotoViewPage(ImageFile image)
	{
		InitializeComponent();
        viewModel = new PhotoViewViewModel(image);
        BindingContext = viewModel;
    }
}