
using Microsoft.Maui.Handlers;
using HandlersTest.Controls;

namespace HandlersTest.Handlers;

public partial class MyViewHandler : ViewHandler<IMyView, MyViewMac>
{
    MyViewMac? myViewMac;

    protected override MyViewMac CreatePlatformView() => myViewMac ??= [];

}
