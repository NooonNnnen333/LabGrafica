namespace lab2;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(ViewModel), typeof(ViewModel));
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}