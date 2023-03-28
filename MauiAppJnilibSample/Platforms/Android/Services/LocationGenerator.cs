using Javax.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JNILocationGenerator = Org.Mauiappjnilibsample.LocationGenerator;

namespace MauiAppJnilibSample.Platforms.Android.Services
{
    internal class LocationGenerator
    {
        public LocationGenerator()
        {
            Generator = new JNILocationGenerator();
        }

        public void SetLocationListener(ILocationListener listener)
        {
            Generator.SetLocationListener(listener);
        }

        public void Start()
        {
            Generator.Start();
        }

        public void Stop()
        {
            Generator.Stop();
        }

        private readonly JNILocationGenerator Generator;
    }
}
