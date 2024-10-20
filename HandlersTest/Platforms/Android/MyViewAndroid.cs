
using Android.Content;
using Android.Util;
using Android.Widget;
using AndroidX.ConstraintLayout.Widget;

using Colors = Android.Graphics.Color;

namespace HandlersTest.Controls;

public class MyViewAndroid : ConstraintLayout
{   
    public double AspectRatio { get; set; }


    public MyViewAndroid(Context context, IAttributeSet? attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes) => Initialize();
    public MyViewAndroid(Context context, IAttributeSet? attrs, int defStyleAttr) : this(context, attrs, defStyleAttr, 0) { }
    public MyViewAndroid(Context context, IAttributeSet? attrs) : this(context, attrs, 0) { }
    public MyViewAndroid(Context context) : this(context, null) { }


    private void Initialize()
    {
        SetBackgroundColor(Colors.Gray);
        LayoutParameters = new(-1, -2);

        var content = new TextView(Context) { 
            Id = GenerateViewId(),
            Text = "ASD",
            Gravity = Android.Views.GravityFlags.Center
        };
        content.SetBackgroundColor(Colors.Pink);


        AddView(content);

        var cs = new ConstraintSet();
        cs.Clone(this);

        cs.ConstrainWidth(content.Id, 0);
        cs.ConstrainHeight(content.Id, 0);

        cs.Connect(content.Id, LayoutParams.Top, LayoutParams.ParentId, LayoutParams.Top, 20);
        //cs.Connect(content.Id, LayoutParams.Bottom, LayoutParams.ParentId, LayoutParams.Bottom);

        cs.Connect(content.Id, LayoutParams.Start, LayoutParams.ParentId, LayoutParams.Start,20);
        cs.Connect(content.Id, LayoutParams.End, LayoutParams.ParentId, LayoutParams.End,20);



        cs.SetDimensionRatio(content.Id, "4:1");

        cs.ApplyTo(this);
        //SetConstraintSet(constraintSet);
    }
}
