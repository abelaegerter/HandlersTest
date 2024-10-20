
using Microsoft.Maui.Handlers;
using HandlersTest.Controls;

namespace HandlersTest.Handlers;

public partial class MyViewHandler : ViewHandler<IMyView, MyViewAndroid>
{
    MyViewAndroid? myViewAndroid;

    protected override MyViewAndroid CreatePlatformView() => myViewAndroid ??= new(Context);

}
