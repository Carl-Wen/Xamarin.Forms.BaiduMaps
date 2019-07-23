using System;

using Foundation;
using UIKit;

namespace Xamarin.Forms.BaiduMaps.Sample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();
            FormsBaiduMaps.Init("B3iCnaZ9pv6UDbenWBEHdfY36dsVLUnM");

            LoadApplication(new App());
            var id = NSBundle.MainBundle.BundleIdentifier;
            System.Console.WriteLine("NSBundle.MainBundle.BundleIdentifier: " + id);
            return base.FinishedLaunching(app, options);
        }
    }
}

