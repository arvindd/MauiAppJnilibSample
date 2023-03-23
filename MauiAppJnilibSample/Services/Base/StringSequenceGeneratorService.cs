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
        /// Sets the listener which is invoked when each string from the sequence is generated.
        /// </summary>
        /// <param name="listener"></param>
        public abstract void SetStringSequenceListener(IStringSequenceListener listener);

        /// <summary>
        /// Starts the streaming of random strings.
        /// 
        /// <para>
        /// This returns a void because the strings are streamed through a listener that
        /// the client of this class registers with <see cref="SetStringSequenceListener(IStringSequenceListener)"/>
        /// </para>
        /// </summary>
        /// <returns></returns>
        public abstract void StartStreamingStrings();

        /// <summary>
        /// Stops the streaming of random strings
        /// </summary>
        /// <returns></returns>
        public abstract void StopStreaming();

    }
}
