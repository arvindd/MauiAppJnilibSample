using DynamicData;
using MauiAppJnilibSample.Platforms.Android.Services;
using MauiAppJnilibSample.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public override void SetStringSequenceListener(IStringSequenceListener listener)
        {
            Generator.SetStringSequenceListener(listener);
        }

        public override void StartStreamingStrings()
        {
            Generator.Start();
        }

        public override void StopStreaming()
        {
            Generator.Stop();
        }

        private JavaStringSequenceGenerator Generator { get; }
    }
}
