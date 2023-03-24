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
using JavaStringSequenceGenerator = MauiAppJnilibSample.Platforms.Android.Services.StringSequenceGenerator;

namespace MauiAppJnilibSample.Services.Java
{
    internal class StringSequenceGenerator : StringSequenceGeneratorService
    {
        public StringSequenceGenerator()
        {
            Generator = new JavaStringSequenceGenerator();
        }

        public override IObservable<IChangeSet<string>> StartStreamingStrings()
        {
            // Create a listener which will listen for strings when the generator
            // generates those strings using the backend JNI code.
            listener = new StringSequenceListener(out strings);

            // This generates the sequence of strings
            Generator.SetStringSequenceListener(listener);

            // Trigger the underlying platform-specific string-sequence generator
            // to start generating strings. The generated strings will be added
            // in the strings list below by the listener.
            Generator.Start();

            // Return the strings as an observable changeset.
            // Make sure we stop the streaming after 3 strings.
            return strings.Connect();
        }

        public override void StopStreaming()
        {
            Generator.Stop();
        }

        private SourceList<string> strings;
        private JavaStringSequenceGenerator Generator { get; }
        private StringSequenceListener listener;
    }
}
