using DynamicData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppJnilibSample.Services.Base
{
    internal abstract class RandomStringService : BaseService
    {
        /// <summary>
        /// Connects to the randome string service, and streams random strings as Observables of ChangeSets.
        /// </summary>
        /// <returns></returns>
        public abstract IObservable<IChangeSet<string>> Connect();
    }
}
