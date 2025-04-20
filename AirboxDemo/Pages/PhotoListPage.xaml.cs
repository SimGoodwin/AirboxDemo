using AirboxDemo.Services.Settings;
using AirboxDemo.ViewModels;

namespace AirboxDemo.Pages;

public partial class PhotoListPage : ContentPage
{
    private readonly PhotoListViewModel viewModel;

    public PhotoListPage(PhotoListViewModel viewModel)
	{
		InitializeComponent();
        this.viewModel = viewModel;
		BindingContext = viewModel;
	}

    private void CarButton_Pressed(object sender, EventArgs e)
    {
        viewModel.SetView(SelectedPhotoType.Car);
    }

    private void HelicopterButton_Pressed(object sender, EventArgs e)
    {
        viewModel.SetView(SelectedPhotoType.Helicopter);
    }

    private void BoatButton_Pressed(object sender, EventArgs e)
    {
        viewModel.SetView(SelectedPhotoType.Boat);
    }

    private async void PhotoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection is null || e.CurrentSelection.Count < 1)
            return;

        var image = e.CurrentSelection[0] as ImageFile;
        var list = sender as CollectionView;

        if (list is not null)
            list.SelectedItem = null;

        if (image is not null)
            await viewModel.DisplayImage(image);
    }
}