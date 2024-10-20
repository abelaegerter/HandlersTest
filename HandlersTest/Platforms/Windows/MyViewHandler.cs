
using Microsoft.Maui.Handlers;
using HandlersTest.Controls;

namespace HandlersTest.Handlers;

public partial class MyViewHandler : ViewHandler<IMyView, MyViewWin>
{
    MyViewWin? myViewWin;

    protected override MyViewWin CreatePlatformView() => myViewWin ??= new();

}
