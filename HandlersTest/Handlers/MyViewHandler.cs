#if ANDROID
using PlatformView = HandlersTest.Controls.MyViewAndroid;
#elif WINDOWS
using PlatformView = HandlersTest.Controls.MyViewWin;
#elif IOS 
using PlatformView = HandlersTest.Controls.MyViewIOS;
#elif MACCATALYST
using PlatformView = HandlersTest.Controls.MyViewMac;
#else
using PlatformView = System.Object;
#endif

using Microsoft.Maui.Handlers;
using HandlersTest.Controls;

namespace HandlersTest.Handlers;


public interface IMyViewHandler : IViewHandler
{
    new IMyView VirtualView { get; }
    new PlatformView PlatformView { get; }
}


public partial class MyViewHandler : IMyViewHandler
{
    public static PropertyMapper<IMyView, IMyViewHandler> Mapper = new( ViewHandler.ViewMapper ) {
        [nameof(MyView.AspectRatio)] = AspectRatio
    };

    static void AspectRatio(IMyViewHandler handler, IMyView view) => handler.PlatformView.AspectRatio = view.AspectRatio;

    IMyView IMyViewHandler.VirtualView => VirtualView;

    PlatformView IMyViewHandler.PlatformView => PlatformView;

    public MyViewHandler(IPropertyMapper mapper, CommandMapper? cmdMapper = null) : base(mapper, cmdMapper) { }
    public MyViewHandler() : this(Mapper) { }


    protected override void ConnectHandler(PlatformView platformView) => base.ConnectHandler(platformView);
    protected override void DisconnectHandler(PlatformView platformView) => base.DisconnectHandler(platformView);

}



