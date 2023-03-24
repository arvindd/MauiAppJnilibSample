using DynamicData;
using MauiAppJnilibSample.Platforms.Android.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppJnilibSample.Services.Base
{
    internal abstract class StringSequenceGeneratorService : BaseService
    {
        /// <summary>
        /// Starts the streaming of random strings
        /// </summary>
        /// <returns></returns>
        public abstract IObservable<IChangeSet<string>> StartStreamingStrings();

        /// <summary>
        /// Stops the streaming of strings
        /// </summary>
        public abstract void StopStreaming();
    }
}
