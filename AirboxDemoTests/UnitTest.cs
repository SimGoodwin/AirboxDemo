using System.Threading;
using AirboxDemo.Pages;
using AirboxDemo.Services.Settings;
using AirboxDemo.ViewModels;
using Moq;

namespace AirboxDemoTests
{
    public class UnitTest
    {
        [Fact]
        public void SampleTest()
        {
            // Arrange
            var mockSettings = new Mock<ISettingsService>();
            mockSettings.Setup(x => x.PhotoType).Returns(SelectedPhotoType.Car);

            var mockFiles = new Mock<IFileService>();
            mockFiles.Setup(x => x.GetAllImages(SelectedPhotoType.Car))
                .Returns(
                [
                    ImageSource.FromFile("car_1_image"),
                    ImageSource.FromFile("car_1_image")
                ]);

            var testView = new PhotoListViewModel(mockSettings.Object, mockFiles.Object);

            // Act
            testView.SetImages();

            // Assert
            Assert.True(testView.Images.Count == 2);            
        }
    }
}
