namespace KalbAPP;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(nameof(GameSettingsPage), typeof(GameSettingsPage));
        Routing.RegisterRoute(nameof(GamePage), typeof(GamePage));
    }
}