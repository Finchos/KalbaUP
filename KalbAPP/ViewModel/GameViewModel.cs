using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace KalbAPP.ViewModel;

public partial class GameViewModel : ObservableObject
{
    [ObservableProperty] 
    private int target;

    [ObservableProperty] 
    private ObservableCollection<Player> players;
    
    [ObservableProperty]
    private Player currentPlayer;

    [ObservableProperty] 
    private int score;
    
    private int currentPlayerIndex;

    public GameViewModel()
    {
        players = Data.PLAYERS;
        target = Data.TARGET;
        ResetScores();

        currentPlayerIndex = 0;
        currentPlayer = players[currentPlayerIndex];
        score = 0;
    }

    [RelayCommand]
    private void FinishedTurn()
    {
        var player = currentPlayer;
        
        player.addScore(score);
        Score = 0;
        if(player.GetScore() >= target) players.Remove(player);
        
        //preparing for another players turn
        currentPlayerIndex++;
        if(currentPlayerIndex == players.Count) currentPlayerIndex = 0;
        CurrentPlayer = players[currentPlayerIndex];
    }

    private void ResetScores()
    {
        foreach (var player in players)
        {
            player.Score = 0;
        }
    }
}