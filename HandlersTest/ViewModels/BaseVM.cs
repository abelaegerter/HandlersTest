using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HandlersTest.ViewModels;

public class BaseVM : INotifyPropertyChanged {
    bool isBusy;
    string? title;

    public bool IsBusy {
        get => isBusy;
        set {
            if (isBusy == value) return;
            isBusy = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(NotBusy));
        }
    }
    public bool NotBusy => !isBusy;

    public string? Title {
        get => title;
        set {
            if (title == value) return;
            title = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
