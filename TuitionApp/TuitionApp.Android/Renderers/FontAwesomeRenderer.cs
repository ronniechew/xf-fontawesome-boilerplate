using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using TuitionApp.Droid;
using Android.Graphics;
using TuitionApp.Droid.Renders;

[assembly: ExportRenderer(typeof(Label), typeof(AwesomeLabelRenderer))]
[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(AwesomeButtonRenderer))]
namespace TuitionApp.Droid.Renders
{
    public class AwesomeLabelRenderer : LabelRenderer
    {
        public AwesomeLabelRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            AwesomeUtil.CheckAndSetTypeFace(Control);
        }
    }

    public class AwesomeButtonRenderer : ButtonRenderer
    {
        public AwesomeButtonRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            AwesomeUtil.CheckAndSetTypeFace(Control);
        }
    }

    internal static class AwesomeUtil
    {
        public static void CheckAndSetTypeFace(TextView view)
        {
            if (view.Text.Length == 0) return;
            var text = view.Text;
            if (text.Length > 1 || text[0] < 0xf000)
            {
                return;
            }

            var font = Typeface.CreateFromAsset(Android.App.Application.Context.ApplicationContext.Assets, "FontAwesome.ttf");
            view.Typeface = font;
        }
    }
}