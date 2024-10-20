
namespace HandlersTest.Controls;

// All the code in this file is only included on iOS.
public class MyViewMac : UIKit.UIView
{
    public double AspectRatio { get; set; }

    public MyViewMac()
    {
        Frame = new CoreGraphics.CGRect(x: 0, y: 0, width: 150, height: 150);
        BackgroundColor = UIKit.UIColor.Gray;
    }
}