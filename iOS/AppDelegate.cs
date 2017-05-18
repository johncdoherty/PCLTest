// ------------------------------------------------------------------------------
//  Copyright © 2017 Esri. All rights reserved.
//  Author: John Doherty
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using PCLTest.Core;
using PCLTest.Shared;
using UIKit;
using FreshTinyIoC;

namespace PCLTest.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			IMyPage page;
			FreshTinyIoC.FreshTinyIoCContainer.Current.Register<IMyPage, MyPage2>();
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
