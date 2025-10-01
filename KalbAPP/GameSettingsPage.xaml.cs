using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KalbAPP.ViewModel;

namespace KalbAPP;

public partial class GameSettingsPage : ContentPage
{
    private double offline = 0.25;
    private double online = 1.0;
    
    private bool isDanOnline = false;
    private bool isDominOnline = false;
    private bool isSimaOnline = false;
    private bool isKajaOnline = false;
    private bool isFrantaOnline = false;
    private bool isHelcaOnline = false;
    
    public GameSettingsPage(GameSettingsViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
        Shell.SetNavBarIsVisible(this, false);
    }


    private void OnDanClicked(object? sender, EventArgs e)
    {
        isDanOnline = !isDanOnline;
        DanButton.Opacity = isDanOnline ? online : offline;
    }

    private void OnDominClicked(object? sender, EventArgs e)
    {
        isDominOnline = !isDominOnline;
        DominButton.Opacity = isDominOnline ? online : offline;
        
    }

    private void OnSimaClicked(object? sender, EventArgs e)
    {
        isSimaOnline = !isSimaOnline;
        SimaButton.Opacity = isSimaOnline ? online : offline;
    }

    private void OnKajaClicked(object? sender, EventArgs e)
    {
        isKajaOnline = !isKajaOnline;
        KajaButton.Opacity = isKajaOnline ? online : offline;
    }


    private void OnFrantaClicked(object? sender, EventArgs e)
    {
        isFrantaOnline = !isFrantaOnline;
        FrantaButton.Opacity = isFrantaOnline ? online : offline;
    }

    private void OnHelcaClicked(object? sender, EventArgs e)
    {
        isHelcaOnline = !isHelcaOnline;
        HelcaButton.Opacity = isHelcaOnline ? online : offline;
    }
}