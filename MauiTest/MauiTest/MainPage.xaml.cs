namespace MauiTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BindingContext = this;
	}

	public string BulletText1 { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod " +
	                                          "tempor incididunt ut labore et dolore magna aliqua. Adipiscing bibendum est " +
	                                          "ultricies integer quis. Vel fringilla est ullamcorper eget. Urna molestie at " +
	                                          "elementum eu facilisis sed odio morbi quis. Augue mauris augue neque gravida. ";

	public string BulletText2 { get; set; } = "Egestas maecenas pharetra convallis posuere morbi leo urna molestie at. " +
	                                          "Sem fringilla ut morbi tincidunt augue. Vitae proin sagittis nisl rhoncus mattis " +
	                                          "rhoncus urna. Vestibulum sed arcu non odio euismod lacinia at. Egestas congue quisque " +
	                                          "egestas diam in arcu cursus euismod quis. Sodales ut etiam sit amet.";
}

