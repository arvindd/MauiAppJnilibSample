using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndroidRandomString = Org.Mauiappjnilibsample.RandomString;

namespace MauiAppJnilibSample.Platforms.Android.Services
{
    internal class RandomString
    {
        private AndroidRandomString str = new AndroidRandomString();

        public string Generate()
        {
            return str.Generate();
        }
    }
}
