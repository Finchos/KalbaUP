using CommunityToolkit.Mvvm.ComponentModel;

namespace KalbAPP;

public partial class Player : ObservableObject
{
    [ObservableProperty] 
    private string name;
    
    [ObservableProperty] 
    private string profilePicture;

    [ObservableProperty] 
    private int score;

    public int GetScore()
    {
        return score;
    }    
    public void addScore(int points)
    {
        Score += points;
    }
}