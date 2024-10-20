
namespace HandlersTest.Controls;


public interface IMyView : IView
{
    double AspectRatio { get; set; }
}

public class MyView : ContentView, IMyView
{
    public static BindableProperty AspectRatioProperty = BindableProperty.Create(
        nameof(AspectRatio),
        typeof(double),
        typeof(MyView),
        defaultValue: 0d
    );

    public double AspectRatio {
        get => (double)GetValue(AspectRatioProperty);
        set => SetValue(AspectRatioProperty, value);
    }
}
