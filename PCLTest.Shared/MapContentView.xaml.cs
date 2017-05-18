// ------------------------------------------------------------------------------
//  Copyright © 2017 Esri. All rights reserved.
//  Author: John Doherty
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Esri.ArcGISRuntime.Mapping;
using PCLTest.Core;
using Xamarin.Forms;

namespace PCLTest.Shared
{
	/// <summary>
	/// Map content view. Implements IMapContentView for IOC.
	/// </summary>
	public partial class MapContentView : ContentView, IMapContentView
	{
		public MapContentView()
		{
			InitializeComponent();
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
