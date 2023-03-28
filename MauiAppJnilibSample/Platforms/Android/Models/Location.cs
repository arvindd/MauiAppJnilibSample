using Java.Lang;
using Kotlin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loc = Org.Mauiappjnilibsample.Location;

namespace MauiAppJnilibSample.Platforms.Android.Models
{
    public class Location : Loc
    {
        public Location(float lat, float lon) : base(lat, lon) { }
        public float Latitude => base.Lat;
        public float Longitude => base.Lon;
    }
}
