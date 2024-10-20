
using HandlersTest.Controls;
using HandlersTest.Handlers;

namespace HandlersTest.Hosting;

// All the code in this file is included in all platforms.
public static class MyControlsExtention {

    public static MauiAppBuilder MyControlsConfig(this MauiAppBuilder builder) {
        
        //HANDLERS
        builder.ConfigureMauiHandlers(delegate (IMauiHandlersCollection handlers) {
            handlers.AddHandler(typeof(MyView), typeof(MyViewHandler));

        });

        return builder;
    }




}
