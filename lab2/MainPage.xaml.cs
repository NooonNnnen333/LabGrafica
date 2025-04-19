namespace lab2;

public partial class MainPage : ContentPage
{
    private ViewModel vm = new ViewModel();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = vm;
    }
}