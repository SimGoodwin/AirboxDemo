using AirboxDemo.Services.Settings;
using AirboxDemo.ViewModels;

namespace AirboxDemo.Pages;

public partial class PhotoListPage : ContentPage
{
    private readonly PhotoListViewModel viewModel;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="viewModel">View model</param>
    public PhotoListPage(PhotoListViewModel viewModel)
	{
		InitializeComponent();
        this.viewModel = viewModel;
		BindingContext = viewModel;
	}

    /// <summary>
    /// Handle car button press
    /// </summary>
    /// <param name="sender">Not used</param>
    /// <param name="e">Not used</param>
    private void CarButton_Pressed(object sender, EventArgs e)
    {
        viewModel.SetView(SelectedPhotoType.Car);
    }

    /// <summary>
    /// Handle helicopter button press
    /// </summary>
    /// <param name="sender">Not used</param>
    /// <param name="e">Not used</param>
    private void HelicopterButton_Pressed(object sender, EventArgs e)
    {
        viewModel.SetView(SelectedPhotoType.Helicopter);
    }

    /// <summary>
    /// Handle boat button press
    /// </summary>
    /// <param name="sender">Not used</param>
    /// <param name="e">Not used</param>
    private void BoatButton_Pressed(object sender, EventArgs e)
    {
        viewModel.SetView(SelectedPhotoType.Boat);
    }

    /// <summary>
    /// Handle photo list selection changed
    /// </summary>
    /// <param name="sender">CollectionView</param>
    /// <param name="e">Event args</param>
    private async void PhotoList_SelectionChangedAsync(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection is null || e.CurrentSelection.Count < 1)
            return;

        var image = e.CurrentSelection[0] as ImageFile;
        var list = sender as CollectionView;

        if (list is not null)
            list.SelectedItem = null;

        if (image is not null)
            await viewModel.DisplayImageAsync(image);
    }
}