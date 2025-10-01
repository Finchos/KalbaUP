using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace KalbAPP.ViewModel;

public partial class GameSettingsViewModel : ObservableObject
{
    [ObservableProperty] 
    private ObservableCollection<Player> players;

    private Player Dan;
    private Player Domin;
    private Player Simon;
    private Player Kaja;
    private Player Franta;
    private Player Helca;
    
    private int guestCount;
    
    [ObservableProperty]
    private int target;

    private const double offline = 0.25;
    private const double online = 1.0;

    [ObservableProperty] private double danState;
    [ObservableProperty] private double dominState;
    [ObservableProperty] private double simaState;
    [ObservableProperty] private double kajaState;
    [ObservableProperty] private double frantaState;
    [ObservableProperty] private double helcaState;
    
    
    public GameSettingsViewModel()
    {
        Dan = new Player{Name = "Dan", ProfilePicture = "dan.png"};
        Domin = new Player{Name = "Domin", ProfilePicture = "domin.png"};
        Simon = new Player {Name = "Šimon", ProfilePicture = "sima.png" };
        Kaja = new Player {Name = "Kája", ProfilePicture = "kaja.png" };
        Franta = new Player {Name = "Franta", ProfilePicture = "franta.png" };
        Helca = new Player {Name = "Helča", ProfilePicture = "helca.png" };
        
        danState = offline;
        dominState = offline;
        simaState = offline;
        kajaState = offline;
        frantaState = offline;
        helcaState = offline;
        
        players = new ObservableCollection<Player>();
        
        guestCount = 0;
    }

    [RelayCommand]
    private void PlayerAdd(string name)
    {
        switch (name)
        {
            case "Dan":
            {
                if (danState == offline)
                {
                    danState = online;
                    players.Add(Dan);
                }
                else
                {
                    danState = offline;
                    players.Remove(Dan);
                }
                break;
            }

            case "Domin":
            {
                if (dominState == offline)
                {
                    dominState = online;
                    players.Add(Domin);
                }
                else
                {
                    dominState = offline;
                    players.Remove(Domin);
                }
                break;
            }
            
            case "Sima":
            {
                if (simaState == offline)
                {
                    simaState = online;
                    players.Add(Simon);
                }
                else
                {
                    simaState = offline;
                    players.Remove(Simon);
                }
                break;
            }
            
            case "Kaja":
            {
                if (kajaState == offline)
                {
                    kajaState = online;
                    players.Add(Kaja);
                }
                else
                {
                    kajaState = offline;
                    players.Remove(Kaja);
                }
                break;
            }
            
            case "Franta":
            {
                if (frantaState == offline)
                {
                    frantaState = online;
                    players.Add(Franta);
                }
                else
                {
                    frantaState = offline;
                    players.Remove(Franta);
                }
                break;
            }
            
            case "Helca":
            {
                if (helcaState == offline)
                {
                    helcaState = online;
                    players.Add(Helca);
                }
                else
                {
                    helcaState = offline;
                    players.Remove(Helca);
                }
                break;
            }
        }
    }

    [RelayCommand]
    private void GuestAdd()
    {
        if (guestCount < 3)
        {
            guestCount++;
            players.Add(new Player {Name = "Guest " + guestCount, ProfilePicture = "guest" + guestCount + ".png"});
        }
        else return;
    }

    [RelayCommand]
    private async Task StartGame()
    {
        Data.PLAYERS = players;
        Data.TARGET = target;
        await Shell.Current.GoToAsync(nameof(GamePage));
    }
}