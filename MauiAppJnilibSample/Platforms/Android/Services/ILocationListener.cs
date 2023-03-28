using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JNILocationListener = Org.Mauiappjnilibsample.ILocationListener;
using JNILocation = Org.Mauiappjnilibsample.Location;


namespace MauiAppJnilibSample.Platforms.Android.Services
{
    /// <summary>
    /// An interface extension to the JNI interface.
    /// 
    /// <para>
    /// We name this like an interface although this is a class because this class
    /// is meant to be a direct conduit to the JNI interface.
    /// </para>
    /// </summary>
    internal abstract class ILocationListener : Java.Lang.Object, JNILocationListener
    {
        public abstract void OnLocation(JNILocation loc);
    }
}
