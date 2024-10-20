
using Microsoft.Maui.Handlers;
using HandlersTest.Controls;

namespace HandlersTest.Handlers;

public partial class MyViewHandler : ViewHandler<IMyView, MyViewIOS>
{
    MyViewIOS? myViewIOS;

    protected override MyViewIOS CreatePlatformView() => myViewIOS ??= [];

}
