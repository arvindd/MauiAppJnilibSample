using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JNIRandomString = Org.Mauiappjnilibsample.RandomString;

namespace MauiAppJnilibSample.Platforms.Android.Services
{
    internal class RandomString
    {
        private JNIRandomString str = new JNIRandomString();
        public string Generate()
        {
            return str.Generate();
        }
    }
}