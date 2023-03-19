﻿using MauiAppJnilibSample.Services.Base;
using MauiAppJnilibSample.Services.Mock;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppJnilibSample
{
    internal static class AppConfig
    {
        public static void ConfigureServices()
        {
            // Register all services
            Locator.CurrentMutable.RegisterConstant<LocationSensor>(new MockLocationSensor());

            // Make these services available to all other classes
            LocationSensor = Locator.Current.GetService<LocationSensor>();
        }

        public static LocationSensor LocationSensor { get; private set; }
    }
}
