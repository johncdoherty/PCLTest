// ------------------------------------------------------------------------------
//  Copyright © 2017 Esri. All rights reserved.
//  Author: John Doherty
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using PCLTest.Core;
using Esri.ArcGISRuntime.Mapping;
namespace PCLTest.Shared
{
	public partial class MyPage : ContentPage, IMyPage
	{
		public MyPage()
		{
			InitializeComponent();
			Title = "Display a map";

			// Create the UI, setup the control references and execute initialization 
			Initialize();
        }

        private void Initialize()
		{
			// Create new Map with basemap
			Map myMap = new Map(Basemap.CreateImagery());

			// Assign the map to the MapView
			MyMapView.Map = myMap;   
		}
	}
}
