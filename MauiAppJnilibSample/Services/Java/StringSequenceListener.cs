using DynamicData;
using MauiAppJnilibSample.Platforms.Android.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppJnilibSample.Services.Java
{
    internal class StringSequenceListener : IStringSequenceListener
    {
        public StringSequenceListener(out SourceList<string> strlist)
        {
            strings = strlist = new SourceList<string>();
        }
        public override void OnString(string str)
        {
            // We'll limit only 3 strings on the UI
            if (strings.Count == 3)
            {
                strings.Clear();
            }

            strings.Add(str);
        }

        private readonly SourceList<string> strings;
    }
}
