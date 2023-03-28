using DynamicData;
using MauiAppJnilibSample.Platforms.Android.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Location = MauiAppJnilibSample.Platforms.Android.Models.Location;

namespace MauiAppJnilibSample.Services.Base
{
    internal abstract class LocationGeneratorService : BaseService
    {
        /// <summary>
        /// Starts the streaming of random locations
        /// </summary>
        /// <returns></returns>
        public abstract IObservable<IChangeSet<Location>> StartStreamingLocations();

        /// <summary>
        /// Stops the streaming of locations
        /// </summary>
        public abstract void StopStreaming();
    }
}
