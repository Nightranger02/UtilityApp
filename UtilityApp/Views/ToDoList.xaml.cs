namespace UtilityApp;

public partial class ToDoList : ContentPage
{
	public ToDoList()
	{
		InitializeComponent();
	}

    private void ClearInput_Clicked(object sender, EventArgs e)
    {
		InputField.Text = string.Empty;
    }
}