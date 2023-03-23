using DynamicData;
using MauiAppJnilibSample.Platforms.Android.Services;
using MauiAppJnilibSample.Services.Base;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaRandomString = MauiAppJnilibSample.Platforms.Android.Services.RandomString;

namespace MauiAppJnilibSample.Services.Java
{
    internal class RandomString : RandomStringService
    {
        private readonly Random random = new();
        private readonly JavaRandomString str = new();
        public override IObservable<IChangeSet<string>> GenerateStrings()
        {
            return Observable.Generate(0,
                     x => x < 3,
                     x => x + 1,
                     _ => str.Generate(),
                     _ => TimeSpan.FromSeconds(random.Next(1, 2)))
                .Log(this, "String", x => x)
                .ToObservableChangeSet();
        }
    }
}
