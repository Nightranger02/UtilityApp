namespace UtilityApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void NavToDoList_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ToDoList());
	}
}

