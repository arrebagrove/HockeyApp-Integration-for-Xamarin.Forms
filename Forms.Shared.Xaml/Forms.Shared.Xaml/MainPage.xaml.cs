﻿using Forms.Shared.Xaml.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Forms.Shared.Xaml
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            DependencyService.Get<IMetricsManagerService>().TrackEvent("AppStarted");
            InitializeComponent();
		}
	}
}
