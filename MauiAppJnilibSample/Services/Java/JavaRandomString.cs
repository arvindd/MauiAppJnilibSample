﻿using DynamicData;
using MauiAppJnilibSample.Services.Base;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiAppJnilibSample.Platforms.Android.Services;

namespace MauiAppJnilibSample.Services.Java
{
    internal class JavaRandomString : RandomStringService
    {
        private readonly Random random = new();
        private readonly RandomString str = new();

        public override IObservable<IChangeSet<string>> Connect()
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