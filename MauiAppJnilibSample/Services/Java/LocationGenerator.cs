using DynamicData;
using DynamicData.Binding;
using MauiAppJnilibSample.Platforms.Android.Services;
using MauiAppJnilibSample.Services.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaLocationGenerator = MauiAppJnilibSample.Platforms.Android.Services.LocationGenerator;
using Location = MauiAppJnilibSample.Platforms.Android.Models.Location;

namespace MauiAppJnilibSample.Services.Java
{
    internal class LocationGenerator : LocationGeneratorService
    {
        public LocationGenerator()
        {
            Generator = new JavaLocationGenerator();
        }

        public override IObservable<IChangeSet<Location>> StartStreamingLocations()
        {
            // Create a listener which will listen for locations when the generator
            // generates those locations using the backend JNI code.
            listener = new LocationListener(out locations);

            // This generates the locations
            Generator.SetLocationListener(listener);

            // Trigger the underlying platform-specific location generator
            // to start generating locations. The generated locations will be added
            // in the location list below by the listener.
            Generator.Start();

            // Return the locations as an observable changeset.
            return locations.Connect();
        }

        public override void StopStreaming()
        {
            Generator.Stop();
            locations.Dispose();
        }

        private SourceList<Location> locations;
        private JavaLocationGenerator Generator { get; }
        private LocationListener listener;
    }
}
