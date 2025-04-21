using AirboxDemo.ViewModels;

namespace AirboxDemo.Pages;

public partial class PhotoViewPage : ContentPage
{
    private double rotation;
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

    /// <summary>
    /// Animate image rotation anti-clockwise
    /// </summary>
    /// <param name="sender">Not used</param>
    /// <param name="e">Not used</param>
    private void TurnLeft_Tapped(object sender, TappedEventArgs e)
    {
        rotation -= 90;
        ChosenImage.RotateTo(rotation);
    }

    /// <summary>
    /// Animate image rotation clockwise
    /// </summary>
    /// <param name="sender">Not used</param>
    /// <param name="e">Not used</param>
    private void TurnRight_Tapped(object sender, TappedEventArgs e)
    {
        rotation += 90;
        ChosenImage.RotateTo(rotation);
    }
}