
namespace HandlersTest.ViewModels;

public class MainPageVM : BaseVM {
    
    public double selectedWidth = -1;
    public double SelectedWidth {
        get => selectedWidth;
        set {
            if (selectedWidth == value) return;
            selectedWidth = value;
            OnPropertyChanged();
        }
    }
    public MainPageVM() {
        Title = "Handler Test";
    }

}
