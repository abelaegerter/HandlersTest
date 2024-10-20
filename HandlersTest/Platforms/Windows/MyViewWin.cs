
using Microsoft.Maui.Platform;

using Microsoft.UI.Xaml.Controls;
using Grid = Microsoft.UI.Xaml.Controls.Grid;

namespace HandlersTest.Controls;

public class MyViewWin : Grid
{
    public double AspectRatio { get; set; }

    public MyViewWin()
    {
        //Content = n
        //Width = 200;
        //Height = 200;
        //Background = Colors.Gray.ToPlatform();
        BorderBrush = Colors.Black.ToPlatform();
        BorderThickness = new Microsoft.UI.Xaml.Thickness(1);

        var txt = new TextBlock() { Text = "Beta Test", HorizontalAlignment = Microsoft.UI.Xaml.HorizontalAlignment.Center };
        //SetColumn(txt,0);
        //SetRow(txt,0);
        Children.Add(txt);


        //var bg = new Rectangle() { Width = 200, Height = 200, Fill = Colors.Pink.ToPlatform() };
        //Children.Add(bg);
    }
}
