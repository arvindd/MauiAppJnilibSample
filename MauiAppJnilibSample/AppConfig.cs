using MauiAppJnilibSample.Services.Base;
using MauiAppJnilibSample.Services.Java;
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
            Locator.CurrentMutable.RegisterConstant<RandomStringService>(new JavaRandomString());

            // Make these services available to all other classes
            RandomString = Locator.Current.GetService<RandomStringService>();
        }

        public static RandomStringService RandomString { get; private set; }
    }
}
