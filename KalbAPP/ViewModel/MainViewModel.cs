using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace KalbAPP.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    private async Task StartApplication()
    {
        await Shell.Current.GoToAsync(nameof(GameSettingsPage));
    }
}