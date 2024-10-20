using HandlersTest.ViewModels;

namespace HandlersTest;

public partial class MainPage : ContentPage
{
    private MainPageVM vm = new();
    public MainPage()
    {
        BindingContext = vm;
        InitializeComponent();
    }


}
