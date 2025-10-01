using System.Collections.ObjectModel;

namespace KalbAPP;

public static class Data
{
    public static ObservableCollection<Player> PLAYERS { get; set; }
    public static int TARGET { get; set; }
}
//Placeholder="{Binding CurrentPlayer.Name, StringFormat='{0}`s turn'}"