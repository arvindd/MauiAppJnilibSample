using DynamicData;
using MauiAppJnilibSample.Platforms.Android.Services;
using Splat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Location = MauiAppJnilibSample.Platforms.Android.Models.Location;
using JNILocation = Org.Mauiappjnilibsample.Location;

namespace MauiAppJnilibSample.Services.Java
{
    internal class LocationListener : ILocationListener
    {
        public LocationListener(out SourceList<Location> loclist)
        {
            locations = loclist = new SourceList<Location>();
        }
        public override void OnLocation(JNILocation loc)
        {
            // We'll add the new element as the first element in the list
            // so that this is always shown first in the UI
            locations.Insert(0, new Location(loc.Lat, loc.Lon));
        }

        private readonly SourceList<Location> locations;
    }
}
