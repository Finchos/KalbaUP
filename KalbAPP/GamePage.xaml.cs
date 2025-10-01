using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KalbAPP.ViewModel;

namespace KalbAPP;

public partial class GamePage : ContentPage
{
    public GamePage(GameViewModel vm)
    {
        InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
        BindingContext = vm;
    }
}