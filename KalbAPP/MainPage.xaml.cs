using KalbAPP.ViewModel;

namespace KalbAPP;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
        
        BindingContext = vm;
        
    }
}