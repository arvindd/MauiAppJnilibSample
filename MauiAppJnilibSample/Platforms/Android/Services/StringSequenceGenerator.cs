using Javax.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JNIStringSequenceGenerator = Org.Mauiappjnilibsample.StringSequenceGenerator;

namespace MauiAppJnilibSample.Platforms.Android.Services
{
    internal class StringSequenceGenerator
    {
        public StringSequenceGenerator()
        {
            Generator = new JNIStringSequenceGenerator();
        }

        public void SetStringSequenceListener(IStringSequenceListener listener)
        {
            Generator.SetStringSequenceListener(listener);
        }

        public void Start()
        {
            Generator.Start();
        }

        public void Stop()
        {
            Generator.Stop();
        }

        private readonly JNIStringSequenceGenerator Generator;
    }
}
