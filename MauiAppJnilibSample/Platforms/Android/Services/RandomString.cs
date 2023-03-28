using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JNIRandomData = Org.Mauiappjnilibsample.RandomData;

namespace MauiAppJnilibSample.Platforms.Android.Services
{
    internal class RandomString
    {
        private JNIRandomData data = new JNIRandomData();
        public string Generate()
        {
            return data.RandomString;
        }
    }
}