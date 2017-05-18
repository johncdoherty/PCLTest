// ------------------------------------------------------------------------------
//  Copyright © 2017 Esri. All rights reserved.
//  Author: John Doherty
// ------------------------------------------------------------------------------

using Xamarin.Forms;
using PCLTest.Core;

namespace PCLTest
{
	public partial class PCLTestPage : ContentPage
	{
		public PCLTestPage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var page = FreshTinyIoC.FreshTinyIoCContainer.Current.Resolve<IMyPage>();
			//var page = new MyPage();
			this.Navigation.PushModalAsync(page as Page);
		}
	}
}
