using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class AppShell : Shell
{

    
    public AppShell(AppShellViewModel vm)
    {
        
        InitializeComponent();

        this.BindingContext = vm;


    }
}
