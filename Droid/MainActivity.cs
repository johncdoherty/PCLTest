using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using PCLTest.Core;
using PCLTest.Shared;
using System.Reflection;

namespace PCLTest.Droid
{
	[Activity(Label = "PCLTest.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			//FormsHelper.ForceLoadingAssemblyContainingType(typeof(MyPage));
			//FormsHelper.ForceLoadingAssemblyContainingType(typeof(IMyPage));
			IMyPage page;

			FreshTinyIoC.FreshTinyIoCContainer.Current.Register<IMyPage, MyPage>();

			LoadApplication(new App());
		}
	}
}
