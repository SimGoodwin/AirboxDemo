using AirboxDemo.ViewModels;

namespace AirboxDemo.Pages;

public partial class PhotoViewPage : ContentPage
{

    private readonly PhotoViewViewModel viewModel;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="image">Image to show</param>
    public PhotoViewPage(ImageFile image)
	{
		InitializeComponent();
        viewModel = new PhotoViewViewModel(image);
        BindingContext = viewModel;
    }
}