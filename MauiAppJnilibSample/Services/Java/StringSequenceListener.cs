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
        public StringSequenceListener(ReadOnlyObservableCollection<string> list)
        {
            _strlist = list;
        }
        public override void OnString(string str)
        {
            _strlist.Append(str);
        }

        private readonly ReadOnlyObservableCollection<string> _strlist;
    }
}
