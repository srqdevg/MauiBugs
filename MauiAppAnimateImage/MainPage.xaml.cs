namespace MauiAppAnimateImage;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		this.Scale = 4;
	}

	private void Start_Animation(object sender, EventArgs e)
	{
		rotation ??= new Animation(v => cog.Rotation = v, 0, 360);
		rotation.Commit(this, "rotate", 16, 1000, Easing.Linear, (_, _) => cog.Rotation = 0, () => true);
	}

	private Animation rotation;
}

